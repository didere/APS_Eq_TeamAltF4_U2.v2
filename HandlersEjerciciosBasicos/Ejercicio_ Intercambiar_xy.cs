using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio__Intercambiar_xy : Ejercicio
    {
        
        private int n; int x; int y;
        public int N { get => n; set => n = value; }
        

        public Ejercicio__Intercambiar_xy(int n) : base(3, "Intercambiar XY", "Intercambiar los valores de X y Y")
        {
            N = n;
            this.n = n;
        }
        public override void Ejecutar()
        {
            x= N / 10; 
            y = N - (x * 10);
            Console.WriteLine("Valor original de N: " + N);
            y = y * 10;
            N = y + x;
            Console.WriteLine("Valor cambiado de N: " + N);
        }
    }
}
