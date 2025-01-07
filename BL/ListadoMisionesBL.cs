using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListadoMisionesBL
    {
        /// <summary>
        /// Pre: NADA
        /// Post: Listado de candidatos
        /// Funcion que devuleve una lista de candidatos haciendo uso de la capa DAL
        /// </summary>
        /// <returns>Listado de candidatos</returns>
        public static List<Misiones> getListadoMisionesBL(){
            return ListadoMisionesDAL.getListadoMisionesDAL();
        }

    }
}
