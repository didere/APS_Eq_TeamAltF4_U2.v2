using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2;
using APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltF4_U2.EjecutoresEjercicios
{
    class RunnerPromedioDe3Calificaciones
    {
        public RunnerPromedioDe3Calificaciones()
        {
            try { 
            float cal1, cal2, cal3;
            Console.WriteLine("Dame la calificación 1:");
            cal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la calificación 2:");
            cal2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la calificación 3:");
            cal3 = float.Parse(Console.ReadLine());   

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_PromedioDe3Calificaciones<float>(cal1, cal2, cal3);
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
