using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetCajaMenor
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtMonto = new DevExpress.XtraEditors.TextEdit();
            this.TxtLblResponsable = new UsuarioControles.TxtLblGeneral();
            this.TxtLblContrapartida = new UsuarioControles.TxtLblGeneral();
            this.TxtLblCodigo = new UsuarioControles.TxtLblGeneral();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.lblBase2 = new UsuarioControles.LblBase();
            this.lblBase3 = new UsuarioControles.LblBase();
            this.lblBase4 = new UsuarioControles.LblBase();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblBase4);
            this.groupControl1.Controls.Add(this.lblBase3);
            this.groupControl1.Controls.Add(this.lblBase2);
            this.groupControl1.Controls.Add(this.lblBase1);
            this.groupControl1.Controls.Add(this.TxtMonto);
            this.groupControl1.Controls.Add(this.acceptCancel1);
            this.groupControl1.Controls.Add(this.TxtLblResponsable);
            this.groupControl1.Controls.Add(this.TxtLblContrapartida);
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Location = new System.Drawing.Point(2, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(565, 168);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // TxtMonto
            // 
            this.TxtMonto.EditValue = "0";
            this.TxtMonto.EnterMoveNextControl = true;
            this.TxtMonto.Location = new System.Drawing.Point(73, 84);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtMonto.Properties.Mask.EditMask = "n2";
            this.TxtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtMonto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtMonto.Properties.MaxLength = 15;
            this.TxtMonto.Properties.ValidateOnEnterKey = true;
            this.TxtMonto.Size = new System.Drawing.Size(100, 20);
            this.TxtMonto.TabIndex = 23;
            // 
            // TxtLblResponsable
            // 
            this.TxtLblResponsable.AutoSize = true;
            this.TxtLblResponsable.Codigo = null;
            this.TxtLblResponsable.Complemento = null;
            this.TxtLblResponsable.database = null;
            this.TxtLblResponsable.DesHabilitarBtnAñadir = true;
            this.TxtLblResponsable.DesHabilitarBtnEditar = true;
            this.TxtLblResponsable.DesHabilitarBtnEliminar = true;
            this.TxtLblResponsable.DesHabilitarBtnExcel = true;
            this.TxtLblResponsable.DesHabilitarBtnGuardar = true;
            this.TxtLblResponsable.DesHabilitarBtnImprimir = true;
            this.TxtLblResponsable.DesHabilitarTodo = false;
            this.TxtLblResponsable.Id = "";
            this.TxtLblResponsable.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblResponsable.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblResponsable.Location = new System.Drawing.Point(73, 57);
            this.TxtLblResponsable.MaxLenght = 0;
            this.TxtLblResponsable.Modo = null;
            this.TxtLblResponsable.Name = "TxtLblResponsable";
            this.TxtLblResponsable.NexControl = false;
            this.TxtLblResponsable.Nombre = null;
            this.TxtLblResponsable.OcultarBtnAñadir = false;
            this.TxtLblResponsable.OcultarBtnEditar = false;
            this.TxtLblResponsable.OcultarBtnEliminar = false;
            this.TxtLblResponsable.OcultarBtnExcel = false;
            this.TxtLblResponsable.OcultarBtnGuardar = false;
            this.TxtLblResponsable.OcultarBtnImprimir = false;
            this.TxtLblResponsable.OpcionGet = null;
            this.TxtLblResponsable.OpGet = false;
            this.TxtLblResponsable.Ordenar = Referencias.OrdenarPor.CampoCodigo;
            this.TxtLblResponsable.PasarUsuario = false;
            this.TxtLblResponsable.PerfilShow = null;
            this.TxtLblResponsable.PonerCeros = false;
            this.TxtLblResponsable.Relacion = null;
            this.TxtLblResponsable.SinBordes = false;
            this.TxtLblResponsable.Size = new System.Drawing.Size(429, 26);
            this.TxtLblResponsable.SoloLectura = false;
            this.TxtLblResponsable.TabIndex = 5;
            this.TxtLblResponsable.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblResponsable.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblResponsable.Usuario = null;
            // 
            // TxtLblContrapartida
            // 
            this.TxtLblContrapartida.AutoSize = true;
            this.TxtLblContrapartida.Codigo = null;
            this.TxtLblContrapartida.Complemento = null;
            this.TxtLblContrapartida.database = null;
            this.TxtLblContrapartida.DesHabilitarBtnAñadir = true;
            this.TxtLblContrapartida.DesHabilitarBtnEditar = true;
            this.TxtLblContrapartida.DesHabilitarBtnEliminar = true;
            this.TxtLblContrapartida.DesHabilitarBtnExcel = true;
            this.TxtLblContrapartida.DesHabilitarBtnGuardar = true;
            this.TxtLblContrapartida.DesHabilitarBtnImprimir = true;
            this.TxtLblContrapartida.DesHabilitarTodo = false;
            this.TxtLblContrapartida.Id = "";
            this.TxtLblContrapartida.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblContrapartida.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblContrapartida.Location = new System.Drawing.Point(102, 33);
            this.TxtLblContrapartida.MaxLenght = 0;
            this.TxtLblContrapartida.Modo = null;
            this.TxtLblContrapartida.Name = "TxtLblContrapartida";
            this.TxtLblContrapartida.NexControl = false;
            this.TxtLblContrapartida.Nombre = null;
            this.TxtLblContrapartida.OcultarBtnAñadir = false;
            this.TxtLblContrapartida.OcultarBtnEditar = false;
            this.TxtLblContrapartida.OcultarBtnEliminar = false;
            this.TxtLblContrapartida.OcultarBtnExcel = false;
            this.TxtLblContrapartida.OcultarBtnGuardar = false;
            this.TxtLblContrapartida.OcultarBtnImprimir = false;
            this.TxtLblContrapartida.OpcionGet = null;
            this.TxtLblContrapartida.OpGet = false;
            this.TxtLblContrapartida.Ordenar = Referencias.OrdenarPor.CampoCodigo;
            this.TxtLblContrapartida.PasarUsuario = false;
            this.TxtLblContrapartida.PerfilShow = null;
            this.TxtLblContrapartida.PonerCeros = false;
            this.TxtLblContrapartida.Relacion = null;
            this.TxtLblContrapartida.SinBordes = false;
            this.TxtLblContrapartida.Size = new System.Drawing.Size(429, 26);
            this.TxtLblContrapartida.SoloLectura = false;
            this.TxtLblContrapartida.TabIndex = 3;
            this.TxtLblContrapartida.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblContrapartida.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblContrapartida.Usuario = null;
            this.TxtLblContrapartida.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblContrapartida_Validating);
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
            this.TxtLblCodigo.Location = new System.Drawing.Point(87, 9);
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
            this.TxtLblCodigo.TabIndex = 1;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblCodigo.Usuario = null;
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(211, 114);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(106, 49);
            this.acceptCancel1.TabIndex = 6;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, 0);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Titulo";
            this.cabeceraForm1.Size = new System.Drawing.Size(567, 32);
            this.cabeceraForm1.TabIndex = 7;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // lblBase1
            // 
            this.lblBase1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase1.Appearance.Options.UseBackColor = true;
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(11, 16);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(53, 13);
            this.lblBase1.TabIndex = 24;
            this.lblBase1.Texto = "Código:";
            // 
            // lblBase2
            // 
            this.lblBase2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase2.Appearance.Options.UseBackColor = true;
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(11, 39);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(90, 13);
            this.lblBase2.TabIndex = 25;
            this.lblBase2.Texto = "Contrapartida:";
            // 
            // lblBase3
            // 
            this.lblBase3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase3.Appearance.Options.UseBackColor = true;
            this.lblBase3.AutoSize = true;
            this.lblBase3.Location = new System.Drawing.Point(11, 65);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(62, 13);
            this.lblBase3.TabIndex = 26;
            this.lblBase3.Texto = "Tercero:";
            // 
            // lblBase4
            // 
            this.lblBase4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase4.Appearance.Options.UseBackColor = true;
            this.lblBase4.AutoSize = true;
            this.lblBase4.Location = new System.Drawing.Point(11, 87);
            this.lblBase4.Name = "lblBase4";
            this.lblBase4.Size = new System.Drawing.Size(49, 13);
            this.lblBase4.TabIndex = 27;
            this.lblBase4.Texto = "Monto:";
            // 
            // FrmGetCajaMenor
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 203);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetCajaMenor";
            this.Text = "Capturando";
            this.Load += new System.EventHandler(this.FrmGetCajaMenor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblCodigo;
        private TxtLblGeneral TxtLblResponsable;
        private TxtLblGeneral TxtLblContrapartida;
        private DevExpress.XtraEditors.TextEdit TxtMonto;
        private AcceptCancel acceptCancel1;
        private CabeceraForm cabeceraForm1;
        private LblBase lblBase4;
        private LblBase lblBase3;
        private LblBase lblBase2;
        private LblBase lblBase1;
    }
}