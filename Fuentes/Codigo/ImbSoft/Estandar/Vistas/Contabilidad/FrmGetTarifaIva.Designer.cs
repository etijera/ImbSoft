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
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTarifa = new UsuarioControles.TxtBase();
            this.RgbModalidad = new DevExpress.XtraEditors.RadioGroup();
            this.lblBase3 = new UsuarioControles.LblBase();
            this.lblBase2 = new UsuarioControles.LblBase();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.RgbTipo = new DevExpress.XtraEditors.RadioGroup();
            this.TxtLblCodigo = new UsuarioControles.TxtLblGeneral();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbModalidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbTipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(253, 160);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(111, 51);
            this.acceptCancel1.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Controls.Add(this.acceptCancel1);
            this.groupControl1.Location = new System.Drawing.Point(2, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(616, 216);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtTarifa);
            this.panel2.Controls.Add(this.RgbModalidad);
            this.panel2.Controls.Add(this.lblBase3);
            this.panel2.Controls.Add(this.lblBase2);
            this.panel2.Controls.Add(this.lblBase1);
            this.panel2.Controls.Add(this.RgbTipo);
            this.panel2.Controls.Add(this.TxtLblCodigo);
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(20, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 129);
            this.panel2.TabIndex = 0;
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTarifa.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtTarifa.Appearance.Options.UseBackColor = true;
            this.TxtTarifa.CaraterPassword = '\0';
            this.TxtTarifa.Location = new System.Drawing.Point(73, 84);
            this.TxtTarifa.MaxLenght = 50;
            this.TxtTarifa.MSpin = null;
            this.TxtTarifa.MTextChanged = null;
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(107, 26);
            this.TxtTarifa.SoloLectura = false;
            this.TxtTarifa.TabIndex = 2;
            this.TxtTarifa.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTarifa.Texto = "0";
            this.TxtTarifa.TipoFormato = Referencias.Funciones.TipoNumerico.Porcentaje2;
            this.TxtTarifa.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtTarifa.UseMaskAsDisplayFormat = false;
            this.TxtTarifa.Value = "0";
            // 
            // RgbModalidad
            // 
            this.RgbModalidad.AutoSizeInLayoutControl = true;
            this.RgbModalidad.EnterMoveNextControl = true;
            this.RgbModalidad.Location = new System.Drawing.Point(182, 84);
            this.RgbModalidad.Name = "RgbModalidad";
            this.RgbModalidad.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RgbModalidad.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.RgbModalidad.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.RgbModalidad.Properties.Appearance.Options.UseBackColor = true;
            this.RgbModalidad.Properties.Appearance.Options.UseBorderColor = true;
            this.RgbModalidad.Properties.Appearance.Options.UseForeColor = true;
            this.RgbModalidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.RgbModalidad.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Bienes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Servicios")});
            this.RgbModalidad.Size = new System.Drawing.Size(376, 26);
            this.RgbModalidad.TabIndex = 3;
            // 
            // lblBase3
            // 
            this.lblBase3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase3.Appearance.Options.UseBackColor = true;
            this.lblBase3.AutoSize = true;
            this.lblBase3.Location = new System.Drawing.Point(13, 90);
            this.lblBase3.Name = "lblBase3";
            this.lblBase3.Size = new System.Drawing.Size(57, 14);
            this.lblBase3.TabIndex = 2;
            this.lblBase3.Texto = "Tarifa:";
            // 
            // lblBase2
            // 
            this.lblBase2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase2.Appearance.Options.UseBackColor = true;
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(13, 56);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(57, 14);
            this.lblBase2.TabIndex = 1;
            this.lblBase2.Texto = "Código:";
            // 
            // lblBase1
            // 
            this.lblBase1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase1.Appearance.Options.UseBackColor = true;
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(13, 22);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(46, 14);
            this.lblBase1.TabIndex = 0;
            this.lblBase1.Texto = "Tipo:";
            // 
            // RgbTipo
            // 
            this.RgbTipo.AutoSizeInLayoutControl = true;
            this.RgbTipo.EnterMoveNextControl = true;
            this.RgbTipo.Location = new System.Drawing.Point(77, 16);
            this.RgbTipo.Name = "RgbTipo";
            this.RgbTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RgbTipo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.RgbTipo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.RgbTipo.Properties.Appearance.Options.UseBackColor = true;
            this.RgbTipo.Properties.Appearance.Options.UseBorderColor = true;
            this.RgbTipo.Properties.Appearance.Options.UseForeColor = true;
            this.RgbTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.RgbTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Generado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Descontable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Régimen Simplificado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Transitorio")});
            this.RgbTipo.Size = new System.Drawing.Size(482, 26);
            this.RgbTipo.TabIndex = 0;
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
            this.TxtLblCodigo.LblNomSize = new System.Drawing.Size(376, 20);
            this.TxtLblCodigo.Location = new System.Drawing.Point(76, 50);
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
            this.TxtLblCodigo.Size = new System.Drawing.Size(485, 26);
            this.TxtLblCodigo.SoloLectura = false;
            this.TxtLblCodigo.TabIndex = 1;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 20);
            this.TxtLblCodigo.Usuario = null;
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, -1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Tarifas I.V.A";
            this.cabeceraForm1.Size = new System.Drawing.Size(618, 32);
            this.cabeceraForm1.TabIndex = 1;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // FrmGetTarifaIva
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 247);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetTarifaIva";
            this.Text = "Tarifas I.V.A";
            this.Load += new System.EventHandler(this.FrmGetTarifaIva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbModalidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbTipo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.RadioGroup RgbModalidad;
        private DevExpress.XtraEditors.RadioGroup RgbTipo;
        private System.Windows.Forms.Panel panel2;
        private LblBase lblBase3;
        private LblBase lblBase2;
        private LblBase lblBase1;
        private CabeceraForm cabeceraForm1;
        private TxtBase TxtTarifa;
    }
}