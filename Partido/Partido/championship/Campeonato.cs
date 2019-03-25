using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;

        //Enlace con Jornada
        private List<Jornada> jugadores = new List<Jornada>();

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }

    }
}
