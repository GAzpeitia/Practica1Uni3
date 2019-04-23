using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Boleto
    {
        private long _folio;
        private string _fecha;
        private int _asiento;
        private double _costo;

        //Métodos Getter´s y Setter´s
        public long Folio { get; set; }
        public string Fecha { get; set; }
        public int Asiento { get; set; }
        public double Costo { get; set; }
    }
}
