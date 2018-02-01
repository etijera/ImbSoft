namespace ImbSoft.Vistas
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.LnkLblMinimizar = new System.Windows.Forms.LinkLabel();
            this.LnkLblCerrar = new System.Windows.Forms.LinkLabel();
            this.BtnAjustes = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(277, 232);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 38);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.ToolTip = "Entrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.EnterMoveNextControl = true;
            this.TxtPassword.Location = new System.Drawing.Point(108, 261);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.TxtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TxtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPassword.Properties.Appearance.Options.UseFont = true;
            this.TxtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.TxtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPassword.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtPassword.Properties.MaxLength = 20;
            this.TxtPassword.Properties.UseSystemPasswordChar = true;
            this.TxtPassword.Size = new System.Drawing.Size(142, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress_1);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.EnterMoveNextControl = true;
            this.TxtUsuario.Location = new System.Drawing.Point(108, 220);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.TxtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TxtUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUsuario.Properties.Appearance.Options.UseFont = true;
            this.TxtUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.TxtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsuario.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtUsuario.Properties.MaxLength = 20;
            this.TxtUsuario.Size = new System.Drawing.Size(142, 20);
            this.TxtUsuario.TabIndex = 1;
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
            this.LnkLblMinimizar.TabIndex = 10;
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
            this.LnkLblCerrar.TabIndex = 11;
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
            this.BtnAjustes.TabIndex = 18;
            this.BtnAjustes.ToolTip = "Ajustes de conexión";
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // FrmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.LnkLblCerrar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LnkLblMinimizar);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.TransparencyKey = System.Drawing.Color.SeaGreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.LinkLabel LnkLblMinimizar;
        private System.Windows.Forms.LinkLabel LnkLblCerrar;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.SimpleButton BtnAjustes;
    }
}