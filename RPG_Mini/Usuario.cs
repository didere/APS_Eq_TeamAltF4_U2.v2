using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini
{
    public class Usuario : Personaje
    {
        private static Random random = new Random();

        public Usuario(string nombre, int vida = 100, int ataque = 15, double probEsquivar = 0.20)
            : base(nombre, vida, ataque, probEsquivar) { } 
        public override int Atacar(Personaje objetivo)
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
            return dano;
        }
        public override void Defensa()
        {
            EstaDefendido = true;
            Console.WriteLine($"{Nombre} se pone en guardia. El próximo golpe causará la mitad de daño.");
        }
    }
}
