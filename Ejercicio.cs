using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Eq_TeamAltf4_U2
{
    public class Ejercicio
    {
        private int identificador; 
        private string nombre_ejercicio; 
        private string descripcion; 
        public int Identificador 
        { 
            get => identificador; 
            set => identificador = value; 
        }
        public string NombreEjercicio
        { 
            get => nombre_ejercicio; 
            set => nombre_ejercicio = value; 
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }        

        public Ejercicio(int identificador, string nombre_ejercicio, string descripcion)
        {
            Identificador = identificador;
            NombreEjercicio = nombre_ejercicio;
            Descripcion = descripcion;
        }

        public virtual void Ejecutar()
        {
        
        }

        public override string ToString()
        {
            return "(" + Identificador + ") - Nombre: " + NombreEjercicio + " - Descripción: " + Descripcion;
        }
    }
}
