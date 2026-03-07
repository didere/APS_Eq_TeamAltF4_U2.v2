using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace APS_Eq_TeamAltF4_U2.v2.Auxiliar
{
    internal class NumPrimo<T> where T : INumber<T>
    {
            private T numero;
    
            public T Numero { get => numero; set => numero = value; }
    
            public NumPrimo(T numero)
            {
                Numero = numero;
            }
    }
}
