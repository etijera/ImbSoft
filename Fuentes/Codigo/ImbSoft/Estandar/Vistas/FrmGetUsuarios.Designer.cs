﻿namespace Estandar.Vistas
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblNameFrm = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPass2 = new UsuarioControles.TxtBase();
            this.TxtPass1 = new UsuarioControles.TxtBase();
            this.LblTipoUsuario = new UsuarioControles.LblBase();
            this.LueTipoUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtNombre = new UsuarioControles.TxtBase();
            this.LblNombre = new UsuarioControles.LblBase();
            this.TxtUsuario = new UsuarioControles.TxtBase();
            this.LblConfirmarC = new UsuarioControles.LblBase();
            this.LblContraseña = new UsuarioControles.LblBase();
            this.LblUsurio = new UsuarioControles.LblBase();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueTipoUsuario.Properties)).BeginInit();
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
            this.panel1.Controls.Add(this.TxtPass2);
            this.panel1.Controls.Add(this.TxtPass1);
            this.panel1.Controls.Add(this.LblTipoUsuario);
            this.panel1.Controls.Add(this.LueTipoUsuario);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.LblConfirmarC);
            this.panel1.Controls.Add(this.LblContraseña);
            this.panel1.Controls.Add(this.LblUsurio);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 179);
            this.panel1.TabIndex = 0;
            // 
            // TxtPass2
            // 
            this.TxtPass2.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtPass2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtPass2.Appearance.Options.UseBackColor = true;
            this.TxtPass2.CaraterPassword = '*';
            this.TxtPass2.Location = new System.Drawing.Point(144, 138);
            this.TxtPass2.MaxLength = 50;
            this.TxtPass2.MSpin = null;
            this.TxtPass2.MTextChanged = null;
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.Size = new System.Drawing.Size(173, 26);
            this.TxtPass2.SoloLectura = false;
            this.TxtPass2.TabIndex = 4;
            this.TxtPass2.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPass2.Texto = "";
            this.TxtPass2.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtPass2.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtPass2.UseMaskAsDisplayFormat = false;
            this.TxtPass2.Value = "";
            this.TxtPass2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPass2_Validating);
            // 
            // TxtPass1
            // 
            this.TxtPass1.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtPass1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtPass1.Appearance.Options.UseBackColor = true;
            this.TxtPass1.CaraterPassword = '*';
            this.TxtPass1.Location = new System.Drawing.Point(144, 107);
            this.TxtPass1.MaxLength = 50;
            this.TxtPass1.MSpin = null;
            this.TxtPass1.MTextChanged = null;
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.Size = new System.Drawing.Size(173, 26);
            this.TxtPass1.SoloLectura = false;
            this.TxtPass1.TabIndex = 3;
            this.TxtPass1.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPass1.Texto = "";
            this.TxtPass1.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtPass1.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtPass1.UseMaskAsDisplayFormat = false;
            this.TxtPass1.Value = "";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(19, 82);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(89, 14);
            this.LblTipoUsuario.TabIndex = 7;
            this.LblTipoUsuario.Texto = "Tipo Usuario:";
            // 
            // LueTipoUsuario
            // 
            this.LueTipoUsuario.EnterMoveNextControl = true;
            this.LueTipoUsuario.Location = new System.Drawing.Point(147, 78);
            this.LueTipoUsuario.Name = "LueTipoUsuario";
            this.LueTipoUsuario.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.LueTipoUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.LueTipoUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.LueTipoUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.LueTipoUsuario.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.LueTipoUsuario.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkGreen;
            this.LueTipoUsuario.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.LueTipoUsuario.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.LueTipoUsuario.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.LueTipoUsuario.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.LueTipoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueTipoUsuario.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LueTipoUsuario.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LueTipoUsuario.Properties.ShowHeader = false;
            this.LueTipoUsuario.Size = new System.Drawing.Size(166, 20);
            this.LueTipoUsuario.TabIndex = 2;
            this.LueTipoUsuario.Enter += new System.EventHandler(this.LueTipoUsuario_Enter);
            this.LueTipoUsuario.Leave += new System.EventHandler(this.LueTipoUsuario_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtNombre.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.Appearance.Options.UseBackColor = true;
            this.TxtNombre.CaraterPassword = '\0';
            this.TxtNombre.Location = new System.Drawing.Point(144, 44);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.MSpin = null;
            this.TxtNombre.MTextChanged = null;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(173, 26);
            this.TxtNombre.SoloLectura = false;
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Texto = "";
            this.TxtNombre.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtNombre.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtNombre.UseMaskAsDisplayFormat = false;
            this.TxtNombre.Value = "";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(19, 51);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 14);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Texto = "Nombre:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtUsuario.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtUsuario.Appearance.Options.UseBackColor = true;
            this.TxtUsuario.CaraterPassword = '\0';
            this.TxtUsuario.Location = new System.Drawing.Point(144, 13);
            this.TxtUsuario.MaxLength = 20;
            this.TxtUsuario.MSpin = null;
            this.TxtUsuario.MTextChanged = null;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(173, 26);
            this.TxtUsuario.SoloLectura = false;
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsuario.Texto = "";
            this.TxtUsuario.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtUsuario.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtUsuario.UseMaskAsDisplayFormat = false;
            this.TxtUsuario.Value = "";
            this.TxtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            // 
            // LblConfirmarC
            // 
            this.LblConfirmarC.AutoSize = true;
            this.LblConfirmarC.Location = new System.Drawing.Point(19, 145);
            this.LblConfirmarC.Name = "LblConfirmarC";
            this.LblConfirmarC.Size = new System.Drawing.Size(129, 14);
            this.LblConfirmarC.TabIndex = 9;
            this.LblConfirmarC.Texto = "Confir. Contraseña:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(19, 114);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(84, 14);
            this.LblContraseña.TabIndex = 8;
            this.LblContraseña.Texto = "Contraseña:";
            // 
            // LblUsurio
            // 
            this.LblUsurio.AutoSize = true;
            this.LblUsurio.Location = new System.Drawing.Point(19, 20);
            this.LblUsurio.Name = "LblUsurio";
            this.LblUsurio.Size = new System.Drawing.Size(60, 14);
            this.LblUsurio.TabIndex = 5;
            this.LblUsurio.Texto = "Usuario:";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(138, 203);
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
            this.panelControl1.Location = new System.Drawing.Point(2, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(385, 259);
            this.panelControl1.TabIndex = 0;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, -1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Usuarios";
            this.cabeceraForm1.Size = new System.Drawing.Size(387, 32);
            this.cabeceraForm1.TabIndex = 1;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
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
            this.ClientSize = new System.Drawing.Size(388, 288);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "FrmGetUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "Usuarios";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.GetUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueTipoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsuarioControles.AcceptCancel acceptCancel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl LblNameFrm;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UsuarioControles.CabeceraForm cabeceraForm1;
        private UsuarioControles.LblBase LblUsurio;
        private UsuarioControles.LblBase LblConfirmarC;
        private UsuarioControles.LblBase LblContraseña;
        private UsuarioControles.TxtBase TxtUsuario;
        private UsuarioControles.TxtBase TxtNombre;
        private UsuarioControles.LblBase LblNombre;
        private UsuarioControles.LblBase LblTipoUsuario;
        private DevExpress.XtraEditors.LookUpEdit LueTipoUsuario;
        private UsuarioControles.TxtBase TxtPass2;
        private UsuarioControles.TxtBase TxtPass1;
    }
}