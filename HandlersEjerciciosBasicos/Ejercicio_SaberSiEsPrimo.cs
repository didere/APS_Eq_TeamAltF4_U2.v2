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
    internal class Ejercicio_SaberSiEsPrimo<T> : Ejercicio where T : INumber<T>
    {
        NumPrimo<T> numPrimo;
        public NumPrimo<T> NumPrimo { get => numPrimo; set => numPrimo = value; }
        public Ejercicio_SaberSiEsPrimo(T numero) : base(12, "Saber si es primo", "Determina si un número es primo o no")
        {
            NumPrimo = new NumPrimo<T>(numero);
        }
        public override void Ejecutar()
        {
            bool esPrimo;
            if (Convert.ToDouble(NumPrimo.Numero) < 2)
            {
                esPrimo = false;
            }
            else
            {
                esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(Convert.ToDouble(NumPrimo.Numero)); i++)
                {
                    if (Convert.ToDouble(NumPrimo.Numero) % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("El número " + NumPrimo.Numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + NumPrimo.Numero + " no es primo.");
            }
        }
    }
}
