using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Reservacion
    {
        private string _fecha;
        private string _numeroTarjeta;

        //Enlace con Boleto
        private List<Boleto> jugadores = new List<Boleto>();

        //Métodos Getter´s y Setter´s
        public string Fecha { get; set; }
        public string NumeroTarjeta { get; set; }

    }
}
