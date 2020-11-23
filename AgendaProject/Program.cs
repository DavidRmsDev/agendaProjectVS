using AgendaProject.modelo.conexion;
using System;
using System.Windows.Forms;

namespace AgendaProject
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
            if (new Conexion().ComprobarConexion())
            {
                Application.Run(new Inicio());
            }
        }
    }
}
