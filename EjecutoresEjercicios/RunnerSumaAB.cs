using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerSumaAB
    {
        public RunnerSumaAB()
        {
            int a, b;
            Console.WriteLine("Dame el Valor A;");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el Valor B;");
            b = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_SumaAB(a, b);
            ejercicio.Ejecutar();
        }
    }
}
