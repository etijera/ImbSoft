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
            this.acceptCancel1 = new AcceptCancel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ChkGravamen = new DevExpress.XtraEditors.CheckEdit();
            this.TxtUltimoCheque = new DevExpress.XtraEditors.TextEdit();
            this.LblUltimoCheque = new System.Windows.Forms.Label();
            this.TxtLblArchivoDisfon = new TxtLblGeneral();
            this.LblArchivoDisfon = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblCodigo = new TxtLblGeneral();
            this.LblCodigo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGravamen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUltimoCheque.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(192, 111);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ChkGravamen);
            this.groupControl1.Controls.Add(this.TxtUltimoCheque);
            this.groupControl1.Controls.Add(this.LblUltimoCheque);
            this.groupControl1.Controls.Add(this.TxtLblArchivoDisfon);
            this.groupControl1.Controls.Add(this.LblArchivoDisfon);
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Controls.Add(this.LblCodigo);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(532, 93);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // ChkGravamen
            // 
            this.ChkGravamen.EnterMoveNextControl = true;
            this.ChkGravamen.Location = new System.Drawing.Point(252, 63);
            this.ChkGravamen.Name = "ChkGravamen";
            this.ChkGravamen.Properties.Caption = "Aplicar Gravames a Trnasacciones Financieras";
            this.ChkGravamen.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ChkGravamen.Size = new System.Drawing.Size(250, 19);
            this.ChkGravamen.TabIndex = 24;
            // 
            // TxtUltimoCheque
            // 
            this.TxtUltimoCheque.EditValue = "";
            this.TxtUltimoCheque.EnterMoveNextControl = true;
            this.TxtUltimoCheque.Location = new System.Drawing.Point(90, 62);
            this.TxtUltimoCheque.Name = "TxtUltimoCheque";
            this.TxtUltimoCheque.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtUltimoCheque.Properties.MaxLength = 12;
            this.TxtUltimoCheque.Properties.ValidateOnEnterKey = true;
            this.TxtUltimoCheque.Size = new System.Drawing.Size(100, 20);
            this.TxtUltimoCheque.TabIndex = 23;
            // 
            // LblUltimoCheque
            // 
            this.LblUltimoCheque.AutoSize = true;
            this.LblUltimoCheque.Location = new System.Drawing.Point(8, 65);
            this.LblUltimoCheque.Name = "LblUltimoCheque";
            this.LblUltimoCheque.Size = new System.Drawing.Size(76, 13);
            this.LblUltimoCheque.TabIndex = 22;
            this.LblUltimoCheque.Text = "Último Cheque";
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
            this.TxtLblArchivoDisfon.Id = "";
            this.TxtLblArchivoDisfon.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblArchivoDisfon.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblArchivoDisfon.Location = new System.Drawing.Point(90, 35);
            this.TxtLblArchivoDisfon.MaxLenght = 0;
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
            this.TxtLblArchivoDisfon.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblArchivoDisfon.PerfilShow = null;
            this.TxtLblArchivoDisfon.PonerCeros = false;
            this.TxtLblArchivoDisfon.Relacion = null;
            this.TxtLblArchivoDisfon.SinBordes = false;
            this.TxtLblArchivoDisfon.Size = new System.Drawing.Size(429, 26);
            this.TxtLblArchivoDisfon.SoloLectura = false;
            this.TxtLblArchivoDisfon.TabIndex = 3;
            this.TxtLblArchivoDisfon.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblArchivoDisfon.TxtCodSize = new System.Drawing.Size(100, 18);
            // 
            // LblArchivoDisfon
            // 
            this.LblArchivoDisfon.Location = new System.Drawing.Point(11, 42);
            this.LblArchivoDisfon.Name = "LblArchivoDisfon";
            this.LblArchivoDisfon.Size = new System.Drawing.Size(69, 13);
            this.LblArchivoDisfon.TabIndex = 2;
            this.LblArchivoDisfon.Text = "Archivo Disfon";
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
            this.TxtLblCodigo.Location = new System.Drawing.Point(90, 11);
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
            this.LblCodigo.Location = new System.Drawing.Point(11, 18);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(33, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // FrmGetCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 154);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetCuentasBancarias";
            this.Text = "Capturando ";
            this.Load += new System.EventHandler(this.FrmGetCuentasBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGravamen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUltimoCheque.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtUltimoCheque;
        private System.Windows.Forms.Label LblUltimoCheque;
        private TxtLblGeneral TxtLblArchivoDisfon;
        private DevExpress.XtraEditors.LabelControl LblArchivoDisfon;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.LabelControl LblCodigo;
        private DevExpress.XtraEditors.CheckEdit ChkGravamen;
    }
}