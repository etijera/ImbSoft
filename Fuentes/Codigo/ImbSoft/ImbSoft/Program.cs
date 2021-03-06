﻿using ImbSoft.Views;
using ImbSoft.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImbSoft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The following line provides localization for data formats. 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            // The following line provides localization for the application's user interface. 
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");

            System.Globalization.CultureInfo before = System.Threading.Thread.CurrentThread.CurrentCulture;
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");//es-CO
                // Proceed with specific code
            }

            finally
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = before;
            }



            FrmLogin1 login = new FrmLogin1();
            if (login.ShowDialog() == DialogResult.OK)
            {
                FrmMenu principal = new FrmMenu();

                principal.Usuario = login.Usuario;
                principal.Periodo = login.Periodo;

                Application.Run(principal);
            }

        }
    }
}
