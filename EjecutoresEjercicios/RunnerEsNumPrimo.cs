using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios
{
    class RunnerEsNumPrimo
    {
        public RunnerEsNumPrimo()
        {
            Console.WriteLine("Dame un número para saber si es primo o no");
            int numero = int.Parse(Console.ReadLine());
            Ejercicio ejercicio;
            ejercicio = new HandlersEjerciciosBasicos.Ejercicio_SaberSiEsPrimo<int>(numero);
            ejercicio.Ejecutar();
        }
    }
}
