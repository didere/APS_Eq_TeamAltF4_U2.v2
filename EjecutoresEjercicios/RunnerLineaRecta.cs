using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2;
using APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos;

namespace APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios
{
    public class RunnerLineaRecta
    {
        public RunnerLineaRecta()
        {
            int m, x, b;
            bool se_ejecuto = false;
            while (!se_ejecuto) //Sirve para hacer que el codigo se siguiera ejecutando
            {
                try
                { //inicio de l avalidacion de codigo
                    Console.WriteLine("Dame valor de m: ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el valor de x: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el valor de b: ");
                    b = int.Parse(Console.ReadLine());
                    Ejercicio ejercicio;
                    ejercicio = new Ejercicio_LineaRecta<int>(m, x, b);
                    ejercicio.Ejecutar();

                    se_ejecuto = true;
                } //fin de la validacion de codigo
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio una excepcion" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Intento de ejecucion terminado: ");
                }
            }
        }
    }
}
