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

namespace Estandar.Vistas
{
    public partial class FrmGetTercero : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public string Usuario { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }

        #endregion

        #region Variables        

        private string codCliente = "";
        private string codPropierio = "";
        private string delmrk = "";
        private string nit = "";

        #endregion

        #region Metodos

        public FrmGetTercero()
        {
            InitializeComponent();
        }


        public void LlenarDV()
        {
            if (!string.IsNullOrEmpty(TxtDocumentoId.Texto.Trim()))
            {
                DataTable dtDV = DataBase.ExecuteQueryDataTable("select DBO.Digito_Verificacion('" + TxtDocumentoId.Texto.Trim() + "')", "tabla", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
                if (dtDV.Rows.Count > 0) { TxtDV.Texto = dtDV.Rows[0][0].ToString().Trim(); }
            }
        }

        private bool  ValidateData()
        {
            bool aceptar = true;
            if (String.IsNullOrEmpty(TxtDocumentoId.Texto))
            {
                errorP2.SetError(TxtDocumentoId, "El campo es obligatorio.");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtDocumentoId, "");
            }

            if (String.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                errorP2.SetError(TxtRazonSocial, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtRazonSocial, "");
            }

            if (String.IsNullOrEmpty(TxtDireccion.Text))
            {
                errorP2.SetError(TxtDireccion, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtDireccion, "");
            }

            if (String.IsNullOrEmpty(TxtLblCiudad.Codigo))
            {
                errorP2.SetError(TxtLblCiudad, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtLblCiudad, "");
            }

            if (String.IsNullOrEmpty(TxtLblPais.Codigo))
            {
                errorP2.SetError(TxtLblPais, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtLblPais, "");
            }

            if (String.IsNullOrEmpty(TxtLblTipoProveedor.Codigo))
            {
                errorP2.SetError(TxtLblTipoProveedor, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtLblTipoProveedor, "");
            }

            if (String.IsNullOrEmpty(TxtLblTipoCliente.Codigo))
            {
                errorP2.SetError(TxtLblTipoCliente, "El campo es obligatorio");
                aceptar = false;
            }
            else
            {
                errorP2.SetError(TxtLblTipoCliente, "");
            }

           
            if (String.IsNullOrEmpty(TxtPrimerNombre.Text))
            {
                if (RgPersona.SelectedIndex == 1)
                {
                    errorP2.SetError(TxtPrimerNombre, "El campo es obligatorio");
                    aceptar = false;
                }
                else
                {
                    errorP2.SetError(TxtPrimerNombre, "");
                }
            }
            else
            {
                errorP2.SetError(TxtPrimerNombre, "");
            }

            //if (String.IsNullOrEmpty(TxtSegundoNombre.Text))
            //{
            //    if (RgPersona.SelectedIndex == 1)
            //    {
            //        errorP1.SetError(TxtSegundoNombre, "El campo es obligatorio");
            //        aceptar = false;
            //    }
            //    else
            //    {
            //        errorP1.SetError(TxtSegundoNombre, "");
            //    }
            //}
            //else
            //{
            //    errorP1.SetError(TxtSegundoNombre, "");
            //}

            //if (String.IsNullOrEmpty(TxtSegundoApellido.Text))
            //{
            //    if (RgPersona.SelectedIndex == 1)
            //    {
            //        errorP1.SetError(TxtSegundoApellido, "El campo es obligatorio");
            //        aceptar = false;
            //    }
            //    else
            //    {
            //        errorP1.SetError(TxtSegundoApellido, "");
            //    }
            //}
            //else
            //{
            //    errorP1.SetError(TxtSegundoApellido, "");
            //}

            if (String.IsNullOrEmpty(TxtPrimerApellido.Text))
            {
                if (RgPersona.SelectedIndex == 1)
                {
                    errorP2.SetError(TxtPrimerApellido, "El campo es obligatorio");
                    aceptar = false;
                }
                else
                {
                    errorP2.SetError(TxtPrimerApellido, "");
                }
            }
            else
            {
                errorP2.SetError(TxtPrimerApellido, "");
            }
            


            //if (TxtDocumentoId.Text != ""
            //&& TxtRazonSocial.Text != ""
            //&& TxtDireccion.Text != ""
            //&& !String.IsNullOrEmpty(TxtLblCiudad.Codigo)
            //&& !String.IsNullOrEmpty(TxtLblPais.Codigo))
            //{
            //    aceptar = true;
            //}
            //else
            //{
            //    aceptar = false;
            //}

            return aceptar; 
        }

        public void BuscarNit()
        {
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "EXISTPROP"),
                                                new SqlParameter("@clinit", TxtDocumentoId.Texto) };

            var cod = DataBase.ExecuteQueryDataTable("PA_ImbPropietario", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (cod.Rows.Count > 0)
            {
                ID = cod.Rows[0]["CodTer"].ToString();
                codCliente = cod.Rows[0]["CodCli"].ToString();
                codPropierio = cod.Rows[0]["CodPro"].ToString();
                delmrk = cod.Rows[0]["Delmrk"].ToString();
                Modo = "E";

                if (delmrk=="1")
                {
                    LlenarFormulario();
                }
                else
                {
                    if (XtraMessageBox.Show("Ya existe una persona en el sistema con esta identificación, puede que haya sido eliminada.\n Desea Recuperarla?", Referencias.Properties.Resources.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Modo = "E";
                        Recuperar();
                        LlenarFormulario();
                    }
                    else
                    {
                        TxtDocumentoId.Focus();
                    }
                }

            }
          
        }

        public void Recuperar()
        {
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "RECUPERAR"),
                                                new SqlParameter("@clinit", TxtDocumentoId.Texto) };
                
                bool ok = DataBase.ExecuteNonQuery("PA_ImbPropietario", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

        }

        private void LlenarFormulario()
        {

            if (Modo.Equals("E"))
            {
                Text = "Editar Propietario";

                SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "GETPRONIT"),
                new SqlParameter("@clinit", TxtDocumentoId.Texto) };
                DataTable dsCods = new DataTable();
                dsCods = DataBase.ExecuteQueryDataTable("PA_ImbPropietario", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

                if (dsCods.Rows.Count > 0)
                {
                    CboTipoDocumento.Text = dsCods.Rows[0]["tipDoc"].ToString();
                    TxtDocumentoId.Texto = dsCods.Rows[0]["ternit"].ToString();
                    TxtDV.Texto = dsCods.Rows[0]["digVer"].ToString();
                    if (Convert.ToInt32(dsCods.Rows[0]["terPersona"].ToString()) == 1)
                    {
                        RgPersona.SelectedIndex = 1;
                    }
                    else
                    {
                        RgPersona.SelectedIndex = 0;
                    }
                    radioGroup2_SelectedIndexChanged(null, null);

                    TxtRazonSocial.Text = dsCods.Rows[0]["ternom"].ToString();
                    TxtPrimerApellido.Text = dsCods.Rows[0]["TerPriApe"].ToString();
                    TxtSegundoApellido.Text = dsCods.Rows[0]["TerSegApe"].ToString();
                    TxtPrimerNombre.Text = dsCods.Rows[0]["TerPriNom"].ToString();
                    TxtSegundoNombre.Text = dsCods.Rows[0]["TerSegNom"].ToString();
                    TxtRepresentanteLegal.Text = dsCods.Rows[0]["terreplegal"].ToString();
                    TxtCedula.Text = dsCods.Rows[0]["tercedreplegal"].ToString();
                    TxtContacto.Text = dsCods.Rows[0]["tercontacto"].ToString();
                    TxtCargo.Text = dsCods.Rows[0]["tercargocontacto"].ToString();
                    TxtEmail.Text = dsCods.Rows[0]["termail"].ToString();
                    TxtTelefono.Text = dsCods.Rows[0]["tertel"].ToString();
                    TxtCelular.Text = dsCods.Rows[0]["tercel"].ToString();
                    TxtFax.Text = dsCods.Rows[0]["terFax"].ToString();
                    TxtDireccion.Text = dsCods.Rows[0]["terdir"].ToString();
                    TxtLblBarrio.Codigo = dsCods.Rows[0]["terzona"].ToString();
                    TxtLblBarrio.Edit();
                    TxtLblCiudad.Codigo = dsCods.Rows[0]["terCodCiu"].ToString();
                    TxtLblCiudad.Edit();
                    TxtLblPais.Codigo = dsCods.Rows[0]["terPais"].ToString();
                    TxtLblPais.Edit();
                    TxtNumeroCuenta.Text = dsCods.Rows[0]["terCta"].ToString();


                    if (Convert.ToInt32(dsCods.Rows[0]["TerTipoCuenta"].ToString()) == 2)
                    {
                        RgTipoCuenta.SelectedIndex = 1;
                    }
                    else
                    {
                        RgTipoCuenta.SelectedIndex = 0;
                    }
                    TxtLblBanco.Codigo = dsCods.Rows[0]["terBan"].ToString();
                    TxtLblBanco.Edit();
                    
                    if (Convert.ToInt32(dsCods.Rows[0]["TerRegi"].ToString()) == 1)
                    {
                        RgRegimen.SelectedIndex = 1;
                    }
                    else
                    {
                        RgRegimen.SelectedIndex = 0;
                    }
                   
                    if (Convert.ToInt32(dsCods.Rows[0]["retefuentePro"].ToString()) == 0)
                    {
                        ChkReteFtePr.Checked = false;
                    }
                    else
                    {
                        ChkReteFtePr.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["granContriPro"].ToString()) == 0)
                    {
                        ChkGranConPr.Checked = false;
                    }
                    else
                    {
                        ChkGranConPr.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["IcaPr"].ToString()) == 0)
                    {
                        ChkIcaPr.Checked = false;
                    }
                    else
                    {
                        ChkIcaPr.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["aplReteicaPr"].ToString()) == 0)
                    {
                        ChkAplicarReteIcaPr.Checked = false;
                    }
                    else
                    {
                        ChkAplicarReteIcaPr.Checked = true;
                    }

                    TxtResolucion.Text = dsCods.Rows[0]["ResDian"].ToString();
                    TxtFechaRs.DateTime = Convert.ToDateTime(dsCods.Rows[0]["fechaRes"]);
                    TxtRangoNumeracionRs.Text = dsCods.Rows[0]["rangoRes"].ToString();

                    if (Convert.ToInt32(dsCods.Rows[0]["retefuenteCli"].ToString()) == 0)
                    {
                        ChkReteFteCl.Checked = false;
                    }
                    else
                    {
                        ChkReteFteCl.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["granContriCli"].ToString()) == 0)
                    {
                        ChkGranConCl.Checked = false;
                    }
                    else
                    {
                        ChkGranConCl.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["ReteIva"].ToString()) == 0)
                    {
                        ChkReteIva.Checked = false;
                    }
                    else
                    {
                        ChkReteIva.Checked = true;
                    }

                    if (Convert.ToInt32(dsCods.Rows[0]["ReteicaCl"].ToString()) == 0)
                    {
                        ChkReteIcaCl.Checked = false;
                    }
                    else
                    {
                        ChkReteIcaCl.Checked = true;
                    }

                    ValidateData();

                    TxtLblTipoProveedor.Codigo = dsCods.Rows[0]["tipoProveedor"].ToString();
                    TxtLblTipoProveedor.Edit();
                    TxtLblTipoCliente.Codigo = dsCods.Rows[0]["tipoCliente"].ToString();
                    TxtLblTipoCliente.Edit();

                }
                dsCods.Dispose();
            }
            else
            {
                Text = "Nuevo Propietario";
            }
        }

        public void Guardar()
        {
            if (ValidateData())
            {
                if (Modo.Equals("N"))
                {
                    RegistrarCliente();
                }
                else
                {
                    ActualizarCliente();
                }
            }
            else
            {
                XtraMessageBox.Show("Debe ingresar los campos obligatorios.", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            CboTipoDocumento.SelectedIndex = 1;
            TxtDocumentoId.Texto = "";
            RgPersona.SelectedIndex = 0;
            TxtRazonSocial.Text = "";
            TxtPrimerApellido.Text = "";
            TxtSegundoApellido.Text = "";
            TxtPrimerNombre.Text = "";
            TxtSegundoNombre.Text = "";
            TxtRepresentanteLegal.Text = "";
            TxtCedula.Text = "";
            TxtContacto.Text = "";
            TxtCargo.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
            TxtCelular.Text = "";
            TxtFax.Text = "";
            TxtDireccion.Text = "";
            TxtLblBarrio.Codigo = "";
            TxtLblBarrio.Borrar();
            TxtLblCiudad.Codigo = "";
            TxtLblCiudad.Borrar();
            TxtLblPais.Codigo = "169";
            TxtLblPais.Edit();
            TxtNumeroCuenta.Text = "";
            RgTipoCuenta.SelectedIndex = 0;
            TxtLblBanco.Codigo = "";
            TxtLblBanco.Borrar();
            RgRegimen.SelectedIndex = 0;

            ChkReteFtePr.Checked = false;
            ChkGranConPr.Checked = false;
            ChkIcaPr.Checked = false;
            ChkAplicarReteIcaPr.Checked = false;
            TxtResolucion.Text = "";
            TxtFechaRs.Text = "";
            TxtFechaRs.Enabled = false;
            TxtRangoNumeracionRs.Text = "";
            ChkReteFteCl.Checked = false;
            ChkGranConCl.Checked = false;
            ChkReteIva.Checked = false;
            ChkReteIcaCl.Checked = false;

            TxtLblTipoProveedor.Codigo = "";
            TxtLblTipoProveedor.Borrar();
            TxtLblTipoCliente.Codigo = "";
            TxtLblTipoCliente.Borrar();

           
        }

        public void RegistrarCliente()
        {
            SqlParameter[] parametros_insertar = new[] { new SqlParameter("@Operacion", "INSPROPIETA"),
                                                        new SqlParameter("@clinom", TxtRazonSocial.Text),
                                                        new SqlParameter("@clinit", TxtDocumentoId.Texto),
                                                        new SqlParameter("@cliconta", TxtContacto.Text),
                                                        new SqlParameter("@clicargo", TxtCargo.Text),
                                                        new SqlParameter("@clidir", TxtDireccion.Text),
                                                        new SqlParameter("@cliciud", TxtLblCiudad.Codigo ?? ""),
                                                        new SqlParameter("@climail", TxtEmail.Text),
                                                        new SqlParameter("@clicuen", TxtNumeroCuenta.Text),
                                                        new SqlParameter("@clitel", TxtTelefono.Text),
                                                        new SqlParameter("@clifax", TxtFax.Text),
                                                        new SqlParameter("@cliban", TxtLblBanco.Codigo ?? ""),
                                                        new SqlParameter("@cliPriNom", TxtPrimerNombre.Text),
                                                        new SqlParameter("@cliSegNom", TxtSegundoNombre.Text),
                                                        new SqlParameter("@cliPriApe", TxtPrimerApellido.Text),
                                                        new SqlParameter("@cliSegApe", TxtSegundoApellido.Text),
                                                        new SqlParameter("@tipDoc", CboTipoDocumento.Text),
                                                        new SqlParameter("@digVer", TxtDV.Texto),
                                                         new SqlParameter("@cliauto", (ChkReteFtePr.Checked) ? 1 : 0),//(ChkReteFteCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliautoica", (ChkReteIva.Checked) ? 1 : 0),
                                                        new SqlParameter("@cligran",  (ChkGranConPr.Checked) ? 1 : 0),//(ChkGranConCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliica",  (ChkAplicarReteIcaPr.Checked) ? 1 : 0),//(ChkReteIcaCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliregi", (RgRegimen.SelectedIndex == 0) ? 2 : 1),
                                                        new SqlParameter("@clicontac2", TxtLblBarrio.Codigo ?? ""),
                                                        new SqlParameter("@clicel1", TxtCelular.Text),
                                                        new SqlParameter("@clitipcuen", RgTipoCuenta.SelectedIndex + 1), 
                                                        new SqlParameter("@clireplegal", TxtRepresentanteLegal.Text),
                                                        new SqlParameter("@cliced", TxtCedula.Text),
                                                        new SqlParameter("@clicodciud", TxtLblCiudad.Codigo ?? ""),
                                                        new SqlParameter("@clipersona", (RgPersona.SelectedIndex == 0) ? 2 : 1),
                                                        new SqlParameter("@cliPais", TxtLblPais.Codigo ?? ""),
                                                        new SqlParameter("@CliTipoCli", TxtLblTipoCliente.Codigo ?? ""),

                                                        new SqlParameter("@proauto", (ChkReteFtePr.Checked) ? 1 : 0),
                                                        new SqlParameter("@progran", (ChkGranConPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@proica", (ChkAplicarReteIcaPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@proautoica",(ChkIcaPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@prores2", TxtResolucion.Text),
                                                        new SqlParameter("@proactividad", TxtRangoNumeracionRs.Text),
                                                        new SqlParameter("@proTipoProvee", TxtLblTipoProveedor.Codigo),
                                                        new SqlParameter("@TerCiu", TxtLblCiudad.Nombre??"")};

            bool IsDone = DataBase.ExecuteNonQuery("PA_ImbPropietario", CommandType.StoredProcedure, parametros_insertar, ConexionDB.getInstancia().Conexion(Database, null));
            //bool insertado = true;

            if ((IsDone))
            {
                XtraMessageBox.Show("Registro exitoso", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show("Error al insertar Propietario.", Referencias.Properties.Resources.AppName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            ValidateData();
        }

        public void ActualizarCliente()
        {

            SqlParameter[] parametros_update = new[] {  new SqlParameter("@Operacion", "UPDPROPIETA"),
                                                        new SqlParameter("@codTer", ID),
                                                        new SqlParameter("@clicod", codCliente),
                                                        new SqlParameter("@codPro", codPropierio),
                                                        new SqlParameter("@clinom", TxtRazonSocial.Text.Trim()),
                                                        new SqlParameter("@clinit", TxtDocumentoId.Texto.Trim()),
                                                        new SqlParameter("@cliconta", TxtContacto.Text.Trim()),
                                                        new SqlParameter("@clicargo", TxtCargo.Text.Trim()),
                                                        new SqlParameter("@clidir", TxtDireccion.Text.Trim()),
                                                        new SqlParameter("@cliciud", TxtLblCiudad.Codigo ?? ""),
                                                        new SqlParameter("@climail", TxtEmail.Text.Trim()),
                                                        new SqlParameter("@clicuen", TxtNumeroCuenta.Text.Trim()),
                                                        new SqlParameter("@clitel", TxtTelefono.Text.Trim()),
                                                        new SqlParameter("@clifax", TxtFax.Text.Trim()),
                                                        new SqlParameter("@cliban", TxtLblBanco.Codigo ?? ""),
                                                        new SqlParameter("@cliPriNom", TxtPrimerNombre.Text.Trim()),
                                                        new SqlParameter("@cliSegNom", TxtSegundoNombre.Text.Trim()),
                                                        new SqlParameter("@cliPriApe", TxtPrimerApellido.Text.Trim()),
                                                        new SqlParameter("@cliSegApe", TxtSegundoApellido.Text.Trim()),
                                                        new SqlParameter("@tipDoc", CboTipoDocumento.Text.Trim()),
                                                        new SqlParameter("@digVer", TxtDV.Texto.Trim()),
                                                        new SqlParameter("@cliauto", (ChkReteFtePr.Checked) ? 1 : 0),//(ChkReteFteCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliautoica", (ChkReteIva.Checked) ? 1 : 0),
                                                        new SqlParameter("@cligran",  (ChkGranConPr.Checked) ? 1 : 0),//(ChkGranConCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliica",  (ChkAplicarReteIcaPr.Checked) ? 1 : 0),//(ChkReteIcaCl.Checked) ? 1 : 0),
                                                        new SqlParameter("@cliregi", (RgRegimen.SelectedIndex == 0) ? 2 : 1),
                                                        new SqlParameter("@clicontac2", TxtLblBarrio.Codigo ?? ""),
                                                        new SqlParameter("@clicel1", TxtCelular.Text.Trim()),
                                                        new SqlParameter("@clitipcuen", RgTipoCuenta.SelectedIndex + 1),     
                                                        new SqlParameter("@clireplegal", TxtRepresentanteLegal.Text.Trim()),
                                                        new SqlParameter("@cliced", TxtCedula.Text.Trim()),
                                                        new SqlParameter("@clicodciud", TxtLblCiudad.Codigo ?? ""),
                                                        new SqlParameter("@clipersona", (RgPersona.SelectedIndex == 0) ? 2 : 1),
                                                        new SqlParameter("@cliPais", TxtLblPais.Codigo ?? ""),
                                                        new SqlParameter("@CliTipoCli", TxtLblTipoCliente.Codigo ?? ""),
                                                        
                                                        new SqlParameter("@proauto", (ChkReteFtePr.Checked) ? 1 : 0),
                                                        new SqlParameter("@progran", (ChkGranConPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@proica", (ChkAplicarReteIcaPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@proautoica",(ChkIcaPr.Checked) ? 1 : 0),
                                                        new SqlParameter("@prores2", TxtResolucion.Text.Trim()),
                                                        new SqlParameter("@proactividad", TxtRangoNumeracionRs.Text.Trim()),
                                                        new SqlParameter("@proTipoProvee", TxtLblTipoProveedor.Codigo),
                                                        new SqlParameter("@TerCiu", TxtLblCiudad.Nombre??"")};
            bool IsDone = DataBase.ExecuteNonQuery("PA_ImbPropietario", CommandType.StoredProcedure, parametros_update, ConexionDB.getInstancia().Conexion(Database, null));
   
            if (IsDone)
            {
                XtraMessageBox.Show("Actualización exitosa", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // alertControl1.Show(this, "Clientes", "Actualización exitosa.");
                Close();
            }
            else
            {
                XtraMessageBox.Show("Error al actualizar Registro.", Referencias.Properties.Resources.AppName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            ValidateData();

        }

        public void Cancelar()
        {
            this.Close();
        }

        #endregion

        #region Eventos        

        private void FrmGetPropietario_Load(object sender, EventArgs e)
        {
            TxtLblBarrio.PerfilShow = Perfilador.getInstancia().CargarPerfil("BarriosJ");
            TxtLblBarrio.DesHabilitarBtnExcel = true;
            TxtLblBarrio.DesHabilitarBtnGuardar = true;
            TxtLblBarrio.DesHabilitarBtnImprimir = true;

            TxtLblCiudad.PerfilShow = Perfilador.getInstancia().CargarPerfil("CiudadesJ");

            TxtLblCiudad.DesHabilitarBtnExcel = true;
            TxtLblCiudad.DesHabilitarBtnGuardar = true;
            TxtLblCiudad.DesHabilitarBtnImprimir = true;

            TxtLblPais.PerfilShow = Perfilador.getInstancia().CargarPerfil("PaisesJ");
            TxtLblPais.DesHabilitarBtnExcel = true;
            TxtLblPais.DesHabilitarBtnGuardar = true;
            TxtLblPais.DesHabilitarBtnImprimir = true;

            TxtLblBanco.PerfilShow = Perfilador.getInstancia().CargarPerfil("BancosJ");
            TxtLblBanco.DesHabilitarBtnExcel = true;
            TxtLblBanco.DesHabilitarBtnGuardar = true;
            TxtLblBanco.DesHabilitarBtnImprimir = true;

            TxtLblBarrio.database = Database;
            TxtLblBarrio.Usuario = Usuario;
            TxtLblCiudad.database = Database;
            TxtLblCiudad.Usuario = Usuario;
            TxtLblPais.database = Database;
            TxtLblPais.Usuario = Usuario;
            TxtLblBanco.database = Database;
            TxtLblBanco.Usuario = Usuario;

            TxtLblTipoCliente.PerfilShow = Perfilador.getInstancia().CargarPerfil("TipoCliente");
            TxtLblTipoCliente.database = Database;
            TxtLblTipoCliente.DesHabilitarBtnExcel = true;
            TxtLblTipoCliente.DesHabilitarBtnGuardar = true;
            TxtLblTipoCliente.DesHabilitarBtnImprimir = true;
            TxtLblTipoCliente.Usuario = Usuario;

            TxtLblTipoProveedor.PerfilShow = Perfilador.getInstancia().CargarPerfil("ImbTipoProvee");
            TxtLblTipoProveedor.database = Database;
            TxtLblTipoProveedor.DesHabilitarBtnExcel = true;
            TxtLblTipoProveedor.DesHabilitarBtnGuardar = true;
            TxtLblTipoProveedor.DesHabilitarBtnImprimir = true;
            TxtLblTipoProveedor.Usuario = Usuario;

            if (Modo=="E")
            {
                this.Text = "Editar Propietario";
                SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "GETNITPROP"),
                new SqlParameter("@codTer", ID) };
                DataTable dsCods = new DataTable();
                dsCods = DataBase.ExecuteQueryDataTable("PA_ImbPropietario", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

                if (dsCods.Rows.Count > 0)
                {
                    TxtDocumentoId.Texto = dsCods.Rows[0]["ternit"].ToString();
                    nit = dsCods.Rows[0]["ternit"].ToString();
                    codCliente = dsCods.Rows[0]["CodCli"].ToString();
                    codPropierio = dsCods.Rows[0]["CodPro"].ToString();
                    LlenarFormulario();
                }
            }

            ValidateData();
            TxtDocumentoId.Focus();
        }

        //private void TxtDocumentoId_Validated(object sender, EventArgs e)
        //{
        //    if (CboTipoDocumento.Text.Trim() == "NI")
        //    {
        //        LlenarDV();
        //    }

        //    BuscarNit();

        //    ValidateData();
        //}

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RgPersona.SelectedIndex == 0)
            {
                TxtPrimerApellido.Enabled = false;
                TxtPrimerNombre.Enabled = false;
                TxtSegundoApellido.Enabled = false;
                TxtSegundoNombre.Enabled = false;

                //TxtDV.Enabled = true;

            }
            else
            {
                TxtPrimerApellido.Enabled = true;
                TxtPrimerNombre.Enabled = true;
                TxtSegundoApellido.Enabled = true;
                TxtSegundoNombre.Enabled = true;
                TxtDV.Texto = "";
                //TxtDV.Enabled = false;


            }
            ValidateData();
        }

        //private void TxtRazonSocial_Validated(object sender, EventArgs e)
        //{
        //    ValidateData();
        //}

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (RgPersona.SelectedIndex == 1)
            {
                string nombres = String.Format("{0} {1}", TxtPrimerNombre.Text.Trim(), TxtSegundoNombre.Text.Trim());
                string apellidos = String.Format("{0} {1}", TxtPrimerApellido.Text.Trim(), TxtSegundoApellido.Text.Trim());

                if (TxtRazonSocial.Text.Equals(string.Format("{0} {1}", nombres, apellidos).ToUpper()))
                {
                    TxtRazonSocial.Text = string.Format("{0} {1}", apellidos, nombres);
                }
                else
                {
                    TxtRazonSocial.Text = String.Format("{0} {1}", nombres, apellidos);
                }
            } 
        }

        private void TxtDireccion_Validated(object sender, EventArgs e)
        {

            ValidateData();
        }

        private void TxtLblCiudad_Validated(object sender, EventArgs e)
        {

            ValidateData();
        }

        private void TxtLblPais_Validated(object sender, EventArgs e)
        {

            ValidateData();
        }

        private void TxtLblTipoProveedor_Validated(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void TxtLblTipoCliente_Validated(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void RgRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChkIcaPr.Checked == true || ChkGranConPr.Checked == true || ChkReteFtePr.Checked == true)
            {
                RgRegimen.SelectedIndex = 1;
            }

            if (RgRegimen.SelectedIndex == 0)
            {
                TxtResolucion.Enabled = false;
                TxtFechaRs.Enabled = false;
                TxtRangoNumeracionRs.Enabled = false;
            }
            else
            {
                TxtResolucion.Enabled = true;
                TxtFechaRs.Enabled = true;
                TxtRangoNumeracionRs.Enabled = true;
            }
        }

        private void ChkGranConPr_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGranConPr.Checked)
            {
                RgRegimen.SelectedIndex = 1;
                ChkIcaPr.Checked = true;
            }
            else
            {
                ChkIcaPr.Checked = false;
                if (ChkIcaPr.Checked == false && ChkReteFtePr.Checked == false) 
                {
                    RgRegimen.SelectedIndex = 0;
                }
            }
        }

        private void ChkIcaPr_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkIcaPr.Checked)
            {
                RgRegimen.SelectedIndex = 1;
                ChkAplicarReteIcaPr.Checked = false;
                ChkAplicarReteIcaPr.Enabled = false;
                ChkGranConPr.Checked = true;
            }
            else
            {
                ChkAplicarReteIcaPr.Enabled = true;
                ChkGranConPr.Checked = false;
                if (ChkGranConPr.Checked == false && ChkReteFtePr.Checked == false)
                {
                    RgRegimen.SelectedIndex = 0;
                }
            }
        }

        private void ChkReteFtePr_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkReteFtePr.Checked)
            {
                RgRegimen.SelectedIndex = 1;
            }
            else
            {
                if (ChkIcaPr.Checked == false && ChkGranConPr.Checked == false)
                {
                    RgRegimen.SelectedIndex = 0;
                }
            }
        }

        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CboTipoDocumento.SelectedIndex == 0)
            //    //{
            //    //    RgRegimen.SelectedIndex = 0;
            //    //    LlenarDV();
            //    //}
            //    //if (CboTipoDocumento.SelectedIndex == 1) { RgRegimen.SelectedIndex = 1; }
        }

        #endregion

        private void TxtDocumentoId_Validated(object sender, EventArgs e)
        {
            if (CboTipoDocumento.Text.Trim() == "NI")
            {
                LlenarDV();
            }

            BuscarNit();

            ValidateData();
        }

        private void TxtRazonSocial_Validated(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void TxtDireccion_Validated_1(object sender, EventArgs e)
        {
            ValidateData();
        }


    }
}