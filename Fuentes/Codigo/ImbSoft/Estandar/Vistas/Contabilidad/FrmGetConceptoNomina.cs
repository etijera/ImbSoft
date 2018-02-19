using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Referencias;
using UsuarioControles;

namespace Estandar.Vistas.Contabilidad
{
    public partial class FrmGetConceptoNomina : FormularioBase
    {
        public string OpcionGet { get; set; }
        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }
        public String Usuario { get; set; }

        public FrmGetConceptoNomina()
        {
            InitializeComponent();
            acceptCancel1.Maceptar = "BtnAceptar";
        }

        public void DeshabilitarCuenta()
        {
            TxtLblCuenta.Disable();
        }

        public void BtnAceptar()
        {
            AccionesConceptos();
        }

        private String MaxCodigoConcepto()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETMAXCON") };

            DataSet dsCods = new DataSet();

            dsCods = DataBase.ExecuteQuery("PA_REGEMP", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            String maxCod = "0";

            if (dsCods.Tables.Count != 0)
            {
                maxCod = dsCods.Tables[0].Rows[0][0].ToString();
            }

            if (maxCod == "")
            {
                maxCod = "00";
            }

            return maxCod;
        }

        private void AccionesConceptos()
        {
            String Aplicar = "0";

            switch (rgAplicar.SelectedIndex)
            {
                case 0:
                    Aplicar = "1";
                    break;
                case 1:
                    Aplicar = "2";
                    break;
                case 2:
                    Aplicar = "4";
                    break;
                case 3:
                    Aplicar = "5";
                    break;
                case 4:
                    Aplicar = "3";
                    break;
            }

            String Tipo = "1";

            if (rgTipo.SelectedIndex == 1)
            {
                Tipo = "2";
            }

            if (TxtPorcentajeGravable.EditValue == null || TxtPorcentajeGravable.EditValue.ToString() == "")
            {
                TxtPorcentajeGravable.EditValue = "0";
            }

            TxtPorcentajeGravable.EditValue = TxtPorcentajeGravable.EditValue.ToString().Replace(',', '.');

            if (Modo.Equals("N"))
            {

                String nuevoCodCon = Funciones.getInstancia().RellenarCadenaPorLaIzquierda((MaxCodigoConcepto().ToInt() + 1).ToString(), '0', 4);

                SqlParameter[] parametros1;

                if (rgTipo.SelectedIndex == 0)
                {

                    parametros1 = new [] { new SqlParameter("@Operacion", "INSCONNOM"),
                    new SqlParameter("@concod", nuevoCodCon),
                    new SqlParameter("@connom", TxtConcepto.Text),
                    new SqlParameter("@conaux", TxtLblCuenta.Codigo ?? ""),
                    new SqlParameter("@concre", ""),
                    new SqlParameter("@conapli", Aplicar),
                    new SqlParameter("@contip", Tipo),
                    new SqlParameter("@consal", (ChkSeguridadSocial.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpri", (ChkARLParafiscales.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@convac", (ChkPrimasCesantias.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conret", (ChkRetenciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpvac", (ChkVacaciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpor", TxtPorcentajeGravable.EditValue) };
                }
                else
                {
                    parametros1 = new [] { new SqlParameter("@Operacion", "INSCONNOM"),
                    new SqlParameter("@concod", nuevoCodCon),
                    new SqlParameter("@connom", TxtConcepto.Text),
                    new SqlParameter("@conaux", ""),
                    new SqlParameter("@concre", TxtLblCuenta.Codigo ?? ""),
                    new SqlParameter("@conapli", Aplicar),
                    new SqlParameter("@contip", Tipo),
                    new SqlParameter("@consal", (ChkSeguridadSocial.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpri", (ChkARLParafiscales.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@convac", (ChkPrimasCesantias.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conret", (ChkRetenciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpvac", (ChkVacaciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpor", TxtPorcentajeGravable.EditValue) };
                }

                bool IsDone = DataBase.ExecuteNonQuery("PA_REGEMP", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

                if (IsDone)
                {
                    LimpiarCampos();
                    alertControl1.Show(this, "Conceptos de Nómina", "Registro exitoso.");
                }

            }
            else
            {

                if (rgTipo.SelectedIndex == 0)
                {
                    SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDCONNOM"),
                    new SqlParameter("@concod", ID),
                    new SqlParameter("@connom", TxtConcepto.Text),
                    new SqlParameter("@conaux", TxtLblCuenta.Codigo ?? ""),
                    new SqlParameter("@concre", ""),
                    new SqlParameter("@conapli", Aplicar),
                    new SqlParameter("@contip", Tipo),
                    new SqlParameter("@consal", (ChkSeguridadSocial.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpri", (ChkARLParafiscales.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@convac", (ChkPrimasCesantias.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conret", (ChkRetenciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpvac", (ChkVacaciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpor", TxtPorcentajeGravable.EditValue) };

                    DataBase.ExecuteNonQuery("PA_REGEMP", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

                }
                else
                {
                    SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDCONNOM"),
                    new SqlParameter("@concod", ID),
                    new SqlParameter("@connom", TxtConcepto.Text),
                    new SqlParameter("@conaux", ""),
                    new SqlParameter("@concre", TxtLblCuenta.Codigo ?? ""),
                    new SqlParameter("@conapli", Aplicar),
                    new SqlParameter("@contip", Tipo),
                    new SqlParameter("@consal", (ChkSeguridadSocial.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpri", (ChkARLParafiscales.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@convac", (ChkPrimasCesantias.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conret", (ChkRetenciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpvac", (ChkVacaciones.Checked == false) ? "0" : "1" ),
                    new SqlParameter("@conpor", TxtPorcentajeGravable.EditValue) };

                    DataBase.ExecuteNonQuery("PA_REGEMP", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

                }

                alertControl1.Show(this, "Conceptos de Nómina", "Actualización exitosa.");
                DialogResult = DialogResult.OK;
                Close();

            }
        }


        private void LimpiarCampos()
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = String.Empty;
                }

                if (c is DateEdit)
                {
                    ((DateEdit)c).Text = String.Empty;
                }

                if (c is ComboBoxEdit)
                {
                    ((ComboBoxEdit)c).Text = String.Empty;
                }

                if (c is TxtLblGeneral)
                {
                    ((TxtLblGeneral)c).Codigo = String.Empty;
                    ((TxtLblGeneral)c).Borrar();
                }

                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = String.Empty;
                }

                if (c is DateEdit)
                {
                    ((DateEdit)c).Text = String.Empty;
                }

                if (c is ComboBoxEdit)
                {
                    ((ComboBoxEdit)c).Text = String.Empty;
                }

                if (c is TxtLblGeneral)
                {
                    ((TxtLblGeneral)c).Codigo = String.Empty;
                    ((TxtLblGeneral)c).Borrar();
                }

                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }
            }

            foreach (Control c in panel3.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = String.Empty;
                }

                if (c is DateEdit)
                {
                    ((DateEdit)c).Text = String.Empty;
                }

                if (c is ComboBoxEdit)
                {
                    ((ComboBoxEdit)c).Text = String.Empty;
                }

                if (c is TxtLblGeneral)
                {
                    ((TxtLblGeneral)c).Codigo = String.Empty;
                    ((TxtLblGeneral)c).Borrar();
                }

                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }
            }

            foreach (Control c in panel4.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = String.Empty;
                }

                if (c is DateEdit)
                {
                    ((DateEdit)c).Text = String.Empty;
                }

                if (c is ComboBoxEdit)
                {
                    ((ComboBoxEdit)c).Text = String.Empty;
                }

                if (c is TxtLblGeneral)
                {
                    ((TxtLblGeneral)c).Codigo = String.Empty;
                    ((TxtLblGeneral)c).Borrar();
                }

                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }

                if (c is CheckEdit)
                {
                    ((CheckEdit)c).Checked = false;
                }
            }

            Validar();
            TxtConcepto.Focus();
        }

        private void Validar()
        {
            if (TxtConcepto.Text == "")
            {
                errorP1.SetError(TxtConcepto, "El campo es obligatorio");
            }
            else
            {
                errorP1.SetError(TxtConcepto, "");
            }

            if (TxtConcepto.Text != "")
            {
                acceptCancel1.HabilitarAceptar = true;
            }
            else
            {
                acceptCancel1.HabilitarAceptar = false;
            }

        }

        private void GetConceptoNomina_Load(object sender, EventArgs e)
        {
            TxtLblCuenta.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblCuenta.database = Database;
            TxtLblCuenta.DesHabilitarBtnExcel = true;
            TxtLblCuenta.DesHabilitarBtnGuardar = true;
            TxtLblCuenta.DesHabilitarBtnImprimir = true;
            TxtLblCuenta.DesHabilitarBtnAñadir = true;
            TxtLblCuenta.DesHabilitarBtnEditar = true;
            TxtLblCuenta.DesHabilitarBtnEliminar = true;
            TxtLblCuenta.Ordenar = OrdenarPor.CampoCodigo;
            TxtLblCuenta.Usuario = Usuario;

            if (Modo.Equals("E"))
            {
                Text = "Editar Concepto";
                LlenarCampos();
            }
            else
            {
                Text = "Nuevo Concepto";
            }

            Validar();
        }

        private void LlenarCampos()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETCONNOM"),
            new SqlParameter("@concod", ID) };

            DataTable dsCods = new DataTable();

            dsCods = DataBase.ExecuteQueryDataTable("PA_REGEMP", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dsCods.Rows[0]["Tipo"].ToString() == "1")
            {
                TxtLblCuenta.Codigo = dsCods.Rows[0]["CuentaDev"].ToString();
            }
            else
            {
                TxtLblCuenta.Codigo = dsCods.Rows[0]["CuentaDed"].ToString();
            }
            TxtConcepto.Text = dsCods.Rows[0]["Concepto"].ToString();
            TxtLblCuenta.Edit();

            switch (dsCods.Rows[0]["Aplica"].ToString())
            {
                case "1":
                    rgAplicar.SelectedIndex = 0;
                    break;
                case "2":
                    rgAplicar.SelectedIndex = 1;
                    break;
                case "3":
                    rgAplicar.SelectedIndex = 4;
                    break;
                case "4":
                    rgAplicar.SelectedIndex = 2;
                    break;
                case "5":
                    rgAplicar.SelectedIndex = 3;
                    break;
            }

            switch (dsCods.Rows[0]["Tipo"].ToString())
            {
                case "1":
                    rgTipo.SelectedIndex = 0;
                    break;
                case "2":
                    rgTipo.SelectedIndex = 1;
                    break;
            }

            String Seguridad = dsCods.Rows[0]["Seguridad"].ToString();

            if (Seguridad == "0")
            {
                ChkSeguridadSocial.Checked = false;
            }
            else
            {
                ChkSeguridadSocial.Checked = true;
            }

            String ARL = dsCods.Rows[0]["ARL"].ToString();

            if (ARL == "0")
            {
                ChkARLParafiscales.Checked = false;
            }
            else
            {
                ChkARLParafiscales.Checked = true;
            }

            String Primas = dsCods.Rows[0]["Primas"].ToString();

            if (Primas == "0")
            {
                ChkPrimasCesantias.Checked = false;
            }
            else
            {
                ChkPrimasCesantias.Checked = true;
            }

            String Retenciones = dsCods.Rows[0]["Retenciones"].ToString();

            if (Retenciones == "0")
            {
                ChkRetenciones.Checked = false;
            }
            else
            {
                ChkRetenciones.Checked = true;
            }

            String Vacaciones = dsCods.Rows[0]["Vacaciones"].ToString();

            if (Vacaciones == "0")
            {
                ChkVacaciones.Checked = false;
            }
            else
            {
                ChkVacaciones.Checked = true;
            }

            TxtPorcentajeGravable.Text = dsCods.Rows[0]["Porcentaje"].ToString();

        }
        private void ChkRetenciones_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRetenciones.Checked == true)
            {
                TxtPorcentajeGravable.Enabled = true;
            }
            else
            {
                TxtPorcentajeGravable.Enabled = false;
            }
        }

        private void rgTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgTipo.SelectedIndex == 0)
            {
                ChkARLParafiscales.Enabled = true;
                //ChkARLParafiscales.Checked = true;
                ChkPrimasCesantias.Enabled = true;
                //ChkPrimasCesantias.Checked = true;
                ChkRetenciones.Enabled = true;
                //ChkRetenciones.Checked = true;
                ChkSeguridadSocial.Enabled = true;
                //ChkSeguridadSocial.Checked = true;
                ChkVacaciones.Enabled = true;
                //ChkVacaciones.Checked = true;
            }
            else
            {
                ChkARLParafiscales.Enabled = false;
                ChkARLParafiscales.Checked = false;
                ChkPrimasCesantias.Enabled = false;
                ChkPrimasCesantias.Checked = false;
                ChkRetenciones.Enabled = false;
                ChkRetenciones.Checked = false;
                ChkSeguridadSocial.Enabled = false;
                ChkSeguridadSocial.Checked = false;
                ChkVacaciones.Enabled = false;
                ChkVacaciones.Checked = false;
            }
        }

        private void TxtConcepto_KeyUp(object sender, KeyEventArgs e)
        {
            Validar();
        }

        private void TxtLblCuenta_Validating(object sender, CancelEventArgs e)
        {
            if (TxtLblCuenta.Codigo != null)
            {
                if (TxtLblCuenta.Codigo != "")
                {
                    if (TxtLblCuenta.Codigo.Trim().Length < 6)
                    {
                        XtraMessageBox.Show("Debe escoger un código auxiliar.", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtLblCuenta.Codigo = "";
                        TxtLblCuenta.Borrar();
                        TxtLblCuenta.Focus();
                    }
                }

            }
        }

    }
}
