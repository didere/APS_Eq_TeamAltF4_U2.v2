using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios
{
    internal class RunnerPerimetroPolRegular
    {
        public RunnerPerimetroPolRegular() { 
            int cantidad_Lados; 
            int longitud_Lados;
            try
            {
                Console.WriteLine("Ingrese la cantidad de lados del polígono regular:");
                cantidad_Lados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
                longitud_Lados = int.Parse(Console.ReadLine());

                Ejercicio ejercicio;
                ejercicio = new HandlersEjerciciosBasicos.
                    Ejercicio_PerimetroPoligonoRegular<int>
                    (longitud_Lados, cantidad_Lados);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
                Console.WriteLine("Un argumento no cumple las restricciones de entrada");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
              
            }
        }
    }
}
