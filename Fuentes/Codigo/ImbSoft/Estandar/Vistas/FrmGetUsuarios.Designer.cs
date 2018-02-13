namespace Estandar.Vistas
{
    partial class FrmGetUsuarios
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
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.LblNameFrm = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblConfirmarC = new UsuarioControles.LblBase();
            this.LblContraseña = new UsuarioControles.LblBase();
            this.LblUsurio = new UsuarioControles.LblBase();
            this.TxtPass2 = new DevExpress.XtraEditors.TextEdit();
            this.TxtPass1 = new DevExpress.XtraEditors.TextEdit();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNameFrm
            // 
            this.LblNameFrm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameFrm.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblNameFrm.Location = new System.Drawing.Point(273, 3);
            this.LblNameFrm.Name = "LblNameFrm";
            this.LblNameFrm.Size = new System.Drawing.Size(0, 18);
            this.LblNameFrm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblConfirmarC);
            this.panel1.Controls.Add(this.LblContraseña);
            this.panel1.Controls.Add(this.LblUsurio);
            this.panel1.Controls.Add(this.TxtPass2);
            this.panel1.Controls.Add(this.TxtPass1);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(18, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 130);
            this.panel1.TabIndex = 0;
            // 
            // LblConfirmarC
            // 
            this.LblConfirmarC.AutoSize = true;
            this.LblConfirmarC.Location = new System.Drawing.Point(24, 89);
            this.LblConfirmarC.Name = "LblConfirmarC";
            this.LblConfirmarC.Size = new System.Drawing.Size(119, 13);
            this.LblConfirmarC.TabIndex = 10;
            this.LblConfirmarC.Texto = "Confir. Contraseña:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(24, 57);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(78, 13);
            this.LblContraseña.TabIndex = 9;
            this.LblContraseña.Texto = "Contraseña:";
            // 
            // LblUsurio
            // 
            this.LblUsurio.AutoSize = true;
            this.LblUsurio.Location = new System.Drawing.Point(24, 25);
            this.LblUsurio.Name = "LblUsurio";
            this.LblUsurio.Size = new System.Drawing.Size(60, 13);
            this.LblUsurio.TabIndex = 8;
            this.LblUsurio.Texto = "Usuario:";
            // 
            // TxtPass2
            // 
            this.TxtPass2.EnterMoveNextControl = true;
            this.TxtPass2.Location = new System.Drawing.Point(155, 86);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtPass2.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtPass2.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPass2.Properties.Appearance.Options.UseForeColor = true;
            this.TxtPass2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPass2.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtPass2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtPass2.Properties.MaxLength = 50;
            this.TxtPass2.Properties.UseSystemPasswordChar = true;
            this.TxtPass2.Size = new System.Drawing.Size(167, 20);
            this.TxtPass2.TabIndex = 7;
            this.TxtPass2.TextChanged += new System.EventHandler(this.TxtPass2_TextChanged);
            this.TxtPass2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPass2_Validating);
            // 
            // TxtPass1
            // 
            this.TxtPass1.EnterMoveNextControl = true;
            this.TxtPass1.Location = new System.Drawing.Point(155, 54);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtPass1.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtPass1.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPass1.Properties.Appearance.Options.UseForeColor = true;
            this.TxtPass1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPass1.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtPass1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtPass1.Properties.MaxLength = 50;
            this.TxtPass1.Properties.UseSystemPasswordChar = true;
            this.TxtPass1.Size = new System.Drawing.Size(167, 20);
            this.TxtPass1.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.EnterMoveNextControl = true;
            this.TxtUsuario.Location = new System.Drawing.Point(156, 22);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.TxtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsuario.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtUsuario.Properties.MaxLength = 50;
            this.TxtUsuario.Size = new System.Drawing.Size(166, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Location = new System.Drawing.Point(24, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario:";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(138, 177);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(108, 49);
            this.acceptCancel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.acceptCancel1);
            this.panelControl1.Location = new System.Drawing.Point(2, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(385, 236);
            this.panelControl1.TabIndex = 0;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(1, 1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Usuarios";
            this.cabeceraForm1.Size = new System.Drawing.Size(385, 32);
            this.cabeceraForm1.TabIndex = 1;
            // 
            // FrmGetUsuarios
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.cabeceraForm1);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "FrmGetUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "Usuarios";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.GetUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UsuarioControles.AcceptCancel acceptCancel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.TextEdit TxtPass1;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.LabelControl LblNameFrm;
        private DevExpress.XtraEditors.TextEdit TxtPass2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UsuarioControles.CabeceraForm cabeceraForm1;
        private UsuarioControles.LblBase LblUsurio;
        private UsuarioControles.LblBase LblConfirmarC;
        private UsuarioControles.LblBase LblContraseña;
    }
}