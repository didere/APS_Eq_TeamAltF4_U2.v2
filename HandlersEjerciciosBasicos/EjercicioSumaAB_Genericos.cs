using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class EjercicioSumaAB_Genericos<T> : Ejercicio
    {
        private T a;
        private T b;

        public T A
        {
            get => a;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El valor de A no puede ser nulo.");
                }
                a = value;
            }
        }

        public T B
        {
            get => b;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El valor de B no puede ser nulo.");
                }
                b = value;
            }
        }

        public EjercicioSumaAB_Genericos(T a, T b) : base(7, "Suma con datos Genericos", "Suma con datos genericos")
        {
            A = a;
            B = b;
        }

        public EjercicioSumaAB_Genericos() : base(7, "Suma con datos Genericos", "Suma con datos genericos")
        {
          
        }

        public override void Ejecutar()
        {
            // parse es string to numero
            double resultado = Convert.ToDouble(A) + Convert.ToDouble(B);
            Console.WriteLine("La suma de A + B= " + resultado);
        }
    }
}
