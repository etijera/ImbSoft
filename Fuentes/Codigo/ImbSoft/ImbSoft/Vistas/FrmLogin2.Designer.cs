namespace Adicionales.Views.Helpers
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.GbxIniciar = new DevExpress.XtraEditors.GroupControl();
            this.LueUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.LueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.CbxMes = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.LblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.CbxAño = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.LblContraseña = new DevExpress.XtraEditors.LabelControl();
            this.LblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.PbxGeneral = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxIniciar)).BeginInit();
            this.GbxIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxAño.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGeneral.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxIniciar
            // 
            this.GbxIniciar.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.GbxIniciar.Appearance.Options.UseForeColor = true;
            this.GbxIniciar.Controls.Add(this.LueUsuario);
            this.GbxIniciar.Controls.Add(this.LueEmpresa);
            this.GbxIniciar.Controls.Add(this.CbxMes);
            this.GbxIniciar.Controls.Add(this.LblEmpresa);
            this.GbxIniciar.Controls.Add(this.CbxAño);
            this.GbxIniciar.Controls.Add(this.TxtContraseña);
            this.GbxIniciar.Controls.Add(this.LblContraseña);
            this.GbxIniciar.Controls.Add(this.LblUsuario);
            this.GbxIniciar.Location = new System.Drawing.Point(61, 80);
            this.GbxIniciar.Name = "GbxIniciar";
            this.GbxIniciar.Size = new System.Drawing.Size(236, 130);
            this.GbxIniciar.TabIndex = 0;
            this.GbxIniciar.Text = "Iniciar Sesión";
            // 
            // LueUsuario
            // 
            this.LueUsuario.Enabled = false;
            this.LueUsuario.EnterMoveNextControl = true;
            this.LueUsuario.Location = new System.Drawing.Point(68, 51);
            this.LueUsuario.Name = "LueUsuario";
            this.LueUsuario.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueUsuario.Properties.Appearance.Options.UseBorderColor = true;
            this.LueUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.LueUsuario.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueUsuario.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueUsuario.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.LueUsuario.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.LueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueUsuario.Properties.ShowHeader = false;
            this.LueUsuario.Properties.Leave += new System.EventHandler(this.lookUpEdit1_Properties_Leave);
            this.LueUsuario.Size = new System.Drawing.Size(160, 20);
            this.LueUsuario.TabIndex = 1;
            this.LueUsuario.EditValueChanged += new System.EventHandler(this.LueUsuario_EditValueChanged);
            // 
            // LueEmpresa
            // 
            this.LueEmpresa.EnterMoveNextControl = true;
            this.LueEmpresa.Location = new System.Drawing.Point(68, 26);
            this.LueEmpresa.Name = "LueEmpresa";
            this.LueEmpresa.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueEmpresa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueEmpresa.Properties.Appearance.Options.UseBorderColor = true;
            this.LueEmpresa.Properties.Appearance.Options.UseForeColor = true;
            this.LueEmpresa.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueEmpresa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueEmpresa.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.LueEmpresa.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.LueEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.LueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueEmpresa.Properties.ShowHeader = false;
            this.LueEmpresa.Properties.Leave += new System.EventHandler(this.lookUpEdit1_Properties_Leave);
            this.LueEmpresa.Size = new System.Drawing.Size(160, 20);
            this.LueEmpresa.TabIndex = 0;
            this.LueEmpresa.EditValueChanged += new System.EventHandler(this.LueEmpresa_EditValueChanged);
            // 
            // CbxMes
            // 
            this.CbxMes.Enabled = false;
            this.CbxMes.EnterMoveNextControl = true;
            this.CbxMes.Location = new System.Drawing.Point(123, 103);
            this.CbxMes.Name = "CbxMes";
            this.CbxMes.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxMes.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.CbxMes.Properties.Appearance.Options.UseBorderColor = true;
            this.CbxMes.Properties.Appearance.Options.UseForeColor = true;
            this.CbxMes.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxMes.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.CbxMes.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.CbxMes.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.CbxMes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CbxMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxMes.Properties.CaseSensitiveSearch = true;
            this.CbxMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CbxMes.Size = new System.Drawing.Size(105, 20);
            this.CbxMes.TabIndex = 4;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblEmpresa.Location = new System.Drawing.Point(6, 29);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(41, 13);
            this.LblEmpresa.TabIndex = 10;
            this.LblEmpresa.Text = "Empresa";
            // 
            // CbxAño
            // 
            this.CbxAño.EditValue = "";
            this.CbxAño.Enabled = false;
            this.CbxAño.EnterMoveNextControl = true;
            this.CbxAño.Location = new System.Drawing.Point(6, 103);
            this.CbxAño.Name = "CbxAño";
            this.CbxAño.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxAño.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.CbxAño.Properties.Appearance.Options.UseBorderColor = true;
            this.CbxAño.Properties.Appearance.Options.UseForeColor = true;
            this.CbxAño.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxAño.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.CbxAño.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.CbxAño.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.CbxAño.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CbxAño.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxAño.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CbxAño.Size = new System.Drawing.Size(105, 20);
            this.CbxAño.TabIndex = 3;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.EnterMoveNextControl = true;
            this.TxtContraseña.Location = new System.Drawing.Point(68, 77);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.TxtContraseña.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtContraseña.Properties.Appearance.Options.UseBorderColor = true;
            this.TxtContraseña.Properties.Appearance.Options.UseForeColor = true;
            this.TxtContraseña.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.TxtContraseña.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtContraseña.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.TxtContraseña.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.TxtContraseña.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtContraseña.Properties.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(160, 20);
            this.TxtContraseña.TabIndex = 2;
            // 
            // LblContraseña
            // 
            this.LblContraseña.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblContraseña.Location = new System.Drawing.Point(6, 81);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(56, 13);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblUsuario.Location = new System.Drawing.Point(6, 55);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(36, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnIniciar);
            this.groupControl3.Location = new System.Drawing.Point(137, 216);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(84, 35);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "groupControl3";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnIniciar.Appearance.Options.UseForeColor = true;
            this.BtnIniciar.Location = new System.Drawing.Point(5, 5);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(74, 25);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar Sesión";
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // PbxGeneral
            // 
            this.PbxGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbxGeneral.EditValue = ((object)(resources.GetObject("PbxGeneral.EditValue")));
            this.PbxGeneral.Location = new System.Drawing.Point(0, 0);
            this.PbxGeneral.Name = "PbxGeneral";
            this.PbxGeneral.Properties.AllowFocused = false;
            this.PbxGeneral.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PbxGeneral.Size = new System.Drawing.Size(359, 74);
            this.PbxGeneral.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 255);
            this.Controls.Add(this.GbxIniciar);
            this.Controls.Add(this.PbxGeneral);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2010 Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmLogin";
            this.Text = "Bienvenido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GbxIniciar)).EndInit();
            this.GbxIniciar.ResumeLayout(false);
            this.GbxIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxAño.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxGeneral.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PbxGeneral;
        private DevExpress.XtraEditors.GroupControl GbxIniciar;
        private DevExpress.XtraEditors.TextEdit TxtContraseña;
        private DevExpress.XtraEditors.LabelControl LblContraseña;
        private DevExpress.XtraEditors.LabelControl LblUsuario;
        private DevExpress.XtraEditors.ComboBoxEdit CbxAño;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnIniciar;
        private DevExpress.XtraEditors.LabelControl LblEmpresa;
        private DevExpress.XtraScheduler.UI.MonthEdit CbxMes;
        private DevExpress.XtraEditors.LookUpEdit LueEmpresa;
        private DevExpress.XtraEditors.LookUpEdit LueUsuario;
    }
}