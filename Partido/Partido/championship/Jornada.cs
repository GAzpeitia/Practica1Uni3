using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship
{
    class Jornada:Persona
    {
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private Boolean _isConcluida;
        
        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean IsConcluida { get; set; }
    }
}
