/***
* Formulario   : FormularioBase
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
    public partial class FormularioBase : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor de la clase FormularioBase
        /// </summary>
        public FormularioBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        private void FormularioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Escape)
            {
                Close();
            }

        }

        private void FormularioBase_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void FormularioBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void FormularioBase_MouseUp(object sender, MouseEventArgs e)
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
