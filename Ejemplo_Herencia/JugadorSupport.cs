using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.Ejemplo_Herencia
{
    public class JugadorSupport : Jugador
    {
        private string habilidad;

        public string Habilidad
        {
            get => habilidad;
            set => habilidad = value;
        }
        public JugadorSupport(string yayayaya, string habilidad) : base(yayayaya)
        {
            Habilidad = habilidad;
        }

        public override void Atacar()
        {
            
        }

    }
}
