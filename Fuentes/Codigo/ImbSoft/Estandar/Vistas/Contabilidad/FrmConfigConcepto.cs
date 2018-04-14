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
    public partial class FrmConfigConcepto : FormularioBase
    {

        #region Propiedades

        public String Database { get; set; }
        public String Motivo { get; set; }

        #endregion

        #region Metodos

        /// <summary>FrmConfigConcepto()
        /// Constructor de la clase
        /// </summary>
        public FrmConfigConcepto()
        {
            InitializeComponent();
            txtLblConceptos.PerfilShow = Perfilador.getInstancia().CargarPerfil("ImbConceptos");
            txtLblConceptos.database = Database;

            txtLblConceptos.LblNomSize = new Size(334, 20);
            txtLblConceptos.OcultarBtnAñadir = true;
            txtLblConceptos.OcultarBtnEditar = true;
            txtLblConceptos.OcultarBtnEliminar = true;
            txtLblConceptos.OcultarBtnExcel = true;
            txtLblConceptos.OcultarBtnGuardar = true;
            txtLblConceptos.OcultarBtnImprimir = true;
        }

        /// <summary>Accept()
        /// Permite realizar la configuracion del concepto.
        /// </summary>
        public void Accept()
        {
            if (!String.IsNullOrEmpty(txtLblConceptos.Id)&&!String.IsNullOrEmpty(txtLblConceptos.Codigo))
            {
                if (!Consultar())
                {
                    SqlParameter[] parametros1 = new[] {      new SqlParameter("@Operacion","IC"),
                                                              new SqlParameter("@Codigo",txtLblConceptos.Id),
                                                              new SqlParameter("@CodigoConcepto",Motivo)};

                    DataBase.ExecuteNonQuery("PA_ImbConceptos", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

                    XtraMessageBox.Show("El concepto ha sido configurado satisfactoriamente", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult= DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("La configuración no se puede realizar, porque ya existe un concepto para < "+Motivo+" > configurado", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Debe ingresar un concepto", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>Consultar()
        /// Permite validar si los campos estan llenos antes de ejecutar la accion del boton aceptar
        /// </summary>
        /// <returns>Retorna true si ya existe un concepto configurado, y false si no existe</returns>
        public bool Consultar()
        {
            bool retorno = false;
            SqlParameter[] parametros1 = new[] {      new SqlParameter("@Operacion","SC"),
                                                      new SqlParameter("@CodigoConcepto",Motivo)};

            DataSet ds = DataBase.ExecuteQuery("PA_ImbConceptos", "datos", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
            if (ds.Tables[0].Rows.Count>0)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Eventos

        private void FrmConfigConcepto_Load(object sender, EventArgs e)
        {
            this.Text = "Configurar concepto para < " + Motivo + " >";
        }

        #endregion        
    }
}