using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class CiudadBL
    {
        public BindingList<Ciudad> listadeCiudades { get; set; }

        public CiudadBL()
        {
            listadeCiudades = new BindingList<Ciudad>();
            CrearDatosdePrueba();

        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Roma");
            var ciudad2 = new Ciudad(2, "Paris");
            var ciudad3 = new Ciudad(3, "Madrid");

            listadeCiudades.Add(ciudad1);
            listadeCiudades.Add(ciudad2);
            listadeCiudades.Add(ciudad3);
        }
    }


}
