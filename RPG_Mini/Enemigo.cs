using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini
{
        public class Enemigo : Personaje
        {
            public Enemigo(string nombre, int vida = 80, int ataque = 10, double probEsquivar = 0.10)
                : base(nombre, vida, ataque, probEsquivar) { }
        }
        /*
         * Jugador tiene vida / ataque
         * 
         * Cada x tiempo, mientras que tenga vida,
         * podra aparesersele un enemigo (existen tres tipos de enemigos cada uno con sus caracteristicas de vida y ataque)
         * 
         * en cada turno el jugador puede atacar o defenderse
         * 
         * si decide atacar, el enemigo podria recibir el ataque, bloquear(defenderse) o esquivar
         * 
         * Despues del turno del jugador, el enemigo podra atacar, 
         * si el jugador defendio previamente entonces el ataque bajara menos existe una probabilidad de que se esquive el ataque
         */
}
