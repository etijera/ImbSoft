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
            this.TxtLblCuenta = new UsuarioControles.TxtLblGeneral();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.errorP2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.GbxDatos = new DevExpress.XtraEditors.GroupControl();
            this.TxtPorcentaje = new UsuarioControles.TxtBase();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBase2 = new UsuarioControles.LblBase();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.LblPanel4 = new UsuarioControles.LblBase();
            this.LblNombre = new UsuarioControles.LblBase();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMonto = new UsuarioControles.TxtBase();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).BeginInit();
            this.GbxDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.TxtLblCuenta.Enabled = false;
            this.TxtLblCuenta.Id = "";
            this.TxtLblCuenta.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCuenta.LblNomSize = new System.Drawing.Size(253, 20);
            this.TxtLblCuenta.Location = new System.Drawing.Point(96, 12);
            this.TxtLblCuenta.MaxLenght = 12;
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
            this.TxtLblCuenta.Size = new System.Drawing.Size(362, 26);
            this.TxtLblCuenta.SoloLectura = false;
            this.TxtLblCuenta.TabIndex = 4;
            this.TxtLblCuenta.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCuenta.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblCuenta.Usuario = null;
            this.TxtLblCuenta.Validated += new System.EventHandler(this.TxtLblCuenta_Validated);
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(222, 246);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(227, 75);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Tipo de Retención";
            // 
            // rgTipo
            // 
            this.rgTipo.AutoSizeInLayoutControl = true;
            this.rgTipo.Location = new System.Drawing.Point(1, 2);
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTipo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTipo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.rgTipo.Properties.Appearance.Options.UseBackColor = true;
            this.rgTipo.Properties.Appearance.Options.UseFont = true;
            this.rgTipo.Properties.Appearance.Options.UseForeColor = true;
            this.rgTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Anticipo de Impuestos y Contribuciones"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Retenciones a Cargo")});
            this.rgTipo.Size = new System.Drawing.Size(243, 42);
            this.rgTipo.TabIndex = 59;
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(17, 267);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(117, 49);
            this.acceptCancel1.TabIndex = 8;
            // 
            // errorP2
            // 
            this.errorP2.ContainerControl = this;
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.panel1);
            this.GbxDatos.Location = new System.Drawing.Point(12, 32);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.ShowCaption = false;
            this.GbxDatos.Size = new System.Drawing.Size(569, 198);
            this.GbxDatos.TabIndex = 9;
            this.GbxDatos.Text = "groupControl1";
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Far;
            this.TxtPorcentaje.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtPorcentaje.Appearance.Options.UseBackColor = true;
            this.TxtPorcentaje.CaraterPassword = '\0';
            this.TxtPorcentaje.Location = new System.Drawing.Point(93, 85);
            this.TxtPorcentaje.MaxLenght = 9;
            this.TxtPorcentaje.MTextChanged = null;
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(107, 26);
            this.TxtPorcentaje.SoloLectura = false;
            this.TxtPorcentaje.TabIndex = 10;
            this.TxtPorcentaje.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPorcentaje.Texto = "0,";
            this.TxtPorcentaje.TipoFormato = Referencias.Funciones.TipoNumerico.Porcentaje3;
            this.TxtPorcentaje.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPorcentaje.UseMaskAsDisplayFormat = true;
            this.TxtPorcentaje.Value = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtPorcentaje);
            this.panel1.Controls.Add(this.TxtLblCuenta);
            this.panel1.Controls.Add(this.lblBase2);
            this.panel1.Controls.Add(this.TxtMonto);
            this.panel1.Controls.Add(this.lblBase1);
            this.panel1.Controls.Add(this.LblPanel4);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(25, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 125);
            this.panel1.TabIndex = 3;
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(15, 90);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(80, 14);
            this.lblBase2.TabIndex = 11;
            this.lblBase2.Texto = "Porcentaje:";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(15, 54);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(61, 14);
            this.lblBase1.TabIndex = 10;
            this.lblBase1.Texto = "Monto:";
            // 
            // LblPanel4
            // 
            this.LblPanel4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblPanel4.Appearance.Options.UseBackColor = true;
            this.LblPanel4.AutoSize = true;
            this.LblPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPanel4.Location = new System.Drawing.Point(205, 44);
            this.LblPanel4.Name = "LblPanel4";
            this.LblPanel4.Size = new System.Drawing.Size(123, 16);
            this.LblPanel4.TabIndex = 10;
            this.LblPanel4.Texto = "Tipo de Retención";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(15, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 14);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Texto = "Cuenta:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rgTipo);
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(205, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 49);
            this.panel2.TabIndex = 11;
            // 
            // TxtMonto
            // 
            this.TxtMonto.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Far;
            this.TxtMonto.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtMonto.Appearance.Options.UseBackColor = true;
            this.TxtMonto.CaraterPassword = '\0';
            this.TxtMonto.Location = new System.Drawing.Point(93, 48);
            this.TxtMonto.MaxLenght = 9;
            this.TxtMonto.MTextChanged = null;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(107, 26);
            this.TxtMonto.SoloLectura = false;
            this.TxtMonto.TabIndex = 9;
            this.TxtMonto.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMonto.Texto = "0,";
            this.TxtMonto.TipoFormato = Referencias.Funciones.TipoNumerico.Decimal;
            this.TxtMonto.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtMonto.UseMaskAsDisplayFormat = true;
            this.TxtMonto.Value = "0";
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, -1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Retenciones";
            this.cabeceraForm1.Size = new System.Drawing.Size(555, 32);
            this.cabeceraForm1.TabIndex = 10;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // FrmGetRetenciones
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 333);
            this.Controls.Add(this.cabeceraForm1);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GbxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetRetenciones";
            this.Text = "FrmRetenciones";
            this.Load += new System.EventHandler(this.FrmGetRetenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).EndInit();
            this.GbxDatos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TxtLblGeneral TxtLblCuenta;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorP2;
        private DevExpress.XtraEditors.GroupControl GbxDatos;
        private TxtBase TxtMonto;
        private LblBase LblNombre;
        private System.Windows.Forms.Panel panel1;
        private LblBase LblPanel4;
        private CabeceraForm cabeceraForm1;
        private TxtBase TxtPorcentaje;
        private LblBase lblBase2;
        private LblBase lblBase1;
        private System.Windows.Forms.Panel panel2;
    }
}