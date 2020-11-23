using AgendaProject.dao.mysql;
using AgendaProject.modelo.clases;
using AgendaProject.modelo.conexion;
using System.Windows.Forms;

namespace AgendaProject
{
    public partial class Registro : Form
    {
        public Registro()
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

        private void VaciarCampos()
        {
            textBox_nickname.Text = "";
            textBox_password.Text = "";
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
            return new Usuario(textBox_nickname.Text,textBox_password.Text);
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (ComprobarRellenos())
                {
                    Usuario u = CrearUsuario();
                    if (!ComprobarUsuario())
                    {
                        new MySQLUsuarioDAO().Insertar(u);
                        VaciarCampos();
                        MessageBox.Show("Inicie sesión", "Operación");
                        Inicio.inicio.CargarInicio();
                    }
                    else
                        MessageBox.Show("Nombre de usuario no disponible, ya está registrado", "Error");
                }
            }
        }
    }
}
