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
using Contabilidad;

namespace ImbSoft.Vistas
{
    public partial class FrmMenu : FormularioBase
    {

        #region Propiedades
        public String Database { get; set; }
        public String Usuario { get; set; }

        #endregion

        #region Metodos
        public FrmMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        //private void BtnIUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    FrmListaUsuarios lUsu = new FrmListaUsuarios();
        //    lUsu.Database = Database;
        //    lUsu.ShowDialog();

        //    //FrmGetUsuarios frmUsuarios = new FrmGetUsuarios();
        //    //frmUsuarios.Database = Database;
        //    //frmUsuarios.Usuario = Usuario;
        //    //frmUsuarios.Modo = "N";
        //    //frmUsuarios.Show();

        //    //frmUsuarios.MdiParent = this;
        //    //XtraForm hijo = null;

        //    //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
        //    //{
        //    //    if (this.MdiChildren[i].GetType() == frmUsuarios.GetType())
        //    //    {
        //    //        hijo = (XtraForm)this.MdiChildren[i];
        //    //    }
        //    //}

        //    //if (hijo != null)
        //    //    frmUsuarios.Activate();
        //    //else
        //    //    frmUsuarios.Show();
        //}

        private void BtnIUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmListaUsuarios lUsu = new FrmListaUsuarios();
            lUsu.Database = Database;
            lUsu.ShowDialog();
        }

        private void BtnIGeneral_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            Form1 frmUsuarios = new Form1();
            frmUsuarios.Show();

            frmUsuarios.MdiParent = this;
            XtraForm hijo = null;

            for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            {
                if (this.MdiChildren[i].GetType() == frmUsuarios.GetType())
                {
                    hijo = (XtraForm)this.MdiChildren[i];
                }
            }

            if (hijo != null)
                frmUsuarios.Activate();
            else
                frmUsuarios.Show();
        }

        #endregion

        private void BtnIngresarDocumentos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEntradaDoc2 frmEntrarDoc = new FrmEntradaDoc2();
            frmEntrarDoc.Database = "ImbSoft";
            frmEntrarDoc.AñoPeriodo = 2018;
            frmEntrarDoc.MesPeriodo = 1;
            frmEntrarDoc.Usuario = "ETIJERA";
            frmEntrarDoc.ShowDialog();
        }

    }
}