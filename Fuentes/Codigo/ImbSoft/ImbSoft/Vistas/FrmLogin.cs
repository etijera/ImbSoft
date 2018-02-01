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
using Referencias;
using UsuarioControles;
using Referencias.Properties;
using Settings;

namespace ImbSoft.Vistas
{
    public partial class FrmLogin : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string NomUsuario { get; set; }

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;

        #endregion

        #region Metodos
        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty((TxtUsuario.Text)))
            {
                errorP1.SetError(TxtUsuario, "Debe ingresar el usuario.");
                TxtUsuario.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtUsuario, "");
            }

            if (string.IsNullOrEmpty((TxtPassword.Text)))
            {
                errorP1.SetError(TxtPassword, "Debe ingresar la contraseña.");
                TxtPassword.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtPassword, "");
            }
           
            return retorno;
        }

        public bool ValidarLogin()
        {
            string user = TxtUsuario.Text.Trim();
            string pass = TxtPassword.Text.Trim();
            bool retorno = false;

            DataSet ds = Funciones.getInstancia().ValidarUsuario(user, pass, ConexionDB.getInstancia().Conexion(null, null));
            if (ds.Tables.Count>0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    XtraMessageBox.Show("Usuario y/o contraseña incorrectos.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    TxtUsuario.Focus();
                }
            }
            else
            {
                retorno = false;
                XtraMessageBox.Show("La base de datos configurada no tiene la estructura necesaria para iniciar sesión. Por favor verifique los ajustes de conexión o comuníquese con el administrador del sistema.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                BtnAjustes.Focus();
            }
            
            return retorno;
        }

        public void Entrar()
        {
            if (Validar())
            {
                if (ValidarLogin())
                {
                    NomUsuario = TxtUsuario.Text.Trim();                   

                    DialogResult = DialogResult.OK;
                }
            }
        }

        #endregion

        #region Eventos

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void TxtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Entrar();
            }
        }

        private void LnkLblMinimizar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LnkLblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            FrmConfigurar config = new FrmConfigurar();
            config.ShowDialog();
        }

        #endregion



    }
}