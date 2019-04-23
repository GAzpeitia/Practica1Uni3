using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido
{
    class Jornada:Persona
    {
        //private int _id;
        private string _fechaInicio;
        private string _fechaFin;
        private Boolean _isConcluida;
        
        //Métodos Getter´s y Setter´s
        //public int Id { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public Boolean IsConcluida { get; set; }
    }
}
