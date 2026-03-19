using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.JuegosAzar
{
    internal class JuegoDado
    {
        public JuegoDado()
        {
            Dado dado_usuario;
            Dado dado_computadora;

            dado_usuario = new Dado();
            dado_computadora = new Dado();
            Console.WriteLine("Presione una tecla para lanzar los dados");
            Console.ReadKey();
            dado_usuario.Girar();
            Console.WriteLine("... La computadora lanza sus dados:");
            dado_computadora.Girar();
           
            int resultadoUsuario = dado_usuario.Mirar();
            int resultadoComputadora = dado_computadora.Mirar();

            if (resultadoUsuario > resultadoComputadora)
            {
                Console.WriteLine("Usuario Gana");
            }
            else if (resultadoUsuario == resultadoComputadora)
            {
                Console.WriteLine("Empate");
            }
            else if (resultadoUsuario < resultadoComputadora);
            {
                Console.WriteLine("La Computadora Gana");
            }
        }
    }
}
