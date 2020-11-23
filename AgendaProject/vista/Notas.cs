using AgendaProject.dao.mysql;
using AgendaProject.modelo.clases;
using AgendaProject.modelo.conexion;
using AgendaProject.modelo.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProject.vista
{
    public partial class Notas : Form
    {
        public Notas()
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

            dataGridView1.Columns[1].HeaderText = "Título";
            dataGridView1.Columns[1].Width = 248;
            dataGridView1.Columns[2].HeaderText = "Notas";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Fecha";
            dataGridView1.Columns[3].Width = 248;
            
        }
        private void ActualizarTabla()
        {
            if (new Conexion().ComprobarConexion())
            {
                try
                {
                    DataSet ds = new DataSet();
                    MySQLNotaDAO c = new MySQLNotaDAO();
                    c.ObtenerTodos();
                    c.adaptadador.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    ModificarTabla();
                }
                catch (Exception ex)
                {
                    new Logcat(string.Join(" ", ex.Source, ex.ToString()));
                    MessageBox.Show("No se han podido cargar los datos","Información");
                }
                dataGridView1.ClearSelection();
            }
        }
        private Nota CrearNota()
        {
            string fecha = DateTime.Now.ToString("dddd dd MMMM HH:mm:ss  yyyy");
            return new Nota(textBox_id.Text, textBox_titulo.Text, fecha, richTextBox_nota.Text);
        }
        private void VaciarCampos()
        {
            textBox_id.Text = "";
            textBox_titulo.Text = "";
            richTextBox_nota.Text = "";
            textBox_fecha.Text = "";
        }
        private bool ComprobarEstadoCampos()
        {
            bool valido = true;
            if (textBox_titulo.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un título");
                valido = false;
            }
            else if (!ComprobarLongitud())
                valido = false;

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
        private bool ComprobarLongitud()
        {
            bool valido = true;
            if (textBox_titulo.Text.Length > 15)
            {
                MessageBox.Show("Longitud del título no permitida. Max 15 caracteres.");
                valido = false;
            }
            else if (richTextBox_nota.Text.Length > 155)
            {
                MessageBox.Show("Longitud de la nota no permitida. Max 155 caracteres.");
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
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                textBox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_titulo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                richTextBox_nota.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_fecha.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
 
            }
            else
                dataGridView1.ClearSelection();

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
                            Nota c = CrearNota();
                            new MySQLNotaDAO().Eliminar(c);
                            ActualizarTabla();
                            VaciarCampos();
                        }
                    }
                    else
                        MessageBox.Show("Debe seleccionar una fila de la tabla", "Información");

                }
            }
        }
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            textBox_id.Text = "";
        }
        private void Button_insertar_Click(object sender, EventArgs e)
        {
            if (new Conexion().ComprobarConexion())
            {
                if (ComprobarEstadoCampos())
                {
                    Nota c = CrearNota();
                    new MySQLNotaDAO().Insertar(c);
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
                        Nota c = CrearNota();
                        new MySQLNotaDAO().Modificar(c);
                        VaciarCampos();
                        ActualizarTabla();
                    }
                }
            }
        }
    }
}
