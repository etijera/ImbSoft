using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UsuarioControles;
using Referencias;
using System.Data.SqlClient;

namespace Estandar.Vistas.Contabilidad
{
    public partial class FrmGetTipoActivo : FormularioBase
    {

        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }
        public String Usuario { get; set; }

        #endregion

        #region Metodos

        public FrmGetTipoActivo()
        {
            InitializeComponent();
        }


        public bool AuxiliarCodigo()
        {
            bool r = true;
            if (!String.IsNullOrEmpty(TxtLblCodigo.Id))
            {
                if (TxtLblCodigo.Id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;
                    TxtLblCodigo.Id = "";
                    TxtLblCodigo.Codigo = "";
                    TxtLblCodigo.Nombre = "";
                    TxtLblCodigo.Borrar();

                    XtraMessageBox.Show("El código debe ser una cuenta auxiliar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        private bool ExisteTipoActivo()
        {
            bool retorno = false;

            String sql = String.Format("SELECT tacpuc FROM accgltipoact WHERE delmrk = 1  AND tacpuc = '{0}'",TxtLblCodigo.Id);

            DataTable dtTipoAct = DataBase.ExecuteQueryDataTable(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            
            if (dtTipoAct.Rows.Count > 0)
            {
                retorno = true;
                TxtLblCodigo.Id = "";
                TxtLblCodigo.Codigo = "";
                TxtLblCodigo.Nombre = "";
                TxtLblCodigo.Borrar();
                XtraMessageBox.Show("El código del tipo de activo ya existe.", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return retorno;
        }

        public bool AuxiliarGastoDepre()
        {
            bool r = true;
            if (!String.IsNullOrEmpty(TxtLblGastoDepre.Id))
            {
                if (TxtLblGastoDepre.Id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;
                    TxtLblGastoDepre.Id = "";
                    TxtLblGastoDepre.Codigo = "";
                    TxtLblGastoDepre.Nombre = "";
                    TxtLblGastoDepre.Borrar();

                    XtraMessageBox.Show("El código debe ser una cuenta auxiliar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        public bool AuxiliarDepreCum()
        {
            bool r = true;
            if (!String.IsNullOrEmpty(TxtLblDepreAcum.Id))
            {
                if (TxtLblDepreAcum.Id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;
                    TxtLblDepreAcum.Id = "";
                    TxtLblDepreAcum.Codigo = "";
                    TxtLblDepreAcum.Nombre = "";
                    TxtLblDepreAcum.Borrar();

                    XtraMessageBox.Show("El código debe ser una cuenta auxiliar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        public bool AuxiliarProducotEnP()
        {
            bool r = true;
            if (!String.IsNullOrEmpty(TxtLblProducotEnP.Id))
            {
                if (TxtLblProducotEnP.Id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;
                    TxtLblProducotEnP.Id = "";
                    TxtLblProducotEnP.Codigo = "";
                    TxtLblProducotEnP.Nombre = "";
                    TxtLblProducotEnP.Borrar();

                    XtraMessageBox.Show("El código debe ser una cuenta auxiliar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        public bool AuxiliarCostosIndirectos()
        {
            bool r = true;
            if (!String.IsNullOrEmpty(TxtLblCostosIndirectos.Id))
            {
                if (TxtLblCostosIndirectos.Id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;
                    TxtLblCostosIndirectos.Id = "";
                    TxtLblCostosIndirectos.Codigo = "";
                    TxtLblCostosIndirectos.Nombre = "";
                    TxtLblCostosIndirectos.Borrar();

                    XtraMessageBox.Show("El código debe ser una cuenta auxiliar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        public bool Validar()
        {
            bool retorno = true;
            if (String.IsNullOrEmpty(TxtLblCodigo.Codigo) )
            {
                retorno = false;
                XtraMessageBox.Show("El codigo no puede quedar vacío", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLblCodigo.Focus();
            }

            if (ChkDepreciar.Checked == true)
            {
                if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToInt32(TxtTiempoAdicionar.Text) == 0)
                {
                    retorno = false;
                    XtraMessageBox.Show("Defina el Tiempo a Depreciar", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtTiempoAdicionar.Focus();
                }

                if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToInt32(TxtTiempoAdicionar.Text) > 0
                && String.IsNullOrEmpty(TxtLblGastoDepre.Codigo))
                {
                    retorno = false;
                    XtraMessageBox.Show("Debe Digitar el Código Contable", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtLblGastoDepre.Focus();
                }

                if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToInt32(TxtTiempoAdicionar.Text) > 0
                && !String.IsNullOrEmpty(TxtLblGastoDepre.Codigo) && String.IsNullOrEmpty(TxtLblDepreAcum.Codigo))//
                {
                    retorno = false;
                    XtraMessageBox.Show("Debe Digitar el Código Contable", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtLblDepreAcum.Focus();
                }
            }

            return retorno;
        }

        public void Guardar()
        {
            if (Validar())
            {
                if (Modo != "E")
                {
                    Nuevo();
                }
                else
                {
                    Editando();
                }
            }
        }

        public void Nuevo()
        {
            int tacdepre = 0;
            if (ChkDepreciar.Checked == true)
            {
                tacdepre = 1;
            }

            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "I"),
            new SqlParameter("@tacpuc", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@tacnom", TxtLblCodigo.Nombre),
            new SqlParameter("@tactiempo", TxtTiempoAdicionar.EditValue),
            new SqlParameter("@tacdepre", tacdepre),
            new SqlParameter("@tacgastos", TxtLblGastoDepre.Codigo ?? ""),
            new SqlParameter("@tacdepre_aa", TxtLblDepreAcum.Codigo ?? ""),
            new SqlParameter("@tacproductoPr", TxtLblProducotEnP.Codigo ?? ""),
            new SqlParameter("@pacCostoInd", TxtLblCostosIndirectos.Codigo ?? "") };

            bool IsDone = DataBase.ExecuteNonQuery("PA_TipoActivo", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Editando()
        {
            int tacdepre = 0;
            if (ChkDepreciar.Checked == true)
            {
                tacdepre = 1;
            }
            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "U"),
            new SqlParameter("@tacpuc", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@tacnom", TxtLblCodigo.Nombre),
            new SqlParameter("@tactiempo", TxtTiempoAdicionar.EditValue),
            new SqlParameter("@tacdepre", tacdepre),
            new SqlParameter("@tacgastos", TxtLblGastoDepre.Codigo ?? ""),
            new SqlParameter("@tacdepre_aa", TxtLblDepreAcum.Codigo ?? ""),
            new SqlParameter("@tacproductoPr", TxtLblProducotEnP.Codigo ?? ""),
            new SqlParameter("@pacCostoInd", TxtLblCostosIndirectos.Codigo ?? "") };

            bool IsDone = DataBase.ExecuteNonQuery("PA_TipoActivo", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        #endregion

        #region Eventos

        private void FrmGetTipoActivo_Load(object sender, EventArgs e)
        {
            TxtLblCodigo.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblCodigo.database = Database;
            TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblCodigo.Usuario = Usuario;
            TxtLblCodigo.PasarUsuario = true;

            TxtLblGastoDepre.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblGastoDepre.database = Database;
            TxtLblGastoDepre.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblGastoDepre.Usuario = Usuario;
            TxtLblGastoDepre.PasarUsuario = true;

            TxtLblDepreAcum.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblDepreAcum.database = Database;
            TxtLblDepreAcum.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblDepreAcum.Usuario = Usuario;
            TxtLblDepreAcum.PasarUsuario = true;

            TxtLblProducotEnP.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblProducotEnP.database = Database;
            TxtLblProducotEnP.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblProducotEnP.Usuario = Usuario;
            TxtLblProducotEnP.PasarUsuario = true;

            TxtLblCostosIndirectos.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblCostosIndirectos.database = Database;
            TxtLblCostosIndirectos.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblCostosIndirectos.Usuario = Usuario;
            TxtLblCostosIndirectos.PasarUsuario = true;

            if (Modo == "E")
            {
                SqlParameter[] par = new [] {   new SqlParameter("@Operacion", "S"),
                new SqlParameter("@tacpuc", ID) };

                DataSet ds = DataBase.ExecuteQuery("PA_TipoActivo", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(Database, null));

                this.Text = "Editando";

                TxtLblCodigo.Codigo = ds.Tables[0].Rows[0]["tacpuc"].ToString();
                TxtLblCodigo.Edit();
                TxtLblCodigo.Disable();

                ChkDepreciar.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["tacdepre"]);
                TxtTiempoAdicionar.Text = ds.Tables[0].Rows[0]["tactiempo"].ToString();

                TxtLblGastoDepre.Codigo = ds.Tables[0].Rows[0]["tacgastos"].ToString();
                TxtLblGastoDepre.Edit();

                TxtLblDepreAcum.Codigo = ds.Tables[0].Rows[0]["tacdepre_aa"].ToString();
                TxtLblDepreAcum.Edit();

                TxtLblProducotEnP.Codigo = ds.Tables[0].Rows[0]["tacproductoPr"].ToString();
                TxtLblProducotEnP.Edit();

                TxtLblCostosIndirectos.Codigo = ds.Tables[0].Rows[0]["pacCostoInd"].ToString();
                TxtLblCostosIndirectos.Edit();
            }
        }

        private void ChkDepreciar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDepreciar.Checked == true)
            {
                TxtTiempoAdicionar.Enabled = true;
            }
            else
            {
                TxtTiempoAdicionar.Enabled = false;
                TxtTiempoAdicionar.Text = "";
            }
        }

        private void TxtTiempoAdicionar_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(TxtTiempoAdicionar.Text) < 0)
            {
                TxtTiempoAdicionar.Text = "1";
            }
        }

        private void TxtLblCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!AuxiliarCodigo())
            {
                TxtLblCodigo.Focus();               
            }

            if (Modo !="E")
            {
                if (ExisteTipoActivo())
                {
                    TxtLblCodigo.Focus();
                } 
            }
        }

        private void TxtLblGastoDepre_Validating(object sender, CancelEventArgs e)
        {
            if (!AuxiliarGastoDepre())
            {
                TxtLblGastoDepre.Focus();
            }
        }

        private void TxtLblDepreAcum_Validating(object sender, CancelEventArgs e)
        {
            if (!AuxiliarDepreCum())
            {
                TxtLblDepreAcum.Focus();
            }
        }

        private void TxtLblProducotEnP_Validating(object sender, CancelEventArgs e)
        {
            if (!AuxiliarProducotEnP())
            {
                TxtLblProducotEnP.Focus();
            }
        }

        private void TxtLblCostosIndirectos_Validating(object sender, CancelEventArgs e)
        {
            if (!AuxiliarCostosIndirectos())
            {
                TxtLblCostosIndirectos.Focus();
            }
        }

        #endregion

    }


}
