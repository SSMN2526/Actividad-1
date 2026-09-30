using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Productos
    {
        public string nombre;
        public double precio;
        public int stock;
        public int descripcion;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string MostrarDatos()
        {
            return $"Nombre: {nombre}, Precio: {precio}, Stock: {stock}, Descripcion: {descripcion}";
        }
    }
}
