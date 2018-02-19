using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetTarifaIva
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
            this.acceptCancel1 = new AcceptCancel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.RgbModalidad = new DevExpress.XtraEditors.RadioGroup();
            this.LblTipo = new System.Windows.Forms.Label();
            this.RgbTipo = new DevExpress.XtraEditors.RadioGroup();
            this.TxtTarifa = new DevExpress.XtraEditors.TextEdit();
            this.LblTarifa = new System.Windows.Forms.Label();
            this.TxtLblCodigo = new TxtLblGeneral();
            this.LblCodigo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbModalidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarifa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(200, 111);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.RgbModalidad);
            this.groupControl1.Controls.Add(this.LblTipo);
            this.groupControl1.Controls.Add(this.RgbTipo);
            this.groupControl1.Controls.Add(this.TxtTarifa);
            this.groupControl1.Controls.Add(this.LblTarifa);
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Controls.Add(this.LblCodigo);
            this.groupControl1.Location = new System.Drawing.Point(11, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(551, 93);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "groupControl1";
            // 
            // RgbModalidad
            // 
            this.RgbModalidad.AutoSizeInLayoutControl = true;
            this.RgbModalidad.EnterMoveNextControl = true;
            this.RgbModalidad.Location = new System.Drawing.Point(163, 62);
            this.RgbModalidad.Name = "RgbModalidad";
            this.RgbModalidad.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RgbModalidad.Properties.Appearance.Options.UseBackColor = true;
            this.RgbModalidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.RgbModalidad.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Bienes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Servicios")});
            this.RgbModalidad.Size = new System.Drawing.Size(376, 22);
            this.RgbModalidad.TabIndex = 31;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(14, 15);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(27, 13);
            this.LblTipo.TabIndex = 31;
            this.LblTipo.Text = "Tipo";
            // 
            // RgbTipo
            // 
            this.RgbTipo.AutoSizeInLayoutControl = true;
            this.RgbTipo.EnterMoveNextControl = true;
            this.RgbTipo.Location = new System.Drawing.Point(57, 10);
            this.RgbTipo.Name = "RgbTipo";
            this.RgbTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RgbTipo.Properties.Appearance.Options.UseBackColor = true;
            this.RgbTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.RgbTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Generado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Descontable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Régimen Simplificado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Transitorio")});
            this.RgbTipo.Size = new System.Drawing.Size(482, 22);
            this.RgbTipo.TabIndex = 30;
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.EditValue = "0";
            this.TxtTarifa.EnterMoveNextControl = true;
            this.TxtTarifa.Location = new System.Drawing.Point(57, 62);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTarifa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTarifa.Properties.Mask.EditMask = "P2";
            this.TxtTarifa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtTarifa.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtTarifa.Properties.MaxLength = 15;
            this.TxtTarifa.Properties.ValidateOnEnterKey = true;
            this.TxtTarifa.Size = new System.Drawing.Size(100, 20);
            this.TxtTarifa.TabIndex = 25;
            // 
            // LblTarifa
            // 
            this.LblTarifa.AutoSize = true;
            this.LblTarifa.Location = new System.Drawing.Point(15, 65);
            this.LblTarifa.Name = "LblTarifa";
            this.LblTarifa.Size = new System.Drawing.Size(35, 13);
            this.LblTarifa.TabIndex = 24;
            this.LblTarifa.Text = "Tarifa";
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
            this.TxtLblCodigo.LblNomSize = new System.Drawing.Size(376, 20);
            this.TxtLblCodigo.Location = new System.Drawing.Point(57, 34);
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
            this.TxtLblCodigo.Size = new System.Drawing.Size(485, 26);
            this.TxtLblCodigo.SoloLectura = false;
            this.TxtLblCodigo.TabIndex = 1;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Location = new System.Drawing.Point(18, 41);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(33, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // FrmGetTarifaIva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 153);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetTarifaIva";
            this.Text = "Tarifas I.V.A";
            this.Load += new System.EventHandler(this.FrmGetTarifaIva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbModalidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarifa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.LabelControl LblCodigo;
        private DevExpress.XtraEditors.TextEdit TxtTarifa;
        private System.Windows.Forms.Label LblTarifa;
        private DevExpress.XtraEditors.RadioGroup RgbModalidad;
        private System.Windows.Forms.Label LblTipo;
        private DevExpress.XtraEditors.RadioGroup RgbTipo;
    }
}