using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.RPG_Mini_Clase
{
    internal class Mainjuego
    {
        public Mainjuego()
        {
            List<Enemigo> enemigos = new List<Enemigo>();
            enemigos.Add(new TipoEnemigo1("Luis Salvaje", 100, 10, 0.5));
            enemigos.Add(new TipoEnemigo2("Oscar", 50, 80, 0.3));
            enemigos.Add(new TipoEnemigo3("Aldair", 10, 20, 0.0));

            Personaje pPlayer = new Usuario("Dui", 300, 25, 25);

            Random random = new Random(5);
            int indice;
            int accion;
            do
            {
                indice = random.Next(0, enemigos.Count);
                Enemigo enemigo_a_vencer = enemigos[indice];
                Console.WriteLine($"ha aparecido{enemigo_a_vencer.Nombre}");

                Console.WriteLine("¨Proceso de ataque iniciado presione una tecla para continuar");
                Console.ReadKey();                do { 
                    pPlayer.EfectuarAtaque(enemigo_a_vencer);
                    if (enemigo_a_vencer.Vida > 0)
                    {
                        enemigo_a_vencer.EfectuarAtaque(pPlayer);
                        Console.WriteLine("Turno terminado, Presione una tecla para continuar");
                        Console.ReadKey();
                    }
                }
                while (pPlayer.Vida > 0 && enemigo_a_vencer.Vida > 0);
                #region
                /*
                do
                {
                    Console.WriteLine("Que opcion deseas hacer?: (1.-Atacar, 2.- Defender)");
                    accion = Convert.ToInt32(Console.ReadLine());
                    switch (accion)
                    {
                        case 1:
                            Console.WriteLine("Atacando...");
                            break;
                        case 2:
                            Console.WriteLine("Defendiendo...");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida!");
                            break;
                    }
                } while (accion!=1 || accion!=2);

                int enemigo_accion = random.Next(1,3);

                if (accion == 1)
                {

                }
                else
                {

                }*/
                #endregion
                Console.WriteLine("Enemigo derrotado");
                enemigos.RemoveAt(indice); //eliminate at
            }
            while (pPlayer.Vida > 0 && enemigos.Count > 0);

            if(pPlayer.Vida>0)
            {
                Console.WriteLine("Has gando el juego");

            }
            else
            {
                Console.WriteLine("Has muerto ");
            }
        }
    }
}
