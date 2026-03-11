using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerEjercicioSumaABGenerico
    {
        public RunnerEjercicioSumaABGenerico()
        {
            try { 
            double a, b;
            Console.WriteLine("Dame el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Ejercicio ejercicio;
            ejercicio = new EjercicioSumaAB_Genericos<double>(a, b);
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
