using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadoMisionesDAL
    {
        /// <summary>
        /// Pre: NADA
        /// Post: Lista de misiones obtenida de la base de datos
        /// Funcion que realiza una consulta select para obtnener la lista de las misiones
        /// </summary>
        /// <returns></returns>
        public static List<Misiones> getListadoMisionesDAL()
        {

            SqlConnection sqlConector = new SqlConnection();
            Conexion miConector = new Conexion();
            List<Misiones> listadoMisiones = new List<Misiones>();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader lector;
            Misiones mision;

            try
            {
                sqlConector = miConector.mostrarConeccion();
                miComando.CommandText = "SELECT * FROM Misiones";
                miComando.Connection = sqlConector;
                lector = miComando.ExecuteReader();

                while (lector.Read())
                {
                    mision = new Misiones();
                    mision.Id = (int)lector["Id"];
                    mision.Nombre = (string)lector["Nombre"];
                    mision.Dificultad = (int)lector["Dificultad"];
                    listadoMisiones.Add(mision);
                }
                lector.Close();
                sqlConector.Close();
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            return listadoMisiones;
        }
    }
}

