using AgendaProject.dao.mysql;
using AgendaProject.modelo.clases;
using AgendaProject.modelo.conexion;
using AgendaProject.modelo.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProject.vista
{
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void ModificarTabla()
        {
            dataGridView1.Visible = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 85;
            dataGridView1.Columns[2].HeaderText = "Apellidos";
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].HeaderText = "Teléfono";
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[4].HeaderText = "Dirección";
            dataGridView1.Columns[4].Width = 111;
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[5].Width = 110;
        }
        private void ActualizarTabla()
        {
            if (new Conexion().ComprobarConexion())
            {
                try
                {
                    DataSet ds = new DataSet();
                    MySQLContactoDAO c = new MySQLContactoDAO();
                    c.ObtenerTodos();
                    c.adaptadador.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    ModificarTabla();
                }
                catch (Exception ex)
                {
                    new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    MessageBox.Show("No se han podido cargar los datos", "Información");
                }
                dataGridView1.ClearSelection();
            }
        }
        private void Button_insertar_Click(object sender, EventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (ComprobarEstadoCampos())
                {
                    Contacto c = CrearContacto();
                    new MySQLContactoDAO().Insertar(c);
                    VaciarCampos();
                    ActualizarTabla();

                }
            }
        }
        private void Button_modificar_Click(object sender, EventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (ComprobarEstadoCampos())
                {
                    if (SeleccionaFila())
                    {
                        Contacto c = CrearContacto();
                        new MySQLContactoDAO().Modificar(c);
                        VaciarCampos();
                        ActualizarTabla();
                    }
                }
            }
        }
        private Contacto CrearContacto()
        {
            return new Contacto(textBox_id.Text, textBox_nombre.Text, textBox_apellidos.Text, textBox_telefono.Text, textBox_direccion.Text, textBox_email.Text);
        }
        private void VaciarCampos()
        {
            textBox_id.Text = "";
            textBox_nombre.Text = "";
            textBox_apellidos.Text = "";
            textBox_telefono.Text = "";
            textBox_direccion.Text = "";
            textBox_email.Text = "";
        }
        private bool ComprobarEstadoCampos()
        {
            bool valido = true;
            if (textBox_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un nombre");
                valido = false;
            }
            else if (textBox_telefono.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un teléfono");
                valido = false;
            }
            else if (!PatronTel(textBox_telefono.Text))
            {
                MessageBox.Show("Debe introducir un formato de teléfono válido, 9 dígitos");
                valido = false;
            }
            else if (textBox_email.Text.Length != 0)
            {
                if (!PatronEmail(textBox_email.Text))
                {
                    MessageBox.Show("Debe introducir un formato de email válido");
                    valido = false;
                }
            }
            else if (!ComprobarLongitud())
                valido = false;

            return valido;
        }
        private bool PatronTel(String tel)
        {
            bool valido = true;
            if (tel.Length != 9)
                valido = false;
            try
            {
                int num = int.Parse(tel);
            }
            catch (Exception )
            {
                valido = false;
            }
            return valido;
        }
        private bool SeleccionaFila()
        {
            bool valido = true;
            if (textBox_id.Text.Equals(""))
            {
                valido = false;
                MessageBox.Show("Debe seleccionar una fila de la tabla", "Información");
            } 
            return valido;
        }
        //Documentacion oficial microsoft( https://docs.microsoft.com/es-es/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format )
        private bool PatronEmail(String email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private bool ComprobarLongitud()
        {
            bool valido = true;
            if (textBox_nombre.Text.Length > 20)
            {
                MessageBox.Show("Longitud del nombre no permitida. Max 20 caracteres.");
                valido = false;
            }
            else if (textBox_apellidos.Text.Length > 50)
            {
                MessageBox.Show("Longitud de los apellidos no permitida. Max 50 caracteres.");
                valido = false;
            }
            else if (textBox_direccion.Text.Length > 80)
            {
                MessageBox.Show("Longitud de la dirección no permitida. Max 80 caracteres.");
                valido = false;
            }
            else if (textBox_email.Text.Length > 50)
            {
                MessageBox.Show("Longitud del email no permitida. Max 50 caracteres.");
                valido = false;
            }

            return valido;
        }
        private bool Borrar()
        {
            bool borrar = false;
            DialogResult oDlgRes;
            oDlgRes = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (oDlgRes == DialogResult.OK)
            {
                borrar = true;
            }
            return borrar;
        }
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (textBox_id.Text.Length != 0)
                    {
                        if (Borrar())
                        {
                            Contacto c = CrearContacto();
                            new MySQLContactoDAO().Eliminar(c);
                            ActualizarTabla();
                            VaciarCampos();
                        }
                    }
                    else
                        MessageBox.Show("Debe seleccionar una fila de la tabla", "Información");

                }
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            if (e.RowIndex >= 0)
            {
                
                textBox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_nombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_apellidos.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_telefono.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_direccion.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            else
                dataGridView1.ClearSelection();

        }
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            textBox_id.Text = "";
        }
    }
}
