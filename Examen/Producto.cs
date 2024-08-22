using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Producto: IProducto
    {
        // Propiedades del producto
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        // Propiedad calculada que obtiene el descuento basado en el precio
        public decimal Descuento => CalcularDescuento();

        // Método privado que calcula el descuento basado en el precio
        private decimal CalcularDescuento()
        {
            if (Precio > 90) return Precio * 0.50m;
            if (Precio > 50) return Precio * 0.30m;
            if (Precio > 15) return Precio * 0.25m;
            return Precio * 0.05m;
        }

        // Método que muestra la información del producto en la consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"{Codigo} - {Nombre} - {Precio:C} - {Descuento:C}");
        }
    }
}
