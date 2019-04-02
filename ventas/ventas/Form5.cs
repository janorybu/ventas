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

        public void cargarDatos(ComprasBL comprasBL, ProveedoresBL proveedoresBL, ProductosBL productosBL)
        {
            _comprasBL = comprasBL;
            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeProveedoresBindingSource.DataSource = proveedoresBL.ListadeProveedores;
            listadeProductosBindingSource.DataSource = productosBL.listadeProductos;
        }

        private void comprasDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var compras = (Compras)listadeComprasBindingSource.Current;
            compras.CalcularTotalCompras();
            listadeComprasBindingSource.ResetBindings(false);
        }
    }
}
