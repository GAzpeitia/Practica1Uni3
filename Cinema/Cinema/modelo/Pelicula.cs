using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificacion;
        private string _resumen;

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Clasificacion { get; set; }
        public string Resumen { get; set; }
    }
}
