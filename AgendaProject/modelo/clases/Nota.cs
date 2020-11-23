using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.modelo.clases
{
    public class Nota
    {
        private string id;
        private string titulo;
        private string fecha;
        private string nota;

        public Nota(string id, string titulo, string fecha, string nota)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Fecha = fecha;
            this.Note = nota;
        }

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Note { get => nota; set => nota = value; }
    }
}
