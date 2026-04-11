using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAltF4.SuperSmash
{
    class Personaje
    {
        private string nombre;
        private int ataque;
        private double rapidez;
        private int peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public double Rapidez { get => rapidez; set => rapidez = value; }
        public int Peso { get => peso; set => peso = value; }

        public Personaje(string nombre, int ataque, double rapidez, int peso)
        {
            Nombre = nombre;
            Ataque = ataque;
            Rapidez = rapidez;
            Peso = peso;
        }

        public virtual void Salto()
        {
 
        }

        public virtual void Jab()
        {
          
        }

        public virtual void Smash()
        {
           
        }

        public virtual void FinalSmash()
        {
          
        }
    }
}
