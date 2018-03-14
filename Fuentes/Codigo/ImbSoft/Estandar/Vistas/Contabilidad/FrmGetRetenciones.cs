using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Referencias;
using UsuarioControles;

namespace Estandar.Vistas.Contabilidad
{
    public partial class FrmGetRetenciones : FormularioBase
    {
        /// <summary>
        /// Nombre de la base de datos.
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Define el tipo de acciones (reteica, reteiva, retecree, retefte)
        /// </summary>
        public string OpcionGet { get; set; }

        /// <summary>
        /// N para crear.
        /// E para editar.
        /// </summary>
        public string Modo { get; set; }

        /// <summary>
        /// Define el código PUC.
        /// </summary>
        public string ID { get; set; }

        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmGetRetenciones()
        {
            InitializeComponent();
            acceptCancel1.Maceptar = "BtnAceptar";
        }

        public void BtnAceptar()
        {
            switch (OpcionGet)
            {
                case "retefte":
                    AccionesReteFte();
                    break;
                case "reteica":
                    AccionesReteIca();
                    break;
                case "reteiva":
                    AccionesReteIva();
                    break;
                case "retecree":
                    AccionesReteCree();
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void AccionesReteFte()
        {

            if (Modo.Equals("N"))
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "INSRETEFTE"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteFuente    ", "Registro exitoso.");
            }
            else
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDRETEFTE"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };
                alertControl1.Show(this, "ReteFuente", "Actualización exitosa.");
                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            }
        }

        private void AccionesReteIca()
        {

            if (Modo.Equals("N"))
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "INSRETEICA"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteICA", "Registro exitoso.");
            }
            else
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDRETEICA"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteICA", "Actualización exitosa.");
            }
        }

        private void AccionesReteIva()
        {

            if (Modo.Equals("N"))
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "INSRETEIVA"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteIVA", "Registro exitoso.");
            }
            else
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDRETEIVA"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteIVA", "Actualización exitosa.");
            }
        }

        private void AccionesReteCree()
        {

            if (Modo.Equals("N"))
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "INSRETECREE"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "RetCREE", "Registro exitoso.");
            }
            else
            {
                SqlParameter[] parametros1 = new [] { new SqlParameter("@Operacion", "UPDRETECREE"),
                new SqlParameter("@CodigoPuc", ID),
                new SqlParameter("@Nombre", TxtLblCuenta.Nombre),
                new SqlParameter("@Monto", TxtMonto.Value),
                new SqlParameter("@Porcentaje", TxtPorcentaje.Value),
                new SqlParameter("@Tipo", (rgTipo.SelectedIndex == 0) ? "1" : "2")
                };

                DataBase.ExecuteNonQuery("[Contabilidad].[PA_Retenciones]", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                alertControl1.Show(this, "ReteCREE", "Actualización exitosa.");
            }
        }

        private void LlenarCamposReteFte()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETRETEFTE"),
            new SqlParameter("@CodigoPuc", ID) };

            DataTable dsCods = new DataTable();

            dsCods = DataBase.ExecuteQueryDataTable("[Contabilidad].[PA_Retenciones]", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dsCods.Rows.Count != 0)
            {
                String porc = Convert.ToDouble(dsCods.Rows[0]["Porcentaje"].ToString()).ToString();

                String tipo = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Tipo"].ToString())).ToString();

                if (tipo == "1")
                {
                    rgTipo.SelectedIndex = 0;
                }
                else
                    if (tipo == "2")
                    {
                        rgTipo.SelectedIndex = 1;
                    }

                TxtMonto.Texto = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Monto"].ToString())).ToString();
                TxtPorcentaje.Texto = porc;
            }

        }

        private void LlenarCamposReteIca()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETRETEICA"),
            new SqlParameter("@CodigoPuc", ID) };

            DataTable dsCods = new DataTable();

            dsCods = DataBase.ExecuteQueryDataTable("[Contabilidad].[PA_Retenciones]", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dsCods.Rows.Count != 0)
            {
                String porc = Convert.ToDouble(dsCods.Rows[0]["Porcentaje"].ToString()).ToString();

                String tipo = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Tipo"].ToString())).ToString();

                if (tipo == "1")
                {
                    rgTipo.SelectedIndex = 0;
                }
                else
                    if (tipo == "2")
                    {
                        rgTipo.SelectedIndex = 1;
                    }

                TxtMonto.Texto = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Monto"].ToString())).ToString();
                TxtPorcentaje.Texto = porc;
            }
        }

        private void LlenarCamposReteIva()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETRETEIVA"),
            new SqlParameter("@CodigoPuc", ID) };

            DataTable dsCods = new DataTable();

            dsCods = DataBase.ExecuteQueryDataTable("[Contabilidad].[PA_Retenciones]", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dsCods.Rows.Count != 0)
            {
                String porc = Convert.ToDouble(dsCods.Rows[0]["Porcentaje"].ToString()).ToString();

                String tipo = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Tipo"].ToString())).ToString();

                if (tipo == "1")
                {
                    rgTipo.SelectedIndex = 0;
                }
                else
                    if (tipo == "2")
                    {
                        rgTipo.SelectedIndex = 1;
                    }

                TxtMonto.Texto = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Monto"].ToString())).ToString();
                TxtPorcentaje.Texto = porc;
            }
        }

        private void LlenarCamposReteCree()
        {
            SqlParameter[] parametros = new [] { new SqlParameter("@Operacion", "GETRETECREE"),
            new SqlParameter("@CodigoPuc", ID) };

            DataTable dsCods = new DataTable();

            dsCods = DataBase.ExecuteQueryDataTable("[Contabilidad].[PA_Retenciones]", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dsCods.Rows.Count != 0)
            {
                String porc = Convert.ToDouble(dsCods.Rows[0]["Porcentaje"].ToString()).ToString();

                String tipo = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Tipo"].ToString())).ToString();

                if (tipo == "1")
                {
                    rgTipo.SelectedIndex = 0;
                }
                else
                    if (tipo == "2")
                    {
                        rgTipo.SelectedIndex = 1;
                    }

                TxtMonto.Texto = Convert.ToInt32(Convert.ToDouble(dsCods.Rows[0]["Monto"].ToString())).ToString();
                TxtPorcentaje.Texto = porc;
            }
        }

        private void ValidateData()
        {
            if (String.IsNullOrEmpty(TxtLblCuenta.Codigo))
            {
                errorP1.SetError(TxtLblCuenta, "El campo es obligatorio.");
            }
            else
            {
                errorP1.SetError(TxtLblCuenta, "");
            }

            if (TxtPorcentaje.Value.ToString() == "0" || TxtPorcentaje.Value == null)
            {
                errorP1.SetError(TxtPorcentaje, "Debe especificar un porcentaje.");
            }
            else
            {
                errorP1.SetError(TxtPorcentaje, "");
            }

            if (!String.IsNullOrEmpty(TxtLblCuenta.Codigo)
            && (TxtPorcentaje.Value.ToString() != "0" && TxtPorcentaje.Value != null))
            {
                acceptCancel1.HabilitarAceptar = true;
            }
            else
            {
                acceptCancel1.HabilitarAceptar = false;
            }
        }

        private void FrmGetRetenciones_Load(object sender, EventArgs e)
        {
            TxtLblCuenta.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            TxtLblCuenta.database = Database;
            TxtLblCuenta.DesHabilitarBtnExcel = true;
            TxtLblCuenta.DesHabilitarBtnGuardar = true;
            TxtLblCuenta.DesHabilitarBtnImprimir = true;
            TxtLblCuenta.DesHabilitarBtnAñadir = true;
            TxtLblCuenta.DesHabilitarBtnEditar = true;
            TxtLblCuenta.Ordenar = OrdenarPor.CampoCodigo;

            //Asignar el formato texto 
            TxtMonto.AsignarTipoFormatoNumerico();
            TxtPorcentaje.AsignarTipoFormatoNumerico();
            //Nombrar metodos para los eventos
            TxtMonto.MSpin = "TxtMonto_Spin";
            TxtPorcentaje.MTextChanged = "TxtPorcentaje_TextChanged";
            TxtPorcentaje.MSpin = "TxtPorcentaje_Spin";

            TxtLblCuenta.Codigo = (ID ?? "");
            TxtLblCuenta.Edit();

            if (Modo.Equals("E"))
            {
                switch (OpcionGet)
                {
                    case "retefte":
                        Text = "Editar Retención en la Fuente por Renta";
                        LlenarCamposReteFte();
                        break;
                    case "reteica":
                        Text = "Editar Retención en la Fuente por ICA";
                        LlenarCamposReteIca();
                        break;
                    case "reteiva":
                        Text = "Editar Retención en la Fuente por IVA";
                        LlenarCamposReteIva();
                        break;
                    case "retecree":
                        Text = "Editar Retención en la Fuente por CREE";
                        LlenarCamposReteCree();
                        break;
                }
            }
            else
            {
                switch (OpcionGet)
                {
                    case "retefte":
                        Text = "Nueva Retención en la Fuente por Renta";
                        break;
                    case "reteica":
                        Text = "Nueva Retención en la Fuente por ICA";
                        break;
                    case "reteiva":
                        Text = "Nueva Retención en la Fuente por IVA";
                        break;
                    case "retecree":
                        Text = "Nueva Retención en la Fuente por CREE";
                        break;
                }

                TxtLblCuenta.Enabled = true;

            }

            ValidateData();
        }

        private void TxtLblCuenta_Validated(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void TxtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void TxtMonto_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtPorcentaje_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

    }
}
