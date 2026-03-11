using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace APS_Eq_TeamAltF4_U2.v2.Ejemplo_Herencia
{
    public class SupportType1 : JugadorSupport
    {
        private string habilidad_especifica;
        public string Habilidad_especifica
        {
            get => habilidad_especifica;
            set
            {
                habilidad_especifica = value;
            }
        }
        public SupportType1(string nombre ,string habilidad) : base ("Nombre", "Habilidad")
        {
            Habilidad_especifica = habilidad_especifica;
        }
    }
}