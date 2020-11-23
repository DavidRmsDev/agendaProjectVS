using AgendaProject.modelo.conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.dao.conexion
{
    public interface IDAOConexion<ConexionXML>
    {
        ConexionXML DatosConexion();   
    }
}
