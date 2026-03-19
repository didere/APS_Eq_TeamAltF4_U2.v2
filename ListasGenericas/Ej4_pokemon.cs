using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.ListasGenericas
{
     class Ej4_pokemon
    {
        public Ej4_pokemon() 
        {
            List<string> pokesPosibles = new  List<string>();
            pokesPosibles.Add("Pikachu"); //0
            pokesPosibles.Add("Pidgeot"); //1
            pokesPosibles.Add("Evee");    //2
            pokesPosibles.Add("Snorlac"); //3
            pokesPosibles.Add("Charmander"); //4

            Random random = new Random();
            int indicePoke = random.Next(0, pokesPosibles.Count);
            string poke = pokesPosibles[indicePoke];
            Console.WriteLine("Tu pokemon es: " + poke);

            double shiny = random.NextDouble(); 
            if (shiny < 0.01) // 1% de probabilidad de ser shiny
            {
                Console.WriteLine("¡Felicidades! Has encontrado un " + poke + " shiny!");
            }



        }
    }
}
