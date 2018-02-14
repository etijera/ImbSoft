namespace UsuarioControles
{
    partial class TxtBase
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
            this.TxtTex = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTex
            // 
            this.TxtTex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTex.EditValue = "";
            this.TxtTex.EnterMoveNextControl = true;
            this.TxtTex.Location = new System.Drawing.Point(3, 3);
            this.TxtTex.Name = "TxtTex";
            this.TxtTex.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtTex.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.TxtTex.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTex.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTex.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtTex.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.TxtTex.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Teal;
            this.TxtTex.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TxtTex.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTex.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.TxtTex.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TxtTex.Properties.MaxLength = 50;
            this.TxtTex.Size = new System.Drawing.Size(166, 20);
            this.TxtTex.TabIndex = 2;
            this.TxtTex.Enter += new System.EventHandler(this.TxtTex_Enter);
            this.TxtTex.Leave += new System.EventHandler(this.TxtTex_Leave);
            // 
            // TxtBase
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtTex);
            this.Name = "TxtBase";
            this.Size = new System.Drawing.Size(173, 26);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtTex;
    }
}
