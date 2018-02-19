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
    public partial class FrmGetTipoDiferidos : FormularioBase
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

        public FrmGetTipoDiferidos()
        {
            InitializeComponent();
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

        public bool Validar()
        {
            bool retorno = true;
            if (String.IsNullOrEmpty(TxtLblCodigo.Codigo))
            {
                retorno = false;
                XtraMessageBox.Show("El codigo no puede quedar vacío", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLblCodigo.Focus();
            }

            return retorno;
        }

        public void Nuevo()
        {

            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "I"),
            new SqlParameter("@DifPuc", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@DifNom", TxtLblCodigo.Nombre),
            new SqlParameter("@DifDebe", TxtLblDebito.Codigo ?? ""),
            new SqlParameter("@DifHaber", TxtLblCredito.Codigo ?? "") };

            bool IsDone = DataBase.ExecuteNonQuery("PA_PucTipoDiferido", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Editando()
        {
            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "U"),
            new SqlParameter("@DifPuc", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@DifNom", TxtLblCodigo.Nombre),
            new SqlParameter("@DifDebe", TxtLblDebito.Codigo ?? ""),
            new SqlParameter("@DifHaber", TxtLblCredito.Codigo ?? "") };
            //new SqlParameter("@DifPuc",ID??"")

            bool IsDone = DataBase.ExecuteNonQuery("PA_PucTipoDiferido", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        #endregion

        #region Eventos

        private void FrmGetTipoDiferidos_Load(object sender, EventArgs e)
        {
            TxtLblCodigo.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblCodigo.database = Database;
            TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblCodigo.Usuario = Usuario;
            TxtLblCodigo.PasarUsuario = true;

            TxtLblDebito.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblDebito.database = Database;
            TxtLblDebito.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblDebito.Usuario = Usuario;
            TxtLblDebito.PasarUsuario = true;

            TxtLblCredito.PerfilShow = Perfilador.getInstancia().CargarPerfil("PUC");
            TxtLblCredito.database = Database;
            TxtLblCredito.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblCredito.Usuario = Usuario;
            TxtLblCredito.PasarUsuario = true;

            if (Modo == "E")
            {
                SqlParameter[] par = new [] {   new SqlParameter("@Operacion", "S"),
                new SqlParameter("@DifPuc", ID) };

                DataSet ds = DataBase.ExecuteQuery("PA_PucTipoDiferido", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(Database, null));

                this.Text = "Editando";

                TxtLblCodigo.Codigo = ds.Tables[0].Rows[0]["DifPuc"].ToString();
                TxtLblCodigo.Edit();

                TxtLblDebito.Codigo = ds.Tables[0].Rows[0]["DifDebe"].ToString();
                TxtLblDebito.Edit();

                TxtLblCredito.Codigo = ds.Tables[0].Rows[0]["DifHaber"].ToString();
                TxtLblCredito.Edit();

                TxtLblCodigo.Disable();
            }

        }

        private void TxtLblCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!Funciones.getInstancia().Auxiliar(TxtLblCodigo.Codigo))
            {
                TxtLblCodigo.Codigo = "";
                TxtLblCodigo.Borrar();
                TxtLblCodigo.Focus();
            }
        }

        private void TxtLblDebito_Validating(object sender, CancelEventArgs e)
        {
            if (!Funciones.getInstancia().Auxiliar(TxtLblDebito.Codigo))
            {
                TxtLblDebito.Codigo = "";
                TxtLblDebito.Borrar();
                TxtLblDebito.Focus();
            }
        }

        private void TxtLblCredito_Validating(object sender, CancelEventArgs e)
        {
            if (!Funciones.getInstancia().Auxiliar(TxtLblCredito.Codigo))
            {
                TxtLblCredito.Codigo = "";
                TxtLblCredito.Borrar();
                TxtLblCredito.Focus();
            }
        }

        #endregion
    }
}
