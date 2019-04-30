using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProductosBL
    {
        public BindingList<Producto> listadeProductos { get; set; }

        public ProductosBL()
        {
            listadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var producto in listadeProductos)
            {
                if (producto.Id == id)
                {
                    precio = producto.Precio;
                }
            }
            return precio;
        }

        public double  ObtenerCosto(int id )
        {

            double costo = 0;
            foreach (var producto in listadeProductos)
            {
                if(producto.Id == id)
                {
                    costo = producto.Costo;
                }
            }
            return costo;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptos");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 15000, categoria1);

            var fileInfo = new FileInfo(@"C:\Users\itpc\Documents\proyecto\Imagenes\laptopasus");
            var fileStream = fileInfo.OpenRead();


           producto1.Foto =  Program.imageToByteArray  ( Image.FromStream(fileStream));

            var producto2 = new Producto(2, "Laptop Asus", 10000, categoria1);

            fileInfo = new FileInfo(@"C:\Users\itpc\Documents\proyecto\Imagenes\laptopdell");
            fileStream = fileInfo.OpenRead();


            producto2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));


            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);

            fileInfo = new FileInfo(@"C:\Users\itpc\Documents\proyecto\Imagenes\mouselogitech");
            fileStream = fileInfo.OpenRead();


            producto3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
        }
    }
}
