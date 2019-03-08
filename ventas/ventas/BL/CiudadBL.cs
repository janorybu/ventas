using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class CiudadBL
    {
        public BindingList<Ciudad> ListadeCiudades { get; set; }


        public CiudadBL()
        {
            ListadeCiudades = new BindingList<Ciudad>();
            CrearDatosdeprueba();


        }
        private void CrearDatosdeprueba()
        {
   
            var ciudad1 = new Ciudad(1,"Paris" );
            var ciudad2 = new Ciudad(2,"Milan");
            var ciudad3 = new Ciudad(3,"New York");


            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
            ListadeCiudades.Add(ciudad3);
        }
    }
}
