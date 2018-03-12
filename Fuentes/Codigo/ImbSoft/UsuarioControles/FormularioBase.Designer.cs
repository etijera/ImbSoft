namespace UsuarioControles
{
    partial class FormularioBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBase));
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.errorP1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
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
            // FormularioBase
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(198)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 409);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormularioBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormularioBase_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormularioBase_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormularioBase_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormularioBase_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        protected System.Windows.Forms.ErrorProvider errorP1;
    }
}