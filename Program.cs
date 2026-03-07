using System;
using System.Linq.Expressions;
using APS_Eq_TeamAltf4_U2.EjecutoresEjercicios;
using APS_Eq_TeamAltF4_U2.EjecutoresEjercicios;
using APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios;

namespace APS_Eq_TeamAltf4_U2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase icdia");
            Console.WriteLine("Ejercicios básicos");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Par-Impar");
            Console.WriteLine("2. Suma AB");
            Console.WriteLine("3. Intercambio XY");
            Console.WriteLine("4. Mayor de edad");
            Console.WriteLine("5. Número Mayor");
            Console.WriteLine("6. Multiplicacion AB");
            Console.WriteLine("7. Suma con datos Genericos");
            Console.WriteLine("8. Simulacion de un ATM");
            Console.WriteLine("9. Indice de Masa Corporal");
            Console.WriteLine("10. Distancia entre dos puntos");
            Console.WriteLine("11. Promedio de 3 calificaciones");
            Console.WriteLine("12. Es número primo");
            Console.WriteLine("13. Factorial de un número");
            Console.WriteLine("------------------------");
            Console.WriteLine("Ingrese el número del ejercicio que desea ejecutar:");


            int idx;
            int.TryParse(Console.ReadLine(), out idx);

            switch (idx)
            {
                case 1:
                    new RunnerEjercicio_ParImpar();
                    break;
                case 2:
                    new RunnerSumaAB();
                    break;
                case 3:
                    new RunnerIntercambio_xy();
                    break;
                case 4:
                    new RunnerEsMayorDeEdad();
                    break;
                case 5:
                    new RunnerEjercicioNumeroMayor();
                    break;
                case 6:
                    new RunnerMultiplicacionAB();
                    break;
                case 7:
                    new RunnerEjercicioSumaABGenerico();
                    break;
                case 8:
                    new RunnerATM();
                    break;
                case 9:
                    new RunnerEjercicioIMC();
                    break;
                case 10:
                    new RunnerDistanciaEntreDosPuntos();
                    break;
                case 11:
                    new RunnerPromedioDe3Calificaciones();
                    break;
                case 12:
                    new RunnerEsNumPrimo();
                    break;
                case 13:
                    new RunnerFactorial();
                    break;
            }
        }
    }
}
