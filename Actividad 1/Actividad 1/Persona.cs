using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_1
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string Dni;
        //Constructor
        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public string DNI
        {
            get { return DNI; }
            set { DNI = value; }
        }
    }
}
