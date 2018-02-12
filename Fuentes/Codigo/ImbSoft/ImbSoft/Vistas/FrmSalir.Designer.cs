namespace ImbSoft.Vistas
{
    partial class FrmSalir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalir));
            this.PbxPregunta = new DevExpress.XtraEditors.PictureEdit();
            this.LblPregunta = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNameFrm = new DevExpress.XtraEditors.LabelControl();
            this.LnkLblCerrar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPregunta.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxPregunta
            // 
            this.PbxPregunta.EditValue = ((object)(resources.GetObject("PbxPregunta.EditValue")));
            this.PbxPregunta.Location = new System.Drawing.Point(12, 13);
            this.PbxPregunta.Name = "PbxPregunta";
            this.PbxPregunta.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PbxPregunta.Properties.Appearance.Options.UseBackColor = true;
            this.PbxPregunta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PbxPregunta.Size = new System.Drawing.Size(34, 38);
            this.PbxPregunta.TabIndex = 0;
            // 
            // LblPregunta
            // 
            this.LblPregunta.Location = new System.Drawing.Point(54, 24);
            this.LblPregunta.Name = "LblPregunta";
            this.LblPregunta.Size = new System.Drawing.Size(212, 13);
            this.LblPregunta.TabIndex = 1;
            this.LblPregunta.Text = "¿Esta seguro que desea salir de BarBerSoft?";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Controls.Add(this.LblNameFrm);
            this.panel2.Controls.Add(this.LnkLblCerrar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 27);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // LblNameFrm
            // 
            this.LblNameFrm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameFrm.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblNameFrm.Location = new System.Drawing.Point(155, 3);
            this.LblNameFrm.Name = "LblNameFrm";
            this.LblNameFrm.Size = new System.Drawing.Size(29, 18);
            this.LblNameFrm.TabIndex = 0;
            this.LblNameFrm.Text = "Salir";
            this.LblNameFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblNameFrm_MouseDown);
            this.LblNameFrm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblNameFrm_MouseMove);
            this.LblNameFrm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblNameFrm_MouseUp);
            // 
            // LnkLblCerrar
            // 
            this.LnkLblCerrar.ActiveLinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnkLblCerrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLblCerrar.LinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.Location = new System.Drawing.Point(316, 4);
            this.LnkLblCerrar.Name = "LnkLblCerrar";
            this.LnkLblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LnkLblCerrar.TabIndex = 9;
            this.LnkLblCerrar.TabStop = true;
            this.LnkLblCerrar.Text = "X";
            this.LnkLblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnkLblCerrar.UseCompatibleTextRendering = true;
            this.LnkLblCerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblCerrar_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblPregunta);
            this.panel1.Controls.Add(this.PbxPregunta);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 66);
            this.panel1.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.acceptCancel1);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(2, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(336, 133);
            this.panelControl1.TabIndex = 6;
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(109, 80);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(108, 49);
            this.acceptCancel1.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 1);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Teal;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit1.TabIndex = 16;
            // 
            // FrmSalir
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalir";
            this.ShowIcon = false;
            this.Text = "Salir";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FrmSalir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPregunta.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PbxPregunta;
        private DevExpress.XtraEditors.LabelControl LblPregunta;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl LblNameFrm;
        private System.Windows.Forms.LinkLabel LnkLblCerrar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UsuarioControles.AcceptCancel acceptCancel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}