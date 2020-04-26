namespace COMPARASQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.marcoGrilla = new DevExpress.XtraGrid.GridControl();
            this.grilla1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPass1 = new DevExpress.XtraEditors.TextEdit();
            this.txtUser1 = new DevExpress.XtraEditors.TextEdit();
            this.cmbDb1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtServer1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbDb2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPass2 = new DevExpress.XtraEditors.TextEdit();
            this.txtUser2 = new DevExpress.XtraEditors.TextEdit();
            this.txtServer2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.marcoGrilla2 = new DevExpress.XtraGrid.GridControl();
            this.grilla2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.marcoGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcoGrilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).BeginInit();
            this.SuspendLayout();
            // 
            // marcoGrilla
            // 
            this.marcoGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marcoGrilla.Location = new System.Drawing.Point(26, 173);
            this.marcoGrilla.MainView = this.grilla1;
            this.marcoGrilla.Name = "marcoGrilla";
            this.marcoGrilla.Size = new System.Drawing.Size(449, 423);
            this.marcoGrilla.TabIndex = 1;
            this.marcoGrilla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilla1});
            this.marcoGrilla.Click += new System.EventHandler(this.marcoGrilla_Click);
            // 
            // grilla1
            // 
            this.grilla1.GridControl = this.marcoGrilla;
            this.grilla1.Name = "grilla1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPass1);
            this.layoutControl1.Controls.Add(this.txtUser1);
            this.layoutControl1.Controls.Add(this.cmbDb1);
            this.layoutControl1.Controls.Add(this.txtServer1);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(479, 153);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(101, 72);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Properties.PasswordChar = '•';
            this.txtPass1.Size = new System.Drawing.Size(362, 22);
            this.txtPass1.StyleController = this.layoutControl1;
            this.txtPass1.TabIndex = 7;
            // 
            // txtUser1
            // 
            this.txtUser1.EditValue = "sa";
            this.txtUser1.Location = new System.Drawing.Point(101, 44);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(362, 22);
            this.txtUser1.StyleController = this.layoutControl1;
            this.txtUser1.TabIndex = 6;
            // 
            // cmbDb1
            // 
            this.cmbDb1.Location = new System.Drawing.Point(101, 100);
            this.cmbDb1.Name = "cmbDb1";
            this.cmbDb1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDb1.Size = new System.Drawing.Size(362, 22);
            this.cmbDb1.StyleController = this.layoutControl1;
            this.cmbDb1.TabIndex = 5;
            this.cmbDb1.Enter += new System.EventHandler(this.comboBoxEdit1_Enter);
            // 
            // txtServer1
            // 
            this.txtServer1.EditValue = "192.168.168.32";
            this.txtServer1.Location = new System.Drawing.Point(101, 16);
            this.txtServer1.Name = "txtServer1";
            this.txtServer1.Size = new System.Drawing.Size(362, 22);
            this.txtServer1.StyleController = this.layoutControl1;
            this.txtServer1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(479, 153);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtServer1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(453, 28);
            this.layoutControlItem1.Text = "Servidor";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbDb1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(453, 43);
            this.layoutControlItem4.Text = "Base de Datos";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtUser1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(453, 28);
            this.layoutControlItem5.Text = "Usuario";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPass1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(453, 28);
            this.layoutControlItem6.Text = "Password";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cmbDb2);
            this.layoutControl2.Controls.Add(this.txtPass2);
            this.layoutControl2.Controls.Add(this.txtUser2);
            this.layoutControl2.Controls.Add(this.txtServer2);
            this.layoutControl2.Location = new System.Drawing.Point(497, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(480, 155);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cmbDb2
            // 
            this.cmbDb2.Location = new System.Drawing.Point(101, 100);
            this.cmbDb2.Name = "cmbDb2";
            this.cmbDb2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDb2.Size = new System.Drawing.Size(363, 22);
            this.cmbDb2.StyleController = this.layoutControl2;
            this.cmbDb2.TabIndex = 7;
            this.cmbDb2.Enter += new System.EventHandler(this.comboBoxEdit2_Enter);
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(101, 72);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Properties.PasswordChar = '•';
            this.txtPass2.Size = new System.Drawing.Size(363, 22);
            this.txtPass2.StyleController = this.layoutControl2;
            this.txtPass2.TabIndex = 6;
            // 
            // txtUser2
            // 
            this.txtUser2.EditValue = "sa";
            this.txtUser2.Location = new System.Drawing.Point(101, 44);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(363, 22);
            this.txtUser2.StyleController = this.layoutControl2;
            this.txtUser2.TabIndex = 5;
            // 
            // txtServer2
            // 
            this.txtServer2.EditValue = "192.168.168.21";
            this.txtServer2.Location = new System.Drawing.Point(101, 16);
            this.txtServer2.Name = "txtServer2";
            this.txtServer2.Size = new System.Drawing.Size(363, 22);
            this.txtServer2.StyleController = this.layoutControl2;
            this.txtServer2.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(480, 155);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtServer2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(454, 28);
            this.layoutControlItem3.Text = "Servidor";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtUser2;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(454, 28);
            this.layoutControlItem7.Text = "Usuario";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtPass2;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(454, 28);
            this.layoutControlItem8.Text = "Password";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cmbDb2;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(454, 45);
            this.layoutControlItem9.Text = "Base de Datos";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(81, 16);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Location = new System.Drawing.Point(983, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 50);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "ACEPTAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // marcoGrilla2
            // 
            this.marcoGrilla2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marcoGrilla2.Location = new System.Drawing.Point(511, 173);
            this.marcoGrilla2.MainView = this.grilla2;
            this.marcoGrilla2.Name = "marcoGrilla2";
            this.marcoGrilla2.Size = new System.Drawing.Size(450, 423);
            this.marcoGrilla2.TabIndex = 4;
            this.marcoGrilla2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grilla2});
            // 
            // grilla2
            // 
            this.grilla2.GridControl = this.marcoGrilla2;
            this.grilla2.Name = "grilla2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 608);
            this.Controls.Add(this.marcoGrilla2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.marcoGrilla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARAR";
            ((System.ComponentModel.ISupportInitialize)(this.marcoGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcoGrilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl marcoGrilla;
        private DevExpress.XtraGrid.Views.Grid.GridView grilla1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtServer1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit txtServer2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDb1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtPass1;
        private DevExpress.XtraEditors.TextEdit txtUser1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDb2;
        private DevExpress.XtraEditors.TextEdit txtPass2;
        private DevExpress.XtraEditors.TextEdit txtUser2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.GridControl marcoGrilla2;
        private DevExpress.XtraGrid.Views.Grid.GridView grilla2;
    }
}

