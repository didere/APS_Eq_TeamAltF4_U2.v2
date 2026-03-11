using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using APS_Eq_TeamAltF4_U2.v2.Auxiliar;
using APS_Eq_TeamAltf4_U2;
using APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios
{
    class RunnerFactorial
    {
        public RunnerFactorial()
        {
            try { 
            Console.WriteLine("Ingresa un numero para calcular su factorial");
            int numero = int.Parse(Console.ReadLine());
            Ejercicio ejercicio;
            ejercicio = new Ejercicio_NumeroFactorial<int>(numero);
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
