using AgendaProject.modelo.clases;
using AgendaProject.modelo.conexion;
using AgendaProject.modelo.utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProject.dao.mysql
{
    class MySQLContactoDAO : IContactoDAO
    {
        private readonly MySqlConnection Conexion;
        public MySqlDataAdapter adaptadador;

        public MySQLContactoDAO()
        {
            try
            {
                Conexion = new Conexion().Conectar();
            }
            catch (Exception ex)
            {
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                MessageBox.Show("Se ha perdido la conexión con el servidor","Error de conexión");
            }
        }
        public void Eliminar(Contacto dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("borrarContacto", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@idr", int.Parse(dato.Id));

                if (comando.ExecuteNonQuery() != 0)
                {
                    trs.Commit();
                    MessageBox.Show("Registro borrado correctamente","Información");
                }
                else
                    MessageBox.Show("No se ha podido borrar el registro", "Información");

            }
            catch (Exception ex)
            {
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                MessageBox.Show("No se ha podido borrar el registro", "Información");
                trs.Rollback();
            }
            finally
            {
                if(Conexion != null)
                {
                    try
                    {
                        Conexion.Close();
                    }
                    catch (Exception ex) 
                    {
                        new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    }
                }
                    
            }
        }
        public void Insertar(Contacto dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("insertaContacto", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@usu", Inicio.inicio.user);
                comando.Parameters.AddWithValue("@name",dato.Nombre);
                comando.Parameters.AddWithValue("@ape", dato.Apellidos);
                comando.Parameters.AddWithValue("@tel", int.Parse(dato.Telefono));
                comando.Parameters.AddWithValue("@dire", dato.Direccion);
                comando.Parameters.AddWithValue("@emilio", dato.Email);

                comando.ExecuteNonQuery();
                trs.Commit();
                MessageBox.Show("Registro insertado correctamente","Información");

            }
            catch(Exception ex)
            {
                trs.Rollback();
                MessageBox.Show("No se ha podido insertar el registro","Teléfono ya registrado");
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            finally
            {
                if (Conexion != null)
                {
                    try
                    {
                        Conexion.Close();
                    }
                    catch (Exception ex) 
                    {
                        new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    }
                }

            }
        }
        public void Modificar(Contacto dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("modificaContacto", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@id", int.Parse(dato.Id));
                comando.Parameters.AddWithValue("@name", dato.Nombre);
                comando.Parameters.AddWithValue("@ape", dato.Apellidos);
                comando.Parameters.AddWithValue("@tel", int.Parse(dato.Telefono));
                comando.Parameters.AddWithValue("@dire", dato.Direccion);
                comando.Parameters.AddWithValue("@emilio", dato.Email);

                if (comando.ExecuteNonQuery() != 0) { 
                    trs.Commit();
                    MessageBox.Show("Registro modificado correctamente","Información"); 
                }
                else
                    MessageBox.Show("Ningún registro modificado", "Información");
            }
            catch (Exception ex)
            {
                trs.Rollback();
                MessageBox.Show("No se ha podido modificar el registro", "Información");
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            finally
            {
                if (Conexion != null)
                {
                    try
                    {
                        Conexion.Close();
                    }
                    catch (Exception ex) 
                    {
                        new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    }
                }

            }
        }
        public void ObtenerTodos()
        {

            Conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("seleccionaContacto", Conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@usu", Inicio.inicio.user);

                adaptadador = new MySqlDataAdapter(comando);

            }
            catch (Exception ex )
            {
                MessageBox.Show("Error al obtener los datos", "Información");
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
            finally
            {
                if (Conexion != null)
                {
                    try
                    {
                        Conexion.Close();
                    }
                    catch (Exception ex) 
                    {
                        new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    }
                }

            }
        }
    }
}
