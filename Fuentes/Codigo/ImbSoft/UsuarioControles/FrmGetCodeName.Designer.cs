namespace UsuarioControles
{
    partial class FrmGetCodeName
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
            this.GbxDatos = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCod = new UsuarioControles.TxtBase();
            this.LblCodigo = new UsuarioControles.LblBase();
            this.TxtNombre = new UsuarioControles.TxtBase();
            this.LblNombre = new UsuarioControles.LblBase();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).BeginInit();
            this.GbxDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.panel1);
            this.GbxDatos.Controls.Add(this.acceptCancel1);
            this.GbxDatos.Location = new System.Drawing.Point(2, 29);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.ShowCaption = false;
            this.GbxDatos.Size = new System.Drawing.Size(469, 183);
            this.GbxDatos.TabIndex = 1;
            this.GbxDatos.Text = "groupControl1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtCod);
            this.panel1.Controls.Add(this.LblCodigo);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 96);
            this.panel1.TabIndex = 4;
            // 
            // TxtCod
            // 
            this.TxtCod.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtCod.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtCod.Appearance.Options.UseBackColor = true;
            this.TxtCod.CaraterPassword = '\0';
            this.TxtCod.Location = new System.Drawing.Point(80, 19);
            this.TxtCod.MaxLength = 50;
            this.TxtCod.MTextChanged = null;
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(321, 26);
            this.TxtCod.SoloLectura = false;
            this.TxtCod.TabIndex = 11;
            this.TxtCod.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCod.Texto = "";
            this.TxtCod.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtCod.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(14, 25);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(60, 13);
            this.LblCodigo.TabIndex = 10;
            this.LblCodigo.Texto = "Código:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtNombre.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.Appearance.Options.UseBackColor = true;
            this.TxtNombre.CaraterPassword = '\0';
            this.TxtNombre.Location = new System.Drawing.Point(80, 49);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.MTextChanged = null;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(321, 26);
            this.TxtNombre.SoloLectura = false;
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Texto = "";
            this.TxtNombre.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtNombre.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(14, 55);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(60, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Texto = "Nombre:";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(179, 129);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(111, 51);
            this.acceptCancel1.TabIndex = 2;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, -1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Titulo";
            this.cabeceraForm1.Size = new System.Drawing.Size(471, 32);
            this.cabeceraForm1.TabIndex = 2;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // FrmGetCodeName
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 214);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetCodeName";
            this.Text = "FrmGetCodeName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGetCodeName_FormClosing);
            this.Load += new System.EventHandler(this.FrmGetName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).EndInit();
            this.GbxDatos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GbxDatos;
        private AcceptCancel acceptCancel1;
        private CabeceraForm cabeceraForm1;
        private System.Windows.Forms.Panel panel1;
        private TxtBase TxtNombre;
        private LblBase LblNombre;
        private TxtBase TxtCod;
        private LblBase LblCodigo;
    }
}