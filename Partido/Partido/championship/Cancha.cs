using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship.Campeonato
{
    class Cancha
    {
        //Propiedades de la clase
        private int _id;
        private string _tipo; //Soccer, Futbol 7
        private string _nombre;
        private string _ubicacion;

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
    }
}
