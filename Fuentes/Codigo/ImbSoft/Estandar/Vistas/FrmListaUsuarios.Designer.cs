namespace Estandar.Vistas
{
    partial class FrmListaUsuarios
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PrgBuscar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.GctrlGeneral = new DevExpress.XtraGrid.GridControl();
            this.DgvGeneral = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.commonToolBar2G1 = new UsuarioControles.CommonToolBar2G();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BkgwBuscar = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrgBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GctrlGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.PrgBuscar);
            this.groupControl1.Controls.Add(this.GctrlGeneral);
            this.groupControl1.Location = new System.Drawing.Point(2, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(514, 281);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // PrgBuscar
            // 
            this.PrgBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgBuscar.EditValue = "Cargando...";
            this.PrgBuscar.Location = new System.Drawing.Point(132, 127);
            this.PrgBuscar.Name = "PrgBuscar";
            this.PrgBuscar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PrgBuscar.Properties.ShowTitle = true;
            this.PrgBuscar.Size = new System.Drawing.Size(249, 26);
            this.PrgBuscar.TabIndex = 1;
            this.PrgBuscar.Visible = false;
            // 
            // GctrlGeneral
            // 
            this.GctrlGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GctrlGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GctrlGeneral.Location = new System.Drawing.Point(4, 5);
            this.GctrlGeneral.MainView = this.DgvGeneral;
            this.GctrlGeneral.Name = "GctrlGeneral";
            this.GctrlGeneral.Size = new System.Drawing.Size(506, 270);
            this.GctrlGeneral.TabIndex = 0;
            this.GctrlGeneral.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DgvGeneral});
            // 
            // DgvGeneral
            // 
            this.DgvGeneral.GridControl = this.GctrlGeneral;
            this.DgvGeneral.Name = "DgvGeneral";
            this.DgvGeneral.OptionsBehavior.AllowIncrementalSearch = true;
            this.DgvGeneral.OptionsView.ShowGroupPanel = false;
            // 
            // commonToolBar2G1
            // 
            this.commonToolBar2G1.AñadirValidacion = true;
            this.commonToolBar2G1.EditarValidacion = true;
            this.commonToolBar2G1.EliminarValidacion = true;
            this.commonToolBar2G1.ExcelValidacion = true;
            this.commonToolBar2G1.GuardarValidacion = true;
            this.commonToolBar2G1.HabilitarAñadir = true;
            this.commonToolBar2G1.HabilitarEditar = true;
            this.commonToolBar2G1.HabilitarEliminar = true;
            this.commonToolBar2G1.HabilitarExcel = true;
            this.commonToolBar2G1.HabilitarGuardar = true;
            this.commonToolBar2G1.HabilitarImprimir = true;
            this.commonToolBar2G1.ImprimirValidacion = true;
            this.commonToolBar2G1.Location = new System.Drawing.Point(1, 3);
            this.commonToolBar2G1.Mañadir = null;
            this.commonToolBar2G1.Meditar = null;
            this.commonToolBar2G1.Melimnar = null;
            this.commonToolBar2G1.Mexcel = null;
            this.commonToolBar2G1.Mguardar = null;
            this.commonToolBar2G1.Mimprimir = null;
            this.commonToolBar2G1.Name = "commonToolBar2G1";
            this.commonToolBar2G1.Size = new System.Drawing.Size(165, 39);
            this.commonToolBar2G1.TabIndex = 5;
            this.commonToolBar2G1.VerAñadir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.commonToolBar2G1.VerEditar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.commonToolBar2G1.VerEliminar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.commonToolBar2G1.VerExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.commonToolBar2G1.VerGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.commonToolBar2G1.VerImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.commonToolBar2G1);
            this.panelControl1.Location = new System.Drawing.Point(2, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(514, 45);
            this.panelControl1.TabIndex = 8;
            // 
            // BkgwBuscar
            // 
            this.BkgwBuscar.WorkerSupportsCancellation = true;
            this.BkgwBuscar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BkgwBuscar_DoWork);
            this.BkgwBuscar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BkgwBuscar_RunWorkerCompleted);
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(1, 1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Usuarios";
            this.cabeceraForm1.Size = new System.Drawing.Size(515, 32);
            this.cabeceraForm1.TabIndex = 9;
            // 
            // FrmListaUsuarios
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 357);
            this.Controls.Add(this.cabeceraForm1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmListaUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "FrmListaUsuarios";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.FrmListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrgBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GctrlGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl PrgBuscar;
        private DevExpress.XtraGrid.GridControl GctrlGeneral;
        private DevExpress.XtraGrid.Views.Grid.GridView DgvGeneral;
        private UsuarioControles.CommonToolBar2G commonToolBar2G1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.ComponentModel.BackgroundWorker BkgwBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private UsuarioControles.CabeceraForm cabeceraForm1;
    }
}