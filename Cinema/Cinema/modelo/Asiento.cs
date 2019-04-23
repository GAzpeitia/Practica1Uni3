using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Asiento:Sala
    {
        private int _numero;
        private bool _estaDisponible;

        //Métodos Getter´s y Setter´s
        public int Numero { get; set; }
        public bool EstaDisponible { get; set; }

    }
}
