namespace ImbSoft.Vistas
{
    partial class FrmLogin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin1));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.LnkLblMinimizar = new System.Windows.Forms.LinkLabel();
            this.LnkLblCerrar = new System.Windows.Forms.LinkLabel();
            this.BtnAjustes = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtPassword = new UsuarioControles.TxtBase();
            this.lblBase3 = new UsuarioControles.LblBase();
            this.lblBase2 = new UsuarioControles.LblBase();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.CbxMes = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.CbxAño = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LueUsuario = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbxMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxAño.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(262, 50);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 38);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.ToolTip = "Entrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // LnkLblMinimizar
            // 
            this.LnkLblMinimizar.ActiveLinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnkLblMinimizar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblMinimizar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLblMinimizar.LinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.Location = new System.Drawing.Point(312, 12);
            this.LnkLblMinimizar.Name = "LnkLblMinimizar";
            this.LnkLblMinimizar.Size = new System.Drawing.Size(18, 18);
            this.LnkLblMinimizar.TabIndex = 2;
            this.LnkLblMinimizar.TabStop = true;
            this.LnkLblMinimizar.Text = "_";
            this.LnkLblMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblMinimizar.VisitedLinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblMinimizar_LinkClicked_1);
            // 
            // LnkLblCerrar
            // 
            this.LnkLblCerrar.ActiveLinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnkLblCerrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLblCerrar.LinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.Location = new System.Drawing.Point(332, 12);
            this.LnkLblCerrar.Name = "LnkLblCerrar";
            this.LnkLblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LnkLblCerrar.TabIndex = 3;
            this.LnkLblCerrar.TabStop = true;
            this.LnkLblCerrar.Text = "X";
            this.LnkLblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnkLblCerrar.UseCompatibleTextRendering = true;
            this.LnkLblCerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblCerrar_LinkClicked);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.AllowFocus = false;
            this.BtnAjustes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjustes.Image")));
            this.BtnAjustes.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnAjustes.Location = new System.Drawing.Point(12, 12);
            this.BtnAjustes.LookAndFeel.SkinName = "Office 2010 Blue";
            this.BtnAjustes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnAjustes.LookAndFeel.UseWindowsXPTheme = true;
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(18, 18);
            this.BtnAjustes.TabIndex = 1;
            this.BtnAjustes.ToolTip = "Ajustes de conexión";
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtPassword);
            this.groupControl1.Controls.Add(this.lblBase3);
            this.groupControl1.Controls.Add(this.lblBase2);
            this.groupControl1.Controls.Add(this.lblBase1);
            this.groupControl1.Controls.Add(this.CbxMes);
            this.groupControl1.Controls.Add(this.CbxAño);
            this.groupControl1.Controls.Add(this.LueUsuario);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(16, 113);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(332, 167);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // TxtPassword
            // 
            this.TxtPassword.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtPassword.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtPassword.Appearance.Options.UseBackColor = true;
            this.TxtPassword.CaraterPassword = '*';
            this.TxtPassword.Location = new System.Drawing.Point(90, 60);
            this.TxtPassword.MaxLenght = 50;
            this.TxtPassword.MTextChanged = null;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(167, 26);
            this.TxtPassword.SoloLectura = false;
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPassword.Texto = "";
            this.TxtPassword.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtPassword.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // lblBase3
            // 
            this.lblBase3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase3.Appearance.Options.UseBackColor = true;
            this.lblBase3.AutoSize = true;
            this.lblBase3.Location = new System.Drawing.Point(16, 100);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(74, 14);
            this.lblBase3.TabIndex = 7;
            this.lblBase3.Texto = "Periodo";
            // 
            // lblBase2
            // 
            this.lblBase2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase2.Appearance.Options.UseBackColor = true;
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(16, 68);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(80, 14);
            this.lblBase2.TabIndex = 6;
            this.lblBase2.Texto = "Contraseña";
            // 
            // lblBase1
            // 
            this.lblBase1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase1.Appearance.Options.UseBackColor = true;
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(16, 33);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(55, 14);
            this.lblBase1.TabIndex = 5;
            this.lblBase1.Texto = "Usuario";
            // 
            // CbxMes
            // 
            this.CbxMes.Enabled = false;
            this.CbxMes.EnterMoveNextControl = true;
            this.CbxMes.Location = new System.Drawing.Point(185, 97);
            this.CbxMes.Name = "CbxMes";
            this.CbxMes.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.CbxMes.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxMes.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.CbxMes.Properties.Appearance.Options.UseBackColor = true;
            this.CbxMes.Properties.Appearance.Options.UseBorderColor = true;
            this.CbxMes.Properties.Appearance.Options.UseForeColor = true;
            this.CbxMes.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.CbxMes.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CbxMes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CbxMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxMes.Properties.CaseSensitiveSearch = true;
            this.CbxMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CbxMes.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.CbxMes.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CbxMes.Size = new System.Drawing.Size(68, 20);
            this.CbxMes.TabIndex = 3;
            this.CbxMes.Enter += new System.EventHandler(this.CbxMes_Enter);
            this.CbxMes.Leave += new System.EventHandler(this.CbxMes_Leave);
            // 
            // CbxAño
            // 
            this.CbxAño.EditValue = "";
            this.CbxAño.Enabled = false;
            this.CbxAño.EnterMoveNextControl = true;
            this.CbxAño.Location = new System.Drawing.Point(93, 97);
            this.CbxAño.Name = "CbxAño";
            this.CbxAño.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.CbxAño.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CbxAño.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.CbxAño.Properties.Appearance.Options.UseBackColor = true;
            this.CbxAño.Properties.Appearance.Options.UseBorderColor = true;
            this.CbxAño.Properties.Appearance.Options.UseForeColor = true;
            this.CbxAño.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.CbxAño.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CbxAño.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxAño.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.CbxAño.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CbxAño.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CbxAño.Size = new System.Drawing.Size(86, 20);
            this.CbxAño.TabIndex = 2;
            this.CbxAño.Enter += new System.EventHandler(this.CbxAño_Enter);
            this.CbxAño.Leave += new System.EventHandler(this.CbxAño_Leave);
            // 
            // LueUsuario
            // 
            this.LueUsuario.EnterMoveNextControl = true;
            this.LueUsuario.Location = new System.Drawing.Point(93, 30);
            this.LueUsuario.Name = "LueUsuario";
            this.LueUsuario.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.LueUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.LueUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.LueUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.LueUsuario.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueUsuario.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueUsuario.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.LueUsuario.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.LueUsuario.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.LueUsuario.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.LueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueUsuario.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LueUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LueUsuario.Properties.ShowHeader = false;
            this.LueUsuario.Size = new System.Drawing.Size(160, 20);
            this.LueUsuario.TabIndex = 0;
            this.LueUsuario.EditValueChanged += new System.EventHandler(this.LueUsuario_EditValueChanged);
            this.LueUsuario.Enter += new System.EventHandler(this.LueUsuario_Enter);
            this.LueUsuario.Leave += new System.EventHandler(this.LueUsuario_Leave);
            // 
            // FrmLogin1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.LnkLblCerrar);
            this.Controls.Add(this.LnkLblMinimizar);
            this.Name = "FrmLogin1";
            this.Text = "FrmLogin";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.FrmLogin1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbxMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxAño.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.LinkLabel LnkLblMinimizar;
        private System.Windows.Forms.LinkLabel LnkLblCerrar;
        private DevExpress.XtraEditors.SimpleButton BtnAjustes;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LueUsuario;
        private UsuarioControles.LblBase lblBase2;
        private UsuarioControles.LblBase lblBase1;
        private DevExpress.XtraScheduler.UI.MonthEdit CbxMes;
        private DevExpress.XtraEditors.ComboBoxEdit CbxAño;
        private UsuarioControles.LblBase lblBase3;
        private UsuarioControles.TxtBase TxtPassword;
    }
}