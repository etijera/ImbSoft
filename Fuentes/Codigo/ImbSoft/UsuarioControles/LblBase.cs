using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioControles
{
    public partial class LblBase : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public String Texto
        {
            get
            {
                return Label.Text;
            }
            set
            {
                if (value != null)
                {
                    Label.Text = value;
                }
            }
        }

        #endregion

        public LblBase()
        {
            InitializeComponent();
        }
    }
}
