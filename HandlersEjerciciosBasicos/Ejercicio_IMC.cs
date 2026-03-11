using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    public class Ejercicio_IMC<T> : Ejercicio where T : INumber<T>
    { 
        //Tipo de Dato Generico -> T
        private T peso;
        private T estatura;

        public T Peso
        {
            get => peso;
            set
            {
                if (value.CompareTo(T.Zero) <= 0)
                {
                    throw new ArgumentException("El peso debe ser mayor a 0.");
                }
                peso = value;
            }
        }

        public T Estatura
        {
            get => estatura;
            set
            {
                if (value.CompareTo(T.Zero) <= 0)
                {
                    throw new ArgumentException("La estatura debe ser mayor a 0.");
                }
                estatura = value;
            }
        }

        public Ejercicio_IMC() : base(9, "IMC","Cálculo del IMC")
        {
            
        }

        public Ejercicio_IMC(T peso, T estatura) :
            base(9, "IMC", "Cálculo del IMC")
        {
            Peso = peso;
            Estatura = estatura;
        }

        public override void Ejecutar()
        {
            T resultado = Peso / (Estatura * Estatura);
            Console.WriteLine("IMC = " + resultado);
        }
    }
}
