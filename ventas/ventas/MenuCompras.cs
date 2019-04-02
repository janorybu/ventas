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
    public partial class MenuCompras : Form
    {
        ProveedoresBL _proveedoresBL;
        ComprasBL _comprasBL;
        CiudadBL _ciudadesBL;
        ProductosBL _productosBL;
        ClientesBL _clientesBL;
        CategoriaBL _categoriaBL;
        public MenuCompras()
        {
            InitializeComponent();
            _comprasBL = new ComprasBL();
            _proveedoresBL = new ProveedoresBL();
            _ciudadesBL = new CiudadBL();
            _productosBL = new ProductosBL();
            _clientesBL = new ClientesBL();
            _categoriaBL = new CategoriaBL();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var formProveedores = new Form4();
            formProveedores.MdiParent= this;

           formProveedores.cargarDatos(_proveedoresBL, _clientesBL, _categoriaBL, _ciudadesBL);

           formProveedores.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;
            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _productosBL);

            formCompras.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
