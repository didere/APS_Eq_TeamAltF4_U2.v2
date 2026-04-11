using System;
using System.Linq.Expressions;
using APS_Eq_TeamAltf4_U2.EjecutoresEjercicios;
using APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos;
using APS_Eq_TeamAltF4_U2.EjecutoresEjercicios;
using APS_Eq_TeamAltF4_U2.v2.EjecutoresEjercicios;
using APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos;
using APS_Eq_TeamAltF4_U2.v2.JuegosAzar;
using APS_Eq_TeamAltF4_U2.v2.ListasGenericas;
using APS_Eq_TeamAltF4_U2.v2.RPG_Mini_Clase;

namespace APS_Eq_TeamAltf4_U2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Clase_ICDIA_Unidad2");

            List<Ejercicio> listaEjercicios = new List<Ejercicio>();
            listaEjercicios.Add(new Ejercicio_ParImpar());
            listaEjercicios.Add(new Ejercicio_SumaAB());
            listaEjercicios.Add(new Ejercicio__Intercambiar_xy());
            listaEjercicios.Add(new Ejercicio_CompruebaMayoriaEdad());
            listaEjercicios.Add(new Ejercicio_NumeroMayor());
            listaEjercicios.Add(new Ejercicio_MultiplicacionAB());
            listaEjercicios.Add(new EjercicioSumaAB_Genericos<double>());
            listaEjercicios.Add(new Ejercicio_ATM());
            listaEjercicios.Add(new Ejercicio_IMC<double>());
            listaEjercicios.Add(new Ejercicio_DistanciaEntreDosPuntos<int>());
            listaEjercicios.Add(new Ejercicio_PromedioDe3Calificaciones<float>());
            listaEjercicios.Add(new Ejercicio_SaberSiEsPrimo<int>());
            listaEjercicios.Add(new Ejercicio_NumeroFactorial<int>());
            listaEjercicios.Add(new Ejercicio_LineaRecta<int>());
            listaEjercicios.Add(new Ejercicio_PerimetroPoligonoRegular<int>());
            int idx;
            do
            {
                foreach (Ejercicio item in listaEjercicios)
                {
                    Console.WriteLine(item);
                }

              
                //int.TryParse(Console.ReadLine(), out idx);
                idx = 24;
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
                    case 14:
                        new RunnerLineaRecta();
                        break;
                    case 15:
                        new RunnerPerimetroPolRegular();
                        break;
                    //prueba
                    case 20:
                        new Ej2_ListaEnlazada();
                        break;
                    case 21:
                        new Ej3_Lista();
                        break;
                    case 22:
                        new Ej4_pokemon();
                        break;
                    case 23:
                        new JuegoDado();
                        break;
                    case 24:
                        new Mainjuego();
                        break;
                }
            } while (idx != 0);
        }
    }
}
