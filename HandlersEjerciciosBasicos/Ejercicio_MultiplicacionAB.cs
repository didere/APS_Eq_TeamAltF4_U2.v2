using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_MultiplicacionAB : Ejercicio
    {
        private int a;
        private int b;

        public int A
        {
            get => a;
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
            get => b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor de B no puede ser negativo.");
                }
                b = value;
            }
        }

        public Ejercicio_MultiplicacionAB() : base(6, "Multiplicacion AB", "Multiplicar los numeros A y B")
        {
 
        }

        public Ejercicio_MultiplicacionAB(int a, int b) : base (6, "Multiplicacion AB", "Multiplicar los numeros A y B")
        {
            A = a;
            B = b;
        }

        public override void Ejecutar()
        {
            int resultado = A * B;
            Console.WriteLine("Resultado de la multiplicacion: " + resultado);
        }
    }
}
