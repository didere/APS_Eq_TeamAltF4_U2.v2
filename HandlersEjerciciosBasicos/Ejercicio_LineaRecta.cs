using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos
{
    internal class Ejercicio_LineaRecta<T> : Ejercicio where T : INumber<T>
    {
        // y = mx + b
        private T valor_m;
        private T valor_x;
        private T valor_b;

        public T ValorM
        {
            get => valor_m;
            set => valor_m = value;
        }

        public T ValorX
        {
            get => valor_x;
            set
            {
                if (value.CompareTo(0) > 0)
                {
                    valor_x = value;
                }
                else
                {
                    throw new ArgumentException("El valor de la primera es invalido, tu ejecucuion sera el 20 de marzo del 2026");
                }
            }
        }

        public T ValorB
        {
            get => valor_b;
            set => valor_b = value;
        }
        public Ejercicio_LineaRecta() : base(14, "Linea recta", "Genera un punto de una linea recta")
        {
      
        }
        public Ejercicio_LineaRecta(T m, T x, T b) : base (14, "Linea recta", "Genera un punto de una linea recta")
        {
            ValorM = m;
            ValorX = x;
            ValorB = b;
        }

        public override void Ejecutar()
        {
            T resultado = ValorM * ValorX + ValorB;
            Console.WriteLine("El resultado es: "+ resultado);
        }
    }
}
