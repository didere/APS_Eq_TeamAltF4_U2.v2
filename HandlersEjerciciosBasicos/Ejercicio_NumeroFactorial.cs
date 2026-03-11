using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using APS_Eq_TeamAltF4_U2.v2.Auxiliar;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos
{
    internal class Ejercicio_NumeroFactorial<T> : Ejercicio where T : INumber<T>
    {
        NumFactorial<T> numFactorial;

        public NumFactorial<T> NumFactorial
        {
            get => numFactorial;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El número factorial no puede ser nulo.");
                }
                if (value.Numero.CompareTo(T.Zero) < 0)
                {
                    throw new ArgumentException("El número para calcular el factorial no puede ser negativo.");
                }
                numFactorial = value;
            }
        }

        public Ejercicio_NumeroFactorial() : base(13, "Número factorial", "Calcula el factorial de un número")
        {
          
        }

        public Ejercicio_NumeroFactorial(T numero) : base(13, "Número factorial", "Calcula el factorial de un número")
        {
            NumFactorial = new NumFactorial<T>(numero);
        }

        public override void Ejecutar()
        {
            T resultado = T.One;
            for (T i = T.One; i <= NumFactorial.Numero; i++)
            {
                resultado *= i;
                Console.WriteLine("Iteración" + i + ":" + (resultado));
            }
            Console.WriteLine("El factorial de " + NumFactorial.Numero + " es: " + resultado);
        }
    }
}
