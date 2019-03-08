using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship
{
    class Jugador:Persona
    {
        //Atributos
        //private string _equipo;
        private int _numero;
        private string _posicion;

        //Enlace con la clase equipo
        private Equipo _equipe;

        //Métodos Geter´s y Setter´s
        //public string Equipo { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipe { get; set; }
    }
}
