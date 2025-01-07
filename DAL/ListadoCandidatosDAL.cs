using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadoCandidatosDAL
    {
        /// <summary>
        /// Pre: Nada
        /// Post: Lista de candidatos de la base de datos
        /// Funcion que devuelve una lista de candidatos obtendio por la base de datos
        /// </summary>
        /// <returns>Lista de candidatos</returns>
        public static List<Candidato> getListadoCandidatosDAL()
        {

            SqlConnection sqlConector = new SqlConnection();
            Conexion miConector = new Conexion();

            List<Candidato> listadoCandidatos = new List<Candidato>();

            SqlCommand miComando = new SqlCommand();
            SqlDataReader lector;
            Candidato candidato;

            try
            {
                sqlConector = miConector.mostrarConeccion();

                miComando.CommandText = "SELECT * FROM Candidatos";
                miComando.Connection = sqlConector;
                lector = miComando.ExecuteReader();

                while (lector.Read())
                {
                    candidato = new Candidato();
                    candidato.Id = (int)lector["Id"];
                    candidato.Nombre = (string)lector["Nombre"];
                    candidato.Apellidos = (string)lector["Apellidos"];
                    candidato.Direccion = (string)lector["Direccion"];
                    candidato.Pais = (string)lector["Pais"];
                    candidato.Telefono = (string)lector["Telefono"];
                    candidato.FechaNac = (DateTime)lector["FechaNac"]; 
                    candidato.PrecioMedio = (int)lector["PrecioMedio"];
                    listadoCandidatos.Add(candidato);
                }
                lector.Close();
                sqlConector.Close();
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            return listadoCandidatos;
        }
        /// <summary>
        /// Pre: Id del candidato a buscar
        /// Post: Candidato encontrado
        /// Funcion que obtiene un candidato mediante un filtro de su id de la base de datoss
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Candidato getCandidatoPorIdDAL(int id)
        {
            Candidato candidato = new Candidato();
            SqlConnection sqlConector = new SqlConnection();
            Conexion miConector = new Conexion();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader lector;
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            try
            {
                sqlConector = miConector.mostrarConeccion();

                miComando.CommandText = "SELECT * FROM Candidatos where Id = @id";
                miComando.Connection = sqlConector;
                lector = miComando.ExecuteReader();

                if (lector.Read())
                {
                    candidato.Id = (int)lector["Id"];
                    candidato.Nombre = (string)lector["Nombre"];
                    candidato.Apellidos = (string)lector["Apellidos"];
                    candidato.Direccion = (string)lector["Direccion"];
                    candidato.Pais = (string)lector["Pais"];
                    candidato.Telefono = (string)lector["Telefono"];
                    candidato.FechaNac = (DateTime)lector["FechaNac"];
                    candidato.PrecioMedio = (int)lector["PrecioMedio"];
                }
                lector.Close();
                sqlConector.Close();
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            return candidato;
        }
    }

}

