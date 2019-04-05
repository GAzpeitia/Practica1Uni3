using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partido.championship.Campeonato
{
    class Equipo
    {
        //Propiedades del equipo
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;

        //Enlace con jugador
        private List<Jugador> jugadores = new List<Jugador>();

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }
    }
}
