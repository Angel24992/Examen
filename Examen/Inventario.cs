using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Inventario
    {
        // Lista de productos en el inventario
        private List<Producto> productos = new List<Producto>();

        // Verifica si ya existe un producto con el mismo código
        public void AgregarProducto(string codigo, string nombre, decimal precio)
        {
            if (productos.Any(p => p.Codigo == codigo))
            {
                Console.WriteLine("Error: El código del producto ya existe.");
                return;
            }

            // Crea un nuevo producto y lo agrega a la lista
            var producto = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Precio = precio
            };

            productos.Add(producto);
            Console.WriteLine("Producto agregado exitosamente.");
        }

        // Método para eliminar un producto del inventario basado en su código
        public void EliminarProducto(string codigo)
        {
            // Encuentra el producto con el código especificado
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                // Elimina el producto de la lista
                productos.Remove(producto);
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: El producto no existe.");
            }
        }

        // Método para consultar un producto por su código y mostrar su nombre y precio
        public void ConsultarProducto(string codigo) 
        {
            // Encuentra el producto con el código especificado        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio:C}");
            }
            else
            {
                Console.WriteLine("Error: El producto no existe.");
            }
        }

        // Método para modificar el precio de un producto basado en su código
        public void ModificarPrecio(string codigo, decimal nuevoPrecio)
        {
            // Encuentra el producto con el código especificado
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                // Actualiza el precio del producto
                producto.Precio = nuevoPrecio;
                Console.WriteLine("Precio modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: El producto no existe.");
            }
        }

        // Método para mostrar todos los productos con un precio menor a 30$
        public void MostrarProductosMenoresDe30()
        {
            var productosMenoresDe30 = productos.Where(p => p.Precio < 30);
            foreach (var producto in productosMenoresDe30)
            {
                producto.MostrarInformacion();
            }
        }

        // Método para mostrar todos los productos con un precio mayor a 60$
        public void MostrarProductosMayoresDe60()
        {
            var productosMayoresDe60 = productos.Where(p => p.Precio > 60);
            foreach (var producto in productosMayoresDe60)
            {
                producto.MostrarInformacion();
            }
        }

        // Método para mostrar todos los productos en el inventario
        public void MostrarTodosLosProductos()
        {
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
    }
}
