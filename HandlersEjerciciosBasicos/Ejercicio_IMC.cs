using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_IMC<T> : Ejercicio
    {
        private T peso;
        private T altura;

        public T Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public T Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public Ejercicio_IMC(T peso, T altura) : base(9, "Calculo de IMC", "Calcula el indice de masa corporal a partir del peso y la altura")
        {
            this.peso = peso;
            this.altura = altura;
        }

        public override void Ejecutar()
        {
            T resultado = (dynamic)Peso / ((dynamic)Altura * (dynamic)Altura);
            Console.WriteLine("IMC = " + resultado);
        }
    }
}
