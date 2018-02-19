using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetRetenciones
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblCuenta = new TxtLblGeneral();
            this.TxtMonto = new DevExpress.XtraEditors.TextEdit();
            this.TxtPorcentaje = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.acceptCancel1 = new AcceptCancel();
            this.errorP1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Porcentaje:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cuenta:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Monto:";
            // 
            // TxtLblCuenta
            // 
            this.TxtLblCuenta.AutoSize = true;
            this.TxtLblCuenta.Codigo = null;
            this.TxtLblCuenta.Complemento = null;
            this.TxtLblCuenta.database = null;
            this.TxtLblCuenta.DesHabilitarBtnAñadir = false;
            this.TxtLblCuenta.DesHabilitarBtnEditar = false;
            this.TxtLblCuenta.DesHabilitarBtnEliminar = false;
            this.TxtLblCuenta.DesHabilitarBtnExcel = false;
            this.TxtLblCuenta.DesHabilitarBtnGuardar = false;
            this.TxtLblCuenta.DesHabilitarBtnImprimir = false;
            this.TxtLblCuenta.Enabled = false;
            this.TxtLblCuenta.Id = "";
            this.TxtLblCuenta.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCuenta.LblNomSize = new System.Drawing.Size(253, 20);
            this.TxtLblCuenta.Location = new System.Drawing.Point(93, 10);
            this.TxtLblCuenta.MaxLenght = 12;
            this.TxtLblCuenta.Name = "TxtLblCuenta";
            this.TxtLblCuenta.NexControl = false;
            this.TxtLblCuenta.Nombre = null;
            this.TxtLblCuenta.OcultarBtnAñadir = false;
            this.TxtLblCuenta.OcultarBtnEditar = false;
            this.TxtLblCuenta.OcultarBtnEliminar = false;
            this.TxtLblCuenta.OcultarBtnExcel = false;
            this.TxtLblCuenta.OcultarBtnGuardar = false;
            this.TxtLblCuenta.OcultarBtnImprimir = false;
            this.TxtLblCuenta.OpcionGet = null;
            this.TxtLblCuenta.OpGet = false;
            this.TxtLblCuenta.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblCuenta.PerfilShow = null;
            this.TxtLblCuenta.PonerCeros = false;
            this.TxtLblCuenta.Relacion = null;
            this.TxtLblCuenta.SinBordes = false;
            this.TxtLblCuenta.Size = new System.Drawing.Size(362, 26);
            this.TxtLblCuenta.SoloLectura = false;
            this.TxtLblCuenta.TabIndex = 4;
            this.TxtLblCuenta.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCuenta.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCuenta.Validated += new System.EventHandler(this.TxtLblCuenta_Validated);
            // 
            // TxtMonto
            // 
            this.TxtMonto.EnterMoveNextControl = true;
            this.TxtMonto.Location = new System.Drawing.Point(93, 52);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtMonto.Properties.Mask.EditMask = "n0";
            this.TxtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtMonto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtMonto.Properties.MaxLength = 9;
            this.TxtMonto.Size = new System.Drawing.Size(100, 18);
            this.TxtMonto.TabIndex = 5;
            this.TxtMonto.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.TxtMonto_Spin);
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.EnterMoveNextControl = true;
            this.TxtPorcentaje.Location = new System.Drawing.Point(93, 91);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtPorcentaje.Properties.Mask.EditMask = "P3";
            this.TxtPorcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPorcentaje.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtPorcentaje.Properties.MaxLength = 9;
            this.TxtPorcentaje.Size = new System.Drawing.Size(100, 18);
            this.TxtPorcentaje.TabIndex = 6;
            this.TxtPorcentaje.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.TxtPorcentaje_Spin);
            this.TxtPorcentaje.TextChanged += new System.EventHandler(this.TxtPorcentaje_TextChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgTipo);
            this.groupControl1.Location = new System.Drawing.Point(225, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(227, 75);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Tipo de Retención";
            // 
            // rgTipo
            // 
            this.rgTipo.AutoSizeInLayoutControl = true;
            this.rgTipo.Location = new System.Drawing.Point(6, 25);
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTipo.Properties.Appearance.Options.UseBackColor = true;
            this.rgTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Anticipo de Impuestos y Contribuciones"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Retenciones a Cargo")});
            this.rgTipo.Size = new System.Drawing.Size(215, 42);
            this.rgTipo.TabIndex = 59;
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(146, 123);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 8;
            // 
            // errorP1
            // 
            this.errorP1.ContainerControl = this;
            // 
            // FrmGetRetenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 168);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtLblCuenta);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetRetenciones";
            this.Text = "FrmRetenciones";
            this.Load += new System.EventHandler(this.FrmGetRetenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private TxtLblGeneral TxtLblCuenta;
        private DevExpress.XtraEditors.TextEdit TxtMonto;
        private DevExpress.XtraEditors.TextEdit TxtPorcentaje;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorP1;
    }
}