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

        public bool VerBMinimiar
        {
            get
            {
                return LnkLblMinimizar.Visible;
            }
            set
            {
                LnkLblMinimizar.Visible = value;
            }
        }

        public bool VerBCerrar
        {
            get
            {
                return LnkLblCerrar.Visible;
            }
            set
            {
                LnkLblCerrar.Visible = value;
            }
        }

        public bool HabilitarBCerrar
        {
            get
            {
                return LnkLblCerrar.Enabled;
            }
            set
            {
                LnkLblCerrar.Enabled = value;
            }
        }

        public bool HabilitarBMinimiar
        {
            get
            {
                return LnkLblMinimizar.Enabled;
            }
            set
            {
                LnkLblMinimizar.Enabled = value;
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

        private void LblNameFrm_TextChanged(object sender, EventArgs e)
        {
            LblNameFrm.Location = new Point((panel2.Width - LblNameFrm.Width) / 2, LblNameFrm.Location.Y);
        }

        private void LnkLblCerrar_MouseEnter(object sender, EventArgs e)
        {
            LnkLblCerrar.BackColor = Color.FromArgb(180, 0, 0);
            LnkLblCerrar.BackColor = Color.Firebrick;
        }

        private void LnkLblCerrar_MouseLeave(object sender, EventArgs e)
        {
            LnkLblCerrar.BackColor = Color.Transparent;
        }

        private void LnkLblMinimizar_MouseEnter(object sender, EventArgs e)
        {
            LnkLblMinimizar.BackColor = Color.FromArgb(16, 74, 90);
        }

        private void LnkLblMinimizar_MouseLeave(object sender, EventArgs e)
        {
            LnkLblMinimizar.BackColor = Color.Transparent;
        }

        private void LnkLblCerrar_Click(object sender, EventArgs e)
        {
            ParentForm.Close(); 
        }

        private void LnkLblMinimizar_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        #endregion




    }
}
