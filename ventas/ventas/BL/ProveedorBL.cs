using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }

        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
            
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Nombres");
            var categoria2 = new Categoria(2, "Proveedores");

            var proveedores1 = new Proveedores(121, "Mario", 99213424, "SPS", "B.Centro", categoria1);
            var proveedores2 = new Proveedores(122, "Jesus", 97685434, "Lima", "B.Centro", categoria2);
            var proveedores3 = new Proveedores(123, "Jose", 98542345, "Sps", "B. Medina", categoria2);

            ListadeProveedores.Add(proveedores1);
            ListadeProveedores.Add(proveedores2);
            ListadeProveedores.Add(proveedores3);

        }
    }
}
