using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_ParImpar : Ejercicio
    {
        //atributo
        private int n;
        //propiedad
        public int N 
        { 
            get => n; 
            set => n = value; 
        }
        // Constructor
        public Ejercicio_ParImpar(int n) : base(1, "Par-Impar", "Se verifica si el numero es par o impar")
        {
            N = n;
            this.n = n;
        }

        public override void Ejecutar()
        {
            if (N % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}
