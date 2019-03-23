using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLLena;

        //Métodos Getter´s y Seter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool EstaLLena { get; set; }

    }
}
