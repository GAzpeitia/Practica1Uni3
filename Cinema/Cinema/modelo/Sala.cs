using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLLena;

        //Enlace con Asiento
        private List<Asiento> jugadores = new List<Asiento>();

        //Métodos Getter´s y Seter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool EstaLLena { get; set; }

    }
}
