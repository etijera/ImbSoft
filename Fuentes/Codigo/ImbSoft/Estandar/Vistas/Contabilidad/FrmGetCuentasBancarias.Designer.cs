using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetCuentasBancarias
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
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCodigo = new UsuarioControles.LblBase();
            this.ChkGravamen = new DevExpress.XtraEditors.CheckEdit();
            this.LblUltimoCheque = new UsuarioControles.LblBase();
            this.TxtLblCodigo = new UsuarioControles.TxtLblGeneral();
            this.TxtUltimoCheque = new UsuarioControles.TxtBase();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.TxtLblArchivoDisfon = new UsuarioControles.TxtLblGeneral();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGravamen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(241, 129);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(112, 49);
            this.acceptCancel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.acceptCancel1);
            this.groupControl1.Controls.Add(this.lblBase1);
            this.groupControl1.Controls.Add(this.TxtLblArchivoDisfon);
            this.groupControl1.Location = new System.Drawing.Point(2, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(595, 183);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblCodigo);
            this.panel1.Controls.Add(this.ChkGravamen);
            this.panel1.Controls.Add(this.LblUltimoCheque);
            this.panel1.Controls.Add(this.TxtLblCodigo);
            this.panel1.Controls.Add(this.TxtUltimoCheque);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(16, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 100);
            this.panel1.TabIndex = 0;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(14, 25);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(61, 14);
            this.LblCodigo.TabIndex = 3;
            this.LblCodigo.Texto = "Código:";
            // 
            // ChkGravamen
            // 
            this.ChkGravamen.EnterMoveNextControl = true;
            this.ChkGravamen.Location = new System.Drawing.Point(249, 56);
            this.ChkGravamen.Name = "ChkGravamen";
            this.ChkGravamen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGravamen.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.ChkGravamen.Properties.Appearance.Options.UseFont = true;
            this.ChkGravamen.Properties.Appearance.Options.UseForeColor = true;
            this.ChkGravamen.Properties.Caption = "Aplicar Gravames a Trnasacciones Financieras";
            this.ChkGravamen.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ChkGravamen.Size = new System.Drawing.Size(297, 19);
            this.ChkGravamen.TabIndex = 2;
            // 
            // LblUltimoCheque
            // 
            this.LblUltimoCheque.AutoSize = true;
            this.LblUltimoCheque.Location = new System.Drawing.Point(14, 59);
            this.LblUltimoCheque.Name = "LblUltimoCheque";
            this.LblUltimoCheque.Size = new System.Drawing.Size(103, 14);
            this.LblUltimoCheque.TabIndex = 4;
            this.LblUltimoCheque.Texto = "Último Cheque:";
            // 
            // TxtLblCodigo
            // 
            this.TxtLblCodigo.AutoSize = true;
            this.TxtLblCodigo.Codigo = null;
            this.TxtLblCodigo.Complemento = null;
            this.TxtLblCodigo.database = null;
            this.TxtLblCodigo.DesHabilitarBtnAñadir = true;
            this.TxtLblCodigo.DesHabilitarBtnEditar = true;
            this.TxtLblCodigo.DesHabilitarBtnEliminar = true;
            this.TxtLblCodigo.DesHabilitarBtnExcel = true;
            this.TxtLblCodigo.DesHabilitarBtnGuardar = true;
            this.TxtLblCodigo.DesHabilitarBtnImprimir = true;
            this.TxtLblCodigo.DesHabilitarTodo = false;
            this.TxtLblCodigo.Id = "";
            this.TxtLblCodigo.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCodigo.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblCodigo.Location = new System.Drawing.Point(118, 19);
            this.TxtLblCodigo.MaxLenght = 0;
            this.TxtLblCodigo.Modo = null;
            this.TxtLblCodigo.Name = "TxtLblCodigo";
            this.TxtLblCodigo.NexControl = false;
            this.TxtLblCodigo.Nombre = null;
            this.TxtLblCodigo.OcultarBtnAñadir = false;
            this.TxtLblCodigo.OcultarBtnEditar = false;
            this.TxtLblCodigo.OcultarBtnEliminar = false;
            this.TxtLblCodigo.OcultarBtnExcel = false;
            this.TxtLblCodigo.OcultarBtnGuardar = false;
            this.TxtLblCodigo.OcultarBtnImprimir = false;
            this.TxtLblCodigo.OpcionGet = null;
            this.TxtLblCodigo.OpGet = false;
            this.TxtLblCodigo.Ordenar = Referencias.OrdenarPor.CampoCodigo;
            this.TxtLblCodigo.PasarUsuario = false;
            this.TxtLblCodigo.PerfilShow = null;
            this.TxtLblCodigo.PonerCeros = false;
            this.TxtLblCodigo.Relacion = null;
            this.TxtLblCodigo.SinBordes = false;
            this.TxtLblCodigo.Size = new System.Drawing.Size(429, 26);
            this.TxtLblCodigo.SoloLectura = false;
            this.TxtLblCodigo.TabIndex = 0;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblCodigo.Usuario = null;
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // TxtUltimoCheque
            // 
            this.TxtUltimoCheque.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtUltimoCheque.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtUltimoCheque.Appearance.Options.UseBackColor = true;
            this.TxtUltimoCheque.CaraterPassword = '\0';
            this.TxtUltimoCheque.Location = new System.Drawing.Point(115, 54);
            this.TxtUltimoCheque.MaxLenght = 12;
            this.TxtUltimoCheque.MTextChanged = null;
            this.TxtUltimoCheque.Name = "TxtUltimoCheque";
            this.TxtUltimoCheque.Size = new System.Drawing.Size(107, 26);
            this.TxtUltimoCheque.SoloLectura = false;
            this.TxtUltimoCheque.TabIndex = 1;
            this.TxtUltimoCheque.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUltimoCheque.Texto = "";
            this.TxtUltimoCheque.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtUltimoCheque.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(16, 151);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(103, 14);
            this.lblBase1.TabIndex = 25;
            this.lblBase1.Texto = "Archivo Disfon:";
            this.lblBase1.Visible = false;
            // 
            // TxtLblArchivoDisfon
            // 
            this.TxtLblArchivoDisfon.AutoSize = true;
            this.TxtLblArchivoDisfon.Codigo = null;
            this.TxtLblArchivoDisfon.Complemento = null;
            this.TxtLblArchivoDisfon.database = null;
            this.TxtLblArchivoDisfon.DesHabilitarBtnAñadir = false;
            this.TxtLblArchivoDisfon.DesHabilitarBtnEditar = false;
            this.TxtLblArchivoDisfon.DesHabilitarBtnEliminar = false;
            this.TxtLblArchivoDisfon.DesHabilitarBtnExcel = true;
            this.TxtLblArchivoDisfon.DesHabilitarBtnGuardar = true;
            this.TxtLblArchivoDisfon.DesHabilitarBtnImprimir = true;
            this.TxtLblArchivoDisfon.DesHabilitarTodo = false;
            this.TxtLblArchivoDisfon.Id = "";
            this.TxtLblArchivoDisfon.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblArchivoDisfon.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblArchivoDisfon.Location = new System.Drawing.Point(119, 139);
            this.TxtLblArchivoDisfon.MaxLenght = 0;
            this.TxtLblArchivoDisfon.Modo = null;
            this.TxtLblArchivoDisfon.Name = "TxtLblArchivoDisfon";
            this.TxtLblArchivoDisfon.NexControl = false;
            this.TxtLblArchivoDisfon.Nombre = null;
            this.TxtLblArchivoDisfon.OcultarBtnAñadir = false;
            this.TxtLblArchivoDisfon.OcultarBtnEditar = false;
            this.TxtLblArchivoDisfon.OcultarBtnEliminar = false;
            this.TxtLblArchivoDisfon.OcultarBtnExcel = false;
            this.TxtLblArchivoDisfon.OcultarBtnGuardar = false;
            this.TxtLblArchivoDisfon.OcultarBtnImprimir = false;
            this.TxtLblArchivoDisfon.OpcionGet = null;
            this.TxtLblArchivoDisfon.OpGet = false;
            this.TxtLblArchivoDisfon.Ordenar = Referencias.OrdenarPor.CampoCodigo;
            this.TxtLblArchivoDisfon.PasarUsuario = false;
            this.TxtLblArchivoDisfon.PerfilShow = null;
            this.TxtLblArchivoDisfon.PonerCeros = false;
            this.TxtLblArchivoDisfon.Relacion = null;
            this.TxtLblArchivoDisfon.SinBordes = false;
            this.TxtLblArchivoDisfon.Size = new System.Drawing.Size(429, 26);
            this.TxtLblArchivoDisfon.SoloLectura = false;
            this.TxtLblArchivoDisfon.TabIndex = 3;
            this.TxtLblArchivoDisfon.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblArchivoDisfon.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblArchivoDisfon.Usuario = null;
            this.TxtLblArchivoDisfon.Visible = false;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, -1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Capturando ";
            this.cabeceraForm1.Size = new System.Drawing.Size(597, 32);
            this.cabeceraForm1.TabIndex = 1;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // FrmGetCuentasBancarias
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 213);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetCuentasBancarias";
            this.Text = "Capturando ";
            this.Load += new System.EventHandler(this.FrmGetCuentasBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGravamen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblArchivoDisfon;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.CheckEdit ChkGravamen;
        private CabeceraForm cabeceraForm1;
        private System.Windows.Forms.Panel panel1;
        private TxtBase TxtUltimoCheque;
        private LblBase LblUltimoCheque;
        private LblBase LblCodigo;
        private LblBase lblBase1;
    }
}