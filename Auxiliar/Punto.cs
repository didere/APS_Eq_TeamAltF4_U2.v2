using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.Auxiliar
{
    public class Punto<T> where T : INumber<T>
    {
        //Coordenadas
        private T coordX;
        private T coordY;

        public T CoordX { get => coordX; set => coordX = value; }
        public T CoordY { get => coordY; set => coordY = value; }

        public Punto(T coordX, T coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }
    }
}
