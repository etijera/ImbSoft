/***
* Formulario   : FormularioBase2
* Proposito    : Es la clase base a partir de la cual se hereda para crear los nuevos
*                formularios, de tal manera que se especifica el Icono de la ventana y demas
*                Características básicas
*                
* Fecha        : Octubre 02, 2017
* Fecha Act.   :
* Autor        : 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UsuarioControles
{
    public partial class FormularioBase2 : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        public String LblNameFrmText
        {
            get
            {
                return LblNameFrm.Text;
            }
            set
            {
                if (value != null && value != string.Empty)
                    LblNameFrm.Text = value;
            }
        }
        public Boolean LnkLblMinimizarVisible
        {
            get
            {
                return LnkLblMinimizar.Visible;
            }
            set
            {
                if (value != null)
                    LnkLblMinimizar.Visible = value;
            }
        }

        public Boolean LnkLblMinimizarEnabled
        {
            get
            {
                return LnkLblMinimizar.Enabled;
            }
            set
            {
                if (value != null)
                    LnkLblMinimizar.Enabled = value;
            }
        }

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor de la clase FormularioBase2
        /// </summary>
        public FormularioBase2()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        private void FormularioBase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Escape)
            {
                Close();
            }

        }

        private void FormularioBase2_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void FormularioBase2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void FormularioBase2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void LnkLblMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LnkLblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
