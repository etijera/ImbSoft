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
using Referencias.Properties;
using Estandar.Clases;
using Estandar.Controladores;
using DevExpress.XtraBars.Alerter;

namespace Estandar.Vistas
{
    public partial class FrmGetTipoUsuarios : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }
        public string Usuario { get; set; }

        #endregion

        #region Variables

        private Funciones f = new Funciones();
        private bool agrego;

        #endregion

        #region Metodos
        public FrmGetTipoUsuarios()
        {
            InitializeComponent();
        }

        public bool Validar() 
        {
            bool retorno = true;
          
            if (string.IsNullOrEmpty((TxtNombre.Texto)))
            {
                errorP1.SetError(TxtNombre, "Debe ingresar el nombre.");
                TxtNombre.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtNombre, "");
            } 

            if (!string.IsNullOrEmpty((TxtNombre.Texto)))
            {
                if (TxtNombre.Texto.Trim().Contains(" "))
                {
                    errorP1.SetError(TxtNombre, "El nombre no debe tener espacio.");
                    TxtNombre.Focus();
                    retorno = false;
                }
                else
                {
                    errorP1.SetError(TxtNombre, "");
                }                
            }
            else
            {
                errorP1.SetError(TxtNombre, "");
            }           

            return retorno;
        }

        public void Accept() 
        {
            if (Modo != "E") 
            {               
                if (Validar())
                {
                    if (ConsultarTipoUsuario())
                    {
                        InsertarActualizar("INSERT");
                        LimpiarVentana();
                    }
                }                                
            }
            else
            {
                if (Validar())
                {
                    if (ConsultarTipoUsuario())
                    {
                        InsertarActualizar("UPDATE");
                    }
                }
            }
           
        }

        private bool ConsultarTipoUsuario()
        {
            string tipoUser="";
            bool retorno = true;
            
            if (Modo != "E")
            {
                TipoUsuario tipoUs = new TipoUsuario();
                tipoUs.Nombre = TxtNombre.Texto.Trim();
                DataTable dt = CtrlTipoUsuarios.GetTipoUsuarioName(tipoUs);                   
                if (dt.Rows.Count > 0)
                {
                    tipoUser = dt.Rows[0]["Nombre"].ToString();
                }

                if (TxtNombre.Texto == tipoUser)
                {
                    retorno = false;
                    XtraMessageBox.Show("El nombre de tipo de usuario ya existe.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    TxtNombre.Focus();
                }
            }

            return retorno;
        }

        private void LimpiarVentana()
        {
            TxtNombre.Texto = string.Empty;
            ChkAñadir.Checked = false;
            ChkEliminar.Checked = false;
            ChkEditar.Checked = false;
            ChkGuardar.Checked = false;
            ChkImprimir.Checked = false;
            ChkExportar.Checked = false;
        }

        private void CargarDatos(int id)
        {
            TipoUsuario tipoUs = new TipoUsuario();
            tipoUs.Id = id;
            DataTable dt = CtrlTipoUsuarios.GetTipoUsuarioOne(tipoUs);
            DataRow dr = dt.Rows[0];

            TxtNombre.Texto = dr["Nombre"].ToString();
            ChkAñadir.Checked = Convert.ToBoolean(dr["PoderAdicionar"]);
            ChkEliminar.Checked = Convert.ToBoolean(dr["PoderEliminar"]);
            ChkEditar.Checked = Convert.ToBoolean(dr["PoderEditar"]);
            ChkGuardar.Checked = Convert.ToBoolean(dr["PoderGuardar"]);
            ChkImprimir.Checked = Convert.ToBoolean(dr["PoderImprimir"]);
            ChkExportar.Checked = Convert.ToBoolean(dr["PoderExportar"]);            

        }

        private void InsertarActualizar(string modo)
        {
            try
            {
                if (modo == "INSERT")
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();

                    tipoUsuario.Nombre = TxtNombre.Texto.Trim();
                    tipoUsuario.PoderAdicionar = ChkAñadir.Checked;
                    tipoUsuario.PoderEditar = ChkEditar.Checked;
                    tipoUsuario.PoderEliminar = ChkEliminar.Checked;
                    tipoUsuario.PoderGuardar = ChkGuardar.Checked;
                    tipoUsuario.PoderImprimir = ChkImprimir.Checked;
                    tipoUsuario.PoderExportar = ChkExportar.Checked;

                    DataTable dt = CtrlTipoUsuarios.InsertarBasico(tipoUsuario);

                    ID = dt.Rows[0][PerfilAct.Llave].ToString();
                    AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtNombre.Text), Resources.Check);
                    alertControl1.Show(this, info);
                    //    XtraMessageBox.Show("Tipo de usuario insertado con éxito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    LimpiarVentana();                
                    this.TxtNombre.Focus();

                    if (!DesdeMenu)
                        DialogResult = DialogResult.OK;
                    else
                    {
                        agrego = true;
                    }

                }
                else
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();

                    tipoUsuario.Id = Convert.ToInt32(ID);
                    tipoUsuario.PoderAdicionar = ChkAñadir.Checked;
                    tipoUsuario.PoderEditar = ChkEditar.Checked;
                    tipoUsuario.PoderEliminar = ChkEliminar.Checked;
                    tipoUsuario.PoderGuardar = ChkGuardar.Checked;
                    tipoUsuario.PoderImprimir = ChkImprimir.Checked;
                    tipoUsuario.PoderExportar = ChkExportar.Checked;

                    if (CtrlTipoUsuarios.Actualizar(tipoUsuario))
                    {
                        XtraMessageBox.Show("Tipo de usuario actualizado con éxito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                        this.TxtNombre.Text = String.Empty;                       
                        this.TxtNombre.Focus();
                        DialogResult = DialogResult.OK;
                    }
                }
                                         
            }
            catch (Exception ex)
            {
                 XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);                
            }
        }

        #endregion

        #region Eventos

        private void GetUsuarios_Load(object sender, EventArgs e)
        {                     
            if (Modo == "E" && Convert.ToInt32(ID) > 0) 
            {
                CargarDatos(Convert.ToInt32(ID));
                TxtNombre.Enabled = false;              
            }

            TxtNombre.Focus();           
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TxtNombre.Texto.Trim().Length > 0) 
            { 
                if (TxtNombre.Texto.Trim().Contains(" "))
                {                   
                    errorP1.SetError(TxtNombre, "El nombre no debe contener espcios en blanco.");
                    TxtNombre.Focus();
                }
                else
                {
                    errorP1.SetError(TxtNombre, "");
                }
            }
            else
            {
                if (string.IsNullOrEmpty((TxtNombre.Texto))) 
                {
                    errorP1.SetError(TxtNombre, "Debe ingresar el nombre.");
                    TxtNombre.Focus();
                }
                else
                {
                    errorP1.SetError(TxtNombre, "");
                }
            }
        }       

        private void FrmGetTipoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (agrego) { 
                DialogResult = DialogResult.OK;
            }
        }

        #endregion



    }
}