using Referencias;
using UsuarioControles;
namespace Estandar.Vistas.Contabilidad
{
    partial class FrmGetTipoActivo
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
            this.TxtLblCodigo = new TxtLblGeneral();
            this.LblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.ChkDepreciar = new DevExpress.XtraEditors.CheckEdit();
            this.LblTiempoDepre = new DevExpress.XtraEditors.LabelControl();
            this.TxtTiempoAdicionar = new DevExpress.XtraEditors.SpinEdit();
            this.LblMeses = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtLblDepreAcum = new TxtLblGeneral();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblGastoDepre = new TxtLblGeneral();
            this.LblGastoDepre = new DevExpress.XtraEditors.LabelControl();
            this.acceptCancel1 = new AcceptCancel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.TxtLblCostosIndirectos = new TxtLblGeneral();
            this.LblCostosIndirectos = new DevExpress.XtraEditors.LabelControl();
            this.TxtLblProducotEnP = new TxtLblGeneral();
            this.LblContrapartida = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ChkDepreciar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTiempoAdicionar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
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
            this.TxtLblCodigo.LblNomSize = new System.Drawing.Size(320, 20);
            this.TxtLblCodigo.Location = new System.Drawing.Point(62, 9);
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
            this.TxtLblCodigo.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblCodigo.PasarUsuario = false;
            this.TxtLblCodigo.PerfilShow = null;
            this.TxtLblCodigo.PonerCeros = false;
            this.TxtLblCodigo.Relacion = null;
            this.TxtLblCodigo.SinBordes = false;
            this.TxtLblCodigo.Size = new System.Drawing.Size(429, 26);
            this.TxtLblCodigo.SoloLectura = false;
            this.TxtLblCodigo.TabIndex = 1;
            this.TxtLblCodigo.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCodigo.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCodigo.Usuario = null;
            this.TxtLblCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCodigo_Validating);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Location = new System.Drawing.Point(9, 16);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(33, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // ChkDepreciar
            // 
            this.ChkDepreciar.EnterMoveNextControl = true;
            this.ChkDepreciar.Location = new System.Drawing.Point(9, 37);
            this.ChkDepreciar.Name = "ChkDepreciar";
            this.ChkDepreciar.Properties.Caption = "Para Depreciar";
            this.ChkDepreciar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ChkDepreciar.Size = new System.Drawing.Size(97, 19);
            this.ChkDepreciar.TabIndex = 2;
            this.ChkDepreciar.CheckedChanged += new System.EventHandler(this.ChkDepreciar_CheckedChanged);
            // 
            // LblTiempoDepre
            // 
            this.LblTiempoDepre.Location = new System.Drawing.Point(261, 40);
            this.LblTiempoDepre.Name = "LblTiempoDepre";
            this.LblTiempoDepre.Size = new System.Drawing.Size(113, 13);
            this.LblTiempoDepre.TabIndex = 3;
            this.LblTiempoDepre.Text = "Tiempo de Depreciación";
            // 
            // TxtTiempoAdicionar
            // 
            this.TxtTiempoAdicionar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtTiempoAdicionar.Enabled = false;
            this.TxtTiempoAdicionar.Location = new System.Drawing.Point(380, 37);
            this.TxtTiempoAdicionar.Name = "TxtTiempoAdicionar";
            this.TxtTiempoAdicionar.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTiempoAdicionar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTiempoAdicionar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTiempoAdicionar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtTiempoAdicionar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtTiempoAdicionar.Properties.Mask.EditMask = "n0";
            this.TxtTiempoAdicionar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtTiempoAdicionar.Properties.MaxLength = 3;
            this.TxtTiempoAdicionar.Size = new System.Drawing.Size(57, 18);
            this.TxtTiempoAdicionar.TabIndex = 4;
            this.TxtTiempoAdicionar.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTiempoAdicionar_Validating);
            // 
            // LblMeses
            // 
            this.LblMeses.Location = new System.Drawing.Point(443, 40);
            this.LblMeses.Name = "LblMeses";
            this.LblMeses.Size = new System.Drawing.Size(30, 13);
            this.LblMeses.TabIndex = 5;
            this.LblMeses.Text = "Meses";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LblMeses);
            this.groupControl1.Controls.Add(this.LblTiempoDepre);
            this.groupControl1.Controls.Add(this.ChkDepreciar);
            this.groupControl1.Controls.Add(this.TxtLblCodigo);
            this.groupControl1.Controls.Add(this.LblCodigo);
            this.groupControl1.Controls.Add(this.TxtTiempoAdicionar);
            this.groupControl1.Location = new System.Drawing.Point(15, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(505, 67);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtLblDepreAcum);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.TxtLblGastoDepre);
            this.groupControl2.Controls.Add(this.LblGastoDepre);
            this.groupControl2.Location = new System.Drawing.Point(15, 85);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(505, 100);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Depreciacion del Activo";
            // 
            // TxtLblDepreAcum
            // 
            this.TxtLblDepreAcum.AutoSize = true;
            this.TxtLblDepreAcum.Codigo = null;
            this.TxtLblDepreAcum.Complemento = null;
            this.TxtLblDepreAcum.database = null;
            this.TxtLblDepreAcum.DesHabilitarBtnAñadir = true;
            this.TxtLblDepreAcum.DesHabilitarBtnEditar = true;
            this.TxtLblDepreAcum.DesHabilitarBtnEliminar = true;
            this.TxtLblDepreAcum.DesHabilitarBtnExcel = true;
            this.TxtLblDepreAcum.DesHabilitarBtnGuardar = true;
            this.TxtLblDepreAcum.DesHabilitarBtnImprimir = true;
            this.TxtLblDepreAcum.DesHabilitarTodo = false;
            this.TxtLblDepreAcum.Id = "";
            this.TxtLblDepreAcum.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblDepreAcum.LblNomSize = new System.Drawing.Size(260, 20);
            this.TxtLblDepreAcum.Location = new System.Drawing.Point(122, 59);
            this.TxtLblDepreAcum.MaxLenght = 0;
            this.TxtLblDepreAcum.Modo = null;
            this.TxtLblDepreAcum.Name = "TxtLblDepreAcum";
            this.TxtLblDepreAcum.NexControl = false;
            this.TxtLblDepreAcum.Nombre = null;
            this.TxtLblDepreAcum.OcultarBtnAñadir = false;
            this.TxtLblDepreAcum.OcultarBtnEditar = false;
            this.TxtLblDepreAcum.OcultarBtnEliminar = false;
            this.TxtLblDepreAcum.OcultarBtnExcel = false;
            this.TxtLblDepreAcum.OcultarBtnGuardar = false;
            this.TxtLblDepreAcum.OcultarBtnImprimir = false;
            this.TxtLblDepreAcum.OpcionGet = null;
            this.TxtLblDepreAcum.OpGet = false;
            this.TxtLblDepreAcum.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblDepreAcum.PasarUsuario = false;
            this.TxtLblDepreAcum.PerfilShow = null;
            this.TxtLblDepreAcum.PonerCeros = false;
            this.TxtLblDepreAcum.Relacion = null;
            this.TxtLblDepreAcum.SinBordes = false;
            this.TxtLblDepreAcum.Size = new System.Drawing.Size(369, 26);
            this.TxtLblDepreAcum.SoloLectura = false;
            this.TxtLblDepreAcum.TabIndex = 3;
            this.TxtLblDepreAcum.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblDepreAcum.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblDepreAcum.Usuario = null;
            this.TxtLblDepreAcum.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblDepreAcum_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Depreciación Acum.";
            // 
            // TxtLblGastoDepre
            // 
            this.TxtLblGastoDepre.AutoSize = true;
            this.TxtLblGastoDepre.Codigo = null;
            this.TxtLblGastoDepre.Complemento = null;
            this.TxtLblGastoDepre.database = null;
            this.TxtLblGastoDepre.DesHabilitarBtnAñadir = true;
            this.TxtLblGastoDepre.DesHabilitarBtnEditar = true;
            this.TxtLblGastoDepre.DesHabilitarBtnEliminar = true;
            this.TxtLblGastoDepre.DesHabilitarBtnExcel = true;
            this.TxtLblGastoDepre.DesHabilitarBtnGuardar = true;
            this.TxtLblGastoDepre.DesHabilitarBtnImprimir = true;
            this.TxtLblGastoDepre.DesHabilitarTodo = false;
            this.TxtLblGastoDepre.Id = "";
            this.TxtLblGastoDepre.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblGastoDepre.LblNomSize = new System.Drawing.Size(260, 20);
            this.TxtLblGastoDepre.Location = new System.Drawing.Point(122, 27);
            this.TxtLblGastoDepre.MaxLenght = 0;
            this.TxtLblGastoDepre.Modo = null;
            this.TxtLblGastoDepre.Name = "TxtLblGastoDepre";
            this.TxtLblGastoDepre.NexControl = false;
            this.TxtLblGastoDepre.Nombre = null;
            this.TxtLblGastoDepre.OcultarBtnAñadir = false;
            this.TxtLblGastoDepre.OcultarBtnEditar = false;
            this.TxtLblGastoDepre.OcultarBtnEliminar = false;
            this.TxtLblGastoDepre.OcultarBtnExcel = false;
            this.TxtLblGastoDepre.OcultarBtnGuardar = false;
            this.TxtLblGastoDepre.OcultarBtnImprimir = false;
            this.TxtLblGastoDepre.OpcionGet = null;
            this.TxtLblGastoDepre.OpGet = false;
            this.TxtLblGastoDepre.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblGastoDepre.PasarUsuario = false;
            this.TxtLblGastoDepre.PerfilShow = null;
            this.TxtLblGastoDepre.PonerCeros = false;
            this.TxtLblGastoDepre.Relacion = null;
            this.TxtLblGastoDepre.SinBordes = false;
            this.TxtLblGastoDepre.Size = new System.Drawing.Size(369, 26);
            this.TxtLblGastoDepre.SoloLectura = false;
            this.TxtLblGastoDepre.TabIndex = 1;
            this.TxtLblGastoDepre.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblGastoDepre.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblGastoDepre.Usuario = null;
            this.TxtLblGastoDepre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblGastoDepre_Validating);
            // 
            // LblGastoDepre
            // 
            this.LblGastoDepre.Location = new System.Drawing.Point(12, 34);
            this.LblGastoDepre.Name = "LblGastoDepre";
            this.LblGastoDepre.Size = new System.Drawing.Size(92, 13);
            this.LblGastoDepre.TabIndex = 0;
            this.LblGastoDepre.Text = "Gasto Depreciación";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Guardar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(173, 297);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = "Guardar";
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(172, 38);
            this.acceptCancel1.TabIndex = 2;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.TxtLblCostosIndirectos);
            this.groupControl3.Controls.Add(this.LblCostosIndirectos);
            this.groupControl3.Controls.Add(this.TxtLblProducotEnP);
            this.groupControl3.Controls.Add(this.LblContrapartida);
            this.groupControl3.Location = new System.Drawing.Point(15, 191);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(505, 100);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Asiento de Uso de Equipos";
            // 
            // TxtLblCostosIndirectos
            // 
            this.TxtLblCostosIndirectos.AutoSize = true;
            this.TxtLblCostosIndirectos.Codigo = null;
            this.TxtLblCostosIndirectos.Complemento = null;
            this.TxtLblCostosIndirectos.database = null;
            this.TxtLblCostosIndirectos.DesHabilitarBtnAñadir = true;
            this.TxtLblCostosIndirectos.DesHabilitarBtnEditar = true;
            this.TxtLblCostosIndirectos.DesHabilitarBtnEliminar = true;
            this.TxtLblCostosIndirectos.DesHabilitarBtnExcel = true;
            this.TxtLblCostosIndirectos.DesHabilitarBtnGuardar = true;
            this.TxtLblCostosIndirectos.DesHabilitarBtnImprimir = true;
            this.TxtLblCostosIndirectos.DesHabilitarTodo = false;
            this.TxtLblCostosIndirectos.Id = "";
            this.TxtLblCostosIndirectos.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblCostosIndirectos.LblNomSize = new System.Drawing.Size(260, 20);
            this.TxtLblCostosIndirectos.Location = new System.Drawing.Point(122, 59);
            this.TxtLblCostosIndirectos.MaxLenght = 0;
            this.TxtLblCostosIndirectos.Modo = null;
            this.TxtLblCostosIndirectos.Name = "TxtLblCostosIndirectos";
            this.TxtLblCostosIndirectos.NexControl = false;
            this.TxtLblCostosIndirectos.Nombre = null;
            this.TxtLblCostosIndirectos.OcultarBtnAñadir = false;
            this.TxtLblCostosIndirectos.OcultarBtnEditar = false;
            this.TxtLblCostosIndirectos.OcultarBtnEliminar = false;
            this.TxtLblCostosIndirectos.OcultarBtnExcel = false;
            this.TxtLblCostosIndirectos.OcultarBtnGuardar = false;
            this.TxtLblCostosIndirectos.OcultarBtnImprimir = false;
            this.TxtLblCostosIndirectos.OpcionGet = null;
            this.TxtLblCostosIndirectos.OpGet = false;
            this.TxtLblCostosIndirectos.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblCostosIndirectos.PasarUsuario = false;
            this.TxtLblCostosIndirectos.PerfilShow = null;
            this.TxtLblCostosIndirectos.PonerCeros = false;
            this.TxtLblCostosIndirectos.Relacion = null;
            this.TxtLblCostosIndirectos.SinBordes = false;
            this.TxtLblCostosIndirectos.Size = new System.Drawing.Size(369, 26);
            this.TxtLblCostosIndirectos.SoloLectura = false;
            this.TxtLblCostosIndirectos.TabIndex = 3;
            this.TxtLblCostosIndirectos.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblCostosIndirectos.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblCostosIndirectos.Usuario = null;
            this.TxtLblCostosIndirectos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblCostosIndirectos_Validating);
            // 
            // LblCostosIndirectos
            // 
            this.LblCostosIndirectos.Location = new System.Drawing.Point(9, 34);
            this.LblCostosIndirectos.Name = "LblCostosIndirectos";
            this.LblCostosIndirectos.Size = new System.Drawing.Size(31, 13);
            this.LblCostosIndirectos.TabIndex = 2;
            this.LblCostosIndirectos.Text = "Débito";
            // 
            // TxtLblProducotEnP
            // 
            this.TxtLblProducotEnP.AutoSize = true;
            this.TxtLblProducotEnP.Codigo = null;
            this.TxtLblProducotEnP.Complemento = null;
            this.TxtLblProducotEnP.database = null;
            this.TxtLblProducotEnP.DesHabilitarBtnAñadir = true;
            this.TxtLblProducotEnP.DesHabilitarBtnEditar = true;
            this.TxtLblProducotEnP.DesHabilitarBtnEliminar = true;
            this.TxtLblProducotEnP.DesHabilitarBtnExcel = true;
            this.TxtLblProducotEnP.DesHabilitarBtnGuardar = true;
            this.TxtLblProducotEnP.DesHabilitarBtnImprimir = true;
            this.TxtLblProducotEnP.DesHabilitarTodo = false;
            this.TxtLblProducotEnP.Id = "";
            this.TxtLblProducotEnP.LblNomLocation = new System.Drawing.Point(106, 3);
            this.TxtLblProducotEnP.LblNomSize = new System.Drawing.Size(260, 20);
            this.TxtLblProducotEnP.Location = new System.Drawing.Point(122, 27);
            this.TxtLblProducotEnP.MaxLenght = 0;
            this.TxtLblProducotEnP.Modo = null;
            this.TxtLblProducotEnP.Name = "TxtLblProducotEnP";
            this.TxtLblProducotEnP.NexControl = false;
            this.TxtLblProducotEnP.Nombre = null;
            this.TxtLblProducotEnP.OcultarBtnAñadir = false;
            this.TxtLblProducotEnP.OcultarBtnEditar = false;
            this.TxtLblProducotEnP.OcultarBtnEliminar = false;
            this.TxtLblProducotEnP.OcultarBtnExcel = false;
            this.TxtLblProducotEnP.OcultarBtnGuardar = false;
            this.TxtLblProducotEnP.OcultarBtnImprimir = false;
            this.TxtLblProducotEnP.OpcionGet = null;
            this.TxtLblProducotEnP.OpGet = false;
            this.TxtLblProducotEnP.Ordenar = OrdenarPor.CampoNombre;
            this.TxtLblProducotEnP.PasarUsuario = false;
            this.TxtLblProducotEnP.PerfilShow = null;
            this.TxtLblProducotEnP.PonerCeros = false;
            this.TxtLblProducotEnP.Relacion = null;
            this.TxtLblProducotEnP.SinBordes = false;
            this.TxtLblProducotEnP.Size = new System.Drawing.Size(369, 26);
            this.TxtLblProducotEnP.SoloLectura = false;
            this.TxtLblProducotEnP.TabIndex = 1;
            this.TxtLblProducotEnP.TxtCodLocation = new System.Drawing.Point(0, 3);
            this.TxtLblProducotEnP.TxtCodSize = new System.Drawing.Size(100, 18);
            this.TxtLblProducotEnP.Usuario = null;
            this.TxtLblProducotEnP.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLblProducotEnP_Validating);
            // 
            // LblContrapartida
            // 
            this.LblContrapartida.Location = new System.Drawing.Point(9, 66);
            this.LblContrapartida.Name = "LblContrapartida";
            this.LblContrapartida.Size = new System.Drawing.Size(35, 13);
            this.LblContrapartida.TabIndex = 0;
            this.LblContrapartida.Text = "Crédito";
            // 
            // FrmGetTipoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 338);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.acceptCancel1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetTipoActivo";
            this.Text = "Capturando";
            this.Load += new System.EventHandler(this.FrmGetTipoActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChkDepreciar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTiempoAdicionar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TxtLblGeneral TxtLblCodigo;
        private DevExpress.XtraEditors.LabelControl LblCodigo;
        private DevExpress.XtraEditors.CheckEdit ChkDepreciar;
        private DevExpress.XtraEditors.LabelControl LblTiempoDepre;
        private DevExpress.XtraEditors.SpinEdit TxtTiempoAdicionar;
        private DevExpress.XtraEditors.LabelControl LblMeses;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private TxtLblGeneral TxtLblDepreAcum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private TxtLblGeneral TxtLblGastoDepre;
        private DevExpress.XtraEditors.LabelControl LblGastoDepre;
        private AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private TxtLblGeneral TxtLblCostosIndirectos;
        private DevExpress.XtraEditors.LabelControl LblCostosIndirectos;
        private TxtLblGeneral TxtLblProducotEnP;
        private DevExpress.XtraEditors.LabelControl LblContrapartida;
    }
}