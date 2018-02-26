using Referencias;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetPuc
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
            this.LblTipoCuenta = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnPuc = new DevExpress.XtraEditors.SimpleButton();
            this.LblNombreCuenta = new DevExpress.XtraEditors.LabelControl();
            this.TxtNombreCuenta = new DevExpress.XtraEditors.TextEdit();
            this.LblCodigoCuenta = new DevExpress.XtraEditors.LabelControl();
            this.TxtCodigoCuenta = new DevExpress.XtraEditors.TextEdit();
            this.CmbTipoCueta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LblCodigoDian = new DevExpress.XtraEditors.LabelControl();
            this.TxtCodigoDian = new DevExpress.XtraEditors.TextEdit();
            this.LblFormatoVersion = new DevExpress.XtraEditors.LabelControl();
            this.TxtFormatoVersion = new DevExpress.XtraEditors.TextEdit();
            this.TxtLblClasificacion = new UsuarioControles.TxtLblGeneral();
            this.ChkTerceros = new DevExpress.XtraEditors.CheckEdit();
            this.ChkCentroCosto = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.GctrlTiposCuentas = new DevExpress.XtraGrid.GridControl();
            this.DgvTiposCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.LblPanel4 = new UsuarioControles.LblBase();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoCueta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoDian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormatoVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkTerceros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GctrlTiposCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTipoCuenta
            // 
            this.LblTipoCuenta.Location = new System.Drawing.Point(14, 16);
            this.LblTipoCuenta.Name = "LblTipoCuenta";
            this.LblTipoCuenta.Size = new System.Drawing.Size(73, 13);
            this.LblTipoCuenta.TabIndex = 0;
            this.LblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnPuc);
            this.groupControl1.Controls.Add(this.LblNombreCuenta);
            this.groupControl1.Controls.Add(this.TxtNombreCuenta);
            this.groupControl1.Controls.Add(this.LblCodigoCuenta);
            this.groupControl1.Controls.Add(this.TxtCodigoCuenta);
            this.groupControl1.Controls.Add(this.CmbTipoCueta);
            this.groupControl1.Controls.Add(this.LblTipoCuenta);
            this.groupControl1.Location = new System.Drawing.Point(19, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(412, 98);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // BtnPuc
            // 
            this.BtnPuc.Location = new System.Drawing.Point(217, 39);
            this.BtnPuc.Name = "BtnPuc";
            this.BtnPuc.Size = new System.Drawing.Size(19, 20);
            this.BtnPuc.TabIndex = 6;
            this.BtnPuc.Text = "...";
            this.BtnPuc.Click += new System.EventHandler(this.BtnPuc_Click);
            // 
            // LblNombreCuenta
            // 
            this.LblNombreCuenta.Location = new System.Drawing.Point(14, 68);
            this.LblNombreCuenta.Name = "LblNombreCuenta";
            this.LblNombreCuenta.Size = new System.Drawing.Size(75, 13);
            this.LblNombreCuenta.TabIndex = 4;
            this.LblNombreCuenta.Text = "Nombre Cuenta";
            // 
            // TxtNombreCuenta
            // 
            this.TxtNombreCuenta.EnterMoveNextControl = true;
            this.TxtNombreCuenta.Location = new System.Drawing.Point(95, 65);
            this.TxtNombreCuenta.Name = "TxtNombreCuenta";
            this.TxtNombreCuenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtNombreCuenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreCuenta.Properties.MaxLength = 50;
            this.TxtNombreCuenta.Size = new System.Drawing.Size(306, 18);
            this.TxtNombreCuenta.TabIndex = 5;
            this.TxtNombreCuenta.EditValueChanged += new System.EventHandler(this.TxtNombreCuenta_EditValueChanged);
            // 
            // LblCodigoCuenta
            // 
            this.LblCodigoCuenta.Location = new System.Drawing.Point(14, 42);
            this.LblCodigoCuenta.Name = "LblCodigoCuenta";
            this.LblCodigoCuenta.Size = new System.Drawing.Size(73, 13);
            this.LblCodigoCuenta.TabIndex = 2;
            this.LblCodigoCuenta.Text = "Tipo de Cuenta";
            // 
            // TxtCodigoCuenta
            // 
            this.TxtCodigoCuenta.EnterMoveNextControl = true;
            this.TxtCodigoCuenta.Location = new System.Drawing.Point(95, 39);
            this.TxtCodigoCuenta.Name = "TxtCodigoCuenta";
            this.TxtCodigoCuenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtCodigoCuenta.Properties.MaxLength = 12;
            this.TxtCodigoCuenta.Size = new System.Drawing.Size(116, 18);
            this.TxtCodigoCuenta.TabIndex = 3;
            this.TxtCodigoCuenta.EditValueChanged += new System.EventHandler(this.TxtCodigoCuenta_EditValueChanged);
            this.TxtCodigoCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoCuenta_Validating);
            this.TxtCodigoCuenta.Validated += new System.EventHandler(this.TxtCodigoCuenta_Validated);
            // 
            // CmbTipoCueta
            // 
            this.CmbTipoCueta.EditValue = "AUXILIAR";
            this.CmbTipoCueta.EnterMoveNextControl = true;
            this.CmbTipoCueta.Location = new System.Drawing.Point(95, 13);
            this.CmbTipoCueta.Name = "CmbTipoCueta";
            this.CmbTipoCueta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CmbTipoCueta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbTipoCueta.Properties.Items.AddRange(new object[] {
            "AUXILIAR",
            "SUBCUENTA",
            "CUENTAS",
            "GRUPO",
            "CLASE"});
            this.CmbTipoCueta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CmbTipoCueta.Size = new System.Drawing.Size(116, 18);
            this.CmbTipoCueta.TabIndex = 1;
            this.CmbTipoCueta.SelectedIndexChanged += new System.EventHandler(this.CmbDestinadoA_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.LblCodigoDian);
            this.groupControl2.Controls.Add(this.TxtCodigoDian);
            this.groupControl2.Controls.Add(this.LblFormatoVersion);
            this.groupControl2.Controls.Add(this.TxtFormatoVersion);
            this.groupControl2.Location = new System.Drawing.Point(19, 119);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(412, 70);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Información Exogena";
            // 
            // LblCodigoDian
            // 
            this.LblCodigoDian.Location = new System.Drawing.Point(218, 40);
            this.LblCodigoDian.Name = "LblCodigoDian";
            this.LblCodigoDian.Size = new System.Drawing.Size(61, 13);
            this.LblCodigoDian.TabIndex = 2;
            this.LblCodigoDian.Text = "Código DIAN";
            // 
            // TxtCodigoDian
            // 
            this.TxtCodigoDian.EnterMoveNextControl = true;
            this.TxtCodigoDian.Location = new System.Drawing.Point(285, 37);
            this.TxtCodigoDian.Name = "TxtCodigoDian";
            this.TxtCodigoDian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtCodigoDian.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigoDian.Properties.MaxLength = 10;
            this.TxtCodigoDian.Size = new System.Drawing.Size(116, 18);
            this.TxtCodigoDian.TabIndex = 3;
            // 
            // LblFormatoVersion
            // 
            this.LblFormatoVersion.Location = new System.Drawing.Point(14, 40);
            this.LblFormatoVersion.Name = "LblFormatoVersion";
            this.LblFormatoVersion.Size = new System.Drawing.Size(78, 13);
            this.LblFormatoVersion.TabIndex = 0;
            this.LblFormatoVersion.Text = "Formato Versión\r\n";
            // 
            // TxtFormatoVersion
            // 
            this.TxtFormatoVersion.EnterMoveNextControl = true;
            this.TxtFormatoVersion.Location = new System.Drawing.Point(95, 37);
            this.TxtFormatoVersion.Name = "TxtFormatoVersion";
            this.TxtFormatoVersion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtFormatoVersion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFormatoVersion.Properties.MaxLength = 10;
            this.TxtFormatoVersion.Size = new System.Drawing.Size(116, 18);
            this.TxtFormatoVersion.TabIndex = 1;
            this.TxtFormatoVersion.EditValueChanged += new System.EventHandler(this.TxtFormatoVersion_EditValueChanged);
            // 
            // TxtLblClasificacion
            // 
            this.TxtLblClasificacion.AutoSize = true;
            this.TxtLblClasificacion.Codigo = null;
            this.TxtLblClasificacion.Complemento = null;
            this.TxtLblClasificacion.database = null;
            this.TxtLblClasificacion.DesHabilitarBtnAñadir = false;
            this.TxtLblClasificacion.DesHabilitarBtnEditar = false;
            this.TxtLblClasificacion.DesHabilitarBtnEliminar = false;
            this.TxtLblClasificacion.DesHabilitarBtnExcel = false;
            this.TxtLblClasificacion.DesHabilitarBtnGuardar = false;
            this.TxtLblClasificacion.DesHabilitarBtnImprimir = false;
            this.TxtLblClasificacion.DesHabilitarTodo = false;
            this.TxtLblClasificacion.Id = "";
            this.TxtLblClasificacion.LblNomLocation = new System.Drawing.Point(71, 3);
            this.TxtLblClasificacion.LblNomSize = new System.Drawing.Size(234, 20);
            this.TxtLblClasificacion.Location = new System.Drawing.Point(90, 7);
            this.TxtLblClasificacion.MaxLenght = 12;
            this.TxtLblClasificacion.Modo = null;
            this.TxtLblClasificacion.Name = "TxtLblClasificacion";
            this.TxtLblClasificacion.NexControl = false;
            this.TxtLblClasificacion.Nombre = null;
            this.TxtLblClasificacion.OcultarBtnAñadir = false;
            this.TxtLblClasificacion.OcultarBtnEditar = false;
            this.TxtLblClasificacion.OcultarBtnEliminar = false;
            this.TxtLblClasificacion.OcultarBtnExcel = false;
            this.TxtLblClasificacion.OcultarBtnGuardar = false;
            this.TxtLblClasificacion.OcultarBtnImprimir = false;
            this.TxtLblClasificacion.OpcionGet = null;
            this.TxtLblClasificacion.OpGet = false;
            this.TxtLblClasificacion.Ordenar = Referencias.OrdenarPor.CampoNombre;
            this.TxtLblClasificacion.PasarUsuario = false;
            this.TxtLblClasificacion.PerfilShow = null;
            this.TxtLblClasificacion.PonerCeros = false;
            this.TxtLblClasificacion.Relacion = null;
            this.TxtLblClasificacion.SinBordes = false;
            this.TxtLblClasificacion.Size = new System.Drawing.Size(308, 26);
            this.TxtLblClasificacion.SoloLectura = false;
            this.TxtLblClasificacion.TabIndex = 1;
            this.TxtLblClasificacion.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblClasificacion.TxtCodSize = new System.Drawing.Size(65, 20);
            this.TxtLblClasificacion.Usuario = null;
            // 
            // ChkTerceros
            // 
            this.ChkTerceros.Enabled = false;
            this.ChkTerceros.EnterMoveNextControl = true;
            this.ChkTerceros.Location = new System.Drawing.Point(140, 9);
            this.ChkTerceros.Name = "ChkTerceros";
            this.ChkTerceros.Properties.Caption = "Terceros";
            this.ChkTerceros.Size = new System.Drawing.Size(80, 19);
            this.ChkTerceros.TabIndex = 1;
            // 
            // ChkCentroCosto
            // 
            this.ChkCentroCosto.Enabled = false;
            this.ChkCentroCosto.EnterMoveNextControl = true;
            this.ChkCentroCosto.Location = new System.Drawing.Point(9, 9);
            this.ChkCentroCosto.Name = "ChkCentroCosto";
            this.ChkCentroCosto.Properties.Caption = "Centro de Costo";
            this.ChkCentroCosto.Size = new System.Drawing.Size(114, 19);
            this.ChkCentroCosto.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.GctrlTiposCuentas);
            this.groupControl8.Location = new System.Drawing.Point(439, 21);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.ShowCaption = false;
            this.groupControl8.Size = new System.Drawing.Size(322, 325);
            this.groupControl8.TabIndex = 4;
            // 
            // GctrlTiposCuentas
            // 
            this.GctrlTiposCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GctrlTiposCuentas.Location = new System.Drawing.Point(2, 2);
            this.GctrlTiposCuentas.MainView = this.DgvTiposCuentas;
            this.GctrlTiposCuentas.Name = "GctrlTiposCuentas";
            this.GctrlTiposCuentas.Size = new System.Drawing.Size(318, 321);
            this.GctrlTiposCuentas.TabIndex = 0;
            this.GctrlTiposCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DgvTiposCuentas});
            // 
            // DgvTiposCuentas
            // 
            this.DgvTiposCuentas.GridControl = this.GctrlTiposCuentas;
            this.DgvTiposCuentas.Name = "DgvTiposCuentas";
            this.DgvTiposCuentas.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.DgvTiposCuentas_ShowingEditor);
            this.DgvTiposCuentas.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.DgvTiposCuentas_CellValueChanging);
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(176, 395);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(110, 47);
            this.acceptCancel1.TabIndex = 5;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, 0);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Titulo";
            this.cabeceraForm1.Size = new System.Drawing.Size(754, 32);
            this.cabeceraForm1.TabIndex = 6;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Controls.Add(this.LblPanel4);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.groupControl8);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Location = new System.Drawing.Point(2, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(777, 351);
            this.panelControl1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBase1);
            this.panel2.Controls.Add(this.TxtLblClasificacion);
            this.panel2.Location = new System.Drawing.Point(19, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 42);
            this.panel2.TabIndex = 10;
            // 
            // lblBase1
            // 
            this.lblBase1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBase1.Appearance.Options.UseBackColor = true;
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(1, 14);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(82, 13);
            this.lblBase1.TabIndex = 10;
            this.lblBase1.Texto = "Clasificación";
            // 
            // LblPanel4
            // 
            this.LblPanel4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblPanel4.Appearance.Options.UseBackColor = true;
            this.LblPanel4.AutoSize = true;
            this.LblPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPanel4.Location = new System.Drawing.Point(19, 238);
            this.LblPanel4.Name = "LblPanel4";
            this.LblPanel4.Size = new System.Drawing.Size(108, 16);
            this.LblPanel4.TabIndex = 9;
            this.LblPanel4.Texto = "Requerimientos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChkTerceros);
            this.panel1.Controls.Add(this.ChkCentroCosto);
            this.panel1.Location = new System.Drawing.Point(19, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 39);
            this.panel1.TabIndex = 8;
            // 
            // FrmGetPuc
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetPuc";
            this.Text = "PUC";
            this.Load += new System.EventHandler(this.FrmGetPuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoCueta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoDian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFormatoVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkTerceros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GctrlTiposCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblTipoCuenta;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LblNombreCuenta;
        private DevExpress.XtraEditors.TextEdit TxtNombreCuenta;
        private DevExpress.XtraEditors.LabelControl LblCodigoCuenta;
        private DevExpress.XtraEditors.TextEdit TxtCodigoCuenta;
        private DevExpress.XtraEditors.ComboBoxEdit CmbTipoCueta;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LblCodigoDian;
        private DevExpress.XtraEditors.TextEdit TxtCodigoDian;
        private DevExpress.XtraEditors.LabelControl LblFormatoVersion;
        private DevExpress.XtraEditors.TextEdit TxtFormatoVersion;
        private UsuarioControles.TxtLblGeneral TxtLblClasificacion;
        private DevExpress.XtraEditors.CheckEdit ChkTerceros;
        private DevExpress.XtraEditors.CheckEdit ChkCentroCosto;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraGrid.GridControl GctrlTiposCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView DgvTiposCuentas;
        private UsuarioControles.AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.SimpleButton BtnPuc;
        private UsuarioControles.CabeceraForm cabeceraForm1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private UsuarioControles.LblBase LblPanel4;
        private System.Windows.Forms.Panel panel2;
        private UsuarioControles.LblBase lblBase1;
    }
}