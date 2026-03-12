using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltF4_U2.v2.Auxiliar;

namespace APS_Eq_TeamAltF4_U2.v2.ListasGenericas
{
    class Ej2_ListaEnlazada
    {
        public Ej2_ListaEnlazada()
        {
            List<double> calificaciones;
            calificaciones = new List<double>();

            calificaciones.Add(9.5);
            calificaciones.Add(8.0);
            calificaciones.Add(7.5);

            //Console.WriteLine(calificaciones);

            //Recomendado para visualizar o cambios muy puntuales
            foreach (double calificacion in calificaciones)
            {
                Console.WriteLine(calificacion);
                //calificaciones.Remove(calificacion);
            }
            //util para TODO 
            for (int i = 0; i < calificaciones.Count; i++)
            {
                Console.WriteLine(calificaciones[i]);
                calificaciones.RemoveAt(i);
            }
        }
    }
}
