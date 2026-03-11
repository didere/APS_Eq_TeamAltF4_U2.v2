using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using APS_Eq_TeamAltF4_U2.v2.Auxiliar;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    public class Ejercicio_DistanciaEntreDosPuntos<T> : Ejercicio where T : INumber<T>
    {
        Punto<T> punto1;
        Punto<T> punto2;

        public Punto<T> Punto1
        {
            get => punto1;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El Punto1 no puede ser nulo.");
                }
                punto1 = value;
            }
        }

        public Punto<T> Punto2
        {
            get => punto2;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El Punto2 no puede ser nulo.");
                }
                punto2 = value;
            }
        }

        public Ejercicio_DistanciaEntreDosPuntos() : base(10, "Distancia entre 2 puntos", "Cálcula la distancia entre dos puntos")
        {
      
        }

        public Ejercicio_DistanciaEntreDosPuntos(T p1coorX, T p1coorY,
            T p2coorX, T p2coorY) : base(10, "Distancia entre 2 puntos",
            "Cálcula la distancia entre dos puntos")
        {
            Punto1 = new Punto<T>(p1coorX, p1coorY);
            Punto2 = new Punto<T>(p2coorX, p2coorY);
        }

        public override void Ejecutar()
        {
            double part1 = Math.Pow(Convert.ToDouble(Punto1.CoordX - Punto2.CoordX), 2);
            double part2 = Math.Pow(Convert.ToDouble(Punto1.CoordY - Punto2.CoordY), 2);
            double resultado = Math.Sqrt(part1 + part2);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
