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
    class MySQLRecordatorioDAO : IRecordatorioDAO
    {

        private readonly MySqlConnection Conexion;
        public MySqlDataAdapter adaptadador;

        public MySQLRecordatorioDAO()
        {
            try
            {
                Conexion = new Conexion().Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha perdido la conexión con el servidor","Error de conexión");
                new Logcat(string.Join(" ", ex.Source, ex.ToString()));
            }
        }
        public void Eliminar(Recordatorio dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("borrarRecordatorio", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@idr", int.Parse(dato.Id));

                if (comando.ExecuteNonQuery() != 0)
                {
                    trs.Commit();
                    MessageBox.Show("Registro borrado correctamente", "Información");
                }
                else
                    MessageBox.Show("No se ha podido borrar el registro", "Información");

            }
            catch (Exception ex)
            {
                trs.Rollback();
                MessageBox.Show("No se ha podido borrar el registro", "Información");
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
        public void Insertar(Recordatorio dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("insertaRecordatorio", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@usu", Inicio.inicio.user);
                comando.Parameters.AddWithValue("@title", dato.Titulo);
                comando.Parameters.AddWithValue("@fech", dato.Fecha);
                comando.Parameters.AddWithValue("@hora", dato.Hora);
                comando.Parameters.AddWithValue("@descr", dato.Descripcion);

                comando.ExecuteNonQuery();
                trs.Commit();
                MessageBox.Show("Registro insertado correctamente", "Información");

            }
            catch (Exception ex)
            {
                trs.Rollback();
                MessageBox.Show("No se ha podido insertar el registro", "Información");
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
        public void Modificar(Recordatorio dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("modificaRecordatorio", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@id", int.Parse(dato.Id));
                comando.Parameters.AddWithValue("@title", dato.Titulo);
                comando.Parameters.AddWithValue("@descr", dato.Descripcion);
                comando.Parameters.AddWithValue("@fech", dato.Fecha);
                comando.Parameters.AddWithValue("@hora", dato.Hora);

                if (comando.ExecuteNonQuery() != 0)
                {
                    trs.Commit();
                    MessageBox.Show("Registro modificado correctamente", "Información");
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
                MySqlCommand comando = new MySqlCommand("seleccionaRecordatorio", Conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@usu", Inicio.inicio.user);

                adaptadador = new MySqlDataAdapter(comando);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos","Error de conexión");
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
