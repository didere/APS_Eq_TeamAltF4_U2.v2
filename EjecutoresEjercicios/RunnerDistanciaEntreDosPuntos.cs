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
            try
            {
                Console.WriteLine("Ingrese el valor de x1: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de y1: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de x2: ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de y2: ");
                d = int.Parse(Console.ReadLine());

                Ejercicio ejercicio;
                ejercicio = new Ejercicio_DistanciaEntreDosPuntos<int>(a, b, c, d);
                ejercicio.Ejecutar();
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
                Console.WriteLine("Un argumento no cumple las restricciones de entrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);

            }

            
        }

    }
}