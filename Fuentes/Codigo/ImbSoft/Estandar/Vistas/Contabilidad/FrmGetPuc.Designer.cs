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
            this.BtnPuc = new DevExpress.XtraEditors.SimpleButton();
            this.ChkTerceros = new DevExpress.XtraEditors.CheckEdit();
            this.ChkCentroCosto = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.GctrlTiposCuentas = new DevExpress.XtraGrid.GridControl();
            this.DgvTiposCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtNombreCuenta = new UsuarioControles.TxtBase();
            this.TxtCodigoCuenta = new UsuarioControles.TxtBase();
            this.CmbTipoCueta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LblCodigoCuenta = new UsuarioControles.LblBase();
            this.LblTipoCuenta = new UsuarioControles.LblBase();
            this.LblNombreCuenta = new UsuarioControles.LblBase();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPanel4 = new UsuarioControles.LblBase();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkTerceros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GctrlTiposCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoCueta.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPuc
            // 
            this.BtnPuc.Location = new System.Drawing.Point(249, 62);
            this.BtnPuc.LookAndFeel.SkinName = "Office 2010 Blue";
            this.BtnPuc.Name = "BtnPuc";
            this.BtnPuc.Size = new System.Drawing.Size(19, 20);
            this.BtnPuc.TabIndex = 4;
            this.BtnPuc.Text = "...";
            this.BtnPuc.Click += new System.EventHandler(this.BtnPuc_Click);
            // 
            // ChkTerceros
            // 
            this.ChkTerceros.Enabled = false;
            this.ChkTerceros.EnterMoveNextControl = true;
            this.ChkTerceros.Location = new System.Drawing.Point(140, 20);
            this.ChkTerceros.Name = "ChkTerceros";
            this.ChkTerceros.Properties.Caption = "Terceros";
            this.ChkTerceros.Size = new System.Drawing.Size(80, 19);
            this.ChkTerceros.TabIndex = 1;
            // 
            // ChkCentroCosto
            // 
            this.ChkCentroCosto.Enabled = false;
            this.ChkCentroCosto.EnterMoveNextControl = true;
            this.ChkCentroCosto.Location = new System.Drawing.Point(9, 20);
            this.ChkCentroCosto.Name = "ChkCentroCosto";
            this.ChkCentroCosto.Properties.Caption = "Centro de Costo";
            this.ChkCentroCosto.Size = new System.Drawing.Size(114, 19);
            this.ChkCentroCosto.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.GctrlTiposCuentas);
            this.groupControl8.Location = new System.Drawing.Point(4, 3);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.ShowCaption = false;
            this.groupControl8.Size = new System.Drawing.Size(412, 262);
            this.groupControl8.TabIndex = 3;
            // 
            // GctrlTiposCuentas
            // 
            this.GctrlTiposCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GctrlTiposCuentas.Location = new System.Drawing.Point(2, 2);
            this.GctrlTiposCuentas.MainView = this.DgvTiposCuentas;
            this.GctrlTiposCuentas.Name = "GctrlTiposCuentas";
            this.GctrlTiposCuentas.Size = new System.Drawing.Size(408, 258);
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
            this.acceptCancel1.Location = new System.Drawing.Point(163, 300);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(110, 46);
            this.acceptCancel1.TabIndex = 5;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, 0);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Plan único de cuentas";
            this.cabeceraForm1.Size = new System.Drawing.Size(439, 32);
            this.cabeceraForm1.TabIndex = 6;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Controls.Add(this.acceptCancel1);
            this.panelControl1.Location = new System.Drawing.Point(2, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 354);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(426, 297);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panel2);
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.Controls.Add(this.LblPanel4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(420, 269);
            this.xtraTabPage1.Text = "General";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtNombreCuenta);
            this.panel2.Controls.Add(this.BtnPuc);
            this.panel2.Controls.Add(this.TxtCodigoCuenta);
            this.panel2.Controls.Add(this.CmbTipoCueta);
            this.panel2.Controls.Add(this.LblCodigoCuenta);
            this.panel2.Controls.Add(this.LblTipoCuenta);
            this.panel2.Controls.Add(this.LblNombreCuenta);
            this.panel2.Location = new System.Drawing.Point(6, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 152);
            this.panel2.TabIndex = 0;
            // 
            // TxtNombreCuenta
            // 
            this.TxtNombreCuenta.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtNombreCuenta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombreCuenta.Appearance.Options.UseBackColor = true;
            this.TxtNombreCuenta.CaraterPassword = '\0';
            this.TxtNombreCuenta.Location = new System.Drawing.Point(126, 100);
            this.TxtNombreCuenta.MaxLenght = 50;
            this.TxtNombreCuenta.MTextChanged = null;
            this.TxtNombreCuenta.Name = "TxtNombreCuenta";
            this.TxtNombreCuenta.Size = new System.Drawing.Size(274, 26);
            this.TxtNombreCuenta.SoloLectura = false;
            this.TxtNombreCuenta.TabIndex = 6;
            this.TxtNombreCuenta.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreCuenta.Texto = "";
            this.TxtNombreCuenta.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtNombreCuenta.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // TxtCodigoCuenta
            // 
            this.TxtCodigoCuenta.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtCodigoCuenta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodigoCuenta.Appearance.Options.UseBackColor = true;
            this.TxtCodigoCuenta.CaraterPassword = '\0';
            this.TxtCodigoCuenta.Location = new System.Drawing.Point(126, 59);
            this.TxtCodigoCuenta.MaxLenght = 50;
            this.TxtCodigoCuenta.MTextChanged = null;
            this.TxtCodigoCuenta.Name = "TxtCodigoCuenta";
            this.TxtCodigoCuenta.Size = new System.Drawing.Size(123, 26);
            this.TxtCodigoCuenta.SoloLectura = false;
            this.TxtCodigoCuenta.TabIndex = 3;
            this.TxtCodigoCuenta.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigoCuenta.Texto = "";
            this.TxtCodigoCuenta.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtCodigoCuenta.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtCodigoCuenta.Validated += new System.EventHandler(this.TxtCodigoCuenta_Validated);
            // 
            // CmbTipoCueta
            // 
            this.CmbTipoCueta.EditValue = "AUXILIAR";
            this.CmbTipoCueta.EnterMoveNextControl = true;
            this.CmbTipoCueta.Location = new System.Drawing.Point(129, 24);
            this.CmbTipoCueta.Name = "CmbTipoCueta";
            this.CmbTipoCueta.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.CmbTipoCueta.Properties.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.CmbTipoCueta.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.CmbTipoCueta.Properties.Appearance.Options.UseBackColor = true;
            this.CmbTipoCueta.Properties.Appearance.Options.UseBorderColor = true;
            this.CmbTipoCueta.Properties.Appearance.Options.UseForeColor = true;
            this.CmbTipoCueta.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmbTipoCueta.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.CmbTipoCueta.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.CmbTipoCueta.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CmbTipoCueta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbTipoCueta.Properties.Items.AddRange(new object[] {
            "AUXILIAR",
            "SUBCUENTA",
            "CUENTAS",
            "GRUPO",
            "CLASE"});
            this.CmbTipoCueta.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.CmbTipoCueta.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CmbTipoCueta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CmbTipoCueta.Size = new System.Drawing.Size(116, 20);
            this.CmbTipoCueta.TabIndex = 1;
            this.CmbTipoCueta.SelectedIndexChanged += new System.EventHandler(this.CmbTipoCueta_SelectedIndexChanged);
            this.CmbTipoCueta.Enter += new System.EventHandler(this.CmbTipoCueta_Enter);
            this.CmbTipoCueta.Leave += new System.EventHandler(this.CmbTipoCueta_Leave);
            // 
            // LblCodigoCuenta
            // 
            this.LblCodigoCuenta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LblCodigoCuenta.Appearance.Options.UseBackColor = true;
            this.LblCodigoCuenta.AutoSize = true;
            this.LblCodigoCuenta.Location = new System.Drawing.Point(6, 66);
            this.LblCodigoCuenta.Name = "LblCodigoCuenta";
            this.LblCodigoCuenta.Size = new System.Drawing.Size(111, 13);
            this.LblCodigoCuenta.TabIndex = 2;
            this.LblCodigoCuenta.Texto = "Código de Cuenta";
            // 
            // LblTipoCuenta
            // 
            this.LblTipoCuenta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LblTipoCuenta.Appearance.Options.UseBackColor = true;
            this.LblTipoCuenta.AutoSize = true;
            this.LblTipoCuenta.Location = new System.Drawing.Point(6, 27);
            this.LblTipoCuenta.Name = "LblTipoCuenta";
            this.LblTipoCuenta.Size = new System.Drawing.Size(97, 13);
            this.LblTipoCuenta.TabIndex = 0;
            this.LblTipoCuenta.Texto = "Tipo de Cuenta";
            // 
            // LblNombreCuenta
            // 
            this.LblNombreCuenta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCuenta.Appearance.Options.UseBackColor = true;
            this.LblNombreCuenta.AutoSize = true;
            this.LblNombreCuenta.Location = new System.Drawing.Point(6, 107);
            this.LblNombreCuenta.Name = "LblNombreCuenta";
            this.LblNombreCuenta.Size = new System.Drawing.Size(97, 13);
            this.LblNombreCuenta.TabIndex = 5;
            this.LblNombreCuenta.Texto = "Nombre Cuenta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChkTerceros);
            this.panel1.Controls.Add(this.ChkCentroCosto);
            this.panel1.Location = new System.Drawing.Point(6, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 61);
            this.panel1.TabIndex = 2;
            // 
            // LblPanel4
            // 
            this.LblPanel4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblPanel4.Appearance.Options.UseBackColor = true;
            this.LblPanel4.AutoSize = true;
            this.LblPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPanel4.Location = new System.Drawing.Point(6, 178);
            this.LblPanel4.Name = "LblPanel4";
            this.LblPanel4.Size = new System.Drawing.Size(108, 16);
            this.LblPanel4.TabIndex = 1;
            this.LblPanel4.Texto = "Requerimientos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl8);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(420, 269);
            this.xtraTabPage2.Text = "Tipos de cuenta";
            // 
            // FrmGetPuc
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 385);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetPuc";
            this.Text = "PUC";
            this.Load += new System.EventHandler(this.FrmGetPuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkTerceros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GctrlTiposCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoCueta.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private UsuarioControles.LblBase LblCodigoCuenta;
        private UsuarioControles.LblBase LblTipoCuenta;
        private UsuarioControles.LblBase LblNombreCuenta;
        private DevExpress.XtraEditors.ComboBoxEdit CmbTipoCueta;
        private UsuarioControles.TxtBase TxtCodigoCuenta;
        private UsuarioControles.TxtBase TxtNombreCuenta;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}