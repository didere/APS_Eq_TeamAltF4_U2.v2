using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace APS_Eq_TeamAltF4_U2.v2.Auxiliar
{
    public class Calificaciones<T> where T : INumber<T>
    {
        private T calificacion1;
        private T calificacion2;
        private T calificacion3;

        public T Calificacion1 { get => calificacion1; set => calificacion1 = value; }
        public T Calificacion2 { get => calificacion2; set => calificacion2 = value; }
        public T Calificacion3 { get => calificacion3; set => calificacion3 = value; }

        public Calificaciones(T calificacion1, T calificacion2, T calificacion3)
        {
            Calificacion1 = calificacion1;
            Calificacion2 = calificacion2;
            Calificacion3 = calificacion3;
        }
    }
}
