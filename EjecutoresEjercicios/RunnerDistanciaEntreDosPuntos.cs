using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerDistanciaEntreDosPuntos
    {
        public RunnerDistanciaEntreDosPuntos()
        {

            int a, b, c, d;
            //punto 1
            a = 2;
            b = 4;
            //punto 2 
            c = 5;
            d = 3;

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_DistanciaEntreDosPuntos<int>(
                a, b, c, d);
            ejercicio.Ejecutar();
        }

    }
}

// Tarea: 
// -> Promedio de 3 calificaciones
// -> Determinar si un número es primo 
// -> Factorial : 
/*  
n = 5
5 * 4 * 3 * 2 * 1

n = 3
3 * 2 *1

n = 4
4 * 3 * 2 * 1

*/  