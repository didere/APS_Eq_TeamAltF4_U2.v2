using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltF4_U2.v2.ListasGenericas
{
    internal class Ej3_Lista
    {
        public Ej3_Lista()
        {
            List<int> califs_parcial1;
            califs_parcial1 = new List<int>();
            //Objeto de la clase Random para generar números aleatorios
            Random random;
            random = new Random(5);

            for (int i = 0; i < 10; i++)
            {
                int v= random.Next(0,11);
                Console.WriteLine(v);
                califs_parcial1.Add(v);
            }

            Console.WriteLine();
        }
    }
}
