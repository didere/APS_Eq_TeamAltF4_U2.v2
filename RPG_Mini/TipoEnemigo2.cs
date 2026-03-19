using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini
{
    public class TipoEnemigo2 : Enemigo
    {
        private static Random random = new Random();

        public TipoEnemigo2(string nombre, int vida = 60, int ataque = 12, double probEsquivar = 0.05)
            : base(nombre, vida, ataque, probEsquivar) { }
        public override int Atacar(Personaje objetivo)
        {
            bool esquivado = random.NextDouble() < objetivo.ProbEsquivar;
            if (esquivado)
            {
                Console.WriteLine($"{objetivo.Nombre} esquivó el ataque de {Nombre}!");
                return 0;
            }

            int dano = Ataque * 2;

            if (objetivo.EstaDefendido)
            {
                dano /= 2;
                Console.WriteLine($"{objetivo.Nombre} bloqueó parte del golpe!");
            }

            objetivo.Vida -= dano;
            objetivo.EstaDefendido = false;

            Console.WriteLine($"{Nombre} (Tipo 2) ataca con FUERZA DOBLE ({dano} daño). " +
                              $"(Vida restante de {objetivo.Nombre}: {objetivo.Vida})");
            return dano;
        }
        public override void Defensa()
        {
            EstaDefendido = true;
            Console.WriteLine($"{Nombre} (Tipo 2) se pone en guardia. El próximo golpe causará la mitad de daño.");
        }
    }
}
