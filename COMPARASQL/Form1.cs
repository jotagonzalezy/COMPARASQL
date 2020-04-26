using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace COMPARASQL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void comboBoxEdit1_Enter(object sender, EventArgs e)
        {
            try
            {
                FillDatabaseList("Data Source=" + txtServer1.Text + "; Initial Catalog=master;  Persist Security Info=True;User ID=" + txtUser1.Text + "; Password=" + txtPass1.Text, ref cmbDb1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxEdit2_Enter(object sender, EventArgs e)
        {
            try
            {
                FillDatabaseList("Data Source=" + txtServer2.Text + "; Initial Catalog=master;  Persist Security Info=True;User ID=" + txtUser2.Text + "; Password=" + txtPass2.Text, ref cmbDb2);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FillTableDiff();
                FillFuncDiff();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private class EstructuraTablas
        {
            public string TableName { get; set; }
            public string ColumnName { get; set; }
            public bool IsNullable { get; set; }
            public string DataType { get; set; }
            public string TableType { get; set; }
        }




        private void FillDatabaseList(string conexStrg, ref ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            //const string sqlString = "SELECT name FROM sysdatabases WHERE dbid > 6 ORDER BY name";
            const string sqlString =
                "SELECT name FROM sys.databases AS db WHERE  (database_id > 4) AND (state <> 6) ORDER BY name";
            var myConnection = new SqlConnection(conexStrg);
            myConnection.Open();
            var myCommand = new SqlCommand(sqlString, myConnection);
            var myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                combo.Properties.Items.Add(myReader.GetString(myReader.GetOrdinal("name")));
            }
            myConnection.Close();

        }

        #region Tablas y vistas
        private void FillTableDiff()
        {
            var estructuraTablaslist = GetEstructuraDb("Data Source=" + txtServer1.Text + "; Initial Catalog=" + cmbDb1.Text + ";  Persist Security Info=True;User ID=" + txtUser1.Text + "; Password=" + txtPass1.Text);
            var estructuraTablaslist2 = GetEstructuraDb("Data Source=" + txtServer2.Text + "; Initial Catalog=" + cmbDb2.Text + ";  Persist Security Info=True;User ID=" + txtUser2.Text + "; Password=" + txtPass2.Text);
            var myList1 = estructuraTablaslist.Concat(estructuraTablaslist2).ToList();

            var result2 = from myObjs in myList1
                          group myObjs by new { myObjs.DataType, myObjs.ColumnName, myObjs.TableName, myObjs.TableType }
                              into g
                          where g.Count() == 1
                          select new
                          {
                              g.Key.TableName,
                              g.Key.ColumnName,
                              g.Key.DataType,
                              g.Key.TableType
                          };

            marcoGrilla.BindingContext = new BindingContext();
            marcoGrilla.DataSource = result2;
            grilla1.PopulateColumns();

            if (!result2.Any()) return;
            grilla1.Columns["TableType"].GroupIndex = 0;
            grilla1.Columns["TableName"].GroupIndex = 1;
        }
        private IEnumerable<EstructuraTablas> GetEstructuraDb(string conexStrg)
        {
            var lista = new List<EstructuraTablas>();
            const string sqlString = "SELECT INFORMATION_SCHEMA.COLUMNS.TABLE_NAME, INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, " +
                                     " INFORMATION_SCHEMA.COLUMNS.IS_NULLABLE, INFORMATION_SCHEMA.COLUMNS.DATA_TYPE, INFORMATION_SCHEMA.TABLES.TABLE_TYPE " +
                                     " FROM INFORMATION_SCHEMA.COLUMNS INNER JOIN INFORMATION_SCHEMA.TABLES ON " +
                                     " INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = INFORMATION_SCHEMA.TABLES.TABLE_NAME ORDER BY INFORMATION_SCHEMA.COLUMNS.TABLE_NAME, " +
                                     " INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME";
            var myConnection = new SqlConnection(conexStrg);
            myConnection.Open();

            var myCommand = new SqlCommand(sqlString, myConnection);
            var myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                var estructuraModel = new EstructuraTablas
                {
                    ColumnName = myReader.GetString(myReader.GetOrdinal("COLUMN_NAME")),
                    TableName = myReader.GetString(myReader.GetOrdinal("TABLE_NAME")),
                    TableType = myReader.GetString(myReader.GetOrdinal("TABLE_TYPE")),
                    IsNullable = myReader.GetString(myReader.GetOrdinal("IS_NULLABLE")) == "YES",
                    DataType = myReader.GetString(myReader.GetOrdinal("DATA_TYPE")),
                };
                lista.Add(estructuraModel);
            }
            myConnection.Close();
            return lista;
        }
        #endregion

        #region Funciones
        private IEnumerable<EstructuraTablas> GetFuncionDb(string conexStrg)
        {
            var lista = new List<EstructuraTablas>();
            const string sqlString =
                "SELECT  name, xtype FROM  sysobjects WHERE  " +
                " (xtype <> 'U') AND (xtype <> 'V') AND " +
                " (xtype <> 'TR')AND (xtype <> 'D') " +
                " ORDER BY name";


            var myConnection = new SqlConnection(conexStrg);
            myConnection.Open();

            var myCommand = new SqlCommand(sqlString, myConnection);
            var myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                var tipo = myReader.GetString(myReader.GetOrdinal("xtype")).Trim();
                if (tipo == "TR")
                    tipo = "TRIGGER";

                if (tipo == "F")
                    tipo = "REL.FORANEA";

                if (tipo == "PK")
                    tipo = "REL.PRIMARIA";

                if (tipo == "P")
                    tipo = "PROC.ALMACENADO";

                if (tipo == "IF" || tipo == "TF")
                    tipo = "FUNC.TABLA";

                if (tipo == "FN")
                    tipo = "FUNC.ESCALAR";

                var estructuraModel = new EstructuraTablas
                {
                    ColumnName = myReader.GetString(myReader.GetOrdinal("name")),
                    TableType = tipo,
                };
                lista.Add(estructuraModel);
            }

            const string sqlString2 =
                "SELECT sys.sysobjects.name AS name, OBJECT_NAME(sys.sysobjects.parent_obj) " +
                " AS table_name FROM     sys.sysobjects INNER JOIN sys.tables AS t " +
                " ON sys.sysobjects.parent_obj = t.object_id WHERE  (sys.sysobjects.type = 'TR')";
            myReader.Close();
            var myCommand2 = new SqlCommand(sqlString2, myConnection);

            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                var estructuraModel = new EstructuraTablas
                {
                    ColumnName = myReader2.GetString(myReader2.GetOrdinal("name")),
                    TableType = "TRIGGER",
                    TableName = myReader2.GetString(myReader2.GetOrdinal("table_name")),
                };
                lista.Add(estructuraModel);
            }




            myConnection.Close();
            return lista;
        }
        private void FillFuncDiff()
        {
            var estructuraFuncList = GetFuncionDb("Data Source=" + txtServer1.Text + "; Initial Catalog=" + cmbDb1.Text + ";  Persist Security Info=True;User ID=" + txtUser1.Text + "; Password=" + txtPass1.Text);
            var estructuraFuncList2 = GetFuncionDb("Data Source=" + txtServer2.Text + "; Initial Catalog=" + cmbDb2.Text + ";  Persist Security Info=True;User ID=" + txtUser2.Text + "; Password=" + txtPass2.Text);
            var myList1 = estructuraFuncList.Concat(estructuraFuncList2).ToList();

            var result2 = from myObjs in myList1
                          group myObjs by new { myObjs.ColumnName, myObjs.TableType, myObjs.TableName }
                              into g
                          where g.Count() == 1
                          select new { g.Key.ColumnName, g.Key.TableType, g.Key.TableName };
            marcoGrilla2.BindingContext = new BindingContext();
            marcoGrilla2.DataSource = result2;
            grilla2.PopulateColumns();
            grilla2.Columns["TableType"].GroupIndex = 0;
        }
        #endregion



        private void marcoGrilla_Click(object sender, EventArgs e)
        {

        }


    }
}
