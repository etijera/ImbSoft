using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetTipoDiferidos
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtLblCredito = new TxtLblGeneral();
            this.LblCredito = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblDebito = new TxtLblGeneral();
            this.LblDebito = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtLblCodigo = new TxtLblGeneral();
            this.LblCodigo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(167, 165);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtLblCredito);
            this.groupControl2.Controls.Add(this.LblCredito);
            this.groupControl2.Controls.Add(this.TxtLblDebito);
            this.groupControl2.Controls.Add(this.LblDebito);
            this.groupControl2.Location = new System.Drawing.Point(10, 66);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(486, 93);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Registro Contable";
            // 
            // TxtLblCredito
            // 
            this.TxtLblCredito.AutoSize = true;
            this.TxtLblCredito.Codigo = null;
            this.TxtLblCredito.Complemento = null;
            this.TxtLblCredito.database = null;
            this.TxtLblCredito.DesHabilitarBtnAñadir = true;
            this.TxtLblCredito.DesHabilitarBtnEditar = true;
            this.TxtLblCredito.DesHabilitarBtnEliminar = true;
            this.TxtLblCredito.DesHabilitarBtnExcel = true;
            this.TxtLblCredito.DesHabilitarBtnGuardar = true;
            this.TxtLblCredito.DesHabilitarBtnImprimir = true;
            this.TxtLblCredito.Id = "";
            this.TxtLblCredito.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCredito.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblCredito.Location = new System.Drawing.Point(50, 59);
            this.TxtLblCredito.MaxLenght = 0;
            this.TxtLblCredito.Name = "TxtLblCredito";
            this.TxtLblCredito.NexControl = false;
            this.TxtLblCredito.Nombre = null;
            this.TxtLblCredito.OcultarBtnAñadir = false;
            this.TxtLblCredito.OcultarBtnEditar = false;
            this.TxtLblCredito.OcultarBtnEliminar = false;
            this.TxtLblCredito.OcultarBtnExcel = false;
            this.TxtLblCredito.OcultarBtnGuardar = false;
            this.TxtLblCredito.OcultarBtnImprimir = false;
            this.TxtLblCredito.OpcionGet = null;
            this.TxtLblCredito.OpGet = false;
            this.TxtLblCredito.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblCredito.PerfilShow = null;
            this.TxtLblCredito.PonerCeros = false;
            this.TxtLblCredito.Relacion = null;
            this.TxtLblCredito.SinBordes = false;
            this.TxtLblCredito.Size = new System.Drawing.Size(429, 26);
            this.TxtLblCredito.SoloLectura = false;
            this.TxtLblCredito.TabIndex = 3;
            this.TxtLblCredito.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCredito.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCredito.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCredito_Validating);
            // 
            // LblCredito
            // 
            this.LblCredito.Location = new System.Drawing.Point(9, 66);
            this.LblCredito.Name = "LblCredito";
            this.LblCredito.Size = new System.Drawing.Size(35, 13);
            this.LblCredito.TabIndex = 2;
            this.LblCredito.Text = "Crédito";
            // 
            // TxtLblDebito
            // 
            this.TxtLblDebito.AutoSize = true;
            this.TxtLblDebito.Codigo = null;
            this.TxtLblDebito.Complemento = null;
            this.TxtLblDebito.database = null;
            this.TxtLblDebito.DesHabilitarBtnAñadir = true;
            this.TxtLblDebito.DesHabilitarBtnEditar = true;
            this.TxtLblDebito.DesHabilitarBtnEliminar = true;
            this.TxtLblDebito.DesHabilitarBtnExcel = true;
            this.TxtLblDebito.DesHabilitarBtnGuardar = true;
            this.TxtLblDebito.DesHabilitarBtnImprimir = true;
            this.TxtLblDebito.Id = "";
            this.TxtLblDebito.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblDebito.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblDebito.Location = new System.Drawing.Point(51, 27);
            this.TxtLblDebito.MaxLenght = 0;
            this.TxtLblDebito.Name = "TxtLblDebito";
            this.TxtLblDebito.NexControl = false;
            this.TxtLblDebito.Nombre = null;
            this.TxtLblDebito.OcultarBtnAñadir = false;
            this.TxtLblDebito.OcultarBtnEditar = false;
            this.TxtLblDebito.OcultarBtnEliminar = false;
            this.TxtLblDebito.OcultarBtnExcel = false;
            this.TxtLblDebito.OcultarBtnGuardar = false;
            this.TxtLblDebito.OcultarBtnImprimir = false;
            this.TxtLblDebito.OpcionGet = null;
            this.TxtLblDebito.OpGet = false;
            this.TxtLblDebito.Ordenar = OrdenarPor.CampoCodigo;
            this.TxtLblDebito.PerfilShow = null;
            this.TxtLblDebito.PonerCeros = false;
            this.TxtLblDebito.Relacion = null;
            this.TxtLblDebito.SinBordes = false;
            this.TxtLblDebito.Size = new System.Drawing.Size(429, 26);
            this.TxtLblDebito.SoloLectura = false;
            this.TxtLblDebito.TabIndex = 1;
            this.TxtLblDebito.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblDebito.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblDebito.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblDebito_Validating);
            // 
            // LblDebito
            // 
            this.LblDebito.Location = new System.Drawing.Point(9, 34);
            this.LblDebito.Name = "LblDebito";
            this.LblDebito.Size = new System.Drawing.Size(31, 13);
            this.LblDebito.TabIndex = 0;
            this.LblDebito.Text = "Débito";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Controls.Add(this.LblCodigo);
            this.groupControl1.Location = new System.Drawing.Point(10, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(486, 48);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
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
            this.TxtLblCodigo.Location = new System.Drawing.Point(50, 9);
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
            // FrmGetTipoDiferidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 209);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetTipoDiferidos";
            this.Text = "Capturando";
            this.Load += new System.EventHandler(this.FrmGetTipoDiferidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private TxtLblGeneral TxtLblCredito;
        private DevExpress.XtraEditors.LabelControl LblCredito;
        private TxtLblGeneral TxtLblDebito;
        private DevExpress.XtraEditors.LabelControl LblDebito;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.LabelControl LblCodigo;
    }
}