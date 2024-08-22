using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IProducto
    {
        // Propiedades requeridas por la interfaz
        string Codigo { get; set; }
        string Nombre { get; set; }
        decimal Precio { get; set; }
        decimal Descuento { get; }

        // Método para mostrar la información del producto
        void MostrarInformacion();
    }
}
