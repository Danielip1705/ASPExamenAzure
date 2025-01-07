using DAL;
using ENT;
namespace BL
{
    public class ListadoCandidatosBL
    {
        /// <summary>
        /// Pre:NADA
        /// Post: Lista de candidatos
        /// Funcion que hace usa de la capa dal para obtener un listado de candidatos
        /// </summary>
        /// <returns>Lista de candidatos</returns>
        private static List<Candidato> getListadoCandidatosBL(){
            return ListadoCandidatosDAL.getListadoCandidatosDAL();
        }
        /// <summary>
        /// Pre: El usuario envia la dificultad
        /// Post: Lista de candidatos aptos para realizar esta mision
        /// Funcion que hace un filtrado de candidatos dependiendo de la dificultad elegida
        /// </summary>
        /// <param name="dificultad">Dificultad de la mision</param>
        /// <returns>Lista de candidatos aptos para esa mision</returns>
        public static List<Candidato> getListadoCandidatosAptoBL(int dificultad){
            List<Candidato> listadoCandidato = getListadoCandidatosBL();
            List<Candidato> listadoFiltrado = new List<Candidato>();

            switch(dificultad){
                case 1 or 2:
                    listadoFiltrado =listadoCandidato.Where(c => c.Pais.Equals("USA")).ToList();
                    break;
                case 3:
                    listadoFiltrado = listadoCandidato.Where(c => c.Pais.Equals("USA") && c.Edad>40).ToList();
                    break;
                case 4:
                    listadoFiltrado = listadoCandidato.Where(c => c.Pais.Equals("Italia") && c.Edad > 45).ToList();

                    break;
                case 5:
                    listadoFiltrado = listadoCandidato.Where(c => c.Pais.Equals("Italia") && c.Edad > 45 && c.Edad<55).ToList();

                    break;
            }

            return listadoFiltrado;

        }
        /// <summary>
        /// Funcion que hace uso de la capa dal para obtener un candidato segun su id
        /// </summary>
        /// <param name="id">Id del candidato</param>
        /// <returns>Candidato buscado</returns>
        public static Candidato getCandidatoPorIdBL(int id)
        {
            return ListadoCandidatosDAL.getCandidatoPorIdDAL(id);
        }
    }
}
