using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class CategoriaBL
    {
        public BindingList<Categoria> ListadeCategorias { get; set; }

        public CategoriaBL()
        {
            ListadeCategorias = new BindingList<Categoria>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
           var categoria1 = new Categoria(1, "Nombre");
            var categoria2 = new Categoria(2, "Ciudades");
            
            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);

           

           
        }

        
    }
}
