namespace ENT
{
    public class Candidato
    {
        #region Atributos
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        private string direccion;
        private string pais;
        private string telefono;
        private DateTime fechaNac;
        private int precioMedio;
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

        public int Edad{
            get { return DateTime.Now.Year - fechaNac.Year; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public int PrecioMedio
        {
            get { return precioMedio; }
            set { precioMedio = value; }
        }
        #endregion
        #region Constructores
        public Candidato() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id">id del candidato obtenido de la base de datos</param>
        /// <param name="nombre">nombre del candidato obtenido de la base de datos</param>
        /// <param name="apellidos">apellido del candidato obtenido de la base de datos</param>
        /// <param name="direccion">direccion del candidato obtenido de la base de datos</param>
        /// <param name="pais">pais del candidato obtenido de la base de datos</param>
        /// <param name="telefono">telefono del candidato obtenido de la base de datos</param>
        /// <param name="fechaNac">fecha de nacimiento del candidato obtenido de la base de datos</param>
        /// <param name="precioMedio">Precio del candidato obtenido de la base de datos</param>
        public Candidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNac, int precioMedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.pais = pais;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
            this.precioMedio = precioMedio;
        }
        #endregion
    }
}
