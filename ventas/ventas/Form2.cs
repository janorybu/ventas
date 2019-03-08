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
        public Form2()
        {
            InitializeComponent();

        }

        private void listadeCategoriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listadeClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarDatos(ClientesBL clientesBL, CiudadBL ciudadesBL)
        {

            
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;

            //var categoriasBL = new CategoriaBL();
            //listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
            listadeCiudadesBindingSource.DataSource = ciudadesBL.listadeCiudades;
        }
    }
}
