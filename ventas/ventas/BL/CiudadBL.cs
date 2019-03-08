using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class CiudadBL
    {
        public List<Ciudad> ListadeCiudades { get; set; }

        public CiudadBL()
        {
            ListadeCiudades = new List<Ciudad>();
            CrearDatosdePrueba();

        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Roma");
            var ciudad2 = new Ciudad(2, "Paris");
            var ciudad3 = new Ciudad(3, "Madrid");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
            ListadeCiudades.Add(ciudad3);
        }
    }


}
