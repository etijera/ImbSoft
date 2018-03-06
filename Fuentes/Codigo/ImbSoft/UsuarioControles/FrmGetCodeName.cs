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
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;

namespace UsuarioControles
{

    public partial class FrmGetCodeName : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }
        public string ID { get; set; }
        public Perfil PerfilAct { get; set; }
        public bool DesdeMenu { get; set; }
        public bool PonerCeros { get; set; }
        public String Usuario { get; set; }

        #endregion

        #region Variables
        private bool agrego;
        #endregion
        
        #region Metodos

        /// <summary>FrmGetCodeName()
        /// Constructor de la clase
        /// </summary>
        public FrmGetCodeName()
        {
            InitializeComponent();
        }

        private void LimpiarForm()
        {
            this.TxtCod.Texto = String.Empty;
            this.TxtNombre.Texto = String.Empty;
        }

        /// <summary>Accept()
        /// Permite realizar las acciones de inserccion y de edicion; cuando se presiona el boton aceptar.
        /// </summary>
        public void Accept()
        {
            if (Validar())
            {
                try
                {
                    if (Modo.Equals("N"))
                    {
                        string code = TxtCod.Texto;

                        string camp = String.Format("SELECT {0} FROM {1} WHERE MarcaBorrado = 1 AND {2} = '{3}'", PerfilAct.CampoCodigo,
                        PerfilAct.Tabla, PerfilAct.CampoCodigo, code);

                        DataSet ds = DataBase.ExecuteQuery(camp, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            String sql = String.Format("INSERT INTO {0} ({1},{2}) VALUES ('{3}','{4}')", PerfilAct.Tabla,
                            PerfilAct.CampoCodigo, PerfilAct.CampoNombre, code, TxtNombre.Texto);

                            bool IsDone = DataBase.ExecuteNonQuery(sql, CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                            if (IsDone)
                            {
                                string cons = String.Format("SELECT {0} FROM {1} WHERE MarcaBorrado = 1 AND {2} = '{3}'", PerfilAct.Llave,
                                PerfilAct.Tabla, PerfilAct.CampoCodigo, code);

                                DataSet dsCons = DataBase.ExecuteQuery(cons, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                                ID = dsCons.Tables[0].Rows[0][PerfilAct.Llave].ToString();
                                //AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtNombre.Text), Resources.Check);
                                //alertControl1.Show(this, info);
                                this.TxtCod.Texto = String.Empty;
                                this.TxtNombre.Texto = String.Empty;
                                this.TxtCod.Focus();
                                if (!DesdeMenu)
                                    DialogResult = DialogResult.OK;
                                else
                                {
                                    LimpiarForm();
                                    agrego = true;
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Ya existe un registro con ese Código", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                            TxtCod.Focus();
                        }
                    }
                    else
                    {
                        String sql = String.Format("UPDATE {0} SET {1} = '{2}', {3} = '{4}' WHERE {5} = '{6}'", PerfilAct.Tabla,
                        PerfilAct.CampoCodigo, TxtCod.Texto, PerfilAct.CampoNombre, TxtNombre.Texto, PerfilAct.Llave, ID);

                        bool IsDone = DataBase.ExecuteNonQuery(sql, CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                        if (IsDone)
                        {
                          //  AlertInfo info = new AlertInfo(Resources.SystemMessage, String.Format(Resources.SaveSuccess, TxtNombre.Text), Resources.Check);
                          //  alertControl1.Show(this, info);
                            this.TxtNombre.Texto = String.Empty;
                            this.TxtNombre.Focus();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    return;
                }
            }
        }

        /// <summary>Validar()
        /// Este metodo permite validar que los campos no esten vacios, antes de enviar los datos.
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            bool retorno = true;
            if (String.IsNullOrEmpty(TxtCod.Texto))
            {
                retorno = false;
                XtraMessageBox.Show("El codigo no puede quedar vacío", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCod.Focus();
            }

            if (String.IsNullOrEmpty(TxtNombre.Texto) && !String.IsNullOrEmpty(TxtCod.Texto))
            {
                retorno = false;
                XtraMessageBox.Show("El nombre no puede quedar vacío", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombre.Focus();
            }

            return retorno;
        }

        #endregion

        #region Eventos

        private void FrmGetName_Load(object sender, EventArgs e)
        {
            cabeceraForm1.NombreCabecera = "Añadir " + PerfilAct.Titulo;
            cabeceraForm1.Width = cabeceraForm1.Width - 1;
            cabeceraForm1.Width = cabeceraForm1.Width + 1;
            if (Modo == "E")
            {
                cabeceraForm1.NombreCabecera = "Editar " + PerfilAct.Titulo;

                string camp = "";
                camp = camp.Vector2Cadena(",", PerfilAct.Campos);
                string condicion = String.Format(" AND {0} = '{1}'", PerfilAct.Llave, ID);
                String cad = String.Format("SELECT {0}, {1} FROM {2} WHERE MarcaBorrado = 1 {3}", camp, PerfilAct.CampoCodigo, PerfilAct.Tabla, condicion);
                DataSet ds = DataBase.ExecuteQuery(cad, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

                this.TxtNombre.Texto = ds.Tables[0].Rows[0][PerfilAct.CampoNombre].ToString();
                this.TxtCod.Texto = ds.Tables[0].Rows[0][PerfilAct.CampoCodigo].ToString();
                //TxtCod.Text = PerfilAct.CampoCodigo;
                TxtCod.Enabled = false;
            }
            else
            {
                String sSql = String.Format("SELECT CHARACTER_MAXIMUM_LENGTH FROM information_schema.columns WHERE TABLE_SCHEMA + '.' + table_name = '{0}' AND COLUMN_NAME='{1}'", PerfilAct.Tabla, PerfilAct.CampoCodigo);
                DataSet ds = DataBase.ExecuteQuery(sSql, "tamaño", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
                this.TxtCod.MaxLenght = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            }

            String sSql2 = String.Format("SELECT CHARACTER_MAXIMUM_LENGTH FROM information_schema.columns WHERE TABLE_SCHEMA + '.' + table_name = '{0}' AND COLUMN_NAME='{1}'", PerfilAct.Tabla, PerfilAct.CampoNombre);
            DataSet ds1 = DataBase.ExecuteQuery(sSql2, "tamaño", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            this.TxtNombre.MaxLenght = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
        }

        private void TxtCod_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtCod.Texto))
            {
                try
                {
                    if (TxtCod.Texto.Contains('+') || TxtCod.Texto.Contains("'"))
                    {
                        XtraMessageBox.Show("El codigo no puede contener los caracteres ' y +", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCod.Focus();
                    }
                    if (Convert.ToInt32(TxtCod.Texto) == 0)
                    {
                        XtraMessageBox.Show("El codigo no puede ser 0", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCod.Focus();
                    }

                    if (PonerCeros)
                    {
                        String cod = TxtCod.Texto;
                        if (!String.IsNullOrEmpty(cod))
                        {
                            string codigo = Funciones.getInstancia().RellenarCadenaPorLaIzquierda(cod, '0', TxtCod.MaxLenght);
                            TxtCod.Texto = codigo;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void FrmGetCodeName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (agrego)
                DialogResult = DialogResult.OK;
        }
        #endregion


    }
}
