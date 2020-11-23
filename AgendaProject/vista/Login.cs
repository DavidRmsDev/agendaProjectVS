using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaProject.dao.mysql;
using AgendaProject.modelo.clases;
using AgendaProject.modelo.conexion;

namespace AgendaProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool ComprobarLongitud()
        {
            bool valido = true;

            if (textBox_nickname.Text.Length > 25)
            {
                valido = false;
                MessageBox.Show("Longitud del nickname no permitida. Max 25 caracteres.", "Error.");
            }
            else if (textBox_password.Text.Length > 25)
            {
                valido = false;
                MessageBox.Show("Longitud de la contraseña no permitida. Max 25 caracteres.", "Error.");
            }

            return valido;
        }

        private bool ComprobarUsuario()
        {
            return new MySQLUsuarioDAO().ComprobarNombreUsuario(textBox_nickname.Text);
        }

        private bool ComprobarRellenos()
        {
            bool relleno = true;

            if (textBox_nickname.Text.Length == 0)
            {
                relleno = false;
                MessageBox.Show("Debe introducir un usuario", "Error");
            }
            else if (textBox_password.Text.Length == 0)
            {
                relleno = false;
                MessageBox.Show("Debe introducir una contraseña", "Error");
            }
            else if (!ComprobarLongitud())
            {
                relleno = false;
            }

            return relleno;
        }

        private Usuario CrearUsuario()
        {
            return new Usuario(textBox_nickname.Text, textBox_password.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (ComprobarRellenos())
                {
                    if (ComprobarUsuario())
                    {
                        Usuario u = CrearUsuario();
                        if ((Inicio.inicio.user = new MySQLUsuarioDAO().DevolverUsuario(u)) != 0)
                        {
                            MessageBox.Show("Usuario logeado con éxito", "Información");
                            Inicio.inicio.MenuLogin();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Contraseña incorrecta", "Error de login");
                    }
                    else
                        MessageBox.Show("Usuario incorrecto", "Error de login");
                }
            }
        }
    }
}
