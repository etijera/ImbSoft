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
    public partial class FrmGetTarifaIva : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }

        #endregion

        #region Metodos

        public FrmGetTarifaIva()
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

            if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToDecimal(TxtTarifa.EditValue) == 0)
            {
                retorno = false;
                XtraMessageBox.Show("Debe digitar la tarifa", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTarifa.Focus();
            }

            if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToDecimal(TxtTarifa.EditValue) > 0 && RgbTipo.SelectedIndex == -1)
            {
                retorno = false;
                XtraMessageBox.Show("Debe seleccionar un tipo", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RgbTipo.Focus();
            }

            if (!String.IsNullOrEmpty(TxtLblCodigo.Codigo) && Convert.ToDecimal(TxtTarifa.EditValue) > 0
            && RgbTipo.SelectedIndex != -1 && RgbModalidad.SelectedIndex == -1)
            {
                retorno = false;
                XtraMessageBox.Show("Debe seleccionar una modalidad", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RgbModalidad.Focus();
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

            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "ITI"),
            new SqlParameter("@Codigo", ID ?? ""),
            new SqlParameter("@Modalidad", RgbModalidad.SelectedIndex + 1),
            new SqlParameter("@TipoRetencion", RgbTipo.SelectedIndex + 1),
            new SqlParameter("@PorcentajeRetencion", Funciones.getInstancia().FormatearValorDecimal(TxtTarifa.EditValue.ToString())) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            // XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Editando()
        {
            SqlParameter[] parametros1 = new [] {    new SqlParameter("@Operacion", "UTI"),
            new SqlParameter("@Codigo", ID ?? ""),
            new SqlParameter("@Modalidad", RgbModalidad.SelectedIndex + 1),
            new SqlParameter("@TipoRetencion", RgbTipo.SelectedIndex + 1),
            new SqlParameter("@PorcentajeRetencion", Funciones.getInstancia().FormatearValorDecimal(TxtTarifa.EditValue.ToString())) };

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con exito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        #endregion

        #region Eventos


        private void FrmGetTarifaIva_Load(object sender, EventArgs e)
        {
            TxtLblCodigo.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblCodigo.database = Database;
            TxtLblCodigo.Ordenar = OrdenarPor.CampoCodigo;

            if (Modo == "E")
            {
                SqlParameter[] par = new [] {   new SqlParameter("@Operacion", "STI"),
                new SqlParameter("@Codigo", ID) };

                DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(Database, null));

                this.Text = "Editando";

                TxtLblCodigo.Codigo = ds.Tables[0].Rows[0]["Codigo"].ToString();
                TxtLblCodigo.Edit();

                RgbModalidad.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0]["Modalidad"]) - 1;
                RgbTipo.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0]["TipoRetencion"]) - 1;

                TxtTarifa.Text = ds.Tables[0].Rows[0]["PorcentajeRetencion"].ToString();

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
