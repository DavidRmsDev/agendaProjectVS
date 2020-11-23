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
    class MySQLUsuarioDAO : IUsuarioDAO
    {

        private readonly MySqlConnection Conexion;

        public MySQLUsuarioDAO()
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
        public void Insertar(Usuario dato)
        {
            Conexion.Open();
            MySqlTransaction trs = Conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("insertaUsuario", Conexion, trs)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };


                comando.Parameters.AddWithValue("@nick", dato.Nickname);
                comando.Parameters.AddWithValue("@pass", dato.Password);


                comando.ExecuteNonQuery();
                trs.Commit();
                MessageBox.Show("Usuario registrado correctamente", "Información");

            }
            catch (Exception ex)
            {
                trs.Rollback();
                MessageBox.Show("No se ha podido dar de alta al usuario", "Nickname ya registrado");
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
        public bool ComprobarNombreUsuario(string nick)
        {
            bool existe = false;
            MySqlDataReader reader;
            Conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("comprobarNombreUsuario", Conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@nick", nick);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                    existe = true;

            }catch (Exception ex)
            {
                MessageBox.Show("Usuario incorrecto", "Error de login");
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
            return existe;
        }
        public int DevolverUsuario(Usuario u)
        {
            int user = 0;

            MySqlDataReader reader;
            Conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("seleccionaUsuario", Conexion)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@nick", u.Nickname);
                comando.Parameters.AddWithValue("@pass", u.Password);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                       
                       user = int.Parse(reader.GetString(0));
                    }

            }
            catch (Exception ex)
            {
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
            return user;
        }
        public void Eliminar(Usuario dato)
        {
            throw new NotImplementedException();
        }
        public void Modificar(Usuario dato)
        {
            throw new NotImplementedException();
        }
        public void ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
