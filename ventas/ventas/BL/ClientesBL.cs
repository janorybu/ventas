using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas;
using ventas.Modelos;

namespace ventas.BL
{
   public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();

        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Nombres");
            var categoria2 = new Categoria(2, "Ciudades");

            var cliente1 = new Cliente(121, "Josue", 99213424,"Roma", "Roma, Italia", categoria1 );
            var cliente2 = new Cliente(122, "Ramon", 97685434, "Paris", "Paris, Francia", categoria2);
            var cliente3 = new Cliente(123, "Jorge", 98542345, "Madrid", "Madrid, España", categoria2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
