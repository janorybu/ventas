using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Categoria
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Juan";

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nombre = "Ramon";

            var categoria3 = new Categoria();
            categoria3.Id = 3;
            categoria3.Nombre = "Josue";

            //Cliente
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan";
            cliente1.Telefono = "96283142";
            cliente1.Direccion = "calle 5";
            cliente1.categoria = categoria1;

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Ramon";
            cliente2.Telefono = "98643212";
            cliente2.Direccion = "B San Fco, calle veinte";
            cliente2.categoria = categoria2;

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Josue";
            cliente3.Direccion = "B San Jose,contiguo a Billar Nemesis";
            cliente3.categoria = categoria3;

            //Ciudades
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "Las Vegas";
            ciudad1.cliente = cliente1;
            ciudad1.cliente = cliente1;

            Ciudad ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Los Angeles";
            ciudad2.cliente = cliente2;

            Ciudad ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "San Diego";
            ciudad3.cliente = cliente3;

            //Lista De Ciudades
            var listadeCiudades = new List<Ciudad>();
            listadeCiudades.Add(ciudad1);
            listadeCiudades.Add(ciudad2);
            listadeCiudades.Add(ciudad3);
            
            foreach (var c in listadeCiudades)
            

           
          
            MessageBox.Show(c.Descripcion + " " + c.cliente.Nombre);
        }
    }
}
