using AgendaProject.dao.conexion;
using AgendaProject.modelo.conexion;
using AgendaProject.modelo.utilidades;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AgendaProject
{
    public partial class Inicio : Form
    {
        public int user = 0;
        private Form childForm;
        public static Inicio inicio;
        public Inicio()
        {
                    inicio = this;
                    InitializeComponent();
                    MenuSinLogin();
            if(!new Conexion().ComprobarConexion())
            {
                archivoToolStripMenuItem.Enabled = false;
            }
                

        }
        private void RegistroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CerrarVentana();
            childForm = new Registro
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void IniciarSesiónToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CerrarVentana();
            childForm = new Login
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void CerrarVentana() 
        {
            if(childForm!=null)
            childForm.Close();

        }
        public void CargarInicio()
        {
            user = 0;
            CerrarVentana();
            childForm = new Login
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void VerContactosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CerrarVentana();
            childForm = new vista.Contactos
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void VerNotasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CerrarVentana();
            childForm = new vista.Notas
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void VerRecordatoriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CerrarVentana();
            childForm = new vista.Recordatorios
            {
                MdiParent = this,
                Text = "Ventana",
                StartPosition = FormStartPosition.Manual
            };
            childForm.Show();
        }
        private void DesconectarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            user = 0;
            CerrarVentana();
            MenuSinLogin();
        }
        public void MenuSinLogin()
        {
            archivoToolStripMenuItem.Enabled = true;
            contactosToolStripMenuItem.Enabled = false;
            notasToolStripMenuItem.Enabled = false;
            recordatoriosToolStripMenuItem.Enabled = false;
            cerrarSesiónToolStripMenuItem.Enabled = false;
        }
        public void MenuLogin()
        {
            archivoToolStripMenuItem.Enabled = false;
            contactosToolStripMenuItem.Enabled = true;
            notasToolStripMenuItem.Enabled = true;
            recordatoriosToolStripMenuItem.Enabled = true;
            cerrarSesiónToolStripMenuItem.Enabled = true;
        }
    }
}
