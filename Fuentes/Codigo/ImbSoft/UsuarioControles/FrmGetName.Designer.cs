
namespace UsuarioControles
{
    partial class FrmGetName
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
            this.GbxDatos = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombre = new UsuarioControles.TxtBase();
            this.LblNombre = new UsuarioControles.LblBase();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).BeginInit();
            this.GbxDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.panel1);
            this.GbxDatos.Controls.Add(this.acceptCancel1);
            this.GbxDatos.Location = new System.Drawing.Point(2, 29);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.ShowCaption = false;
            this.GbxDatos.Size = new System.Drawing.Size(460, 163);
            this.GbxDatos.TabIndex = 0;
            this.GbxDatos.Text = "groupControl1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(22, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 74);
            this.panel1.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtNombre.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.Appearance.Options.UseBackColor = true;
            this.TxtNombre.CaraterPassword = '\0';
            this.TxtNombre.Location = new System.Drawing.Point(80, 23);
            this.TxtNombre.MaxLenght = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(321, 26);
            this.TxtNombre.SoloLectura = false;
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.TextMayusMinus = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.TipoFormato = Referencias.Funciones.TipoNumerico.Ninguno;
            this.TxtNombre.TipoMascara = DevExpress.XtraEditors.Mask.MaskType.None;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(14, 30);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(60, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Texto = "Nombre:";
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(175, 106);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(110, 49);
            this.acceptCancel1.TabIndex = 2;
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(1, 1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Titulo";
            this.cabeceraForm1.Size = new System.Drawing.Size(460, 32);
            this.cabeceraForm1.TabIndex = 1;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = false;
            // 
            // FrmGetName
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 194);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.cabeceraForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetName";
            this.Text = "Capturando";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGetName_FormClosing);
            this.Load += new System.EventHandler(this.FrmGetName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbxDatos)).EndInit();
            this.GbxDatos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GbxDatos;
        private AcceptCancel acceptCancel1;
        private CabeceraForm cabeceraForm1;
        private System.Windows.Forms.Panel panel1;
        private TxtBase TxtNombre;
        private LblBase LblNombre;
    }
}