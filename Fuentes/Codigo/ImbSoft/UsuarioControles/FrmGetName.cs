 /***
 * Formulario   : FrmGetName
 * Proposito    : Permite capturar datos para tablas donde solo se requiere de un código y un Nombre/Descripción,
 *                sin embargo solo se ingresa el nombre o descripción ya que el código se genera tomando 
 *                el numero maximo de registros más uno y agregando ceros por la izquierda.
 * Fecha        : Febrero, 2012
 * Fecha Act.   : 
 * Autor        : 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using System.Data.SqlClient;
using Referencias;
using Referencias.Properties;

namespace UsuarioControles
{
    public partial class FrmGetName : FormularioBase
    {
        #region Propiedades
        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }
        public String Usuario { get; set; }

        #endregion

        #region Variables
        private bool agrego;
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmGetName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se ejecuta al presionar el botón Aceptar
        /// Inserta el registro en la tabla cuando la propiedad Modo tiene un valor "N", en caso contrario lo actualiza
        /// </summary>
        public void Accept()
        {
            try
            {
                if (!String.IsNullOrEmpty(TxtNombre.Text))
                {
                    if (Modo.Equals("N"))
                    {
                        string code = Funciones.getInstancia().GetNextCode(PerfilAct.Tabla, PerfilAct.Llave,
                        ConexionDB.getInstancia().Conexion(Database, null),PerfilAct.CampoCodigo);

                        string camp = "";
                        
                        camp = PerfilAct.CampoCodigo + "," + PerfilAct.CampoNombre;
                        var sql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", PerfilAct.Tabla,
                        camp, String.Format("'{0}', '{1}'", code, TxtNombre.Text));

                        var IsDone = DataBase.ExecuteNonQuery(sql, CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                        if (IsDone)
                        {
                            string cons = String.Format("SELECT {0} FROM {1} WHERE MarcaBorrado = 1 AND {2} = '{3}'", PerfilAct.Llave,
                            PerfilAct.Tabla, PerfilAct.CampoCodigo, code);

                            DataSet ds = DataBase.ExecuteQuery(cons, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                            ID = ds.Tables[0].Rows[0][PerfilAct.Llave].ToString();
                            //AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtNombre.Text), Resources.Check);
                            //alertControl1.Show(this, info);
                            this.TxtNombre.Text = String.Empty;
                            this.TxtNombre.Focus();
                            if (!DesdeMenu)
                                DialogResult = DialogResult.OK;
                            else
                            {
                                agrego = true;
                                this.TxtNombre.Text = String.Empty;
                            }
                        }
                    }
                    else
                    {
                        String sql = String.Format("UPDATE {0} SET {1} = '{2}' WHERE {3} = '{4}'", PerfilAct.Tabla,
                        PerfilAct.CampoNombre, TxtNombre.Text, PerfilAct.Llave, ID);

                        bool IsDone = DataBase.ExecuteNonQuery(sql, CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                        if (IsDone)
                        {
                            //AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtNombre.Text), Resources.Check);
                            //alertControl1.Show(this, info);
                            this.TxtNombre.Text = String.Empty;
                            this.TxtNombre.Focus();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("El nombre no puede quedar vacío", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombre.Focus();
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }
        }

        #endregion

        #region Eventos
        private void FrmGetName_Load(object sender, EventArgs e)
        {
            cabeceraForm1.NombreCabecera = "Añadir " + PerfilAct.Titulo;

            if (Modo == "E")
            {
                cabeceraForm1.NombreCabecera = "Editando - " + this.Text;               
                string camp = "";
                camp = camp.Vector2Cadena(",", PerfilAct.Campos);
                string condicion = String.Format(" AND {0} = '{1}'", PerfilAct.Llave, ID);
                String cad = String.Format("SELECT {0} FROM {1} WHERE MarcaBorrado = 1 {2}", camp, PerfilAct.Tabla, condicion);
                DataSet ds = DataBase.ExecuteQuery(cad, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                this.TxtNombre.Text = ds.Tables[0].Rows[0][PerfilAct.CampoNombre].ToString();
            }

            String sSql2 = String.Format("SELECT CHARACTER_MAXIMUM_LENGTH FROM information_schema.columns WHERE table_name = '{0}' AND COLUMN_NAME='{1}'", PerfilAct.Tabla, PerfilAct.CampoNombre);
            DataSet ds1 = DataBase.ExecuteQuery(sSql2, "tamaño", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            this.TxtNombre.MaxLenght = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
        }

        private void FrmGetName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (agrego)
                DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
