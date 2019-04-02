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
            CrearDatosdePrueba();
            
        }
        public void CrearDatosdePrueba()
        {
          
            var proveedores1 = new Proveedores(121, "Mario", 99213424);
            var proveedores2 = new Proveedores(122, "Jesus", 97685434);
            var proveedores3 = new Proveedores(123, "Jose", 98542345);

            ListadeProveedores.Add(proveedores1);
            ListadeProveedores.Add(proveedores2);
            ListadeProveedores.Add(proveedores3);

        }
    }
}
