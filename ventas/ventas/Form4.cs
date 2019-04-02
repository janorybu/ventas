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
    public partial class Form4 : Form
    {
        ProveedoresBL  _proveedoresBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadesBL;
        CategoriaBL _categoriaBL;

        public Form4()
        {
            InitializeComponent();
        }

        public void cargarDatos(ProveedoresBL proveedoresBL, ClientesBL clientesBL, CategoriaBL categoriaBL, CiudadBL ciudadBL)
        {
            _proveedoresBL = proveedoresBL;
            _clientesBL = clientesBL;
            _ciudadesBL = ciudadBL;
            _categoriaBL = categoriaBL;

            listadeProveedoresBindingSource.DataSource = proveedoresBL.ListadeProveedores;
            listadeCategoriasBindingSource.DataSource = categoriaBL.ListadeCategorias;
            listadeCiudadesBindingSource.DataSource = ciudadBL.listadeCiudades;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
        }

        private void listadeProveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
