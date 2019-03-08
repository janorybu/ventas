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

        CategoriaBL _categoriasBL;
        ClienteBL _clientesBl;
        CiudadBL _ciudadesBl;

        public Menu()
        {
            InitializeComponent();

            ;
            _categoriasBL = new CategoriaBL();
            _clientesBl = new ClienteBL();
            _ciudadesBl = new CiudadBL();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;

            formClientes.cargarDatos(_clientesBl, _ciudadesBl );

            formClientes.Show();
        }
    }
}
