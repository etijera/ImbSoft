using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Referencias.Properties;
using BarBerSoft.Vistas;

namespace ImbSoft.Views
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades
        public String Database { get; set; }
        public String Usuario { get; set; }

        #endregion

        #region Variables

        private bool logueo = false;
        private bool deFrmSalir = false;

        #endregion

        #region Metodos
        public FrmMain()
        {
            InitializeComponent();
            this.Text = Resources.AppName;
        }

        #endregion

        #region Eventos
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSalir salir = new FrmSalir();
            salir.Tipo = "Salir";
            deFrmSalir = true;
            salir.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ribbonControl1.Enabled = false;
            //FrmLogin login = new FrmLogin();
            //login.ShowDialog();

            //if (login.DialogResult == DialogResult.OK) 
            //{
            //    Database = login.DataBase;
            //    Usuario = login.Usuario;
            //    logueo = true;
            //    ribbonControl1.Enabled = true;
            //}
            //else
            //{
            //    logueo = false;
            //    Application.Exit();
            //}
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSalir salir = new FrmSalir();
            salir.Tipo = "Reiniciar";
            deFrmSalir = true;
            salir.ShowDialog();
        }

        private void SitReportes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmRelacionBanco relXbanco = new FrmRelacionBanco();
            //relXbanco.Database = Database;
            //relXbanco.Usuario = Usuario;
            //relXbanco.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == relXbanco.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    relXbanco.Activate();
            //else
            //    relXbanco.Show();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logueo)
            {
                if (!deFrmSalir)
                {
                    if (XtraMessageBox.Show("¿Esta seguro que desea salir de " + Resources.AppName + "?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        #endregion

        private void BarPresProp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmPrestamosProp presProp = new FrmPrestamosProp();
            //presProp.Database = Database;
            //presProp.Usuario = Usuario;
            //presProp.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == presProp.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    presProp.Activate();
            //else
            //    presProp.Show();
        }

        private void ExogenaPropietario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmInformacionExProp exoProp = new FrmInformacionExProp();
            //exoProp.Database = Database;
            //exoProp.Usuario = Usuario;
            //exoProp.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == exoProp.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    exoProp.Activate();
            //else
            //    exoProp.Show();

        }

        private void ExogenaCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmInformacionExCli exoCli = new FrmInformacionExCli();
            //exoCli.Database = Database;
            //exoCli.Usuario = Usuario;
            //exoCli.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == exoCli.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    exoCli.Activate();
            //else
            //    exoCli.Show();
        }

        private void InformacionRecaudo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmInformeRecaudo inforRecaudo = new FrmInformeRecaudo();
            //inforRecaudo.Database = Database;
            //inforRecaudo.Usuario = Usuario;
            //inforRecaudo.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == inforRecaudo.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    inforRecaudo.Activate();
            //else
            //    inforRecaudo.Show();
        }

        private void ExogenaCliProp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmInformacionExCliProp exoCliProp = new FrmInformacionExCliProp();
            //exoCliProp.Database = Database;
            //exoCliProp.Usuario = Usuario;
            //exoCliProp.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == exoCliProp.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    exoCliProp.Activate();
            //else
            //    exoCliProp.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BarCargosLiqui_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmGetConcepLiqui inforRecaudo = new FrmGetConcepLiqui();
            //inforRecaudo.Database = Database;
            //inforRecaudo.Usuario = Usuario;
            //inforRecaudo.MdiParent = this;
            //XtraForm hijo = null;

            //for (int i = 0; i < this.MdiChildren.Length - 1; i++)
            //{
            //    if (this.MdiChildren[i].GetType() == inforRecaudo.GetType())
            //    {
            //        hijo = (XtraForm)this.MdiChildren[i];
            //    }
            //}

            //if (hijo != null)
            //    inforRecaudo.Activate();
            //else
            //    inforRecaudo.Show();
        }



    }
}
