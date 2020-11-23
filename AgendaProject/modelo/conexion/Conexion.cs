using AgendaProject.dao.conexion;
using AgendaProject.modelo.utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProject.modelo.conexion
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            ConexionXML con = new XMLDAOConexion().DatosConexion();
            conexion = new MySqlConnection(con.ToString());
            
        }
        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
        public MySqlConnection Conectar() => conexion;
        public bool ComprobarConexion()
        {
            bool valido = false;
            try
            {
               new Conexion().conexion.Open();
                    valido = true;
                conexion.Close();
            }
            catch (Exception ex) { 
                System.Windows.Forms.MessageBox.Show("Se ha perdido la conexión con el servidor", "Error de conexión");
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            return valido;
        }
    }
}
