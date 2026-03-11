using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltf4_U2.EjecutoresEjercicios;

class RunnerATM
{
    public RunnerATM()
    {
        try
        {
            Console.WriteLine("Ingresa la cantidad a retirar");
            double cantidad = double.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_ATM(cantidad);
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
