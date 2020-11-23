using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.modelo.clases
{
    public class Usuario
    {
        private string user;
        private string nickname;
        private string password;

        public Usuario(string nickname, string password)
        {
            this.Nickname = nickname;
            this.Password = password;
        }

        public string User { get => user; set => user = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Password { get => password; set => password = value; }
    }
}
