using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Persona
    {
        public string nombre;
        public string dni;
        public int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string MostrarDatos()
        {
            return $"Nombre: {nombre}, DNI: {dni}, Edad: {edad}";
        }

    }
}
