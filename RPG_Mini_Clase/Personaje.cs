using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini_Clase
{
    class Personaje
    {
        private string nombre;
        private int vida;
        private int ataque;
        private double probabilidad_esquivar;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Vida { get => vida; set => vida = value; }

        public int Ataque { get => ataque; set => ataque = value; }

        public double Probabilidad_Esquivar 
        { 
            get 
            { 
                return probabilidad_esquivar; 
            } 
            set 
            {
                probabilidad_esquivar = value;
            } 
        }

        public Personaje(string nombre, int vida, int ataque, double probabilidad_esquivar)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            this.probabilidad_esquivar = probabilidad_esquivar;            
        }
    }
}
