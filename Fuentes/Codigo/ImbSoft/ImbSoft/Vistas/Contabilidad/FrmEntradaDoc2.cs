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
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;
//using Contabilidad.Reports;


namespace Contabilidad
{
    public partial class FrmEntradaDoc2 : FormularioBase
    {

        #region Propiedades

        public string Database { get; set; }
        public string Modo { get; set; }        
        public int MesPeriodo { get; set; }
        public int AñoPeriodo { get; set; }
        public String Usuario { get; set; }
        public string CodigoActivo { get; set; }
        public String Documento { get; set; }
        public String Fuente { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public DataTable DtAsientos { get; set; }
        public String Consecutivo { get; set; }
        public bool desdeDO { get; set; }

        #endregion

        #region variables

        private DataSet dsCuenta = new DataSet();
        private DataTable dtCuenta = new DataTable();
        private bool desdeVentana = false;
        private String texCcosto = "";
        private String texTercero = "";
        private DataTable dtCuentaAgrupada = new DataTable();
        private bool todoBn = false;
        private DataSet dsImprimir = new DataSet();
        private String documento;
        private String fuente;
        private bool encontrado = false;
        private String detalleActual = "";
        public String[] datosNotaAclaratoria;
        private String concepto = "0074";
        private String consecutivo = "";
        private String notaAclaratoria = "";
        private String codCcosto = "";
        private string nombreCcosto = "";

        #endregion

        #region Metodos

        public FrmEntradaDoc2()
        {
            InitializeComponent();
        }

        private void EstructuraDtCuentaAgrupada()
        {
            DataColumn[] columnas = new DataColumn[7];
            columnas[0] = new DataColumn("codigo");
            columnas[1] = new DataColumn("detalle");
            columnas[2] = new DataColumn("ccosto");
            columnas[3] = new DataColumn("tercero");
            columnas[4] = new DataColumn("debito");
            columnas[5] = new DataColumn("credito");
            columnas[6] = new DataColumn("numOT");

            dtCuentaAgrupada.Columns.AddRange(columnas);            
        }

        private void LlenarGrillaCuentas(DataTable dt=null)
        {
            DgvCuenta.Columns.Clear();
            dsCuenta.Tables.Clear();
            if (dt==null)
            {
                SqlParameter[] parametros = new[] { new SqlParameter("@Operacion","SD"),
                                                new SqlParameter("@Fuente",fuente),
                                                new SqlParameter("@Consecutivo",documento),
                                                new SqlParameter("@Fecha",Funciones.getInstancia().Datetime2String(TxtFecha.DateTime))};

                DataSet ds = DataBase.ExecuteQuery("PA_ContEntrarDocOt", "datos", CommandType.StoredProcedure, parametros,
                                                            ConexionDB.getInstancia().Conexion(Database, null));
                dtCuenta = ds.Tables[0].Copy();
            }
            else
            {
                dtCuenta = dt;
            }
                                  
            dsCuenta.Tables.Add(dtCuenta);    
                 
            DataViewManager Dvmanager = new DataViewManager(dsCuenta);
            DataView dvMain = Dvmanager.CreateDataView(dsCuenta.Tables[0]);

            DgvCuenta.OptionsBehavior.AutoPopulateColumns = false;
            GctrlCuenta.DataSource = dvMain;

            string[] captions = new[] { "Código","Nombre","Detalle", "C. Costo","DesCcosto", "Tercero","NomTercero", "Debitos", "Creditos","RCcosto","OT","DetOT" };
            GridColumn[] col1 = new GridColumn[dsCuenta.Tables[0].Columns.Count];
            for (int i = 0; i < dsCuenta.Tables[0].Columns.Count; i++)
            {
                col1[i] = DgvCuenta.Columns.AddField(dsCuenta.Tables[0].Columns[i].Caption.Trim());
                col1[i].VisibleIndex = i;
                col1[i].Caption = captions[i];
                if (i == 4 || i == 6 || i == 1 || i == 9 || i == 11)
                {
                    col1[i].Visible = false;
                }

                col1[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            col1[0].Width = 95;   //Código
            col1[1].Width = 95;   //Nombre
            col1[2].Width = 265;  //Detalle
            col1[3].Width = 60;   // C. Costo
            col1[5].Width = 100;  // Tercero
            col1[7].Width = 100;  // Debitos
            col1[8].Width = 100;
            col1[10].Width = 70;// Creditos 

            col1[7].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            col1[8].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    
            Funciones.getInstancia().Configurar_Grid(DgvCuenta);
            DgvCuenta.OptionsView.ColumnAutoWidth = false;
            DgvCuenta.OptionsBehavior.Editable = true;
            DgvCuenta.OptionsCustomization.AllowSort = false;
            DgvCuenta.OptionsBehavior.AllowIncrementalSearch = false;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textoReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            textoReadOnly.ReadOnly = true;
            DgvCuenta.Columns[0].ColumnEdit = textoReadOnly;
            DgvCuenta.Columns[10].ColumnEdit = textoReadOnly;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit texto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            texto.ReadOnly = false;
            DgvCuenta.Columns[2].ColumnEdit = texto;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textoCcosto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            textoCcosto.ReadOnly = false;
            textoCcosto.MaxLength = 4;
            DgvCuenta.Columns[3].ColumnEdit = textoCcosto;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textoTercero = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            textoTercero.ReadOnly = false;
            textoTercero.MaxLength = 20;
            DgvCuenta.Columns[5].ColumnEdit = textoTercero;

            //DevExpress.XtraEditors.Repository.RepositoryItemTextEdit valor = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            //valor.ReadOnly = false;
            //valor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //valor.Mask.EditMask = "n";
            //valor.Mask.UseMaskAsDisplayFormat = true;
            ////valor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            ////valor.Appearance.Options.UseTextOptions = true;
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit valorNumerico = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            valorNumerico.ReadOnly = false;
            valorNumerico.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            valorNumerico.Mask.EditMask = "n";
            valorNumerico.Mask.UseMaskAsDisplayFormat = true;

            DgvCuenta.Columns[7].ColumnEdit = valorNumerico;
            DgvCuenta.Columns[8].ColumnEdit = valorNumerico;

        }

        public void Añadir()
        {
            FrmAddCuentaEntradaDoc frm = new FrmAddCuentaEntradaDoc();
            frm.Database = Database;
            frm.Usuario = Usuario;
            if (desdeDO) { frm.CambiarCaption(); }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                object[] fila = new object[] { frm.Auxiliar, frm.NomAux, frm.Detalle, frm.Ccosto, frm.NomCcos, frm.Tercero, frm.NomTer, frm.Debito, frm.Credito, 0, frm.numOT, frm.DetOT };
                dtCuenta.Rows.Add(fila);
                DgvCuenta.RefreshData();
                DgvCuenta.SetMasterRowExpanded(DgvCuenta.RowCount - 1, true);
            }
            //FrmShowIt añadir = new FrmShowIt();
            //añadir.database = Database;
            //añadir.PerfilShow = Perfilador.getInstancia().CargarPerfil("Puc");
            //añadir.DesHabilitarBtnAñadir();
            //añadir.DesHabilitarBtnEditar();
            //añadir.DesHabilitarBtnEliminar();
            //añadir.DesHabilitarBtnExcel();
            //añadir.DesHabilitarBtnGuardar();
            //añadir.DesHabilitarBtnImprimir();
            //añadir.Ordenar = OrdenarPor.CampoCodigo;
            //añadir.ShowDialog();
            //if (añadir.DialogResult == DialogResult.OK)
            //{
            //    if (Auxiliar(añadir.Seleccion.Trim()))
            //    {                    
            //        AñadirCuenta(añadir.Seleccion.Trim(), añadir.DescripcionSeleccion.Trim());
            //        DgvCuenta.Focus();
            //        DgvCuenta.FocusedRowHandle = (DgvCuenta.RowCount - 1);
            //        DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Ccosto"]);
            //    }
            //    else
            //    {
            //        Añadir();
            //    }
            //}
        }

        private void AñadirCuenta(String codCuenta, String nombre)
        {
            bool añadir = true;

            bool rCcosto = false;
            string sql = "SELECT glcct FROM accglpuc WHERE glcod='"+codCuenta+"'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null,ConexionDB.getInstancia().Conexion(Database, null));
            
            if (ds.Tables[0].Rows.Count>0)
            {
                rCcosto = Convert.ToBoolean(ds.Tables[0].Rows[0]["glcct"]);
            }

            if (añadir)
            {
                try
                {
                    String detalle = "";
                    string cCosto = "";
                    string nCcosto = "";
                    if (String.IsNullOrEmpty(detalleActual))
                    {
                        detalle = nombre;
                    }
                    else
                    {
                        detalle = detalleActual;
                    }

                    if (Tipo == "OT")
                    {
                        nCcosto = nombreCcosto;
                        cCosto = codCcosto;
                    }
                    else
                    {
                        nCcosto = "";
                        cCosto = "";  
                    }

                    if (rCcosto ==false)
                    {
                        nCcosto = "";
                        cCosto = "";
                    }
                    //"Código","Nombre","Detalle", "C. Costo","DesCcosto", "Tercero","NomTercero", "Debitos", "Creditos","RCcosto"
                    object[] fila = new object[] { codCuenta, nombre, detalle, cCosto, nCcosto, "", "", 0, 0, rCcosto };
                    
                    dtCuenta.Rows.Add(fila);
                    DgvCuenta.RefreshData();
                    DgvCuenta.SetMasterRowExpanded(DgvCuenta.RowCount - 1, true);
                }
                catch (Exception e)
                {

                    XtraMessageBox.Show(e.Message);
                }
            }
        }

        private void AñadirCcosto(String filtro)
        {
            FrmShowIt añadir = new FrmShowIt();
            añadir.database = Database;
            añadir.PerfilShow = Perfilador.getInstancia().CargarPerfil("CC");
            añadir.DesHabilitarBtnAñadir();
            añadir.DesHabilitarBtnEditar();
            añadir.DesHabilitarBtnEliminar();
            añadir.DesHabilitarBtnExcel();
            añadir.DesHabilitarBtnGuardar();
            añadir.DesHabilitarBtnImprimir();
            //añadir.Filtro = filtro;
            añadir.Ordenar = OrdenarPor.CampoNombre;          
            añadir.ShowDialog();
            if (añadir.DialogResult == DialogResult.OK)
            {
                desdeVentana = true;         
                ActualizarCcosto(DgvCuenta.FocusedRowHandle,añadir.Seleccion.Trim(), añadir.DescripcionSeleccion.Trim());
                DgvCuenta.Focus();

                DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
                DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Tercero"]);               
            }
        }

        private void AñadirTercero(string filtro)
        {
            FrmShowIt añadir = new FrmShowIt();
            añadir.database = Database;
            añadir.PerfilShow = Perfilador.getInstancia().CargarPerfil("Terceros");
            añadir.DesHabilitarBtnAñadir();
            añadir.DesHabilitarBtnEditar();
            añadir.DesHabilitarBtnEliminar();
            añadir.DesHabilitarBtnExcel();
            añadir.DesHabilitarBtnGuardar();
            añadir.DesHabilitarBtnImprimir();
            //añadir.Filtro = filtro;
            añadir.Ordenar = OrdenarPor.CampoNombre;
            añadir.ShowDialog();
            if (añadir.DialogResult == DialogResult.OK)
            {
                desdeVentana = true;
                ActualizarTercero(DgvCuenta.FocusedRowHandle, añadir.IdentificacionSeleccion.Trim(), añadir.DescripcionSeleccion.Trim());
                DgvCuenta.Focus();

                DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
                DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Debe"]);
            }
        }

        private void ActualizarCcosto(int indice,String codigo, String nombre) 
        {
            if (desdeVentana)
            {
                desdeVentana = false;
                DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["Ccosto"], codigo);               
            }

            DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["DesCcosto"], nombre);
            DatosGrilla();

            DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
            DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Tercero"]); 
        }

        private void ActualizarTercero(int indice, String codigo, String nombre)
        {
            if (desdeVentana)
            {
                desdeVentana = false;
                DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["Tercero"], codigo);
            }

            DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["NomTercero"], nombre);
            DatosGrilla();

            DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
            DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Debe"]);
        }

        public bool Auxiliar(String id)
        {
            bool r = true;
            if (!String.IsNullOrEmpty(id))
            {
                if (id.Length > 6)
                {
                    r = true;
                }
                else
                {
                    r = false;

                    XtraMessageBox.Show("La cuenta seleccionada de debe ser una cuenta auxiliar", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }

        private void ConsultarConsecutivo(String glCod)
        {
            String sql = "select LTRIM(RTRIM(DBO.PadL(ftecon+1,6,'0'))) as ftecon from profuentes where ftecod ='" + glCod + "' AND delmrk='1'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            string consecutivo = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                consecutivo = " " + (ds.Tables[0].Rows[0]["ftecon"]).ToString();
            }

            TxtDocumento.Text = consecutivo.ToString();            
        }

        public void DatosGrilla() 
        {
            if (DgvCuenta.Columns.Count>0)
            {
                TxtCuenta.Text = " " + DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["Cuenta"]);
                TxtCcosto.Text = " " + DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["DesCcosto"]);
                TxtTercero.Text = " " + DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["NomTercero"]);
                TxtOT.Text = " " + DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["DetOT"]);
            }            
        }

        private void BuscarCcosto(int indice,String codigo)
        {
            String sql = "SELECT ccocod,cconom FROM procencos WHERE ccocod ='" + codigo + "' AND delmrk='1'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            string nombre = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                nombre = " " + (ds.Tables[0].Rows[0]["cconom"]).ToString().Trim();
            }
            else
            {
                XtraMessageBox.Show("El centro de costo no existe.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["Ccosto"], "");
                texCcosto = "";
            }

            ActualizarCcosto(indice, codigo, nombre); 
        }

        private void BuscarTercero(int indice, String codigo)
        {
            String sql = "SELECT ternit,ternom FROM accglter WHERE ternit = '" + codigo + "' AND delmrk='1'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            string nombre = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                nombre = " " + (ds.Tables[0].Rows[0]["ternom"]).ToString().Trim();
            }
            else
            {
                XtraMessageBox.Show("El tercero no existe.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvCuenta.SetRowCellValue(indice, DgvCuenta.Columns["Tercero"], "");
                texTercero = "";
            }

            ActualizarTercero(indice, codigo, nombre);
        }

        public void Totales() 
        {
            if (DgvCuenta.RowCount>0)
            {
                decimal totalDebe = 0;
                decimal totalHaber = 0;
                decimal diferencia = 0;

                for (int i = 0; i < DgvCuenta.RowCount; i++)
                {
                    totalDebe = totalDebe + Convert.ToDecimal(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Debe"]));
                    totalHaber = totalHaber + Convert.ToDecimal(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Haber"]));
                }

                TxtTotalDebe.Text = totalDebe.ToString();
                TxtTotalHaber.Text = totalHaber.ToString();

                diferencia = totalDebe - totalHaber;
                if (diferencia>0)
                {
                    TxtSaldoHaber.Text = diferencia.ToString();
                    TxtSaldoDebe.Text = "0";
                }

                if (diferencia<0)
                {
                    TxtSaldoDebe.Text = diferencia.ToString();
                    TxtSaldoHaber.Text = "0";
                }

                if (diferencia==0)
                {
                    TxtSaldoHaber.Text = "0";
                    TxtSaldoDebe.Text = "0";
                }
            }
            else
            {
                TxtTotalDebe.Text = "0";
                TxtTotalHaber.Text = "0";
                TxtSaldoHaber.Text = "0";
                TxtSaldoDebe.Text = "0";
            }
        }

        public void Eliminar() 
        {

            if (DgvCuenta.RowCount != 0)
            {
                string cuenta = DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["Cuenta"]);
                if (XtraMessageBox.Show("Esta seguro que desea eliminar el registro contable con cuenta: " + cuenta, Resources.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int index = DgvCuenta.GetFocusedDataSourceRowIndex();
                    dtCuenta.Rows.Remove(dtCuenta.Rows[index]);
                    DgvCuenta.RefreshData();
                    Totales();
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un registro", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarTodo() 
        {
            if (DgvCuenta.RowCount != 0)
            {
                string cuenta = DgvCuenta.GetFocusedRowCellDisplayText(DgvCuenta.Columns["Cuenta"]);
                if (XtraMessageBox.Show("Seguro que desea eliminar todos los registro contables: " + cuenta, Resources.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {                    
                    dtCuenta.Rows.Clear();
                    DgvCuenta.RefreshData();
                    Totales();
                }
            }
            else
            {
                XtraMessageBox.Show("Debe existir por lo menos un registro", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarGrilla()
        {
            bool retorno = true;

            if (DgvCuenta.RowCount>0)
            {
                for (int i = 0; i < DgvCuenta.RowCount; i++)
                {
                    for (int j = 0; j < DgvCuenta.Columns.Count; j++)
                    {
                        if (j==3)
                        {
                            if (String.IsNullOrEmpty(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns[j])))
                            {
                                bool rCcosto = Convert.ToBoolean(DgvCuenta.GetRowCellValue(i, DgvCuenta.Columns["RCcosto"]));
                                if (rCcosto)
                                {
                                    XtraMessageBox.Show("No ha especificado el Centro de Costo", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    DgvCuenta.Focus();
                                    DgvCuenta.FocusedRowHandle = i;
                                    DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Ccosto"]);
                                    retorno = false;
                                    break;
                                }
                            }
                        }

                        if (j == 5)
                        {
                            if (String.IsNullOrEmpty(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns[j])))
                            {
                                XtraMessageBox.Show("No ha especificado el Tercero", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                DgvCuenta.Focus();
                                DgvCuenta.FocusedRowHandle = i;
                                DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Tercero"]);
                                retorno = false;
                                break;
                            }
                        }

                        if (j == 7 || j == 8)
                        {
                            decimal debe = Convert.ToDecimal(DgvCuenta.GetRowCellValue(i, DgvCuenta.Columns["Debe"]));
                            decimal haber = Convert.ToDecimal(DgvCuenta.GetRowCellValue(i, DgvCuenta.Columns["Haber"]));

                            if (debe!= 0 && haber != 0)
                            {
                                XtraMessageBox.Show("Defina a que columna le corresponde el valor digitado", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                DgvCuenta.Focus();
                                DgvCuenta.FocusedRowHandle = i;
                                DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Debe"]);
                                SendKeys.Send("{enter}");
                                retorno = false;
                                break;
                            }

                            if (debe == 0 && haber == 0)
                            {
                                XtraMessageBox.Show("Ingrese el valor del debe", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                DgvCuenta.Focus();
                                DgvCuenta.FocusedRowHandle = i;
                                DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Debe"]);
                                SendKeys.Send("{enter}");
                                retorno = false;
                                break;
                            }
                        } 
                    }
                    if (retorno==false)
                    {
                        break;
                    }
                }
            }
            else
            {
                if (Modo!="E")
                {
                    XtraMessageBox.Show("Debe ingresar los registros contables", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = false;
                }
                
            }
            
            return retorno;
        }

        public void Guardar() 
        {
            if (String.IsNullOrEmpty(TxtlblFuente.Codigo))
            {
                XtraMessageBox.Show("Debe ingresar la fuente", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtlblFuente.Focus();
            }
            else
            {
                bool seguir = true;
                if (Modo == "E" || Modo == "OL")
                {
                    if (String.IsNullOrEmpty(TxtDocumento.Text))
                    {
                        seguir = false;
                        XtraMessageBox.Show("Debe ingresar documento", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtDocumento.Focus();
                    }
                }

                if (seguir)
                {
                    if (ValidarGrilla())
                    {
                        if (ValidarFecha())
                        {
                            if (XtraMessageBox.Show("¿Desea guardar los datos del documento?", Resources.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Fecha = TxtFecha.DateTime;
                                Decimal totalDebe = Convert.ToDecimal(TxtTotalDebe.Text);
                                Decimal totalHaber = Convert.ToDecimal(TxtTotalHaber.Text);

                                if (totalDebe != totalHaber)
                                {
                                    XtraMessageBox.Show("El documento aún no esta cuadrado.\n Por favor rectifique.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DgvCuenta.Focus();
                                }
                                else
                                {
                                    bool seg = true;
                                    if (Modo=="E")
                                    {
                                        if (DgvCuenta.RowCount==0)
                                        {
                                            //var explicacion = new FrmGetRazones("0056", Usuario);
                                            //explicacion.Database = Database;
                                            //explicacion.IdDoc = TxtDocumento.Text;

                                            //if (explicacion.ShowDialog() == DialogResult.OK)
                                            //{
                                            //    seg = true;
                                            //}
                                        } 
                                    }
                                    if (seg)
                                    {
                                        RealizarConsultas();
                                    }                                   
                                }
                            }
                        }
                    } 
                } 
                
            }
          
        }

        public bool ValidarFecha()
        {
            bool retorno = true;

            //if (TxtFecha.DateTime.Date < DateTime.Now.Date)
            //{
            //    retorno = false;
            //    XtraMessageBox.Show("La  fecha seleccionada no puede ser menor que la fecha actual.", GLReferences.Properties.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    TxtFecha.Focus();
            //}                

            String sql = "SELECT ccest FROM accglccmes WHERE ccMes ='" + MesPeriodo + "' AND ccAño ='" + AñoPeriodo + "'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));

            bool cierre = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                cierre = Convert.ToBoolean(ds.Tables[0].Rows[0]["ccest"]);
            }  

            if (cierre)
            {                
                XtraMessageBox.Show("Error, el período está cerrado. Por favor verifique.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFecha.Focus();
                return false;
            }

            if (MesPeriodo != TxtFecha.DateTime.Month || AñoPeriodo != TxtFecha.DateTime.Year)
            {
                String mes = Funciones.getInstancia().Numero2Mes(MesPeriodo);                
                XtraMessageBox.Show("El documento que intenta crear no corresponde al periodo que se esta trabajandio (" + mes + " " + AñoPeriodo + "). Por favor verifique.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFecha.Focus();
                return false;
            }

            return retorno;
        }

        private void VerificarConsecutivo() 
        {
            if (Modo!="E")
            {
                SqlParameter[] parametros = new[] { new SqlParameter("@Consecutivo",TxtDocumento.Text.Trim()),
                                                new SqlParameter("@Fuente",TxtlblFuente.Codigo??"")};

                DataSet ds = DataBase.ExecuteQuery("PA_Consecutivo", "consecutivo", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    consecutivo = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            else
            {
                consecutivo = TxtDocumento.Text.Trim();
            }

        }

        private void RealizarConsultas()
        {
            todoBn = true;
            try
            {
                String codigo = "";
                String detalle = "";
                String ccosto = "";
                String tercero = "";
                Decimal vlrDebe = 0;
                Decimal vlrHaber = 0;
                string numOt = "";
                dtCuentaAgrupada.Rows.Clear();
                dtCuentaAgrupada.Columns.Clear();
                EstructuraDtCuentaAgrupada();
                VerificarConsecutivo();

                for (int i = 0; i < DgvCuenta.RowCount; i++)
                {
                    codigo = DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Codigo"]);
                    detalle = DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Detalle"]);
                    ccosto = DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Ccosto"]);
                    tercero = DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Tercero"]);
                    vlrDebe = Convert.ToDecimal(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Debe"]));
                    vlrHaber = Convert.ToDecimal(DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["Haber"]));
                    numOt = DgvCuenta.GetRowCellDisplayText(i, DgvCuenta.Columns["OT"]);
                    String codigo1 = "";
                    String detalle1 = "";
                    String ccosto1 = "";
                    String tercero1 = "";
                    Decimal vlrDebe1 = 0;
                    Decimal vlrHaber1 = 0;
                    string numOt1 = "";
                    if (dtCuentaAgrupada.Rows.Count > 0)
                    {
                        for (int j = 0; j < dtCuentaAgrupada.Rows.Count; j++)
                        {
                            codigo1 = dtCuentaAgrupada.Rows[j][0].ToString();
                            detalle1 = dtCuentaAgrupada.Rows[j][1].ToString();
                            ccosto1 = dtCuentaAgrupada.Rows[j][2].ToString();
                            tercero1 = dtCuentaAgrupada.Rows[j][3].ToString();
                            vlrDebe1 = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][4].ToString());
                            vlrHaber1 = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][5].ToString());
                            numOt1 = dtCuentaAgrupada.Rows[j][6].ToString();
                            if (codigo1 == codigo && ccosto1 == ccosto && tercero1 == tercero)
                            {
                                if (vlrDebe1 > 0 && vlrDebe > 0)
                                {
                                    dtCuentaAgrupada.Rows[j][4] = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][4].ToString()) + vlrDebe;
                                    break;
                                }
                                else
                                {
                                    if (vlrHaber > 0 && vlrHaber1 > 0)
                                    {
                                        dtCuentaAgrupada.Rows[j][5] = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][5].ToString()) + vlrHaber;
                                        break;
                                    }
                                    else
                                    {
                                        dtCuentaAgrupada.Rows.Add(new Object[] { codigo, detalle, ccosto, tercero, vlrDebe, vlrHaber, numOt });
                                        break;
                                    }
                                }

                            }
                        }

                        if (codigo1 != codigo || ccosto1 != ccosto || tercero1 != tercero)
                        {
                            dtCuentaAgrupada.Rows.Add(new Object[] { codigo, detalle, ccosto, tercero, vlrDebe, vlrHaber,numOt });
                        }
                    }
                    else
                    {
                        dtCuentaAgrupada.Rows.Add(new Object[] { codigo, detalle, ccosto, tercero, vlrDebe, vlrHaber,numOt });
                    }
                }

                if (Modo == "E")
                {
                    SqlParameter[] parametros = new[] { new SqlParameter("@Operacion","DCONT"),
                                                        new SqlParameter("@Consecutivo",consecutivo),
                                                        new SqlParameter("@Fuente",TxtlblFuente.Codigo??""),
                                                        new SqlParameter("@Fecha",Funciones.getInstancia().Datetime2String(TxtFecha.DateTime))};

                    DataBase.ExecuteNonQuery("PA_ContEntrarDocumento", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));
                }


                if (Modo != "E" && Modo != "OL")
                {
                    SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","ACTFUENT"),
                                                            new SqlParameter("@Consecutivo",consecutivo),
                                                            new SqlParameter("@Fuente",TxtlblFuente.Codigo??"")};

                    DataBase.ExecuteNonQuery("PA_ContEntrarDocumento", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                }


                for (int j = 0; j < dtCuentaAgrupada.Rows.Count; j++)
                {
                    codigo = dtCuentaAgrupada.Rows[j][0].ToString();
                    detalle = dtCuentaAgrupada.Rows[j][1].ToString();
                    ccosto = dtCuentaAgrupada.Rows[j][2].ToString();
                    tercero = dtCuentaAgrupada.Rows[j][3].ToString();
                    vlrDebe = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][4].ToString());
                    vlrHaber = Convert.ToDecimal(dtCuentaAgrupada.Rows[j][5].ToString());
                    numOt = dtCuentaAgrupada.Rows[j][6].ToString();
                    SqlParameter[] parametros2 = new[] { new SqlParameter("@Mascod",codigo),
                                                        new SqlParameter("@Masfec",Funciones.getInstancia().Datetime2String(TxtFecha.DateTime)),
                                                        new SqlParameter("@Masdoc",consecutivo),
                                                        new SqlParameter("@Masfte",TxtlblFuente.Codigo??""),
                                                        new SqlParameter("@Masdet",detalle),
                                                        new SqlParameter("@Masdeb",vlrDebe),
                                                        new SqlParameter("@Mashbr",vlrHaber),
                                                        new SqlParameter("@Mascco",ccosto),
                                                        new SqlParameter("@Master",tercero),
                                                        new SqlParameter("@MasOt",numOt)};

                    DataBase.ExecuteNonQuery("PA_ContAccGLMAS_OT", CommandType.StoredProcedure, parametros2, ConexionDB.getInstancia().Conexion(Database, null));
                }

                if (Modo == "RA")
                {
                    SqlParameter[] parametrosR = new[] { new SqlParameter("@Operacion","RETIRAR"),
                                                        new SqlParameter("@CodDepre",CodigoActivo)};

                    DataBase.ExecuteNonQuery("PA_DepreActivosFijos", CommandType.StoredProcedure, parametrosR, ConexionDB.getInstancia().Conexion(Database, null));
                }               

                if (Modo == "OL")
                {
                    SqlParameter[] parametros1 = new[] {    new SqlParameter("@Operacion","IDOC"),
                                                            new SqlParameter("@Consecutivo",consecutivo),
                                                            new SqlParameter("@Fuente",TxtlblFuente.Codigo??""),
                                                            new SqlParameter("@Fecha",Funciones.getInstancia().Datetime2String(TxtFecha.DateTime))};

                    DataBase.ExecuteNonQuery("PA_ContEntrarDocumento", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));
                }

                ActualizarNotaAclaratoria(TxtlblFuente.Codigo ?? "", documento);
                //////////// NUEVO

                //if (datosNotaAclaratoria!=null && datosNotaAclaratoria.Length>0)
                //{
                //    var IdData = GetData(
                //        GetParameters(
                //        "I",
                //        datosNotaAclaratoria[0],
                //        "",
                //        datosNotaAclaratoria[1],
                //        consecutivo, Usuario ?? "",
                //        Environment.MachineName,
                //        (
                //            string.IsNullOrEmpty(datosNotaAclaratoria[0]) &&
                //            string.IsNullOrEmpty("") &&
                //            string.IsNullOrEmpty(datosNotaAclaratoria[1])
                //        ) ? "No ha digitado los campos" : "(GUARDO)"
                //        , null
                //        , concepto),
                //        Database
                //    );
                //}
                
                //////////// NUEVO
            }
            catch (Exception ex)
            {
                todoBn = false;
                XtraMessageBox.Show(ex.Message, Resources.AppName);
            }

            if (todoBn)
            {
                Consecutivo = consecutivo;
                Fuente = TxtlblFuente.Codigo ?? "";
                XtraMessageBox.Show("Proceso realizado con exito", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DgvCuenta.RowCount>0)
                {
                    if (XtraMessageBox.Show("¿Desea imprimir el documento?", Resources.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                }               
                DialogResult = DialogResult.OK;
            }
        }

        public void ActualizarNotaAclaratoria(String fte, String doc)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@Operacion", "UNTC"),
                                                             new SqlParameter("@Fuente", fte),
                                                             new SqlParameter("@Consecutivo", doc),
                                                             new SqlParameter("@NotaAclaratoria", notaAclaratoria)};
            DataSet dt = DataBase.ExecuteQuery("PA_ContEntrarDocumento", "Cabecera", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

        }

        public void Imprimir() 
        {
            //documento = "002725";
            //fuente = "0004";
            //String consecutivo = "002725";
            //String fuente = "0004";
            dsImprimir = new DataSet();

            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion","IMPNOTCC"),
                                                new SqlParameter("@Consecutivo",consecutivo),//
                                                new SqlParameter("@Fuente",TxtlblFuente.Codigo??"")};//

            DataSet dsCab = DataBase.ExecuteQuery("PA_DepreActivosFijos","Cabecera", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            SqlParameter[] parametros1 = new[] { new SqlParameter("@Operacion","IMPNOTCD"),
                                                  new SqlParameter("@Consecutivo",consecutivo),//
                                                new SqlParameter("@Fuente",TxtlblFuente.Codigo??"")};//

            DataSet dsDet = DataBase.ExecuteQuery("PA_DepreActivosFijos", "Detalle", CommandType.StoredProcedure, parametros1, ConexionDB.getInstancia().Conexion(Database, null));

            dsImprimir.Tables.Add(dsCab.Tables[0].Copy());
            dsImprimir.Tables.Add(dsDet.Tables[0].Copy());

            if (dsImprimir.Relations.Count == 0)
            {
                DataColumn keyColumn = dsImprimir.Tables["Cabecera"].Columns["NumDocumento"];
                DataColumn foreignKeyColumn = dsImprimir.Tables["Detalle"].Columns["NumDocumento"];

                dsImprimir.Relations.Add("Relacion", new DataColumn[] { keyColumn }, new DataColumn[] { foreignKeyColumn }, true);
            }

            //dsImprimir.WriteXmlSchema(System.Windows.Forms.Application.StartupPath + @"/Temp/notaContable.xsd");
            //RptNotaContable report = new RptNotaContable();
            //report.Database = Database;
            //report.DataSource = dsImprimir;
            //report.Fecha = Funciones.getInstancia().FormatoFecha(Funciones.getInstancia().Datetime2String(TxtFecha.DateTime));
            //report.Empresa();
            //report.ShowPreviewDialog(); 
        }

        public void DatosDocumento() 
        {
            SqlParameter[] parametros = new[] { new SqlParameter("@Operacion","SC"),
                                                new SqlParameter("@Fuente",fuente),
                                                new SqlParameter("@Consecutivo",documento),
                                                new SqlParameter("@Fecha",Funciones.getInstancia().Datetime2String(TxtFecha.DateTime))};

           DataSet ds = DataBase.ExecuteQuery("PA_ContEntrarDocumento", "datos", CommandType.StoredProcedure, parametros,
                                                        ConexionDB.getInstancia().Conexion(Database, null));
           if (ds.Tables[0].Rows.Count>0)
           {
               TxtlblFuente.Codigo = ds.Tables[0].Rows[0]["Fuente"].ToString();
               TxtlblFuente.Edit();
               TxtDocumento.Text = ds.Tables[0].Rows[0]["NumDocumento"].ToString();
               TxtFecha.DateTime = Convert.ToDateTime(ds.Tables[0].Rows[0]["Fecha"]);
               TxtTercero.Text = ds.Tables[0].Rows[0]["Tercero"].ToString();
               TxtCcosto.Text = ds.Tables[0].Rows[0]["Ccosto"].ToString();
               TxtCuenta.Text = ds.Tables[0].Rows[0]["Cuenta"].ToString();

               encontrado = true;
           }
           
        }

        public void BusCarNotaAclaratoria() 
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@Operacion", "BNTC"),
                                                             new SqlParameter("@Fuente", Fuente),
                                                             new SqlParameter("@Consecutivo", Documento)};
            DataTable dt = DataBase.ExecuteQueryDataTable("PA_ContEntrarDocumento", "Cabecera", CommandType.StoredProcedure, parametros, ConexionDB.getInstancia().Conexion(Database, null));

            if (dt.Rows.Count>0)
            {
                notaAclaratoria = dt.Rows[0][0].ToString();
            }
        }

        public void CcostoOt() 
        {
            String sql = "select ordenes.OrdCCO,procencos.cconom from ordenes INNER JOIN procencos ON ordenes.OrdCCO = procencos.ccocod where ordnro ='" + Documento + "' AND procencos.delmrk='1'";

            DataSet ds = DataBase.ExecuteQuery(sql, "datos", CommandType.Text, null, ConexionDB.getInstancia().Conexion(Database, null));
            string nombre = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                codCcosto = ds.Tables[0].Rows[0]["OrdCCO"].ToString().Trim();
                nombreCcosto = ds.Tables[0].Rows[0]["cconom"].ToString().Trim();
            }
            else
            {
                codCcosto = "";
                nombreCcosto = "";
            }
        }

        #endregion

        #region Eventos

        private void FrmEntradaDoc_Load(object sender, EventArgs e)
        {

            Database = Database ?? "";
            this.Text = this.Text + " [ " + Database.ToUpper() + " ]";

            TxtlblFuente.PerfilShow = Perfilador.getInstancia().CargarPerfil("Fuentes");
            TxtlblFuente.database = Database;
            TxtlblFuente.PonerCeros = true;

            TxtFecha.DateTime = DateTime.Now;
            
            LlenarGrillaCuentas();

            Usuario = Usuario ?? "";
            Documento = Documento ?? "";
            Fuente = Fuente ?? "";

            if (MesPeriodo == 0)
            {
                MesPeriodo = TxtFecha.DateTime.Month;
            }

            if (AñoPeriodo == 0)
            {
                AñoPeriodo = TxtFecha.DateTime.Year;
            }

            TxtlblFuente.Focus();
            SendKeys.Send("{tab}");

            documento = documento ?? "";
            fuente = fuente ?? "";

            if (Modo =="E")
            {
                this.Text = "Corregir Documento";
                TxtDocumento.Enabled = true;

                BusCarNotaAclaratoria();
            }

            if (Modo == "OL")
            {
                this.Text = "Contabilidad Off - Line";
                TxtDocumento.Enabled = true;
            }

            if (desdeDO) { labelControl3.Text = "DO"; }
            
            if (Fecha == null)
            {
                Fecha = DateTime.Now;
            }
            if (Modo != "E" && Modo != "LL")  
            {                
                Fecha = DateTime.Now;
            }

            TxtlblFuente.Codigo = Fuente;

            if (Modo == "E")
            {
                consecutivo = Documento;
            }
         
            if (Modo == "RA")
            {
                this.Text = "Retirar Activo";
                consecutivo = Documento = Funciones.getInstancia().GetConcecutivo(Database, "29", "Debe configurar la fuente para retiro de activos","1");
                if (!string.IsNullOrEmpty(consecutivo))
                {
                    TxtlblFuente.Codigo = Funciones.getInstancia().GetConcecutivo(Database, "29", "Debe configurar la fuente para retiro de activos", "2");
                }
                
               
                TxtlblFuente.Disable();
                TxtDocumento.Enabled = false;
            }

            if (Modo =="LL")
            {
                LlenarGrillaCuentas(DtAsientos);
                
            }

            TxtlblFuente.Edit();
            TxtDocumento.Text = Documento;
            TxtFecha.DateTime = Fecha;
            TxtDocumento_Validated(sender, null);

            TxtDocumento.Focus();

            if (Modo == "LL")
            {
                ConsultarConsecutivo(TxtlblFuente.Codigo);

                if (DgvCuenta.RowCount>0)
                {
                    DgvCuenta.FocusedRowHandle = 0;
                }
                Totales();
                Modo = "N";

                TxtFecha.DateTime = (Fecha == null) ? DateTime.Now:Fecha;
            }
             //String mes = Funciones.getInstancia().Numero2Mes(MesPeriodo);
             //this.Text = this.Text + "  " + mes + " " + AñoPeriodo;
        }

        private void DgvCuenta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DatosGrilla();
        }

        private void TxtlblFuente_Validated(object sender, EventArgs e)
        {
            if (Modo!="E" && Modo !="OL")
            {
                ConsultarConsecutivo(TxtlblFuente.Codigo);
            }            
        }

        private void DgvCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (DgvCuenta.FocusedColumn == DgvCuenta.Columns["Tercero"])
                {
                    if (String.IsNullOrEmpty(texTercero) )//|| String.IsNullOrEmpty(DgvCuenta.GetRowCellDisplayText(DgvCuenta.FocusedRowHandle, DgvCuenta.Columns["Tercero"]))
                    {
                        string tercero = DgvCuenta.GetRowCellValue(DgvCuenta.FocusedRowHandle, DgvCuenta.Columns["Tercero"]).ToString();
                        AñadirTercero(tercero);
                    }
                }

                if (DgvCuenta.FocusedColumn == DgvCuenta.Columns["Ccosto"])
                {
                    bool rCcosto = Convert.ToBoolean(DgvCuenta.GetRowCellValue(DgvCuenta.FocusedRowHandle, DgvCuenta.Columns["RCcosto"]));
                    if (rCcosto)
                    {
                        if (String.IsNullOrEmpty(texCcosto) || texCcosto == "0000")
                        {
                            string ccosto = DgvCuenta.GetRowCellValue(DgvCuenta.FocusedRowHandle, DgvCuenta.Columns["Ccosto"]).ToString();
                            AñadirCcosto(ccosto);
                        }
                    }
                    else
                    {
                        DgvCuenta.SetFocusedRowCellValue(DgvCuenta.Columns["Ccosto"], "");
                        texCcosto = "";
                        DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
                        DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Tercero"]);
                    }

                }
            }
           
        }

        private void DgvCuenta_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == DgvCuenta.Columns["Ccosto"])
            {
               bool rCcosto = Convert.ToBoolean(DgvCuenta.GetRowCellValue(DgvCuenta.FocusedRowHandle, DgvCuenta.Columns["RCcosto"]));
               if (rCcosto)
               {
                   if (!String.IsNullOrEmpty(e.Value.ToString()))
                   {
                       if (e.Value.ToString().Length < 4)
                       {
                           string nuevo = Funciones.getInstancia().RellenarCadenaPorLaIzquierda(e.Value.ToString(), '0', 4);
                           DgvCuenta.SetRowCellValue(e.RowHandle, e.Column, nuevo);
                       }
                       else
                       {
                           BuscarCcosto(e.RowHandle, e.Value.ToString());
                       }
                   }
                   else
                   {
                       DgvCuenta.SetRowCellValue(e.RowHandle, DgvCuenta.Columns["DesCcosto"], "");
                       DatosGrilla();
                   }
               }
               else
               {
                   if (!String.IsNullOrEmpty(DgvCuenta.GetRowCellDisplayText(e.RowHandle, DgvCuenta.Columns["Ccosto"])))
                   {
                       DgvCuenta.SetRowCellValue(e.RowHandle, DgvCuenta.Columns["Ccosto"], "");
                       texCcosto = "";
                   }                   
                   DgvCuenta.FocusedRowHandle = DgvCuenta.FocusedRowHandle;
                   DgvCuenta.FocusedColumn = (DgvCuenta.Columns["Tercero"]);
               }
            }

            if (e.Column == DgvCuenta.Columns["Tercero"])
            {
                if (!String.IsNullOrEmpty(e.Value.ToString()))
                {
                    BuscarTercero(e.RowHandle, e.Value.ToString().Trim());                 
                }
                else
                {
                    DgvCuenta.SetRowCellValue(e.RowHandle, DgvCuenta.Columns["NomTercero"], "");
                    DatosGrilla();
                }
            }

            if (e.Column == DgvCuenta.Columns["Debe"] || e.Column == DgvCuenta.Columns["Haber"])
            {
                if (String.IsNullOrEmpty(e.Value.ToString()))
                {
                    DgvCuenta.SetRowCellValue(e.RowHandle, e.Column, "0");
                }
            }

            if (e.Column == DgvCuenta.Columns["Debe"] || e.Column == DgvCuenta.Columns["Haber"])
            {
                Totales();
            }


            if (e.Column == DgvCuenta.Columns["Detalle"])
            {
                if (e.RowHandle==DgvCuenta.RowCount-1)
                {
                    if (!String.IsNullOrEmpty(e.Value.ToString()))
                    {
                        detalleActual = DgvCuenta.GetRowCellDisplayText(e.RowHandle, DgvCuenta.Columns["Detalle"]);
                    }
                    else
                    {
                        String nombreCuenta = DgvCuenta.GetRowCellDisplayText(e.RowHandle, DgvCuenta.Columns["Cuenta"]);
                        DgvCuenta.SetRowCellValue(e.RowHandle, DgvCuenta.Columns["Detalle"], nombreCuenta);
                        detalleActual = "";
                    }
                }
               
            }
        }

        private void DgvCuenta_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == DgvCuenta.Columns["Ccosto"])
            {
                
               texCcosto = Funciones.getInstancia().RellenarCadenaPorLaIzquierda(e.Value.ToString(), '0', 4);
            }

            if (e.Column == DgvCuenta.Columns["Tercero"])
            {
                texTercero = e.Value.ToString().Trim();
            }            
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            Añadir();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEntradaDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!todoBn)
            {
                if (XtraMessageBox.Show("¿Confirma abandonar la ventana actual?", Resources.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TxtDocumento_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtlblFuente.Codigo) && !String.IsNullOrEmpty(TxtDocumento.Text))
            {
                fuente = TxtlblFuente.Codigo;
                documento = TxtDocumento.Text;
                TxtlblFuente.Focus();

                if (Modo == "E")
                {
                    DatosDocumento();
                    LlenarGrillaCuentas();
                    Totales();

                    if (encontrado)
                    {
                        TxtlblFuente.Disable();
                        TxtDocumento.Enabled = false;
                        TxtFecha.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show("El documento no ha sido creado. Por favor verifique.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                  
                }
            }           
        }

        private void TxtDocumento_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtlblFuente.Codigo) && !String.IsNullOrEmpty(TxtDocumento.Text))
            {
                fuente = TxtlblFuente.Codigo;
                documento = TxtDocumento.Text;
            }
        }

        private void TxtFecha_Validating(object sender, CancelEventArgs e)
        {
            ValidarFecha();
        }

        private void TxtFecha_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtlblFuente.Codigo) && !String.IsNullOrEmpty(TxtDocumento.Text))
            {
                fuente = TxtlblFuente.Codigo;
                documento = TxtDocumento.Text;
               

                if (Modo == "E")
                {
                    DatosDocumento();
                    LlenarGrillaCuentas();
                    Totales();

                    if (encontrado)
                    {
                        TxtlblFuente.Disable();
                        TxtDocumento.Enabled = false;
                        TxtFecha.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show("El documento no ha sido creado. Por favor verifique.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminarTodo_Click(object sender, EventArgs e)
        {
            EliminarTodo();
        }

        private void BtnNotaAclaratoria_Click(object sender, EventArgs e)
        {
            //var frmNotaAclaratoria = new FrmNotaAclaratoria();
            //frmNotaAclaratoria.Contenido = notaAclaratoria;

            //if (frmNotaAclaratoria.ShowDialog() == DialogResult.OK)
            //{
            //    notaAclaratoria = frmNotaAclaratoria.Contenido;
            //}
        }
        #endregion

        #region Helpers

        public static SqlParameter[] GetParameters(
            string operacion,
            string concepto = "",
            string autorizador = "",
            string descripcion = "",
            string NoOT = "",
            string UsuarioSesion = "",
            string Equipo = "",
            string Accion = "",
            DateTime? Momento = null,
            string Reatip = "")
        {
            /*   [PA_Razones]
                 @Operacion		VARCHAR (2)		= NULL      --
                ,@Concepto		VARCHAR (4)		= NULL		-- undo_trace.reacod
                ,@Autorizador	VARCHAR(15)		= NULL		-- undo_trace.reaaut
                ,@Descripcion	VARCHAR(200)	= NULL		-- undo_trace.reades
                ,@NoOT			VARCHAR(20)		= NULL		-- undo_trace.readoc
                ,@UsuarioSes	VARCHAR(15)		= NULL		-- undo_trace.reausr
                ,@Equipo		VARCHAR(50)		= NULL		-- undo_trace.reaeqp
                ,@Accion		VARCHAR(25)		= NULL		-- undo_trace.reaAct
                ,@Momento		DATETIME		= GETDATE   -- undo_trace.reatim
            */

            return new[]
            {
                new SqlParameter("@Operacion", operacion),
                new SqlParameter("@Concepto", concepto),
                new SqlParameter("@Autorizador", autorizador),
                new SqlParameter("@Descripcion", descripcion),
                new SqlParameter("@NoOT", NoOT),
                new SqlParameter("@UsuarioSes", UsuarioSesion),
                new SqlParameter("@Equipo", Equipo),
                new SqlParameter("@Accion", Accion),
                new SqlParameter("@Momento", Momento ?? DateTime.Now),
                new SqlParameter("@Reatip", Reatip),
            };
        }

        /// <summary>
        /// Genera una tabla con los resultados de la operacion especificada en lo parametros
        /// </summary>
        /// <param name="par">Conjunto de parametros que determinan la operacion (Use GetParameters())</param>
        /// <param name="DB">Base de datos donde se raliza la consulta</param>
        /// <returns>Tabla con registros de resultado</returns>
        public static DataTable GetData(SqlParameter[] par, string DB)
        {
            DataSet ds = null;
            try
            {
                ds = DataBase.ExecuteQuery("PA_Razones", "datos", CommandType.StoredProcedure, par, ConexionDB.getInstancia().Conexion(DB, null));
            }
            catch
            {
                ds = null;
            }

            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }
        #endregion
        
        private void TxtFecha_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}