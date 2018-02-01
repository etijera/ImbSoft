using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UsuarioControles
{
    public partial class CabeceraForm : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public String NombreCabecera
        {
            get
            {
                return LblNameFrm.Text;
            }
            set
            {
                if (value != null)
                {                    
                    LblNameFrm.Text = value;
                }
            }
        }

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;

        #endregion


        #region Metodos

        public CabeceraForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        #region MovVentana

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - ParentForm.Location.X, Cursor.Position.Y - ParentForm.Location.Y);
            mouseAction = true;            
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {               
                ParentForm.Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);                
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void LblNameFrm_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - ParentForm.Location.X, Cursor.Position.Y - ParentForm.Location.Y);
            mouseAction = true;
        }

        private void LblNameFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                ParentForm.Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);  
            }
        }

        private void LblNameFrm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        #endregion

        private void LnkLblMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void LnkLblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ParentForm.Close(); 
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            LblNameFrm.Location = new Point((panel2.Width - LblNameFrm.Width) / 2, LblNameFrm.Location.Y);
        }

        #endregion

    }
}
