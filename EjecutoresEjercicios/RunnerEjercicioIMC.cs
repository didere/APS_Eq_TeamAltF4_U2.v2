using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerEjercicioIMC
    {
        public RunnerEjercicioIMC()
        {
            try { 
            double[] parametros = new double[2];
            Console.WriteLine("Ingresa tu peso en kg");
            parametros[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura en metros");
            parametros[1] = double.Parse(Console.ReadLine());

            Ejercicio ejercicio = new Ejercicio_IMC<double>(parametros[0], parametros[1]);
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
