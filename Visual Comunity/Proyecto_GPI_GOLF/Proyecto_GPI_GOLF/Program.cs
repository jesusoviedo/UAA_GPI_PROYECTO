﻿using System;
using System.Windows.Forms;

namespace Proyecto_GPI_GOLF
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
            Application.Run(new frm_usuario_acc());
        }
    }
}
