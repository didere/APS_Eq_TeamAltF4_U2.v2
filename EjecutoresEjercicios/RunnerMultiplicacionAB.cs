using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios
{
    class RunnerMultiplicacionAB
    {
        public RunnerMultiplicacionAB()
        {
            try { 
            Console.WriteLine("Ingresa el primer numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int b = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_MultiplicacionAB(a,b);
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
