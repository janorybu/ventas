using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();

                
        }

        private void CrearDatosdePrueba()
        { 
            var categoria1 = new Categoria(1, "Nombre");
            var categoria2 = new Categoria(2, "Ciudad");



            var cliente1 = new Cliente(231, "Mario", 5643254, "Paris", "Paris, Francia", categoria1);
            var cliente2 = new Cliente(232, "Luis", 5435, "Milan", "Milan, Italia",  categoria2);
            var cliente3 = new Cliente(233, "Felipe",8753543, "New York", "New York, Washington",  categoria2);
            
                                    
            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);    

        }
       

    }
}
