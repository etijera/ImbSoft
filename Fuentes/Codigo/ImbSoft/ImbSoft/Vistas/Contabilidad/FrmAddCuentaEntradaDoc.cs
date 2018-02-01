using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Referencias;
using Referencias.Properties;
using UsuarioControles;
using DevExpress.XtraEditors;

namespace Contabilidad
{
    public partial class FrmAddCuentaEntradaDoc : FormularioBase
    {

        #region Propiedades

        public string Database { get; set; }
        public string Usuario { get; set; }
        public string Auxiliar { get; set; }
        public string NomAux { get; set; }
        public string Tercero { get; set; }
        public string NomTer { get; set; }
        public string numOT { get; set; }
        public string DetOT { get; set; }
        public string Ccosto { get; set; }
        public string NomCcos { get; set; }
        public double Debito { get; set; }
        public double Credito { get; set; }
        public string Detalle { get; set; }
        public string Tipo { get; set; }
                
        #endregion

        #region Variables

        #endregion

        #region Métodos

        public FrmAddCuentaEntradaDoc()
        {
            InitializeComponent();
        }

        public void Aceptar()
        {
            if (string.IsNullOrEmpty(TxtLblAuxiliar.Codigo))
            {
                XtraMessageBox.Show("Debe ingresar el Auxiliar", "General Ledger",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                TxtLblAuxiliar.Focus();
                return;
            }
            if (txtLblOT.Enabled == true && string.IsNullOrEmpty(txtLblOT.Codigo))
            {
                if (Tipo == "CT")
                {

                    XtraMessageBox.Show("Debe ingresar el CT", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    XtraMessageBox.Show("Debe ingresar la OT", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txtLblOT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtLblTercero.Codigo))
            {
                XtraMessageBox.Show("Debe ingresar el Tercero", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLblTercero.Focus();
                return;
            }

            if (Convert.ToDouble(TxtDebito.EditValue) > 0 && Convert.ToDouble(txtCredito.EditValue) > 0)
            {
                XtraMessageBox.Show("¡Debe ingresar el valor en una sola opcion. Debe ó Haber!", "General Ledger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDebito.EditValue = 0;
                txtCredito.EditValue = 0;
                TxtDebito.Focus();
                return;             
                
            }

            Auxiliar = TxtLblAuxiliar.Codigo.Trim();
            NomAux = TxtLblAuxiliar.Nombre.Trim();
            numOT = string.IsNullOrEmpty(txtLblOT.Codigo) ? "" : txtLblOT.Codigo.Trim();
            DetOT = string.IsNullOrEmpty(txtLblOT.Nombre) ? "" : txtLblOT.Nombre.Trim();
            Tercero = txtLblTercero.Codigo.Trim();
            NomTer = txtLblTercero.Nombre.Trim();
            Debito = Convert.ToDouble(TxtDebito.EditValue);
            Credito = Convert.ToDouble(txtCredito.EditValue);
            DataTable dtRCcosto = DataBase.ExecuteQueryDataTable("SELECT glcct FROM accglpuc WHERE glcod='" + Auxiliar + "'", "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

            if (Tipo=="OT")
            {
                if (dtRCcosto.Rows[0][0].ToString().Trim() == "1" && !string.IsNullOrEmpty(numOT))
                {
                    DataTable dtCcosto = DataBase.ExecuteQueryDataTable("select ccocod,cconom from procencos inner join ordenes on ordenes.OrdCCO = procencos.ccocod where ordnro = '" + numOT + "'", "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
                    Ccosto = dtCcosto.Rows[0][0].ToString().Trim() ?? "";
                    NomCcos = dtCcosto.Rows[0][1].ToString().Trim() ?? "";
                }
                else
                {
                    Ccosto = ""; NomCcos = "";
                }
            }
            else
            {
                Ccosto = ""; NomCcos = "";
            }

            if (string.IsNullOrEmpty(Detalle)) 
            { 
                Detalle = NomAux; 
            }
            DialogResult = DialogResult.OK;
            
            
        }

        public void Cancelar()
        {
            this.Close();
        }

        public void CambiarCaption()
        {
            labelControl36.Text = "DO";
        }

        private void BuscarTerceroCt()
        {
            string sql = String.Format("SELECT accglTer.tercod FROM ImbContratosPropietario INNER JOIN accglTer ON accglTer.ternit = ImbContratosPropietario.NitPropietario WHERE ImbContratosPropietario.NumeContrato = '{0}'", txtLblOT.Codigo.Trim());
            DataTable dt = DataBase.ExecuteQueryDataTable(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

            if (dt.Rows.Count>0)
            {
                txtLblTercero.Codigo = dt.Rows[0]["tercod"].ToString().Trim();
                txtLblTercero.Edit();

                txtLblTercero.Disable();
                TxtDebito.Focus();
            }

        }

        #endregion

        #region Eventos

        private void FrmAddCuentaEntradaDoc_Load(object sender, EventArgs e)
        {
            Tipo = Tipo ?? "OT";

            TxtLblAuxiliar.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblAuxiliar.database = Database;
            TxtLblAuxiliar.Usuario = Usuario;
            TxtLblAuxiliar.DesHabilitarBtnAñadir = true;
            TxtLblAuxiliar.DesHabilitarBtnEditar = true;
            TxtLblAuxiliar.DesHabilitarBtnEliminar = true;
            TxtLblAuxiliar.DesHabilitarBtnExcel = true;
            TxtLblAuxiliar.DesHabilitarBtnGuardar = true;
            TxtLblAuxiliar.DesHabilitarBtnImprimir = true;
            TxtLblAuxiliar.Ordenar = OrdenarPor.CampoCodigo;

            if (Tipo=="CT")
            {
                txtLblOT.PerfilShow = Perfilador.getInstancia().CargarPerfil("CT");
                labelControl36.Text = "CT:";
            }
            else
            {
                txtLblOT.PerfilShow = Perfilador.getInstancia().CargarPerfil("OT");
            }

            txtLblOT.database = Database;
            txtLblOT.Usuario = Usuario;
            txtLblOT.DesHabilitarBtnAñadir = true;
            txtLblOT.DesHabilitarBtnEditar = true;
            txtLblOT.DesHabilitarBtnEliminar = true;
            txtLblOT.DesHabilitarBtnExcel = true;
            txtLblOT.DesHabilitarBtnGuardar = true;
            txtLblOT.DesHabilitarBtnImprimir = true;
            txtLblOT.Ordenar = OrdenarPor.CampoId; 

            txtLblTercero.PerfilShow = Perfilador.getInstancia().CargarPerfil("Terceros");
            txtLblTercero.database = Database;
            txtLblTercero.Usuario = Usuario;
            txtLblTercero.DesHabilitarBtnAñadir = true;
            txtLblTercero.DesHabilitarBtnEditar = true;
            txtLblTercero.DesHabilitarBtnEliminar = true;
            txtLblTercero.DesHabilitarBtnExcel = true;
            txtLblTercero.DesHabilitarBtnGuardar = true;
            txtLblTercero.DesHabilitarBtnImprimir = true;

            txtCredito.EditValue = (double)0;
            TxtDebito.EditValue = (double)0;        
        }

        private void TxtLblAuxiliar_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtLblAuxiliar.Codigo))
            {
                if (TxtLblAuxiliar.Codigo.Length <= 6)
                {
                    XtraMessageBox.Show("La cuenta seleccionada de debe ser una cuenta auxiliar", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtLblAuxiliar.Focus();
                    return;
                }

                int reqOT = Convert.ToInt32(Funciones.getInstancia().GetName(Database, "accglPUC", "glOT", "glcod = '" + TxtLblAuxiliar.Codigo + "'"));

                if (reqOT == 1)
                {
                    txtLblOT.Enabled = true;
                }
                else
                {
                    txtLblOT.Enabled = false;
                }

            }
        }

        #endregion

        private void txtLblOT_Validated(object sender, EventArgs e)
        {
            if (Tipo == "CT")
            {
                if (!String.IsNullOrEmpty(txtLblOT.Codigo))
                {
                    BuscarTerceroCt();
                }
                else
                {
                    txtLblTercero.Codigo = "";
                    txtLblTercero.Borrar();

                    txtLblTercero.Enable();
                }
               
            }
        }
                     
    }
}
