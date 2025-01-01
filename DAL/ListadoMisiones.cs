using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadoMisiones
    {
        public static List<Misiones> getListadoMisionesDAL()
        {

            SqlConnection miConexion = new SqlConnection();
            List<Misiones> listadoMisiones = new List<Misiones>();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader lector;
            Misiones mision;
            miConexion.ConnectionString = ("server=daniel-nervion-db.database.windows.net;database=DanielDB;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;");

            try
            {
                miConexion.Open();

                miComando.CommandText = "SELECT * FROM Misiones";
                miComando.Connection = miConexion;
                lector = miComando.ExecuteReader();
                if (lector.Read())
                {
                    while (lector.Read())
                    {
                        mision = new Misiones();
                        mision.Id = (int)lector["Id"];
                        mision.Nombre = (string)lector["Nombre"];
                        mision.Dificultad = (int)lector["Dificultad"];
                        listadoMisiones.Add(mision);
                    }
                    lector.Close();
                    miConexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return listadoMisiones;
        }

    }
}

