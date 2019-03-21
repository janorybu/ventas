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
        FacturaBL _facturaBL;
        ProveedoresBL _proveedoresBL;
        ComprasBL _comprasBL;
        public Menu()
        {
            InitializeComponent();
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriaBL();
            _clientesBL = new ClientesBL();
            _ciudadesBL = new CiudadBL();
            _facturaBL = new FacturaBL();
            _comprasBL = new ComprasBL();
            _proveedoresBL = new ProveedoresBL();
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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;
            formFactura.cargaDatos(_facturaBL, _clientesBL, _productosBL);

            formFactura.Show();
          
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new Form4();
            formProveedores.MdiParent = this;

            formProveedores.cargarDatos(_proveedoresBL, _ciudadesBL);

            formProveedores.Show();


        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;
            formCompras.cargarDatos(_comprasBL, _clientesBL, _productosBL);

            formCompras.Show();
        }
    }
}
