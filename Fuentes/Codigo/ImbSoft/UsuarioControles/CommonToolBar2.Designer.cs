﻿namespace UsuarioControles
{
    partial class CommonToolBar2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonToolBar2));
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAñadir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnAñadir,
            this.BtnEliminar,
            this.BtnEdit,
            this.BtnImprimir,
            this.BtnGuardar,
            this.BtnExcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bar2.BarAppearance.Normal.Options.UseBackColor = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAñadir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExcel)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.Text = "Main menu";
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Caption = "Add";
            this.BtnAñadir.CausesValidation = true;
            this.BtnAñadir.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnAñadir.Glyph")));
            this.BtnAñadir.Id = 0;
            this.BtnAñadir.Name = "BtnAñadir";
            toolTipItem7.Text = "Adicionar";
            superToolTip7.Items.Add(toolTipItem7);
            this.BtnAñadir.SuperTip = superToolTip7;
            this.BtnAñadir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAñadir_ItemClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Caption = "Edit";
            this.BtnEdit.CausesValidation = true;
            this.BtnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Glyph")));
            this.BtnEdit.Id = 2;
            this.BtnEdit.Name = "BtnEdit";
            toolTipItem9.Text = "Editar";
            superToolTip9.Items.Add(toolTipItem9);
            this.BtnEdit.SuperTip = superToolTip9;
            this.BtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEdit_ItemClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Caption = "Delete";
            this.BtnEliminar.CausesValidation = true;
            this.BtnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Glyph")));
            this.BtnEliminar.Id = 1;
            this.BtnEliminar.Name = "BtnEliminar";
            toolTipItem8.Text = "Eliminar";
            superToolTip8.Items.Add(toolTipItem8);
            this.BtnEliminar.SuperTip = superToolTip8;
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Impr";
            this.BtnImprimir.CausesValidation = true;
            this.BtnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Glyph")));
            this.BtnImprimir.Id = 3;
            this.BtnImprimir.Name = "BtnImprimir";
            toolTipItem10.Text = "Imprimir";
            superToolTip10.Items.Add(toolTipItem10);
            this.BtnImprimir.SuperTip = superToolTip10;
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Caption = "Guardar";
            this.BtnGuardar.CausesValidation = true;
            this.BtnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Glyph")));
            this.BtnGuardar.Id = 4;
            this.BtnGuardar.Name = "BtnGuardar";
            toolTipItem11.Text = "Guardar";
            superToolTip11.Items.Add(toolTipItem11);
            this.BtnGuardar.SuperTip = superToolTip11;
            this.BtnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGuardar_ItemClick);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Caption = "Excel";
            this.BtnExcel.CausesValidation = true;
            this.BtnExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Glyph")));
            this.BtnExcel.Id = 5;
            this.BtnExcel.Name = "BtnExcel";
            toolTipItem12.Text = "Exportar a Excel";
            superToolTip12.Items.Add(toolTipItem12);
            this.BtnExcel.SuperTip = superToolTip12;
            this.BtnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(238, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.barDockControlBottom.Appearance.Options.UseBackColor = true;
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 26);
            this.barDockControlBottom.Size = new System.Drawing.Size(238, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(238, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // CommonToolBar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CommonToolBar2";
            this.Size = new System.Drawing.Size(238, 26);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnAñadir;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BtnEdit;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnExcel;

    }
}
