namespace UsuarioControles
{
    partial class FormularioBase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBase2));
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl();
            this.errorP1 = new System.Windows.Forms.ErrorProvider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictEditLogo = new DevExpress.XtraEditors.PictureEdit();
            this.LnkLblMinimizar = new System.Windows.Forms.LinkLabel();
            this.LblNameFrm = new DevExpress.XtraEditors.LabelControl();
            this.LnkLblCerrar = new System.Windows.Forms.LinkLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictEditLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // alertControl1
            // 
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertControl1.ShowPinButton = false;
            // 
            // errorP1
            // 
            this.errorP1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.PictEditLogo);
            this.panel2.Controls.Add(this.LnkLblMinimizar);
            this.panel2.Controls.Add(this.LblNameFrm);
            this.panel2.Controls.Add(this.LnkLblCerrar);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 27);
            this.panel2.TabIndex = 3;
            // 
            // PictEditLogo
            // 
            this.PictEditLogo.EditValue = ((object)(resources.GetObject("PictEditLogo.EditValue")));
            this.PictEditLogo.Location = new System.Drawing.Point(1, 1);
            this.PictEditLogo.Name = "PictEditLogo";
            this.PictEditLogo.Properties.Appearance.BackColor = System.Drawing.Color.Teal;
            this.PictEditLogo.Properties.Appearance.Options.UseBackColor = true;
            this.PictEditLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictEditLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictEditLogo.Size = new System.Drawing.Size(24, 24);
            this.PictEditLogo.TabIndex = 15;
            // 
            // LnkLblMinimizar
            // 
            this.LnkLblMinimizar.ActiveLinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnkLblMinimizar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblMinimizar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLblMinimizar.LinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.Location = new System.Drawing.Point(551, 4);
            this.LnkLblMinimizar.Name = "LnkLblMinimizar";
            this.LnkLblMinimizar.Size = new System.Drawing.Size(18, 18);
            this.LnkLblMinimizar.TabIndex = 1;
            this.LnkLblMinimizar.TabStop = true;
            this.LnkLblMinimizar.Text = "_";
            this.LnkLblMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblMinimizar.VisitedLinkColor = System.Drawing.Color.White;
            this.LnkLblMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblMinimizar_LinkClicked);
            // 
            // LblNameFrm
            // 
            this.LblNameFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNameFrm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameFrm.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblNameFrm.Location = new System.Drawing.Point(280, 3);
            this.LblNameFrm.Name = "LblNameFrm";
            this.LblNameFrm.Size = new System.Drawing.Size(36, 18);
            this.LblNameFrm.TabIndex = 0;
            this.LblNameFrm.Text = "Titulo";
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
            this.LnkLblCerrar.Location = new System.Drawing.Point(571, 4);
            this.LnkLblCerrar.Name = "LnkLblCerrar";
            this.LnkLblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LnkLblCerrar.TabIndex = 2;
            this.LnkLblCerrar.TabStop = true;
            this.LnkLblCerrar.Text = "X";
            this.LnkLblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnkLblCerrar.UseCompatibleTextRendering = true;
            this.LnkLblCerrar.VisitedLinkColor = System.Drawing.Color.White;
            this.LnkLblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblCerrar_LinkClicked);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Location = new System.Drawing.Point(2, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(595, 378);
            this.groupControl1.TabIndex = 4;
            // 
            // FormularioBase2
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 409);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormularioBase2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormularioBase2_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormularioBase2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormularioBase2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormularioBase2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictEditLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        protected System.Windows.Forms.ErrorProvider errorP1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit PictEditLogo;
        private System.Windows.Forms.LinkLabel LnkLblMinimizar;
        private DevExpress.XtraEditors.LabelControl LblNameFrm;
        private System.Windows.Forms.LinkLabel LnkLblCerrar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}