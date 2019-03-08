using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship
{
    class Equipo
    {
        //Propiedades del equipo
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }
    }
}
