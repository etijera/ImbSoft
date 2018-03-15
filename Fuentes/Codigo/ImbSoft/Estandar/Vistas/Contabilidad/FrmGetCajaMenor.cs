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
    public partial class FrmGetCajaMenor : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }

        #endregion

        #region Metodos

        public FrmGetCajaMenor()
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

            if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && String.IsNullOrEmpty(TxtLblContrapartida.Codigo))
            {
                retorno = false;
                XtraMessageBox.Show("Debe ingresar una cuenta para la contrapartida", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLblContrapartida.Focus();
            }

            if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && !String.IsNullOrEmpty(TxtLblContrapartida.Codigo)
            && String.IsNullOrEmpty(TxtLblResponsable.Codigo))
            {
                retorno = false;
                XtraMessageBox.Show("Debe seleccionar un responsable", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLblResponsable.Focus();
            }

            return retorno;
        }

        public void Nuevo()
        {

            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "ICM"),
            new SqlParameter("@Codigo", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@ContraPartidaCajaMenor", TxtLblContrapartida.Codigo ?? ""),
            new SqlParameter("@ResponsableCajaMenor", TxtLblResponsable.Codigo ?? ""),
            new SqlParameter("@MontoCajaMenor", Funciones.getInstancia().FormatearValorDecimal(TxtMonto.Texto)) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            // XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Editando()
        {
            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "UCM"),
            new SqlParameter("@Codigo", TxtLblCodigo.Codigo ?? ""),
            new SqlParameter("@ContraPartidaCajaMenor", TxtLblContrapartida.Codigo ?? ""),
            new SqlParameter("@ResponsableCajaMenor", TxtLblResponsable.Codigo ?? ""),
            new SqlParameter("@MontoCajaMenor", Funciones.getInstancia().FormatearValorDecimal(TxtMonto.Texto)) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        #endregion

        private void FrmGetCajaMenor_Load(object sender, EventArgs e)
        {
            TxtLblCodigo.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblCodigo.database = Database;
            TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;

            TxtLblContrapartida.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblContrapartida.database = Database;
            TxtLblContrapartida.Ordenar = OrdenarPor.CampoCodigo;

            TxtLblResponsable.PerfilShow = Perfilador.getInstancia().CargarPerfil("Terceros");
            TxtLblResponsable.database = Database;
            TxtLblResponsable.Ordenar = OrdenarPor.CampoNombre;
            
            //Asignar el formato texto al txtMonto
            TxtMonto.AsignarTipoFormatoNumerico();

            if (Modo == "E")
            {
                SqlParameter[] par = new [] {   new SqlParameter("@Operacion", "SCM"),
                new SqlParameter("@Codigo", ID) };

                DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(Database, null));

                cabeceraForm1.NombreCabecera = "Editando";
                cabeceraForm1.Width = cabeceraForm1.Width - 1;
                cabeceraForm1.Width = cabeceraForm1.Width + 1;

                TxtLblCodigo.Codigo = ds.Tables[0].Rows[0]["Codigo"].ToString();
                TxtLblCodigo.Edit();

                TxtLblContrapartida.Codigo = ds.Tables[0].Rows[0]["ContraPartidaCajaMenor"].ToString();
                TxtLblContrapartida.Edit();

                TxtLblResponsable.Codigo = ds.Tables[0].Rows[0]["ResponsableCajaMenor"].ToString();
                TxtLblResponsable.Edit();

                TxtMonto.Texto = ds.Tables[0].Rows[0]["MontoCajaMenor"].ToString();

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

        private void TxtLblContrapartida_Validating(object sender, CancelEventArgs e)
        {
            if (!Funciones.getInstancia().Auxiliar(TxtLblContrapartida.Codigo))
            {
                TxtLblContrapartida.Codigo = "";
                TxtLblContrapartida.Borrar();
                TxtLblContrapartida.Focus();
            }
        }

    }
}
