﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numeroTarjeta;

        //Métodos Getter´s y Setter´s
        public DateTime Fecha { get; set; }
        public string NumeroTarjeta { get; set; }

    }
}