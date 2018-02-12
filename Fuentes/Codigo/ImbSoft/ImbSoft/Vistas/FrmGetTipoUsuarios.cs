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
using ImbSoft.Clases;
using ImbSoft.Controladores;

namespace ImbSoft.Vistas
{
    public partial class FrmGetTipoUsuarios : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Usuario { get; set; }
        public string Modo { get; set; }
        public int Id { get; set; }

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;
        private Funciones f = new Funciones();

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
                if (TxtNombre.Texto.Trim().IndexOf(" ") > 0)
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
                    if (ConsultarUsuario())
                    {
                        InsertarActualizar("INSERT");
                        LimpiarVentana();

                        DialogResult = DialogResult.OK;
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

                        DialogResult = DialogResult.OK;
                    }
                }
                    
                    
                
            }
           
        }

        private bool ConsultarUsuario()
        {
            string user="";
            bool retorno = true;
            
            if (Modo != "E")
            {
                Usuario us = new Usuario();
                us.Nombre = TxtNombre.Texto.Trim();
                DataSet ds = CtrlUsuarios.GetUsuarioName(us);                   
                if (ds.Tables[0].Rows.Count > 0)
                {
                    user = ds.Tables[0].Rows[0]["Nombre"].ToString();
                }

                if (TxtNombre.Texto == user)
                {

                    retorno = false;
                    XtraMessageBox.Show("El nombre de usuario ya existe.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    TxtNombre.Focus();

                }
            }

            return retorno;
        }

        private void LimpiarVentana()
        {
            TxtNombre.Texto = "";
            ChkAñadir.Checked = false;
            ChkEliminar.Checked = false;
            ChkEditar.Checked = false;
            ChkGuardar.Checked = false;
            ChkImprimir.Checked = false;
            ChkExportar.Checked = false;
        }

        private void CargarDatos(int id)
        {
            Usuario us = new Usuario();
            us.Id = id;
            DataSet ds = CtrlUsuarios.GetUsuarioOne(us);
            DataRow dr = ds.Tables[0].Rows[0];
            
            TxtNombre.Texto = dr["Nombre"].ToString();
            TxtPass1.Text = dr["Contrasenia"].ToString();
            TxtPass2.Text = dr["Contrasenia"].ToString();

        }

        private void InsertarActualizar(string modo)
        {
            try
            {
                
                InsertarUsuarioBasico(modo);
                                         
            }
            catch (Exception ex)
            {
                 XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);                
            }
        }

        public void InsertarUsuarioBasico(string modo) 
        {
            if (modo == "INSERT")
            {
                Usuario usuario = new Usuario();
               
                
                usuario.Nombre = TxtNombre.Texto.Trim();
                usuario.Clave = TxtPass2.Text.Trim();

                if (CtrlUsuarios.InsertarBasico(usuario) > 0)
                {
                    XtraMessageBox.Show("Usuario insertado con exito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                Usuario usuario = new Usuario();
               
                usuario.Id = Id;
                usuario.Nombre = TxtNombre.Texto.Trim();
                usuario.Clave = TxtPass2.Text.Trim();

                if (CtrlUsuarios.Actualizar(usuario) > 0)
                {
                    XtraMessageBox.Show("Usuario actualizado con exito.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
            }
        }

        #endregion

        #region Eventos

        private void GetUsuarios_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dt = f.GetTipoUsurios(ConexionDB.getInstancia().Conexion(null, null)).Tables[0];

            //    DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            //    col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 100);
            //    //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            //    return;
            //}
           
            TxtNombre.Focus();
            if (Modo == "E" && Id > 0) 
            {
                CargarDatos(Id);
                TxtNombre.Enabled = false;              
            }
           
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TxtNombre.Texto.Trim().Length > 0) 
            { 
                if (TxtNombre.Texto.Trim().Contains(" "))
                {                   
                    errorP1.SetError(TxtNombre, "El usuario no debe contener espcios en blanco.");
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
                    errorP1.SetError(TxtNombre, "Debe ingresar el usuario.");
                    TxtNombre.Focus();
                }
                else
                {
                    errorP1.SetError(TxtNombre, "");
                }
            }
        }
       
        private void TxtPass2_Validating(object sender, CancelEventArgs e)
        {
            if (TxtPass1.Text != TxtPass2.Text)
            {
                errorP1.SetError(TxtPass1, "Las contraseñas no coinciden.");
                TxtPass1.Focus();
            }
            else
            {
                errorP1.SetError(TxtPass1, "");
            }
        }

        private void TxtPass2_TextChanged(object sender, EventArgs e)
        {
            if (TxtPass2.Text.Trim().Length > 0)
            {
                if (TxtPass1.Text != TxtPass2.Text)
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

        #endregion


    }
}