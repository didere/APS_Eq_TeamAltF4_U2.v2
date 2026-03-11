using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos
{
    internal class Ejercicio_PerimetroPoligonoRegular<T> : Ejercicio where T : INumber<T>
    {
        private T longitudLado;
        private T cantidadLados;

        public T LongitudLado
        {
            get => longitudLado;
            set
            {
                if (value.CompareTo(0) > 0)
                {
                    longitudLado = value;
                }
                else
                {
                    throw new ArgumentException("La longitud debe ser mayor de 0");
                }
            }
        }

        public T CantidadLados
        {
            get => cantidadLados;
            set
            {
                if (value.CompareTo(2) > 0)
                {
                    cantidadLados = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad de lados debe ser mayor o igual a 3");
                }
            }
        }

        public Ejercicio_PerimetroPoligonoRegular()
            : base(15, "Perimetro Poligonos Regulares",
                "Calcula el perimetro de poligonos regulares")
        {
        }

        public Ejercicio_PerimetroPoligonoRegular(T longitudLado, T cantidadLados)
        : base(15, "Perimetro Poligonos Regulares",
            "Calcula el perimetro de poligonos regulares")
        {
            LongitudLado = longitudLado;
            CantidadLados = cantidadLados;
        }
    }
}
