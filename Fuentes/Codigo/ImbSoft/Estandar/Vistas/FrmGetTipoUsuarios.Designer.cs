namespace Estandar.Vistas
{
    partial class FrmGetTipoUsuarios
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
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.LblNameFrm = new DevExpress.XtraEditors.LabelControl();
            this.acceptCancel1 = new UsuarioControles.AcceptCancel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombre = new UsuarioControles.TxtBase();
            this.LblNombre = new UsuarioControles.LblBase();
            this.cabeceraForm1 = new UsuarioControles.CabeceraForm();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChkAñadir = new DevExpress.XtraEditors.CheckEdit();
            this.lblBase1 = new UsuarioControles.LblBase();
            this.ChkEditar = new DevExpress.XtraEditors.CheckEdit();
            this.ChkEliminar = new DevExpress.XtraEditors.CheckEdit();
            this.ChkGuardar = new DevExpress.XtraEditors.CheckEdit();
            this.ChkImprimir = new DevExpress.XtraEditors.CheckEdit();
            this.ChkExportar = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkAñadir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEditar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEliminar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGuardar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkExportar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNameFrm
            // 
            this.LblNameFrm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameFrm.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblNameFrm.Location = new System.Drawing.Point(273, 3);
            this.LblNameFrm.Name = "LblNameFrm";
            this.LblNameFrm.Size = new System.Drawing.Size(0, 18);
            this.LblNameFrm.TabIndex = 0;
            // 
            // acceptCancel1
            // 
            this.acceptCancel1.AcceptButtonText = "Aceptar";
            this.acceptCancel1.CancelButtonText = "Cancelar";
            this.acceptCancel1.HabilitarAceptar = true;
            this.acceptCancel1.HabilitarCancelar = true;
            this.acceptCancel1.Location = new System.Drawing.Point(187, 171);
            this.acceptCancel1.LookAndFeel.SkinName = "Office 2007 Silver";
            this.acceptCancel1.Maceptar = null;
            this.acceptCancel1.Mcancelar = null;
            this.acceptCancel1.Name = "acceptCancel1";
            this.acceptCancel1.Size = new System.Drawing.Size(108, 49);
            this.acceptCancel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.acceptCancel1);
            this.panelControl1.Controls.Add(this.lblBase1);
            this.panelControl1.Location = new System.Drawing.Point(2, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(483, 226);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 56);
            this.panel1.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AlineacionHorizontal = DevExpress.Utils.HorzAlignment.Default;
            this.TxtNombre.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.Appearance.Options.UseBackColor = true;
            this.TxtNombre.CaraterPassword = '\0';
            this.TxtNombre.Location = new System.Drawing.Point(80, 14);
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
            this.LblNombre.Location = new System.Drawing.Point(14, 21);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(60, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Texto = "Nombre:";
            // 
            // cabeceraForm1
            // 
            this.cabeceraForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cabeceraForm1.AutoSize = true;
            this.cabeceraForm1.HabilitarBCerrar = true;
            this.cabeceraForm1.HabilitarBMinimiar = true;
            this.cabeceraForm1.Location = new System.Drawing.Point(0, 1);
            this.cabeceraForm1.Name = "cabeceraForm1";
            this.cabeceraForm1.NombreCabecera = "Tipo de Usuarios";
            this.cabeceraForm1.Size = new System.Drawing.Size(485, 32);
            this.cabeceraForm1.TabIndex = 1;
            this.cabeceraForm1.VerBCerrar = true;
            this.cabeceraForm1.VerBMinimiar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ChkExportar);
            this.panel2.Controls.Add(this.ChkImprimir);
            this.panel2.Controls.Add(this.ChkGuardar);
            this.panel2.Controls.Add(this.ChkEliminar);
            this.panel2.Controls.Add(this.ChkEditar);
            this.panel2.Controls.Add(this.ChkAñadir);
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(22, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 58);
            this.panel2.TabIndex = 10;
            // 
            // ChkAñadir
            // 
            this.ChkAñadir.Location = new System.Drawing.Point(14, 19);
            this.ChkAñadir.Name = "ChkAñadir";
            this.ChkAñadir.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkAñadir.Properties.Appearance.Options.UseForeColor = true;
            this.ChkAñadir.Properties.Caption = "Añadir";
            this.ChkAñadir.Size = new System.Drawing.Size(63, 19);
            this.ChkAñadir.TabIndex = 0;
            // 
            // lblBase1
            // 
            this.lblBase1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBase1.Appearance.Options.UseBackColor = true;
            this.lblBase1.AutoSize = true;
            this.lblBase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBase1.Location = new System.Drawing.Point(22, 89);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(62, 20);
            this.lblBase1.TabIndex = 11;
            this.lblBase1.Texto = "Permisos";
            // 
            // ChkEditar
            // 
            this.ChkEditar.Location = new System.Drawing.Point(152, 19);
            this.ChkEditar.Name = "ChkEditar";
            this.ChkEditar.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkEditar.Properties.Appearance.Options.UseForeColor = true;
            this.ChkEditar.Properties.Caption = "Editar";
            this.ChkEditar.Size = new System.Drawing.Size(63, 19);
            this.ChkEditar.TabIndex = 12;
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.Location = new System.Drawing.Point(83, 19);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkEliminar.Properties.Appearance.Options.UseForeColor = true;
            this.ChkEliminar.Properties.Caption = "Eliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(63, 19);
            this.ChkEliminar.TabIndex = 13;
            // 
            // ChkGuardar
            // 
            this.ChkGuardar.Location = new System.Drawing.Point(221, 19);
            this.ChkGuardar.Name = "ChkGuardar";
            this.ChkGuardar.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkGuardar.Properties.Appearance.Options.UseForeColor = true;
            this.ChkGuardar.Properties.Caption = "Guardar";
            this.ChkGuardar.Size = new System.Drawing.Size(63, 19);
            this.ChkGuardar.TabIndex = 14;
            // 
            // ChkImprimir
            // 
            this.ChkImprimir.Location = new System.Drawing.Point(290, 19);
            this.ChkImprimir.Name = "ChkImprimir";
            this.ChkImprimir.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkImprimir.Properties.Appearance.Options.UseForeColor = true;
            this.ChkImprimir.Properties.Caption = "Imprimir";
            this.ChkImprimir.Size = new System.Drawing.Size(63, 19);
            this.ChkImprimir.TabIndex = 15;
            // 
            // ChkExportar
            // 
            this.ChkExportar.Location = new System.Drawing.Point(359, 19);
            this.ChkExportar.Name = "ChkExportar";
            this.ChkExportar.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.ChkExportar.Properties.Appearance.Options.UseForeColor = true;
            this.ChkExportar.Properties.Caption = "Exportar";
            this.ChkExportar.Size = new System.Drawing.Size(63, 19);
            this.ChkExportar.TabIndex = 16;
            // 
            // FrmGetTipoUsuarios
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 257);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cabeceraForm1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "FrmGetTipoUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "Usuarios";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.GetUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChkAñadir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEditar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEliminar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGuardar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkExportar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsuarioControles.AcceptCancel acceptCancel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl LblNameFrm;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private UsuarioControles.TxtBase TxtNombre;
        private UsuarioControles.LblBase LblNombre;
        private UsuarioControles.CabeceraForm cabeceraForm1;
        private System.Windows.Forms.Panel panel2;
        private UsuarioControles.LblBase lblBase1;
        private DevExpress.XtraEditors.CheckEdit ChkAñadir;
        private DevExpress.XtraEditors.CheckEdit ChkExportar;
        private DevExpress.XtraEditors.CheckEdit ChkImprimir;
        private DevExpress.XtraEditors.CheckEdit ChkGuardar;
        private DevExpress.XtraEditors.CheckEdit ChkEliminar;
        private DevExpress.XtraEditors.CheckEdit ChkEditar;
    }
}