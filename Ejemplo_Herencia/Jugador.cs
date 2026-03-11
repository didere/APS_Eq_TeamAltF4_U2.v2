using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.Ejemplo_Herencia
{
    public class Jugador
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
            
        }
        public Jugador (string name)
            {
            Name = name;
        }

        public virtual void Atacar()
        {
            // ataca -----<<<< Fist attack
        }
    }
}
