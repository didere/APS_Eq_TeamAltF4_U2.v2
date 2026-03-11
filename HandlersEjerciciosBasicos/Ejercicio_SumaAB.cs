using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_SumaAB : Ejercicio
    {
        private int a;
        private int b;

        public int A
        {
            get { return a; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor de A no puede ser negativo.");
                }
                a = value;
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor de B no puede ser negativo.");
                }
                b = value;
            }
        }

        public Ejercicio_SumaAB() : base(2, "Suma AB", "Suma de dos Numeros")
        {
           
        }
        public Ejercicio_SumaAB(int a, int b) : base (2, "Suma AB", "Suma de dos Numeros")
        {
            A = a;
            B = b;
        }

        public override void Ejecutar()
        {
            int resultado = A + B;
            Console.WriteLine("Resultado de la suma: " + resultado);
        }
    }
}
