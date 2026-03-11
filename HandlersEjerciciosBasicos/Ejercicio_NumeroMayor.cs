using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_NumeroMayor : Ejercicio
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

        public Ejercicio_NumeroMayor(int a, int b) : base(5, "Número Mayor", "Determinar cuál de dos números es mayor")
        {
            A = a;
            B = b;
        }

        public Ejercicio_NumeroMayor() : base(5, "Número Mayor", "Determinar cuál de dos números es mayor")
        {
        }

        public override void Ejecutar()
        {
            if (a > b)
            {
                Console.WriteLine("El número mayor es: " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("El número mayor es: " + b);
            }
       
        }
    }
}
