using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inventario = new Inventario();

            while (true)
            {
                Console.WriteLine("1. Mostrar todos los productos");
                Console.WriteLine("2. Introducir producto");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Consultar producto");
                Console.WriteLine("5. Modificar precio");
                Console.WriteLine("6. Mostrar productos menores de 30$");
                Console.WriteLine("7. Mostrar productos mayores de 60$");
                Console.WriteLine("8. Salir");
                Console.Write("Elija una opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Muestra todos los productos en el inventario
                        inventario.MostrarTodosLosProductos();
                        break;

                    case "2":
                        Console.Write("Ingrese código del producto: ");
                        var codigoAgregar = Console.ReadLine();
                        Console.Write("Ingrese nombre del producto: ");
                        var nombreAgregar = Console.ReadLine();
                        Console.Write("Ingrese precio del producto: ");
                        var precioAgregar = decimal.Parse(Console.ReadLine());
                        // Agrega un nuevo producto al inventario
                        inventario.AgregarProducto(codigoAgregar, nombreAgregar, precioAgregar);
                        break;

                    case "3":
                        Console.Write("Ingrese código del producto a eliminar: ");
                        var codigoEliminar = Console.ReadLine();
                        // Elimina un producto del inventario
                        inventario.EliminarProducto(codigoEliminar);
                        break;

                    case "4":
                        Console.Write("Ingrese código del producto a consultar: ");
                        var codigoConsultar = Console.ReadLine();
                        // Consulta un producto por su código
                        inventario.ConsultarProducto(codigoConsultar);
                        break;

                    case "5":
                        Console.Write("Ingrese código del producto a modificar: ");
                        var codigoModificar = Console.ReadLine();
                        Console.Write("Ingrese nuevo precio del producto: ");
                        var nuevoPrecio = decimal.Parse(Console.ReadLine());
                        // Modifica el precio de un producto
                        inventario.ModificarPrecio(codigoModificar, nuevoPrecio);
                        break;

                    case "6":
                        // Muestra todos los productos con un precio menor a 30$
                        inventario.MostrarProductosMenoresDe30();
                        break;
                        
                    case "7":
                        // Muestra todos los productos con un precio mayor a 60$
                        inventario.MostrarProductosMayoresDe60();
                        break;
                        
                    case "8":
                        // Sale del programa
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
