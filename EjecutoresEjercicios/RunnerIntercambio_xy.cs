using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerIntercambio_xy
    {
        public RunnerIntercambio_xy()
        {


            Console.WriteLine("Ingresa un numero de dos valores para intercambiar: ");
            int n = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio__Intercambiar_xy(n);
            ejercicio.Ejecutar();
        }
    }
}
