using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    class ProductosBL
    {
        public List<Producto> listadeProductos { get; set; }

        public ProductosBL()
        {
            listadeProductos = new List<Producto>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptos");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 15000, categoria1);
            var producto2 = new Producto(2, "Laptop Asus", 10000, categoria1);
            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
        }
    }
}
