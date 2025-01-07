using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Misiones
    {
        #region Atributos
        private int id;
        private string nombre;
        private int dificultad;
        #endregion
        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dificultad
        {
            get { return dificultad; }
            set { dificultad = value; }
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Misiones() { }
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        /// <param name="id">Id que se obtiene de la base de datos</param>
        /// <param name="nombre">Nombre la mision que se obtiene de la base de datos</param>
        /// <param name="dificultad">Dificultad de la mision que se obtiene de la base de datos</param>
        public Misiones(int id, string nombre, int dificultad)
        {
            this.id = id;
            this.nombre = nombre;
            this.dificultad = dificultad;
        }
        #endregion
    }
}

