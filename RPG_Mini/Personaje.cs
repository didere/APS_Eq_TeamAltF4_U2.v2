using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini
{
    public class Personaje
    {
        private string nombre;
        private int vida;
        private int ataque;
        private double probEsquivar;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Vida    { get { return vida; }   set { vida = value; } }
        public int Ataque  { get { return ataque; } set { ataque = value; } }
        public double ProbEsquivar { get { return probEsquivar; } set { probEsquivar = value; } }
        public bool EstaDefendido { get; set; } = false;

        private static Random random = new Random();

        public Personaje(string nombre, int vida, int ataque, double probEsquivar)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            ProbEsquivar = probEsquivar;
        }

        public virtual int Atacar(Personaje objetivo)
        {
            bool esquivado = random.NextDouble() < objetivo.ProbEsquivar;
            if (esquivado)
            {
                Console.WriteLine($"{objetivo.Nombre} esquivó el ataque de {Nombre}!");
                return 0;
            }

            int dano = Ataque;

            if (objetivo.EstaDefendido)
            {
                dano /= 2;
                Console.WriteLine($"{objetivo.Nombre} bloqueó parte del golpe!");
            }

            objetivo.Vida -= dano;
            objetivo.EstaDefendido = false; 

            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} causando {dano} de daño. " +
                              $"(Vida restante de {objetivo.Nombre}: {objetivo.Vida})");
            return dano;
        }


        public virtual void Defensa()
        {
            EstaDefendido = true;
            Console.WriteLine($"{Nombre} se pone en guardia. El próximo golpe causará la mitad de daño.");
        }
    }
}
