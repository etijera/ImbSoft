using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Referencias;
using Referencias.Properties;
using DevExpress.XtraEditors;
using UsuarioControles;

namespace Adicionales.Views.Helpers
{
    public partial class FrmLogin : FormularioBase
    {
        #region Propiedades
        public string DataBase { get; set; }
        public string Usuario { get; set; }
        public string tipo { get; set; }

        #endregion

        #region Variables

        private Funciones f = new Funciones();
        private bool logueado = false;

        #endregion

        #region Metodos
        public FrmLogin()
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

        #endregion

        #region Eventos
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                    //f.GetFamilias(ConexionDB.getInstancia().Conexion(null, null)).Tables[0];

                LueEmpresa.Properties.DataSource = dt;
                LueEmpresa.Properties.DisplayMember = "nombre";
                LueEmpresa.Properties.ValueMember = "codigo";

                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                LueEmpresa.Properties.Columns.Add(col);
                LueEmpresa.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }

        }
        private void lookUpEdit1_Properties_Leave(object sender, EventArgs e)
        {
            if (LueEmpresa.EditValue != null)
            {
                try
                {
                    DataBase = LueEmpresa.EditValue.ToString();

                    DataTable dt = f.GetUsuarios(ConexionDB.getInstancia().Conexion(DataBase, null)).Tables[0];

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
        }
        private void LueEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LueEmpresa.EditValue.ToString()))
            {
                LueUsuario.Enabled = true;
                LueUsuario.Text = "";
                LueUsuario.Properties.DataSource = null;
            }
        }
        private void LueUsuario_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LueEmpresa.EditValue.ToString()))
            {
                TxtContraseña.Enabled = true;
                CbxAño.Enabled = true;
                CbxMes.Enabled = true;
            }
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            DataTable dt = f.ValidarUsuario(LueUsuario.Text, TxtContraseña.Text.Trim(), ConexionDB.getInstancia().Conexion(DataBase, null)).Tables[0];
            if (dt.Rows.Count != 0 )
            {
                Usuario = LueUsuario.EditValue.ToString().Trim();
                logueado = true;
                DialogResult = System.Windows.Forms.DialogResult.OK;                                               
            }
            else
            {
                MessageBox.Show("Clave Incorrecta", Resources.AppName , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtContraseña.Text = "";
                TxtContraseña.Focus();
                logueado = false;
            }


        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logueado) 
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel; 
            }
        }

        #endregion
    }
}
