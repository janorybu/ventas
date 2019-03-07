using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class CategoriaBL
    {
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriaBL()
        {
            ListadeCategorias = new List<Categoria>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptos");
            var categoria2 = new Categoria(2, "Accesorios");
            
            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);
           
        }
    }
}
