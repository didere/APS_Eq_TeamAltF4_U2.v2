using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using APS_Eq_TeamAltF4_U2.v2.Auxiliar;
using APS_Eq_TeamAltf4_U2;

namespace APS_Eq_TeamAltF4_U2.v2.HandlersEjerciciosBasicos
{
    public class Ejercicio_PromedioDe3Calificaciones<T> : Ejercicio where T : INumber<T>
    {
        Calificaciones<T> cal1;
        Calificaciones<T> cal2;
        Calificaciones<T> cal3;

        public Calificaciones<T> Cal1 { get => cal1; set => cal1 = value; }
        public Calificaciones<T> Cal2 { get => cal2; set => cal2 = value; }
        public Calificaciones<T> Cal3 { get => cal3; set => cal3 = value; }

        public Ejercicio_PromedioDe3Calificaciones(T cal1, T cal2, T cal3) : base(11, "Promedio de 3 calificaciones", "Calcula el promedio de 3 calificaciones")
        {
            Cal1 = new Calificaciones<T>(cal1, cal2, cal3);
        }

        public override void Ejecutar()
        {
            double resultado = (Convert.ToDouble(Cal1.Calificacion1) + Convert.ToDouble(Cal1.Calificacion2) + Convert.ToDouble(Cal1.Calificacion3)) / 3;
            Console.WriteLine("El promedio de las calificaciones es: "+ resultado);
        }
    }
}
