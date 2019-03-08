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
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriaBL _categoriasBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadesBL;
        public Menu()
        {
            InitializeComponent();
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriaBL();
            _clientesBL = new ClientesBL();
            _ciudadesBL = new CiudadBL();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();

            formProductos.cargarDatos(_productosBL, _categoriasBL);
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL, _ciudadesBL);
            
            formClientes.Show();
        }
    }
}
