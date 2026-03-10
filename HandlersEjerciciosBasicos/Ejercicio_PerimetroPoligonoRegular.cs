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
            get { return longitudLado; }
            set
            {
                if (value.CompareTo(0) > 0)
                {
                    longitudLado = value;
                }
                else
                {
                    throw new ArgumentException("La longitud del lado debe ser mayor a 0.");
                }
            }
        }

        public T CantidadLados
        {
            get { return cantidadLados; }
            set 
            {
                if (value.CompareTo(2) > 0)
                {
                    cantidadLados = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad de lados debe ser mayor o igual a 2.");
                }
            }
        }

        public Ejercicio_PerimetroPoligonoRegular(T longitudLado, T cantidadLados) : base (15, "Perímetro de un polígono regular", "Calcula el perímetro de un polígono regular dado la longitud de sus lados y la cantidad de lados.")
        {
            LongitudLado = longitudLado;
            CantidadLados = cantidadLados;
        }
        public Ejercicio_PerimetroPoligonoRegular() : base(15, "Perímetro de un polígono regular", "Calcula el perímetro de un polígono regular dado la longitud de sus lados y la cantidad de lados.")
        {
        }
    }
}
