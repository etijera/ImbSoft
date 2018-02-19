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
    public partial class FrmGetUsuarios : FormularioBase
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
        public FrmGetUsuarios()
        {
            InitializeComponent();

            LueTipoUsuario.Text = "";
            TxtPass2.MTextChanged = "TxtPass2_TextChanged";
        }

        public bool Validar() 
        {
            bool retorno = true;

            if (string.IsNullOrEmpty((TxtUsuario.Texto)))
            {
                errorP1.SetError(TxtUsuario, "Debe ingresar el usuario.");
                TxtUsuario.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtUsuario, "");
            }

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

            if (LueTipoUsuario.EditValue == null)
            {
                errorP1.SetError(LueTipoUsuario, "Debe seleccionar el tipo de usuario.");
                LueTipoUsuario.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(LueTipoUsuario, "");
            }

            if (string.IsNullOrEmpty((TxtPass1.Texto)))
            {
                errorP1.SetError(TxtPass1, "Debe ingresar la contraseña.");
                TxtPass1.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtPass1, "");
            }

            if (string.IsNullOrEmpty((TxtPass2.Texto)))
            {
                errorP1.SetError(TxtPass2, "Debe confirmar la contraseña.");
                TxtPass2.Focus();
                retorno = false;
            }
            else
            {
                errorP1.SetError(TxtPass2, "");

                if (TxtPass1.Texto != TxtPass2.Texto)
                {
                    errorP1.SetError(TxtPass2, "Las contraseñas no coinciden.");
                    TxtPass2.Focus();
                    retorno = false;
                }
                else
                {
                    errorP1.SetError(TxtPass2, "");
                }
            }

            return retorno;
        }

        public void Accept() 
        {
            if (Modo != "E") 
            {              
                if (Validar())
                {
                    if (ConsultarUsuario())
                    {
                        InsertarActualizar("INSERT");                        
                    }
                }                                
            }
            else
            {
  
                if (Validar())
                {
                    if (ConsultarUsuario())
                    {
                        InsertarActualizar("UPDATE");
                    }
                }
            }           
        }

        public void TxtPass2_TextChanged()
        {
            if (TxtPass2.Texto.Trim().Length > 0)
            {
                if (TxtPass1.Texto != TxtPass2.Texto)
                {
                    errorP1.SetError(TxtPass2, "Las contraseñas no coinciden.");
                    TxtPass2.Focus();
                }
                else
                {
                    errorP1.SetError(TxtPass2, "");
                }
            }
        }

        private bool ConsultarUsuario()
        {
            string user = string.Empty;
            bool retorno = true;
            
            if (Modo != "E")
            {
                Usuario us = new Usuario();
                us.User = TxtUsuario.Texto.Trim();
                DataTable dt = CtrlUsuarios.GetUsuarioName(us);                   
                if (dt.Rows.Count > 0)
                {
                    user = dt.Rows[0]["Usuario"].ToString();
                }

                if (TxtUsuario.Texto == user)
                {
                    retorno = false;
                    XtraMessageBox.Show("El usuario ya existe.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    TxtUsuario.Focus();
                }
            }

            return retorno;
        }

        private void LimpiarVentana()
        {
            TxtUsuario.Texto = string.Empty;
            TxtNombre.Texto = string.Empty;
            LueTipoUsuario.EditValue = null;
            TxtPass1.Texto = string.Empty;
            TxtPass2.Texto = string.Empty;
        }

        private void CargarDatos(int id)
        {
            Usuario us = new Usuario();
            us.Id = id;
            DataTable dt = CtrlUsuarios.GetUsuarioOne(us);
            DataRow dr = dt.Rows[0];

            TxtUsuario.Texto = dr["Usuario"].ToString();
            TxtNombre.Texto = dr["Nombre"].ToString();
            LueTipoUsuario.EditValue = dr["CodTipoUsuario"].ToString();
            TxtPass1.Texto = dr["Clave"].ToString();
            TxtPass2.Texto = dr["Clave"].ToString();
        }

        private void InsertarActualizar(string modo)
        {
            try
            {
                if (modo == "INSERT")
                {
                    Usuario usuario = new Usuario();

                    usuario.Nombre = TxtNombre.Texto.Trim();
                    usuario.User = TxtUsuario.Texto.Trim();
                    usuario.TipoUsuario.Codigo = LueTipoUsuario.EditValue.ToString();
                    usuario.Clave = TxtPass2.Texto.Trim();

                    DataTable dt = CtrlUsuarios.InsertarBasico(usuario);

                    ID = dt.Rows[0][PerfilAct.Llave].ToString();
                    AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtUsuario.Text), Resources.Check);
                    alertControl1.Show(this, info);
                    //    XtraMessageBox.Show("Usuario insertado con éxito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    LimpiarVentana();
                    this.TxtUsuario.Focus();

                    if (!DesdeMenu)
                        DialogResult = DialogResult.OK;
                    else
                    {
                        agrego = true;
                    }
                }
                else
                {
                    Usuario usuario = new Usuario();

                    usuario.Id = Convert.ToInt32(ID);
                    usuario.Nombre = TxtNombre.Texto.Trim();
                    usuario.TipoUsuario.Codigo = LueTipoUsuario.EditValue.ToString();
                    usuario.Clave = TxtPass2.Texto.Trim();

                    if (CtrlUsuarios.Actualizar(usuario))
                    {
                        XtraMessageBox.Show("Usuario actualizado con éxito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                        LimpiarVentana();
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
            try
            {

                DataTable dt = f.GetTipoUsuarios(ConexionDB.getInstancia().Conexion(Database, null)).Tables[0];

                LueTipoUsuario.Properties.Columns.Clear();
                LueTipoUsuario.Properties.DataSource = dt;
                LueTipoUsuario.Properties.DisplayMember = "Nombre";
                LueTipoUsuario.Properties.ValueMember = "Codigo";

                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                LueTipoUsuario.Properties.Columns.Add(col);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }
           
            TxtUsuario.Focus();
            if (Modo == "E" && Convert.ToInt32(ID) > 0) 
            {
                CargarDatos(Convert.ToInt32(ID));
                TxtUsuario.Enabled = false;              
            }
           
        }   

        private void LueTipoUsuario_Enter(object sender, EventArgs e)
        {
            LueTipoUsuario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        }

        private void LueTipoUsuario_Leave(object sender, EventArgs e)
        {
            LueTipoUsuario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (TxtUsuario.Texto.Trim().Length > 0)
            {
                if (TxtUsuario.Texto.Trim().Contains(" "))
                {
                    errorP1.SetError(TxtUsuario, "El usuario no debe contener espcios en blanco.");
                    TxtUsuario.Focus();
                }
                else
                {
                    errorP1.SetError(TxtUsuario, "");
                }
            }
            else
            {
                if (string.IsNullOrEmpty((TxtUsuario.Texto)))
                {
                    errorP1.SetError(TxtUsuario, "Debe ingresar el usuario.");
                    TxtUsuario.Focus();
                }
                else
                {
                    errorP1.SetError(TxtUsuario, "");
                }
            }
        }

        private void TxtPass2_Validating(object sender, CancelEventArgs e)
        {
            if (TxtPass1.Texto != TxtPass2.Texto)
              {
                  errorP1.SetError(TxtPass1, "Las contraseñas no coinciden.");
                  TxtPass1.Focus();
              }
              else
              {
                  errorP1.SetError(TxtPass1, "");
              }
        }

        #endregion




    }
}