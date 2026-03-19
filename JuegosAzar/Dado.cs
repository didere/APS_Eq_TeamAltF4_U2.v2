using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.JuegosAzar
{
    class Dado
    {
        private int valor;  //0
        private Random random;

        public int Valor
        {
            get => valor;
            set => valor = value;
        }
        public Dado(int semilla)
        {
            random = new Random(semilla);
            valor = -1;
        }

        public void Girar()
        {
         valor += random.Next(1,7);    
        }

        public int Mirar()
        {
            return valor;
        }

        public Dado()
        {
            random = new Random();
            Valor = -1;
        }
    }
}
