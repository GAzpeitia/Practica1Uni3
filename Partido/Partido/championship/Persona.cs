using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship
{
    class Persona
    {
        //Propiedades de la clase
        protected int _id;
        protected string _nombre;
        protected DateTime _fechaNacimiento;
        protected string _apellidos;

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Apellidos { get; set; }
    }
}
