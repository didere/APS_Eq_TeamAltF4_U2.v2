using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_CompruebaMayoriaEdad : Ejercicio
    {
        private int edad;

        public int Edad
        {
            get => edad;
            set => edad = value;
        }
        public Ejercicio_CompruebaMayoriaEdad(int edad) : base(4, "Checar si es un ciudadano", "Veridicar si es mayor de edad")
        {
            Edad = edad;
        }
        public override void Ejecutar()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es ciudadano.");
            }
            else
            {
                Console.WriteLine("No es ciudadano.");
            }
        }
    }
}
