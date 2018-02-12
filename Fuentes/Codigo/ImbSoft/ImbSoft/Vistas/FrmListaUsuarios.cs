using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UsuarioControles;
using System.Data.SqlClient;
using Referencias;
using DevExpress.XtraGrid.Columns;
using ImbSoft.Clases;
using ImbSoft.Controladores;
using Referencias.Properties;

namespace ImbSoft.Vistas
{
    public partial class FrmListaUsuarios : FormularioBase
    {
        #region Propiedades

        public string Database { get; set; }
        public string Usuario { get; set; }

        #endregion

        #region Variables

        Point formPosition;
        Boolean mouseAction;
        DataTable dtConsulta = new DataTable();
        DataSet dsConsulta = new DataSet();

        #endregion

        #region Metodos

        public FrmListaUsuarios()
        {
            InitializeComponent();
        }

        public void LlenarDsConsulta()
        {
            try
            {

                DataTable dt = CtrlUsuarios.GetUsuarioAll();

                dtConsulta = dt.Copy();
                dsConsulta.Tables.Clear();
                if (dsConsulta.Tables.Count == 0)
                {
                    dsConsulta.Tables.Add(dtConsulta);
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        public void LlenarGridConsulta()
        {
            DgvGeneral.Columns.Clear();

            DataViewManager dvm = new DataViewManager(dsConsulta);
            DataView dvMain = dvm.CreateDataView(dsConsulta.Tables[0]);
            DgvGeneral.OptionsBehavior.AutoPopulateColumns = false;
            GctrlGeneral.DataSource = dvMain;
            string[] captions = new[] { "Id", "Código", "Nombre Usuario", "Contraseña"};

            GridColumn[] col = new GridColumn[dsConsulta.Tables[0].Columns.Count];
            for (int i = 0; i < dsConsulta.Tables[0].Columns.Count; i++)
            {
                col[i] = DgvGeneral.Columns.AddField(dsConsulta.Tables[0].Columns[i].Caption.Trim());
                col[i].VisibleIndex = i;
                col[i].Caption = captions[i];
                col[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                if (i == 0 || i == 1 || i == 3)
                {
                    col[i].Visible = false;
                }
            }
           
            //DgvGeneral.Columns[1].Width = 100;
            DgvGeneral.Columns[2].Width = 488;

            Funciones.getInstancia().Configurar_Grid(DgvGeneral);
            DgvGeneral.OptionsCustomization.AllowSort = true;
            DgvGeneral.OptionsView.ColumnAutoWidth = false;
            DgvGeneral.OptionsFind.AlwaysVisible = true;

        }

        public void Añadir() 
        {
            FrmGetUsuarios usuarios = new FrmGetUsuarios();
            usuarios.Database = Database;
            usuarios.Modo = "N";
            usuarios.ShowDialog();

            if (usuarios.DialogResult == DialogResult.OK) 
            {
                if (!BkgwBuscar.IsBusy)
                {
                    PrgBuscar.Visible = true;
                    BkgwBuscar.RunWorkerAsync();
                }
            }

        }

        public void Editar() 
        {
            if (DgvGeneral.RowCount>0 && DgvGeneral.GetFocusedRow() != null)
            {
                int idGeneral = Convert.ToInt32(DgvGeneral.GetFocusedRowCellValue("Id"));
                FrmGetUsuarios usuarios = new FrmGetUsuarios();
                usuarios.Database = Database;
                usuarios.Modo = "E";
                usuarios.Id = idGeneral;
                usuarios.ShowDialog();

                if (usuarios.DialogResult == DialogResult.OK)
                {
                    if (!BkgwBuscar.IsBusy)
                    {
                        PrgBuscar.Visible = true;
                        BkgwBuscar.RunWorkerAsync();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un registro.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Eliminar() 
        {
            if (DgvGeneral.RowCount > 0 && DgvGeneral.GetFocusedRow() != null)
            {
                int idGeneral = Convert.ToInt32(DgvGeneral.GetFocusedRowCellValue("Id"));
              
                Usuario usua= new Usuario();
                usua.Id = idGeneral;             

                if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CtrlUsuarios.Eliminar(usua);

                    if (!BkgwBuscar.IsBusy)
                    {
                        PrgBuscar.Visible = true;
                        BkgwBuscar.RunWorkerAsync();
                    }
                }                              
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un registro.", Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Eventos

        //#region MovVentana
        //private void LnkLblMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void LnkLblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void panel2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
        //    mouseAction = true;
        //}

        //private void panel2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (mouseAction == true)
        //    {
        //        Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
        //    }
        //}

        //private void panel2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mouseAction = false;
        //}

        //private void LblNameFrm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
        //    mouseAction = true;
        //}

        //private void LblNameFrm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (mouseAction == true)
        //    {
        //        Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
        //    }
        //}

        //private void LblNameFrm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mouseAction = false;
        //}

        //#endregion

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            if (!BkgwBuscar.IsBusy)
            {
                PrgBuscar.Visible = true;
                BkgwBuscar.RunWorkerAsync();
            }
        }

        private void BkgwBuscar_DoWork(object sender, DoWorkEventArgs e)
        {
            LlenarDsConsulta();
        }

        private void BkgwBuscar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PrgBuscar.Visible = false;
            LlenarGridConsulta();
        }


        #endregion     


    }
}