using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Referencias;
using Referencias.Properties;
using UsuarioControles;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Estandar.Vistas.Contabilidad
{
    public partial class FrmGetPuc : FormularioBase
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

        DataSet dsTiposCuentas = new DataSet();
        DataTable dtTiposCuentas = new DataTable();
        String nuevoCodCon = "";

        #endregion

        #region Metodos

        public FrmGetPuc()
        {
            InitializeComponent();
        }

        public void LlenarGrillaTiposCuentas() 
        {
            DgvTiposCuentas.Columns.Clear();
            dsTiposCuentas.Tables.Clear();
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "SCLC"),
                                                new SqlParameter("@Codigo", TxtCodigoCuenta.Texto.Trim()) };

            DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros,
                                                    ConexionDB.getInstancia().Conexion(Database, null));
            dtTiposCuentas = ds.Tables[0].Copy();

            dsTiposCuentas.Tables.Add(dtTiposCuentas);

            DataViewManager Dvmanager = new DataViewManager(dsTiposCuentas);
            DataView dvMain = Dvmanager.CreateDataView(dsTiposCuentas.Tables[0]);

            DgvTiposCuentas.OptionsBehavior.AutoPopulateColumns = false;
            GctrlTiposCuentas.DataSource = dvMain;


            string[] captions = new[] { "Código", "Descripción", "Sel"};
            GridColumn[] col = new GridColumn[dsTiposCuentas.Tables[0].Columns.Count];
            for (int i = 0; i < dsTiposCuentas.Tables[0].Columns.Count; i++)
            {
                col[i] = DgvTiposCuentas.Columns.AddField(dsTiposCuentas.Tables[0].Columns[i].Caption.Trim());
                col[i].VisibleIndex = i;
                col[i].Caption = captions[i];

                if (i == 0)
                {
                    col[i].Visible = false;
                }
                col[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            col[1].Width = 340;  //Descripción
            col[2].Width = 30;  //Sel
   

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textSoloLectura = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            textSoloLectura.ReadOnly = true;

            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit memo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            memo.ReadOnly = false;            

            col[1].ColumnEdit = textSoloLectura;
            col[2].ColumnEdit = memo;

            Funciones.getInstancia().Configurar_Grid(DgvTiposCuentas);
            DgvTiposCuentas.OptionsView.ColumnAutoWidth = false;
            DgvTiposCuentas.OptionsCustomization.AllowSort = false;
            DgvTiposCuentas.OptionsBehavior.Editable = false;
        }

        public string CodigoClasificacion(String codigo) 
        {
            String codigoRetorno = "";

            if (CmbTipoCueta.SelectedIndex == 0)
            {
                codigoRetorno = codigo;
            }

            if (CmbTipoCueta.SelectedIndex == 1)
            {
                if (codigo.Length > 6)
                {
                    codigoRetorno = codigo.Substring(0, 6);
                }
                else
                {
                    codigoRetorno = codigo;
                }               
            }

            if (CmbTipoCueta.SelectedIndex == 2)
            {
                if (codigo.Length > 4)
                {
                    codigoRetorno = codigo.Substring(0, 4);
                }
                else
                {
                    codigoRetorno = codigo;
                } 
            }

            if (CmbTipoCueta.SelectedIndex == 3)
            {
                if (codigo.Length > 2)
                {
                    codigoRetorno = codigo.Substring(0, 2);
                }
                else
                {
                    codigoRetorno = codigo;
                } 
            }

            if (CmbTipoCueta.SelectedIndex == 4)
            {
                if (codigo.Length > 1)
                {
                    codigoRetorno = codigo.Substring(0, 1);
                }
                else
                {
                    codigoRetorno = codigo;
                } 
            }

            return codigoRetorno;
        }

        public void ClasificacionCodigo(String codigo) 
        {

            if (codigo.Length > 6)
            {
                CmbTipoCueta.SelectedIndex = 0;
            }               

            if (codigo.Length == 6)
            {
                CmbTipoCueta.SelectedIndex = 1;
            }

            if (codigo.Length == 4)
            {
                CmbTipoCueta.SelectedIndex = 2;
            }

            if (codigo.Length == 2)
            {
                CmbTipoCueta.SelectedIndex = 3;
            }

            if (codigo.Length == 1)
            {
                CmbTipoCueta.SelectedIndex = 4;
            }
        }

        public bool ValidarCodigo(String codigo) 
        {
            bool retorno = true;

            if (CmbTipoCueta.SelectedIndex == 0)
            {
                if (codigo.Length < 7)
                {
                    XtraMessageBox.Show("El código no es un auxiliar", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }

            if (CmbTipoCueta.SelectedIndex == 1)
            {
                if (codigo.Length !=6)
                {
                    XtraMessageBox.Show("El código no es una subcuenta", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }

            if (CmbTipoCueta.SelectedIndex == 2)
            {
                if (codigo.Length != 4)
                {
                    XtraMessageBox.Show("El código no es una cuenta", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }
            if (CmbTipoCueta.SelectedIndex == 3)
            {
                if (codigo.Length != 2)
                {
                    XtraMessageBox.Show("El código no es un grupo", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }

            if (CmbTipoCueta.SelectedIndex == 4)
            {
                if (codigo.Length != 1)
                {
                    XtraMessageBox.Show("El código no es una clase", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }

            return retorno;
        
        }

        private void Recuperar(String codigo)
        {
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "R"),
                                                new SqlParameter("@Codigo", codigo)};

            DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros,
                                                    ConexionDB.getInstancia().Conexion(Database, null));
        }

        public void ConsultarCuenta(String codigo) 
        {
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "S"),
                                                new SqlParameter("@Codigo", codigo)};

            DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros,
                                                    ConexionDB.getInstancia().Conexion(Database, null));
            if (ds.Tables[0].Rows.Count>0)
            {
                int activo = Convert.ToInt32(ds.Tables[0].Rows[0]["MarcaBorrado"]);
                if (activo==0)
                {
                    if (DialogResult.Yes == XtraMessageBox.Show("El código que intenta ingresar fue eliminado. ¿Desea recuperar el registro? ", Resources.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Recuperar(TxtCodigoCuenta.Texto);
                        ConsultarCuenta(TxtCodigoCuenta.Texto);
                    }
                    else
                    {
                        TxtCodigoCuenta.Focus();
                    }
                }
                else
                {
                    Modo = "E";
                    TxtNombreCuenta.Texto = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    //TxtFormatoVersion.Text = ds.Tables[0].Rows[0]["Version"].ToString();
                    //TxtCodigoDian.Text = ds.Tables[0].Rows[0]["Dian"].ToString();
                    //TxtLblClasificacion.Codigo = ds.Tables[0].Rows[0]["Clasificacion"].ToString();
                    //TxtLblClasificacion.Edit();
                    //if (String.IsNullOrEmpty(TxtLblClasificacion.Codigo))
                    //{
                    //    TxtLblClasificacion.Codigo = "";
                    //    TxtLblClasificacion.Borrar();
                    //}

                    ChkCentroCosto.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Ccosto"]);
                    ChkTerceros.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Tercero"]);

                    CmbTipoCueta.Enabled = false;
                    TxtCodigoCuenta.Enabled = false;
                }                
            }
            else
            {
                Modo = "N";
                TxtNombreCuenta.Texto = "";
                //TxtCodigoDian.Text = "";
                //TxtCodigoDian.Text = "";
                //TxtLblClasificacion.Codigo = "";
                //TxtLblClasificacion.Borrar();
                ChkCentroCosto.Checked = false;
                ChkTerceros.Checked = false;

                CmbTipoCueta.Enabled = true;
                TxtCodigoCuenta.Enabled = true;
            }

            LlenarGrillaTiposCuentas();

            if (CmbTipoCueta.SelectedIndex == 0)
            {
                DgvTiposCuentas.OptionsBehavior.Editable = true;
            }
            else
            {
                DgvTiposCuentas.OptionsBehavior.Editable = false;
            }
        }

        private String TipoCuenta(GridView view, int row)
        {
            string tipo = "";
            GridColumn col = view.Columns["Codigo"];
          
            tipo = Convert.ToString(view.GetRowCellValue(row, col));

            return tipo;
        }

        public void Guardar() 
        {
            if (Validar())
            {
                //if (Modo != "E")
                //{
                    Nuevo();

                    EliminarPucClasificacionDet();
                
                    for (int i = 0; i < DgvTiposCuentas.RowCount; i++)
                    {
                        
                        String det_codigo = DgvTiposCuentas.GetRowCellDisplayText(i, DgvTiposCuentas.Columns["Codigo"]);
                        String det_Puc = TxtCodigoCuenta.Texto;

                        bool sel = Convert.ToBoolean(DgvTiposCuentas.GetRowCellValue(i, DgvTiposCuentas.Columns["Sel"]));
                        if (sel)
                        {
                            InsertarPucClasificacionDet(det_codigo, det_Puc);
                        }
                        
                    }

                    DialogResult = DialogResult.OK;
                //}
            }
        }

        public void EliminarPucClasificacionDet() 
        {
            SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","D"),
                                                    new SqlParameter("@CodigoPuc",TxtCodigoCuenta.Texto.Trim())};

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_ClasificacionPucDetalles", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

        }

        public bool Validar()
        {
            bool retorno = true;
            if (String.IsNullOrEmpty(TxtCodigoCuenta.Texto))
            {
                retorno = false;
                XtraMessageBox.Show("Debe digitar un código para la cuenta", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCodigoCuenta.Focus();
            }

            if (!String.IsNullOrEmpty(TxtCodigoCuenta.Texto) && String.IsNullOrEmpty(TxtNombreCuenta.Texto))
            {
                retorno = false;
                XtraMessageBox.Show("Debe digitar el nombre de la cuenta", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombreCuenta.Focus();
            }

            return retorno;
        }

        public void Nuevo()
        {

            SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","IUPUC"),
                                                    new SqlParameter("@Codigo",TxtCodigoCuenta.Texto),
                                                    new SqlParameter("@Nombre",TxtNombreCuenta.Texto),
                                                    //new SqlParameter("@Version",TxtFormatoVersion.Text),
                                                    //new SqlParameter("@CodigoDIAN",TxtCodigoDian.Text),
                                                    //new SqlParameter("@TipoConcepto",TxtLblClasificacion.Codigo??""),
                                                    new SqlParameter("@Ccosto",ChkCentroCosto.Checked),
                                                    new SqlParameter("@Tercero",ChkTerceros.Checked)};

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_Puc", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            //XtraMessageBox.Show("Proceso realizado con éxito", Referencias.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
           // 
        }

        public void InsertarTipoDiferido() 
        {
            //SqlParameter[] parametros = new[] {    new SqlParameter("@Operacion","VIDF"),
            //                                       new SqlParameter("@Codigo",TxtCodigoCuenta.Text)};
            //DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","I"),
            //                                        new SqlParameter("@DifPuc",TxtCodigoCuenta.Text),
            //                                        new SqlParameter("@DifNom",TxtNombreCuenta.Text),
            //                                        new SqlParameter("@DifDebe",""),
            //                                        new SqlParameter("@DifHaber","")};

            //    bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_PucTipoDiferido", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
            //}
        }

        public void InsertarTipoActivo() 
        {
            //SqlParameter[] parametros = new[] {    new SqlParameter("@Operacion","VIAF"),
            //                                       new SqlParameter("@Codigo",TxtCodigoCuenta.Text)};
            //DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            //if (ds.Tables[0].Rows.Count==0)
            //{
            //    SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","I"),
            //                                        new SqlParameter("@tacpuc",TxtCodigoCuenta.Text),
            //                                        new SqlParameter("@tacnom",TxtNombreCuenta.Text),
            //                                        new SqlParameter("@tactiempo","0"),
            //                                        new SqlParameter("@tacdepre","0"),
            //                                        new SqlParameter("@tacgastos",""),
            //                                        new SqlParameter("@tacdepre_aa","")};

            //    bool IsDone = DataBase.ExecuteNonQuery("PA_TipoActivo", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
            //}            
        }

        private String MaxCodigoConcepto()
        {
            //SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "GETMAXCON") };

            //DataSet dsCods = new DataSet();

            //dsCods = DataBase.ExecuteQuery("PA_REGEMP", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            //String maxCod = "0";

            //if (dsCods.Tables.Count != 0)
            //{
            //    maxCod = dsCods.Tables[0].Rows[0][0].ToString();
            //}

            //if (maxCod == "")
            //{
            //    maxCod = "00";
            //}

            //return maxCod;
            return "";
        }

        public void InsertarConceptoNomina() 
        {
            //SqlParameter[] parametros = new[] {    new SqlParameter("@Operacion","VICN"),
            //                                       new SqlParameter("@Codigo",TxtCodigoCuenta.Text)};
            //DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    nuevoCodCon = Funciones.getInstancia().RellenarCadenaPorLaIzquierda((MaxCodigoConcepto().ToInt() + 1).ToString(), '0', 4);

            //    SqlParameter[] parametros1 = new[] { new SqlParameter("@Operacion", "INSCONNOM"),
            //                   new SqlParameter("@concod", nuevoCodCon),
            //                   new SqlParameter("@connom", TxtNombreCuenta.Text),
            //                   new SqlParameter("@conaux", TxtCodigoCuenta.Text),
            //                   new SqlParameter("@concre", ""),
            //                   new SqlParameter("@conapli", "1"),
            //                   new SqlParameter("@contip", "1"),
            //                   new SqlParameter("@consal", "0"),
            //                   new SqlParameter("@conpri", "0"),
            //                   new SqlParameter("@convac", "0" ),
            //                   new SqlParameter("@conret", "0"),
            //                   new SqlParameter("@conpvac", "0"),
            //                   new SqlParameter("@conpor", "0")};

            //    bool IsDone = DataBase.ExecuteNonQuery("PA_REGEMP", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
            //}
            //else
            //{
            //    nuevoCodCon = ds.Tables[0].Rows[0]["conCod"].ToString();
            //}
        }

        public void InsertarPucClasificacionDet(String codigo,String puc) 
        {
            SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","I"),
                                                    new SqlParameter("@CodigoClasificacion",codigo),
                                                    new SqlParameter("@CodigoPuc",puc)};

            bool IsDone = DataBase.ExecuteNonQuery("Contabilidad.PA_ClasificacionPucDetalles", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
        }

        public bool ConsultarCodigo(String codigo) 
        {
            bool retorno = false;
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion", "S"),
                                                new SqlParameter("@Codigo", codigo)};

            DataSet ds = DataBase.ExecuteQuery("Contabilidad.PA_Puc", "datos", CommandType.StoredProcedure, parametros,
                                                    ConexionDB.getInstancia().Conexion(Database, null));

            if (ds.Tables[0].Rows.Count > 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool ValidarNivelAnterior(String codigo) 
        {
            bool retorno = true;

            if (CmbTipoCueta.SelectedIndex == 0)// Auxiliar
            {
                if (!ConsultarCodigo(codigo.Substring(0,6)))
                {
                    XtraMessageBox.Show("Debe ingresar la subcuenta " + codigo.Substring(0, 6), Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }                                
            }

            if (CmbTipoCueta.SelectedIndex == 1)// Subcuenta
            {
                if (!ConsultarCodigo(codigo.Substring(0, 4)))
                {
                    XtraMessageBox.Show("Debe ingresar la cuenta " + codigo.Substring(0, 4), Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }  
            }

            if (CmbTipoCueta.SelectedIndex == 2)// cuenta
            {
                if (!ConsultarCodigo(codigo.Substring(0, 2)))
                {
                    XtraMessageBox.Show("Debe ingresar el grupo " + codigo.Substring(0, 2), Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }
            if (CmbTipoCueta.SelectedIndex == 3)// grupo
            {
                if (!ConsultarCodigo(codigo.Substring(0, 1)))
                {
                    XtraMessageBox.Show("Debe ingresar la clase " + codigo.Substring(0, 1), Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                    TxtCodigoCuenta.Focus();
                }
            }
          
            return retorno;
        }

        #endregion

        #region Eventos

        private void FrmGetPuc_Load(object sender, EventArgs e)
        {
            //TxtLblClasificacion.PerfilShow = Perfilador.getInstancia().CargarPerfil("ClasificacionPuc");
            //TxtLblClasificacion.database = Database;
            //TxtLblClasificacion.DesHabilitarBtnExcel = true;
            //TxtLblClasificacion.DesHabilitarBtnGuardar = true;
            //TxtLblClasificacion.Disable();
            //TxtLblClasificacion.Usuario = Usuario;
            //TxtLblClasificacion.PasarUsuario = true;
            

            LlenarGrillaTiposCuentas();

            if (Modo =="E")
            {
                CmbTipoCueta.Enabled = false;
                TxtCodigoCuenta.Enabled = false;
                TxtCodigoCuenta.Texto = ID.Trim();
                ConsultarCuenta(ID.Trim());
                ClasificacionCodigo(ID.Trim());
            }

            if (CmbTipoCueta.SelectedIndex == 0)
            {
                DgvTiposCuentas.OptionsBehavior.Editable = true;
            }
            else
            {
                DgvTiposCuentas.OptionsBehavior.Editable = false;
            }
        }
       

        //private void TxtCodigoCuenta_Validated(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(TxtCodigoCuenta.Text))
        //    {
        //        if (CmbTipoCueta.SelectedIndex == 0)
        //        {
        //            DgvTiposCuentas.OptionsBehavior.Editable = true;
        //        }
        //        else
        //        {
        //            DgvTiposCuentas.OptionsBehavior.Editable = false;
        //        }
        //    }
        //}

        private void BtnPuc_Click(object sender, EventArgs e)
        {
            FrmShowIt frmShowit = new FrmShowIt();
            frmShowit.database = Database;
            frmShowit.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            frmShowit.DesHabilitarBtnExcel();
            frmShowit.DesHabilitarBtnGuardar();
            frmShowit.DesHabilitarBtnImprimir();
            frmShowit.DesHabilitarBtnAñadir();
            frmShowit.DesHabilitarBtnEditar();
            frmShowit.DesHabilitarBtnEliminar();
            frmShowit.Ordenar = OrdenarPor.CampoCodigo;
            frmShowit.ShowDialog();

            if (frmShowit.DialogResult == DialogResult.OK)
            {
                if (TxtCodigoCuenta.Enabled == true)
                {
                    TxtCodigoCuenta.Texto = CodigoClasificacion(frmShowit.Seleccion.Trim());
                }
                else
                {
                    TxtCodigoCuenta.Texto = frmShowit.Seleccion.Trim();
                }
                
                TxtCodigoCuenta.Focus();       

                if (TxtCodigoCuenta.Enabled == false)
                {
                    ClasificacionCodigo(frmShowit.Seleccion.Trim());
                    ConsultarCuenta(TxtCodigoCuenta.Texto);                    
                }
                
            }            
        }

        private void TxtCodigoCuenta_Validating(object sender, CancelEventArgs e)
        {
            //CmbTipoCueta.SelectedIndex = CladificacionCuenta(TxtCodigoCuenta.Text.Trim());
            if (!String.IsNullOrEmpty(TxtCodigoCuenta.Texto))
            {
                if (ValidarCodigo(TxtCodigoCuenta.Texto.Trim()))
                {
                    if (ValidarNivelAnterior(TxtCodigoCuenta.Texto.Trim()))
                    {
                        ConsultarCuenta(TxtCodigoCuenta.Texto);
                    }                   
                }
            }
        
        }

        private void DgvTiposCuentas_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            bool v = Convert.ToBoolean(view.GetFocusedRowCellValue(view.Columns["Sel"]));
            if (view.FocusedColumn.FieldName == "Sel" && !v)//&& TipoCuenta(view, view.FocusedRowHandle) == "0013"
            {
                if (String.IsNullOrEmpty(TxtCodigoCuenta.Texto)||CmbTipoCueta.SelectedIndex!=0)
                {
                    e.Cancel = true; 
                }
            }           
        }

        private void DgvTiposCuentas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            bool v = Convert.ToBoolean(e.Value);
            //if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0013" && v) // Activos Diferidos
            //{
            //    if (Validar())
            //    {
            //        Nuevo();
            //        InsertarTipoDiferido();
            //        InsertarPucClasificacionDet("0013", TxtCodigoCuenta.Texto.Trim());


            //        FrmGetTipoDiferidos frm = new FrmGetTipoDiferidos();
            //        frm.Database = Database;
            //        frm.Modo = "E";
            //        frm.ID = TxtCodigoCuenta.Texto.Trim();
            //        frm.ShowDialog();
            //        if (frm.DialogResult != DialogResult.OK)
            //        {
            //            view.SetFocusedValue(false);
            //        }
            //    }
               
            //}

            //if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0012" && v) //
            //{
            //    if (Validar())
            //    {
            //        Nuevo();
            //        InsertarTipoActivo();
            //        InsertarPucClasificacionDet("0012", TxtCodigoCuenta.Texto.Trim());

            //        FrmGetTipoActivo frm = new FrmGetTipoActivo();
            //        frm.Database = Database;
            //        frm.Modo = "E";
            //        frm.ID = TxtCodigoCuenta.Texto.Trim();
            //        frm.ShowDialog();
            //        if (frm.DialogResult != DialogResult.OK)
            //        {
            //            view.SetFocusedValue(false);
            //        }
            //    }
            //}

            //if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0011" && v)
            //{
            //    if (Validar())
            //    {
            //        Nuevo();
            //        InsertarConceptoNomina();
            //        InsertarPucClasificacionDet("0011", TxtCodigoCuenta.Texto.Trim());

            //        FrmGetConceptoNomina frm = new FrmGetConceptoNomina();
            //        frm.Database = Database;
            //        frm.Modo = "E";
            //        frm.ID = nuevoCodCon;
            //        frm.DeshabilitarCuenta();
            //        frm.ShowDialog();
            //        if (frm.DialogResult != DialogResult.OK)
            //        {
            //            view.SetFocusedValue(false);
            //        }
            //    }
            //}

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0006" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0006", TxtCodigoCuenta.Texto.Trim());

                    FrmGetCajaMenor frm = new FrmGetCajaMenor();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0005" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0005", TxtCodigoCuenta.Texto.Trim());

                    FrmGetCuentasBancarias frm = new FrmGetCuentasBancarias();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0004" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0004", TxtCodigoCuenta.Texto.Trim());

                    FrmGetTarifaIva frm = new FrmGetTarifaIva();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0002" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0002", TxtCodigoCuenta.Texto.Trim());

                    FrmGetRetenciones frm = new FrmGetRetenciones();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.OpcionGet = "reteica";
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0003" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0003", TxtCodigoCuenta.Texto.Trim());

                    FrmGetRetenciones frm = new FrmGetRetenciones();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.OpcionGet = "reteiva";
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0001" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0001", TxtCodigoCuenta.Texto.Trim());

                    FrmGetRetenciones frm = new FrmGetRetenciones();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.OpcionGet = "retefte";
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }

            if (view.FocusedColumn.FieldName == "Sel" && TipoCuenta(view, view.FocusedRowHandle) == "0014" && v)
            {
                if (Validar())
                {
                    Nuevo();
                    InsertarPucClasificacionDet("0014", TxtCodigoCuenta.Texto.Trim());

                    FrmGetRetenciones frm = new FrmGetRetenciones();
                    frm.Database = Database;
                    frm.Modo = "E";
                    frm.ID = TxtCodigoCuenta.Texto.Trim();
                    frm.OpcionGet = "retecree";
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        view.SetFocusedValue(false);
                    }
                }
            }
        }

        #endregion


        private void CmbTipoCueta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipoCueta.SelectedIndex == 2)
            {
                //TxtLblClasificacion.Enable();
                TxtCodigoCuenta.MaxLenght = 4;
            }
            //else
            //{
            //    TxtLblClasificacion.Codigo = "";
            //    TxtLblClasificacion.Id = "";
            //    TxtLblClasificacion.Borrar();
            //    TxtLblClasificacion.Disable();
            //}

            if (CmbTipoCueta.SelectedIndex == 1)
            {
                ChkCentroCosto.Enabled = true;
                ChkTerceros.Enabled = true;
                TxtCodigoCuenta.MaxLenght = 6;
            }
            else
            {
                ChkCentroCosto.Enabled = false;
                ChkTerceros.Enabled = false;

                ChkTerceros.Checked = false;
                ChkCentroCosto.Checked = false;
            }

            if (CmbTipoCueta.SelectedIndex == 0)
            {
                DgvTiposCuentas.OptionsBehavior.Editable = true;
                TxtCodigoCuenta.MaxLenght = 12;
            }
            else
            {
                DgvTiposCuentas.OptionsBehavior.Editable = false;
            }

            if (CmbTipoCueta.SelectedIndex == 3)
            {
                TxtCodigoCuenta.MaxLenght = 2;
            }

            if (CmbTipoCueta.SelectedIndex == 4)
            {
                TxtCodigoCuenta.MaxLenght = 1;
            }
        }

        private void TxtCodigoCuenta_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtCodigoCuenta.Texto))
            {
                if (CmbTipoCueta.SelectedIndex == 0)
                {
                    DgvTiposCuentas.OptionsBehavior.Editable = true;
                }
                else
                {
                    DgvTiposCuentas.OptionsBehavior.Editable = false;
                }
            }
        }

        private void CmbTipoCueta_Enter(object sender, EventArgs e)
        {
            CmbTipoCueta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
        }

        private void CmbTipoCueta_Leave(object sender, EventArgs e)
        {
            CmbTipoCueta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }


    }
}