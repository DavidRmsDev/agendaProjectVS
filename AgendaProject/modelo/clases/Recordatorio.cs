using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.modelo.clases
{
     public class Recordatorio
    {
        private string id;
        private string titulo;
        private string descripcion;
        private string fecha;
        private string hora;

        public Recordatorio(string id, string titulo, string descripcion, string fecha, string hora)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Hora = hora;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
