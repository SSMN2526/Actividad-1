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

        public Persona(string nombre, string dni, int edad)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }
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
        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }
        public static void Main(string[] args)
        {
            Persona p = new Persona("Ana", "2131364B", 25);

            if (p.EsMayorDeEdad())
            {
                Console.WriteLine($"{p.Nombre} es mayor de edad");
            }
            else
            {
                Console.WriteLine($"{p.Nombre} es menor de edad");
            }

            Console.WriteLine($"Antes: {p.Nombre}, {p.Edad}");

            p.Nombre = "María";
            p.Edad = 30;

            Console.WriteLine($"Después: {p.Nombre}, {p.Edad}");
        }
    }
}
