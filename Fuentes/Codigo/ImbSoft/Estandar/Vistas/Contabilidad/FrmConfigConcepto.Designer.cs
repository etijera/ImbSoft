namespace Estandar.Vistas.Contabilidad
{
    partial class FrmConfigConcepto
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
            this.LblConcepto = new DevExpress.XtraEditors.LabelControl();
            this.txtLblConceptos = new UsuarioControles.TxtLblGeneral();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LblConcepto);
            this.groupControl1.Controls.Add(this.txtLblConceptos);
            this.groupControl1.Location = new System.Drawing.Point(6, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(503, 39);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // LblConcepto
            // 
            this.LblConcepto.Location = new System.Drawing.Point(5, 13);
            this.LblConcepto.Name = "LblConcepto";
            this.LblConcepto.Size = new System.Drawing.Size(46, 13);
            this.LblConcepto.TabIndex = 9;
            this.LblConcepto.Text = "Concepto";
            // 
            // txtLblConceptos
            // 
            this.txtLblConceptos.AutoSize = true;
            this.txtLblConceptos.Codigo = null;
            //this.txtLblConceptos.Complemen = null;
            this.txtLblConceptos.database = null;
            this.txtLblConceptos.Id = "";
            this.txtLblConceptos.LblNomLocation = new System.Drawing.Point(0, 0);
            this.txtLblConceptos.LblNomSize = new System.Drawing.Size(0, 0);
            this.txtLblConceptos.Location = new System.Drawing.Point(57, 6);
            this.txtLblConceptos.Name = "txtLblConceptos";
            this.txtLblConceptos.SoloLectura = false;
            this.txtLblConceptos.Nombre = null;
            this.txtLblConceptos.OcultarBtnAñadir = false;
            this.txtLblConceptos.OcultarBtnEditar = false;
            this.txtLblConceptos.OcultarBtnEliminar = false;
            this.txtLblConceptos.OcultarBtnExcel = false;
            this.txtLblConceptos.OcultarBtnGuardar = false;
            this.txtLblConceptos.OcultarBtnImprimir = false;
            this.txtLblConceptos.PerfilShow = null;
            this.txtLblConceptos.Size = new System.Drawing.Size(342, 26);
            this.txtLblConceptos.TabIndex = 8;
            this.txtLblConceptos.TxtCodLocation = new System.Drawing.Point(0, 0);
            this.txtLblConceptos.TxtCodSize = new System.Drawing.Size(0, 0);
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.Location = new System.Drawing.Point(171, 51);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 3;
            // 
            // FrmConfigConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 96);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigConcepto";
            this.Text = "Configurar Concepto";
            this.Load += new System.EventHandler(this.FrmConfigConcepto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UsuarioControles.TxtLblGeneral txtLblConceptos;
        private UsuarioControles.AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.LabelControl LblConcepto;
    }
}