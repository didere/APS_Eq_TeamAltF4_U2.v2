using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2.HandlersEjerciciosBasicos
{
    class Ejercicio_ATM : Ejercicio
    {
        //Esta clase sera para simular un ATM en donde se ingresa cuanto se quiere retirar en el runner y se muestra el resultado de cuantos billetes de cada denominacion de mayor a menor se necesitan para retirar esa cantidad
        private double cantidad;
        public double Cantidad
        {
            get => cantidad; set => cantidad = value;
        }
        public Ejercicio_ATM(double cantidad) : base(8, "ATM", "Simulacion de un ATM para retirar dinero")
        {
            Cantidad = cantidad;
        }

        public override void Ejecutar()
        {
            Console.WriteLine("Cantidad a retirar: " + Cantidad);
            int bil1000, bil500, bil200, bil100, bil50, bil20, coin10, coin5, coin2, coin1,coincentavos;
            
            
            bil1000 = (int)(Cantidad / 1000);
            Cantidad = Cantidad % 1000;
            bil500 = (int)(Cantidad / 500);
            Cantidad = Cantidad % 500;
            bil200 = (int)(Cantidad / 200);
            Cantidad = Cantidad % 200;
            bil100 = (int)(Cantidad / 100);
            Cantidad = Cantidad % 100;
            bil50 = (int)(Cantidad / 50);
            Cantidad = Cantidad % 50;
            bil20 = (int)(Cantidad / 20);
            Cantidad = Cantidad % 20;
            coin10 = (int)(Cantidad / 10);
            Cantidad = Cantidad % 10;
            coin5 = (int)(Cantidad / 5);
            Cantidad = Cantidad % 5;
            coin2 = (int)(Cantidad / 2);
            Cantidad = Cantidad % 2;
            coin1 = (int)(Cantidad / 1);
            Cantidad = Cantidad % 1;
            coincentavos = (int)(Cantidad * 100);
            
            Console.WriteLine("Billetes de 1000: " + bil1000);
            Console.WriteLine("Billetes de 500: " + bil500);
            Console.WriteLine("Billetes de 200: " + bil200);
            Console.WriteLine("Billetes de 100: " + bil100);
            Console.WriteLine("Billetes de 50: " + bil50);
            Console.WriteLine("Billetes de 20: " + bil20);
            Console.WriteLine("Monedas de 10: " + coin10);
            Console.WriteLine("Monedas de 5: " + coin5);
            Console.WriteLine("Monedas de 2: " + coin2);
            Console.WriteLine("Monedas de 1: " + coin1);
            Console.WriteLine("Monedas de centavos: " + coincentavos);
            
        }
    }
}
