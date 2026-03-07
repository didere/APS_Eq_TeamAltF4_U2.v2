using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;
namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerEsMayorDeEdad
    {
        public RunnerEsMayorDeEdad()
        {
            Console.WriteLine("Dame la edad de la persona");
            int edad = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_CompruebaMayoriaEdad(edad);
            ejercicio.Ejecutar();
        }
    }
}
