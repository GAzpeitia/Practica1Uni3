using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido
{
    class Arbitro:Persona //Hereda los atributos de persona
    {
        //Atributos
        private int _aniosExperiencia;
        private bool _tieneGafete;

        //Métodos Getter´s y Setter´s
        public int AniosExperiencia { get; set; }
        public bool TieneGafete { get; set; }

    }
}
