using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAltF4.SuperSmash
{
    internal class Partida
    {
        public Partida()
        {
            List<Personaje> personajes = new List<Personaje>();

            personajes.Add(new Zoner("Canela"));
            personajes.Add(new Pesado("Rey DDD"));
            personajes.Add(new Ligero("Little mac"));

            foreach (Personaje p in personajes)
            {
                Console.WriteLine($"Nombre: {p.Nombre} | Ataque: {p.Ataque} | Rapidez: {p.Rapidez} | Peso: {p.Peso}");
            }
        }
    }
}
