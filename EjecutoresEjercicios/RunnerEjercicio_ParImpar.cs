using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    public class RunnerEjercicio_ParImpar
    {
        // Constructor con identificador   
        
        public RunnerEjercicio_ParImpar()
        {
            try
            {
                Console.WriteLine("Ingresa un numero: ");
                int n = int.Parse(Console.ReadLine());

                Ejercicio ejercicio;
                ejercicio = new Ejercicio_ParImpar(n);
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
