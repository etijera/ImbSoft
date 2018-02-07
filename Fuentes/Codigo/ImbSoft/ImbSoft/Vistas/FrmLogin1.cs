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
    public partial class FrmLogin1 : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Usuario { get; set; }
        public string tipo { get; set; }
        public string Periodo { get; set; }
        #endregion

        #region Variables

        private Funciones f = new Funciones();
        private bool logueado = false;

        Point formPosition;
        Boolean mouseAction;

        #endregion

        #region Metodos
        public FrmLogin1()
        {
            InitializeComponent();

            for (int i = 1995; i <= DateTime.Now.Year + 5; i++)
            {
                CbxAño.Properties.Items.Add(i);
            }
            CbxAño.EditValue = DateTime.Now.Year;
            CbxMes.EditValue = DateTime.Now.Month;
            LueUsuario.Text = "";
        }        

        public void Entrar()
        {
            DataTable dt = f.ValidarUsuario(LueUsuario.Text, TxtPassword.Text.Trim(), ConexionDB.getInstancia().Conexion(Database, null)).Tables[0];
            if (dt.Rows.Count != 0)
            {
                Usuario = LueUsuario.EditValue.ToString().Trim();
                Periodo = CbxAño.Text + f.RellenarCadenaPorLaIzquierda(f.Mes2Numero(CbxMes.Text).ToString(),'0',2);
                logueado = true;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Clave Incorrecta", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtPassword.Text = "";
                TxtPassword.Focus();
                logueado = false;
            }
        }

        #endregion

        #region Eventos

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Entrar();
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

        private void FrmLogin1_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = f.GetUsuarios(ConexionDB.getInstancia().Conexion(Database, null)).Tables[0];

                LueUsuario.Properties.Columns.Clear();
                LueUsuario.Properties.DataSource = dt;
                LueUsuario.Properties.DisplayMember = "Usuario";
                LueUsuario.Properties.ValueMember = "Codigo";

                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Usuario", "Usuario", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                LueUsuario.Properties.Columns.Add(col);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }
        }

        private void LueUsuario_EditValueChanged(object sender, EventArgs e)
        {
            TxtPassword.Enabled = true;
            CbxAño.Enabled = true;
            CbxMes.Enabled = true;            
        }

        #endregion


    }
}