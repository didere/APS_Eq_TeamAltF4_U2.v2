using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini
{
    public class TipoEnemigo3 : Enemigo
    {
        private static Random random = new Random();

        public TipoEnemigo3(string nombre, int vida = 120, int ataque = 8, double probEsquivar = 0.50)
            : base(nombre, vida, ataque, probEsquivar) { }
        public override int Atacar(Personaje objetivo)
        {
           
            if (Vida < 60)
            {
                Defensa();
                return 0;
            }

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

            Console.WriteLine($"{Nombre} (Tipo 3) ataca con golpe normal ({dano} daño). " +
                              $"(Vida restante de {objetivo.Nombre}: {objetivo.Vida})");
            return dano;
        }

        public override void Defensa()
        {
            EstaDefendido = true;
            Console.WriteLine($"{Nombre} (Tipo 3) se pone en guardia. El próximo golpe causará la mitad de daño.");
        }
    }
}
