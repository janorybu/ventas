using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.Modelos
{
   public  class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public byte[] Foto { get; set; }



        public Proveedores()
        {
            
        }
        

       

        public Proveedores(int id, string nombre, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
                       
           

        }


    }
}
