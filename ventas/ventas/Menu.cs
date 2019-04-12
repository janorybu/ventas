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
        ComprasBL _comprasBL;
        ProveedoresBL _proveedoresBL;
        UsuariosBL _usuariosBL;
       
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
            _usuariosBL = new UsuariosBL();

           
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

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;
            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _productosBL);
            formCompras.Show();
           

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproveedores = new Form4();
            formproveedores.MdiParent = this;

            formproveedores.cargarDatos(_proveedoresBL);

            formproveedores.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuariosBL);

            login.ShowDialog();

            productoToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            clientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerClientes;

            proveedoresToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProveedores;
            comprasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerCompras;

            reporteToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportes;
           
            
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeProductos = new FormReporteProductos();
            formReportedeProductos.cargarDatos(_productosBL);
            formReportedeProductos.MdiParent = this;

            formReportedeProductos.Show();
        }

        private void totalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeVentas = new FormReportedeVentas();
            formReportedeVentas.cargarDatos(_facturaBL, _clientesBL );
            formReportedeVentas.MdiParent = this;

            formReportedeVentas.Show();

        }
    }
}
