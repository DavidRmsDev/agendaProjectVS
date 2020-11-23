using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.modelo.utilidades
{
    public class Logcat
    {
        public Logcat(String mensaje)
        {
            Capturar(mensaje);
        }

        public void Capturar(String cadena)
        {
            StreamWriter fichero;
            try
            {
                if (!File.Exists("Logcat.txt"))
                    fichero = File.CreateText("Logcat.txt");
                else
                    fichero = File.AppendText("Logcat.txt");
                fichero.WriteLine(cadena);
                fichero.WriteLine();
                fichero.Close();
            }
            catch (Exception ex) 
            {
                new Logcat(string.Join(" ",ex.Source,ex.ToString()));
            }
             
        }

    }
}
