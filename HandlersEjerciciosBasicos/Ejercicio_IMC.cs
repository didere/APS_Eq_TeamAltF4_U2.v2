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

        public T Peso { get => peso; set => peso = value; }
        public T Estatura { get => estatura; set => estatura = value; }

        public Ejercicio_IMC(T peso, T estatura) :
            base(8, "IMC",
                "Cálculo del IMC")
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