using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetConceptoNomina
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblCuenta = new UsuarioControles.TxtLblGeneral();
            this.TxtConcepto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new DevExpress.XtraEditors.GroupControl();
            this.rgAplicar = new DevExpress.XtraEditors.RadioGroup();
            this.panel3 = new DevExpress.XtraEditors.GroupControl();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.panel4 = new DevExpress.XtraEditors.GroupControl();
            this.TxtPorcentajeGravable = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ChkVacaciones = new DevExpress.XtraEditors.CheckEdit();
            this.ChkRetenciones = new DevExpress.XtraEditors.CheckEdit();
            this.ChkPrimasCesantias = new DevExpress.XtraEditors.CheckEdit();
            this.ChkARLParafiscales = new DevExpress.XtraEditors.CheckEdit();
            this.ChkSeguridadSocial = new DevExpress.XtraEditors.CheckEdit();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.errorP3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgAplicar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentajeGravable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRetenciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkPrimasCesantias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkARLParafiscales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkSeguridadSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.TxtLblCuenta);
            this.panel1.Controls.Add(this.TxtConcepto);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 69);
            this.panel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Cuenta:";
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
            this.TxtLblCuenta.DesHabilitarTodo = false;
            this.TxtLblCuenta.Id = "";
            this.TxtLblCuenta.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCuenta.LblNomSize = new System.Drawing.Size(260, 20);
            this.TxtLblCuenta.Location = new System.Drawing.Point(81, 35);
            this.TxtLblCuenta.MaxLenght = 0;
            this.TxtLblCuenta.Modo = null;
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
            this.TxtLblCuenta.Ordenar = Referencias.OrdenarPor.CampoNombre;
            this.TxtLblCuenta.PasarUsuario = false;
            this.TxtLblCuenta.PerfilShow = null;
            this.TxtLblCuenta.PonerCeros = false;
            this.TxtLblCuenta.Relacion = null;
            this.TxtLblCuenta.SinBordes = false;
            this.TxtLblCuenta.Size = new System.Drawing.Size(369, 26);
            this.TxtLblCuenta.SoloLectura = false;
            this.TxtLblCuenta.TabIndex = 13;
            this.TxtLblCuenta.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCuenta.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblCuenta.Usuario = null;
            this.TxtLblCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCuenta_Validating);
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.EnterMoveNextControl = true;
            this.TxtConcepto.Location = new System.Drawing.Point(81, 11);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtConcepto.Properties.MaxLength = 100;
            this.TxtConcepto.Size = new System.Drawing.Size(362, 18);
            this.TxtConcepto.TabIndex = 1;
            this.TxtConcepto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtConcepto_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Concepto:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rgAplicar);
            this.panel2.Location = new System.Drawing.Point(13, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "Aplicar por";
            // 
            // rgAplicar
            // 
            this.rgAplicar.AutoSizeInLayoutControl = true;
            this.rgAplicar.Location = new System.Drawing.Point(17, 25);
            this.rgAplicar.Name = "rgAplicar";
            this.rgAplicar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgAplicar.Properties.Appearance.Options.UseBackColor = true;
            this.rgAplicar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgAplicar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Horas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Días"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cuotas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Monto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Porcentaje")});
            this.rgAplicar.Size = new System.Drawing.Size(436, 25);
            this.rgAplicar.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rgTipo);
            this.panel3.Location = new System.Drawing.Point(12, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 115);
            this.panel3.TabIndex = 2;
            this.panel3.Text = "Tipo";
            // 
            // rgTipo
            // 
            this.rgTipo.AutoSizeInLayoutControl = true;
            this.rgTipo.Location = new System.Drawing.Point(10, 18);
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTipo.Properties.Appearance.Options.UseBackColor = true;
            this.rgTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Devengado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Deducido")});
            this.rgTipo.Size = new System.Drawing.Size(93, 92);
            this.rgTipo.TabIndex = 59;
            this.rgTipo.SelectedIndexChanged += new System.EventHandler(this.rgTipo_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtPorcentajeGravable);
            this.panel4.Controls.Add(this.labelControl3);
            this.panel4.Controls.Add(this.ChkVacaciones);
            this.panel4.Controls.Add(this.ChkRetenciones);
            this.panel4.Controls.Add(this.ChkPrimasCesantias);
            this.panel4.Controls.Add(this.ChkARLParafiscales);
            this.panel4.Controls.Add(this.ChkSeguridadSocial);
            this.panel4.Location = new System.Drawing.Point(122, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 115);
            this.panel4.TabIndex = 3;
            this.panel4.Text = "Base para la Liquidación de";
            // 
            // TxtPorcentajeGravable
            // 
            this.TxtPorcentajeGravable.Enabled = false;
            this.TxtPorcentajeGravable.EnterMoveNextControl = true;
            this.TxtPorcentajeGravable.Location = new System.Drawing.Point(267, 85);
            this.TxtPorcentajeGravable.Name = "TxtPorcentajeGravable";
            this.TxtPorcentajeGravable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtPorcentajeGravable.Properties.Mask.EditMask = "P";
            this.TxtPorcentajeGravable.Properties.Mask.IgnoreMaskBlank = false;
            this.TxtPorcentajeGravable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPorcentajeGravable.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtPorcentajeGravable.Size = new System.Drawing.Size(76, 18);
            this.TxtPorcentajeGravable.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(159, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Porcentaje Gravable:";
            // 
            // ChkVacaciones
            // 
            this.ChkVacaciones.Enabled = false;
            this.ChkVacaciones.EnterMoveNextControl = true;
            this.ChkVacaciones.Location = new System.Drawing.Point(18, 85);
            this.ChkVacaciones.Name = "ChkVacaciones";
            this.ChkVacaciones.Properties.Caption = "Vacaciones";
            this.ChkVacaciones.Size = new System.Drawing.Size(84, 19);
            this.ChkVacaciones.TabIndex = 21;
            // 
            // ChkRetenciones
            // 
            this.ChkRetenciones.EnterMoveNextControl = true;
            this.ChkRetenciones.Location = new System.Drawing.Point(157, 60);
            this.ChkRetenciones.Name = "ChkRetenciones";
            this.ChkRetenciones.Properties.Caption = "Retenciones";
            this.ChkRetenciones.Size = new System.Drawing.Size(90, 19);
            this.ChkRetenciones.TabIndex = 20;
            this.ChkRetenciones.CheckedChanged += new System.EventHandler(this.ChkRetenciones_CheckedChanged);
            // 
            // ChkPrimasCesantias
            // 
            this.ChkPrimasCesantias.EnterMoveNextControl = true;
            this.ChkPrimasCesantias.Location = new System.Drawing.Point(157, 35);
            this.ChkPrimasCesantias.Name = "ChkPrimasCesantias";
            this.ChkPrimasCesantias.Properties.Caption = "Primas, Cesantías / Int. Cesantías";
            this.ChkPrimasCesantias.Size = new System.Drawing.Size(186, 19);
            this.ChkPrimasCesantias.TabIndex = 19;
            // 
            // ChkARLParafiscales
            // 
            this.ChkARLParafiscales.EnterMoveNextControl = true;
            this.ChkARLParafiscales.Location = new System.Drawing.Point(18, 60);
            this.ChkARLParafiscales.Name = "ChkARLParafiscales";
            this.ChkARLParafiscales.Properties.Caption = "ARL y Parafiscales";
            this.ChkARLParafiscales.Size = new System.Drawing.Size(110, 19);
            this.ChkARLParafiscales.TabIndex = 18;
            // 
            // ChkSeguridadSocial
            // 
            this.ChkSeguridadSocial.EnterMoveNextControl = true;
            this.ChkSeguridadSocial.Location = new System.Drawing.Point(18, 35);
            this.ChkSeguridadSocial.Name = "ChkSeguridadSocial";
            this.ChkSeguridadSocial.Properties.Caption = "Seguridad Social";
            this.ChkSeguridadSocial.Size = new System.Drawing.Size(110, 19);
            this.ChkSeguridadSocial.TabIndex = 17;
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(185, 275);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(125, 38);
            this.acceptCancel1.TabIndex = 4;
            // 
            // errorP3
            // 
            this.errorP3.ContainerControl = this;
            // 
            // FrmGetConceptoNomina
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 319);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetConceptoNomina";
            this.Text = "Concepto de Nómina";
            this.Load += new System.EventHandler(this.GetConceptoNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgAplicar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentajeGravable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRetenciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkPrimasCesantias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkARLParafiscales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkSeguridadSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.TextEdit TxtConcepto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private TxtLblGeneral TxtLblCuenta;
        private DevExpress.XtraEditors.GroupControl panel2;
        private DevExpress.XtraEditors.GroupControl panel3;
        private DevExpress.XtraEditors.GroupControl panel4;
        private DevExpress.XtraEditors.TextEdit TxtPorcentajeGravable;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ChkVacaciones;
        private DevExpress.XtraEditors.CheckEdit ChkRetenciones;
        private DevExpress.XtraEditors.CheckEdit ChkPrimasCesantias;
        private DevExpress.XtraEditors.CheckEdit ChkARLParafiscales;
        private DevExpress.XtraEditors.CheckEdit ChkSeguridadSocial;
        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.RadioGroup rgAplicar;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private System.Windows.Forms.ErrorProvider errorP3;
    }
}