using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UsuarioControles;

namespace ImbSoft.Vistas
{
    public partial class Form1 : FormularioBase
    {
        public Form1()
        {
            InitializeComponent();
            txtBase1.AsignarTipoFormatoNumerico();
            txtBase2.AsignarTipoFormatoNumerico();
            txtBase3.AsignarTipoFormatoNumerico();
            txtBase4.AsignarTipoFormatoNumerico();
            txtBase5.AsignarTipoFormatoNumerico();
            txtBase6.AsignarTipoFormatoNumerico();
            txtBase7.AsignarTipoFormatoNumerico();
        }
    }
}