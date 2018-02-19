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
            this.LblMonto = new System.Windows.Forms.Label();
            this.TxtLblResponsable = new TxtLblGeneral();
            this.LblResponsable = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblContrapartida = new TxtLblGeneral();
            this.LblContrapartida = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblCodigo = new TxtLblGeneral();
            this.LblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.acceptCancel1 = new AcceptCancel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtMonto);
            this.groupControl1.Controls.Add(this.LblMonto);
            this.groupControl1.Controls.Add(this.TxtLblResponsable);
            this.groupControl1.Controls.Add(this.LblResponsable);
            this.groupControl1.Controls.Add(this.TxtLblContrapartida);
            this.groupControl1.Controls.Add(this.LblContrapartida);
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Controls.Add(this.LblCodigo);
            this.groupControl1.Location = new System.Drawing.Point(11, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(510, 115);
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
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Location = new System.Drawing.Point(8, 87);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(37, 13);
            this.LblMonto.TabIndex = 22;
            this.LblMonto.Text = "Monto";
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
            this.TxtLblResponsable.Id = "";
            this.TxtLblResponsable.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblResponsable.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblResponsable.Location = new System.Drawing.Point(73, 57);
            this.TxtLblResponsable.MaxLenght = 0;
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
            this.TxtLblResponsable.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblResponsable.PerfilShow = null;
            this.TxtLblResponsable.PonerCeros = false;
            this.TxtLblResponsable.Relacion = null;
            this.TxtLblResponsable.SinBordes = false;
            this.TxtLblResponsable.Size = new System.Drawing.Size(429, 26);
            this.TxtLblResponsable.SoloLectura = false;
            this.TxtLblResponsable.TabIndex = 5;
            this.TxtLblResponsable.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblResponsable.TxtCodSize = new System.Drawing.Size(100, 18);
            // 
            // LblResponsable
            // 
            this.LblResponsable.Location = new System.Drawing.Point(11, 64);
            this.LblResponsable.Name = "LblResponsable";
            this.LblResponsable.Size = new System.Drawing.Size(37, 13);
            this.LblResponsable.TabIndex = 4;
            this.LblResponsable.Text = "Tercero";
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
            this.TxtLblContrapartida.Id = "";
            this.TxtLblContrapartida.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblContrapartida.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblContrapartida.Location = new System.Drawing.Point(73, 33);
            this.TxtLblContrapartida.MaxLenght = 0;
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
            this.TxtLblContrapartida.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblContrapartida.PerfilShow = null;
            this.TxtLblContrapartida.PonerCeros = false;
            this.TxtLblContrapartida.Relacion = null;
            this.TxtLblContrapartida.SinBordes = false;
            this.TxtLblContrapartida.Size = new System.Drawing.Size(429, 26);
            this.TxtLblContrapartida.SoloLectura = false;
            this.TxtLblContrapartida.TabIndex = 3;
            this.TxtLblContrapartida.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblContrapartida.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblContrapartida.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblContrapartida_Validating);
            // 
            // LblContrapartida
            // 
            this.LblContrapartida.Location = new System.Drawing.Point(11, 40);
            this.LblContrapartida.Name = "LblContrapartida";
            this.LblContrapartida.Size = new System.Drawing.Size(67, 13);
            this.LblContrapartida.TabIndex = 2;
            this.LblContrapartida.Text = "Contrapartida";
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
            this.TxtLblCodigo.Id = "";
            this.TxtLblCodigo.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCodigo.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblCodigo.Location = new System.Drawing.Point(73, 9);
            this.TxtLblCodigo.MaxLenght = 0;
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
            this.TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblCodigo.PerfilShow = null;
            this.TxtLblCodigo.PonerCeros = false;
            this.TxtLblCodigo.Relacion = null;
            this.TxtLblCodigo.SinBordes = false;
            this.TxtLblCodigo.Size = new System.Drawing.Size(429, 26);
            this.TxtLblCodigo.SoloLectura = false;
            this.TxtLblCodigo.TabIndex = 1;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Location = new System.Drawing.Point(11, 16);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(33, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(182, 130);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 6;
            // 
            // FrmGetCajaMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 171);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetCajaMenor";
            this.Text = "Capturando";
            this.Load += new System.EventHandler(this.FrmGetCajaMenor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.LabelControl LblCodigo;
        private TxtLblGeneral TxtLblResponsable;
        private DevExpress.XtraEditors.LabelControl LblResponsable;
        private TxtLblGeneral TxtLblContrapartida;
        private DevExpress.XtraEditors.LabelControl LblContrapartida;
        private DevExpress.XtraEditors.TextEdit TxtMonto;
        private System.Windows.Forms.Label LblMonto;
        private AcceptCancel acceptCancel1;
    }
}