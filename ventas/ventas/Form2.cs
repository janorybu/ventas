using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;

namespace ventas
{
    public partial class Form2 : Form
    {
        private object listadeCategoriasBindingSource1;

        public Form2()
        {
            InitializeComponent();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Celular Iphone";
            producto1.Precio = 100000;

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Celular Samsung";
            producto2.Precio = 8000;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            foreach (var P in listadeProductos)
            {
                MessageBox.Show(P.Descripcion);

            }


            

            var clientesBL = new ClienteBL();

            listadeClientesBindingSource1.DataSource = clientesBL.ListadeClientes;

            var categoriasBl = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBl.ListadeCategorias;


        }
    }
}
