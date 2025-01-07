using ENT;

namespace ASPExamenPrueba.Models.VM
{
    public class ListadoCandidatosMisionesVM
    {
        #region Atributos y Propiedades
        public List<Candidato> candidatos {get;set;}
        public List<Misiones> misiones {get;set;}
        #endregion
        #region Constructor
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public ListadoCandidatosMisionesVM()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="listaCandidatos">Lista de candidatos pasado por el usuario</param>
        /// <param name="listaMisiones">Lista de misiones pasado por el usuario</param>
        public ListadoCandidatosMisionesVM(List<Candidato> listaCandidatos, List<Misiones> listaMisiones)
        {
            this.candidatos = listaCandidatos;
            this.misiones = listaMisiones;
        }
        #endregion
    }
}
