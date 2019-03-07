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
        public object listadeCategoriasBindingSource1;

        public Form2()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            

            var clientesBL = new ClienteBL();

            listadeClientesBindingSource1.DataSource = clientesBL.ListadeClientes;

            var categoriasBL = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
