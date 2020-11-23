using AgendaProject.modelo.conexion;
using AgendaProject.modelo.utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AgendaProject.dao.conexion
{
    class XMLDAOConexion : IDAOConexion<ConexionXML>
    {
        public ConexionXML DatosConexion()
        {
            ConexionXML con = new ConexionXML();

            try
            {
                                
                                using (XmlReader reader = XmlReader.Create("conexion.xml"))
                                {
                                    while (reader.Read())
                                    {
                                        if (reader.IsStartElement())
                                        {

                                            switch (reader.Name)
                                            {
                                                case "Server":
                                                    if (reader.Read())
                                                    {
                                                        con.Server = reader.Value.Trim();
                                                    }
                                                    break;

                                                case "Database":

                                                    if (reader.Read())
                                                    {
                                                        con.Database = reader.Value.Trim();
                                                    }
                                                    break;
                                                case "Uid":

                                                    if (reader.Read())
                                                    {
                                                        con.Uid = reader.Value.Trim();
                                                    }
                                                    break;
                                                case "Pwd":

                                                    if (reader.Read())
                                                    {
                                                        con.Pwd = reader.Value.Trim();
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                }
                            
            }
            catch (XmlException ex)
            {
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            catch (InvalidOperationException ex)
            {
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            catch (Exception ex) 
            {
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }

            return con;
        }
    }
}
