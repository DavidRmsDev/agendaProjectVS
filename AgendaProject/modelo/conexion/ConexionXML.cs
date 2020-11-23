using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.modelo.conexion
{
    public class ConexionXML
    {
        private string server;
        private string database;
        private string uid;
        private string pwd;

        public ConexionXML()
        {
            server = "";
            database = "";
            Uid = "";
            pwd = "";
        }

        public string Server { get => "server="+server; set => server = value; }
        public string Database { get => "database="+database; set => database = value; }
        public string Uid { get => "Uid="+uid; set => uid = value; }
        public string Pwd { get => "pwd="+pwd; set => pwd = value; }

        public override string ToString()
        {
            return string.Join(";",Server, Database, Uid,Pwd);
        }
    }
}
