using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Taquillero:Persona
    {
        private int _numeroEmpleado;
        private string _tipoEmpleado;

        //Métodos Getter´s y Setter´s
        public int NumeroEmpleado { get; set; }
        public string TipoEmpleado { get; set; }

    }
}
