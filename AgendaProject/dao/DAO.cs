using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProject.dao
{
    interface IDAO <T>
    {

        //Inserta el objeto pasado por parametros a la BBDD
        void Insertar(T dato);
        //Modifica el objeto pasado por parametros a la BBDD

        void Modificar(T dato);
        //Elimina el objeto pasado por parametros a la BBDD

        void Eliminar(T dato);
        //Muestra todos los objetos T de la BBDD

        void ObtenerTodos();
        //Muestra el objeto T de la BBDD cuya id sea la pasada por parametros


    }
}
