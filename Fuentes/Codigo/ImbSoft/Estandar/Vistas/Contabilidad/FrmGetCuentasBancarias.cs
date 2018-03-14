using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Referencias;
using System.Data.SqlClient;
using UsuarioControles;

namespace Estandar.Vistas.Contabilidad
{
    public partial class FrmGetCuentasBancarias : FormularioBase
    {

        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }

        #endregion

        #region Metodos

        public FrmGetCuentasBancarias()
        {
            InitializeComponent();
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

            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "ICB"),
            new SqlParameter("@Codigo", ID ?? ""),
            //new SqlParameter("@GlPlano", TxtLblArchivoDisfon.Codigo ?? ""),
            new SqlParameter("@Cheque", TxtUltimoCheque.Texto.Trim()),
            new SqlParameter("@Gravamen", ChkGravamen.Checked) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Editando()
        {
            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "UCB"),
            new SqlParameter("@Codigo", ID ?? ""),
            //new SqlParameter("@GlPlano", TxtLblArchivoDisfon.Codigo ?? ""),
            new SqlParameter("@Cheque", TxtUltimoCheque.Texto.Trim()),
            new SqlParameter("@Gravamen", ChkGravamen.Checked) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
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

        #endregion

        #region Eventos

        private void FrmGetCuentasBancarias_Load(object sender, EventArgs e)
        {
            TxtLblCodigo.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblCodigo.database = Database;
            TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;

            //TxtLblArchivoDisfon.PerfilShow = Perfilador.getInstancia().CargarPerfil("Disfon");
            //TxtLblArchivoDisfon.database = Database;
            //TxtLblArchivoDisfon.Ordenar = OrdenarPor.CampoCodigo;

            if (Modo == "E")
            {
                SqlParameter[] par = new [] {   new SqlParameter("@Operacion", "SCB"),
                new SqlParameter("@Codigo", ID) };

                DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(Database, null));

                cabeceraForm1.NombreCabecera = "Editando";

                TxtLblCodigo.Codigo = ds.Tables[0].Rows[0]["Codigo"].ToString();
                TxtLblCodigo.Edit();

                //TxtLblArchivoDisfon.Codigo = ds.Tables[0].Rows[0]["glPlano"].ToString();
                //TxtLblArchivoDisfon.Edit();

                TxtUltimoCheque.Texto = ds.Tables[0].Rows[0]["Cheque"].ToString();
                ChkGravamen.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Gravamen"]);

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

        #endregion
    }
}
