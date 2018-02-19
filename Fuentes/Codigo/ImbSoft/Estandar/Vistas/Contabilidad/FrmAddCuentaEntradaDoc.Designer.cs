using Referencias;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmAddCuentaEntradaDoc
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
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblAuxiliar = new UsuarioControles.TxtLblGeneral();
            this.txtLblOT = new UsuarioControles.TxtLblGeneral();
            this.txtLblTercero = new UsuarioControles.TxtLblGeneral();
            this.txtCredito = new DevExpress.XtraEditors.TextEdit();
            this.TxtDebito = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDebito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(11, 34);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(39, 13);
            this.labelControl27.TabIndex = 0;
            this.labelControl27.Text = "Auxiliar:";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(11, 34);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(29, 13);
            this.labelControl33.TabIndex = 0;
            this.labelControl33.Text = "Debe:";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(11, 60);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(18, 13);
            this.labelControl36.TabIndex = 2;
            this.labelControl36.Text = "OT:";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(11, 88);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(41, 13);
            this.labelControl37.TabIndex = 4;
            this.labelControl37.Text = "Tercero:";
            // 
            // TxtLblAuxiliar
            // 
            this.TxtLblAuxiliar.AutoSize = true;
            this.TxtLblAuxiliar.Codigo = null;
            this.TxtLblAuxiliar.Complemento = null;
            this.TxtLblAuxiliar.database = null;
            this.TxtLblAuxiliar.DesHabilitarBtnAñadir = false;
            this.TxtLblAuxiliar.DesHabilitarBtnEditar = false;
            this.TxtLblAuxiliar.DesHabilitarBtnEliminar = false;
            this.TxtLblAuxiliar.DesHabilitarBtnExcel = false;
            this.TxtLblAuxiliar.DesHabilitarBtnGuardar = false;
            this.TxtLblAuxiliar.DesHabilitarBtnImprimir = false;
            this.TxtLblAuxiliar.DesHabilitarTodo = false;
            this.TxtLblAuxiliar.Id = "";
            this.TxtLblAuxiliar.LblNomLocation = new System.Drawing.Point(105, 2);
            this.TxtLblAuxiliar.LblNomSize = new System.Drawing.Size(340, 20);
            this.TxtLblAuxiliar.Location = new System.Drawing.Point(85, 25);
            this.TxtLblAuxiliar.MaxLenght = 12;
            this.TxtLblAuxiliar.Modo = null;
            this.TxtLblAuxiliar.Name = "TxtLblAuxiliar";
            this.TxtLblAuxiliar.NexControl = false;
            this.TxtLblAuxiliar.Nombre = null;
            this.TxtLblAuxiliar.OcultarBtnAñadir = false;
            this.TxtLblAuxiliar.OcultarBtnEditar = false;
            this.TxtLblAuxiliar.OcultarBtnEliminar = false;
            this.TxtLblAuxiliar.OcultarBtnExcel = false;
            this.TxtLblAuxiliar.OcultarBtnGuardar = false;
            this.TxtLblAuxiliar.OcultarBtnImprimir = false;
            this.TxtLblAuxiliar.OpcionGet = null;
            this.TxtLblAuxiliar.OpGet = false;
            this.TxtLblAuxiliar.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblAuxiliar.PasarUsuario = false;
            this.TxtLblAuxiliar.PerfilShow = null;
            this.TxtLblAuxiliar.PonerCeros = false;
            this.TxtLblAuxiliar.Relacion = null;
            this.TxtLblAuxiliar.SinBordes = false;
            this.TxtLblAuxiliar.Size = new System.Drawing.Size(452, 26);
            this.TxtLblAuxiliar.SoloLectura = false;
            this.TxtLblAuxiliar.TabIndex = 1;
            this.TxtLblAuxiliar.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblAuxiliar.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblAuxiliar.Usuario = null;
            this.TxtLblAuxiliar.Validated += new System.EventHandler(this.TxtLblAuxiliar_Validated);
            // 
            // txtLblOT
            // 
            this.txtLblOT.AutoSize = true;
            this.txtLblOT.Codigo = null;
            this.txtLblOT.Complemento = null;
            this.txtLblOT.database = null;
            this.txtLblOT.DesHabilitarBtnAñadir = false;
            this.txtLblOT.DesHabilitarBtnEditar = false;
            this.txtLblOT.DesHabilitarBtnEliminar = false;
            this.txtLblOT.DesHabilitarBtnExcel = false;
            this.txtLblOT.DesHabilitarBtnGuardar = false;
            this.txtLblOT.DesHabilitarBtnImprimir = false;
            this.txtLblOT.DesHabilitarTodo = false;
            this.txtLblOT.Id = "";
            this.txtLblOT.LblNomLocation = new System.Drawing.Point(106, 2);
            this.txtLblOT.LblNomSize = new System.Drawing.Size(340, 20);
            this.txtLblOT.Location = new System.Drawing.Point(85, 53);
            this.txtLblOT.MaxLenght = 12;
            this.txtLblOT.Modo = null;
            this.txtLblOT.Name = "txtLblOT";
            this.txtLblOT.NexControl = false;
            this.txtLblOT.Nombre = null;
            this.txtLblOT.OcultarBtnAñadir = false;
            this.txtLblOT.OcultarBtnEditar = false;
            this.txtLblOT.OcultarBtnEliminar = false;
            this.txtLblOT.OcultarBtnExcel = false;
            this.txtLblOT.OcultarBtnGuardar = false;
            this.txtLblOT.OcultarBtnImprimir = false;
            this.txtLblOT.OpcionGet = null;
            this.txtLblOT.OpGet = false;
            this.txtLblOT.Ordenar = OrdenarPor.CampoNombre;
            this.txtLblOT.PasarUsuario = false;
            this.txtLblOT.PerfilShow = null;
            this.txtLblOT.PonerCeros = false;
            this.txtLblOT.Relacion = null;
            this.txtLblOT.SinBordes = false;
            this.txtLblOT.Size = new System.Drawing.Size(452, 26);
            this.txtLblOT.SoloLectura = false;
            this.txtLblOT.TabIndex = 3;
            this.txtLblOT.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.txtLblOT.TxtCodSize = new System.Drawing.Size(100, 18);
            this.txtLblOT.Usuario = null;
            this.txtLblOT.Validated += new System.EventHandler(this.txtLblOT_Validated);
            // 
            // txtLblTercero
            // 
            this.txtLblTercero.AutoSize = true;
            this.txtLblTercero.Codigo = null;
            this.txtLblTercero.Complemento = null;
            this.txtLblTercero.database = null;
            this.txtLblTercero.DesHabilitarBtnAñadir = false;
            this.txtLblTercero.DesHabilitarBtnEditar = false;
            this.txtLblTercero.DesHabilitarBtnEliminar = false;
            this.txtLblTercero.DesHabilitarBtnExcel = false;
            this.txtLblTercero.DesHabilitarBtnGuardar = false;
            this.txtLblTercero.DesHabilitarBtnImprimir = false;
            this.txtLblTercero.DesHabilitarTodo = false;
            this.txtLblTercero.Id = "";
            this.txtLblTercero.LblNomLocation = new System.Drawing.Point(106, 2);
            this.txtLblTercero.LblNomSize = new System.Drawing.Size(340, 20);
            this.txtLblTercero.Location = new System.Drawing.Point(85, 81);
            this.txtLblTercero.MaxLenght = 12;
            this.txtLblTercero.Modo = null;
            this.txtLblTercero.Name = "txtLblTercero";
            this.txtLblTercero.NexControl = false;
            this.txtLblTercero.Nombre = null;
            this.txtLblTercero.OcultarBtnAñadir = false;
            this.txtLblTercero.OcultarBtnEditar = false;
            this.txtLblTercero.OcultarBtnEliminar = false;
            this.txtLblTercero.OcultarBtnExcel = false;
            this.txtLblTercero.OcultarBtnGuardar = false;
            this.txtLblTercero.OcultarBtnImprimir = false;
            this.txtLblTercero.OpcionGet = null;
            this.txtLblTercero.OpGet = false;
            this.txtLblTercero.Ordenar = OrdenarPor.CampoNombre;
            this.txtLblTercero.PasarUsuario = false;
            this.txtLblTercero.PerfilShow = null;
            this.txtLblTercero.PonerCeros = false;
            this.txtLblTercero.Relacion = null;
            this.txtLblTercero.SinBordes = false;
            this.txtLblTercero.Size = new System.Drawing.Size(452, 26);
            this.txtLblTercero.SoloLectura = false;
            this.txtLblTercero.TabIndex = 5;
            this.txtLblTercero.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.txtLblTercero.TxtCodSize = new System.Drawing.Size(100, 18);
            this.txtLblTercero.Usuario = null;
            // 
            // txtCredito
            // 
            this.txtCredito.EnterMoveNextControl = true;
            this.txtCredito.Location = new System.Drawing.Point(88, 55);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCredito.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtCredito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCredito.Properties.Mask.EditMask = "n2";
            this.txtCredito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCredito.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCredito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCredito.Size = new System.Drawing.Size(122, 18);
            this.txtCredito.TabIndex = 3;
            // 
            // TxtDebito
            // 
            this.TxtDebito.EnterMoveNextControl = true;
            this.TxtDebito.Location = new System.Drawing.Point(89, 30);
            this.TxtDebito.Name = "TxtDebito";
            this.TxtDebito.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtDebito.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.TxtDebito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtDebito.Properties.Mask.EditMask = "n2";
            this.TxtDebito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtDebito.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtDebito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDebito.Size = new System.Drawing.Size(121, 18);
            this.TxtDebito.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Haber:";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(197, 227);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Aceptar";
            this.acceptCancel1.Mcancelar = "Cancelar";
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtDebito);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl33);
            this.groupControl1.Controls.Add(this.txtCredito);
            this.groupControl1.Location = new System.Drawing.Point(14, 134);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(542, 86);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ingresar Valor...";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtLblAuxiliar);
            this.groupControl2.Controls.Add(this.txtLblTercero);
            this.groupControl2.Controls.Add(this.labelControl27);
            this.groupControl2.Controls.Add(this.labelControl36);
            this.groupControl2.Controls.Add(this.txtLblOT);
            this.groupControl2.Controls.Add(this.labelControl37);
            this.groupControl2.Location = new System.Drawing.Point(14, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(542, 116);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Ingresar Cuenta...";
            // 
            // FrmAddCuentaEntradaDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 270);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.acceptCancel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddCuentaEntradaDoc";
            this.Text = "Adicionar Cuenta";
            this.Load += new System.EventHandler(this.FrmAddCuentaEntradaDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDebito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private UsuarioControles.TxtLblGeneral TxtLblAuxiliar;
        private UsuarioControles.TxtLblGeneral txtLblOT;
        private UsuarioControles.TxtLblGeneral txtLblTercero;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UsuarioControles.AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.TextEdit TxtDebito;
        private DevExpress.XtraEditors.TextEdit txtCredito;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;

    }
}