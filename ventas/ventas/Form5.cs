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
using ventas.Modelos;

namespace ventas
{
    public partial class Form5 : Form
    {
        ComprasBL _comprasBL;
        public Form5()
        {
            InitializeComponent();
        }

        private void comprasDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarDatos(ComprasBL comprasBL, ClientesBL clientesBL, ProductosBL productosBL)
        {
          
            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productosBL.listadeProductos;
        }


        private void comprasDetalleDataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            var compras = (Compras)listadeComprasBindingSource.Current;
            compras.CalcularTotalCompras();


            listadeClientesBindingSource.ResetBindings(false);
        }
    }
}
