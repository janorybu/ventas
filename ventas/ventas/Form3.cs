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
    public partial class Form3 : Form
    {
        FacturaBL _facturaBL;
        public Form3()
        {
            InitializeComponent();
        }

        public void cargaDatos(FacturaBL facturaBL, ClientesBL clientesBL, ProductosBL productosBL)
        {
            _facturaBL = facturaBL;

            listadeFacturasBindingSource.DataSource = facturaBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productosBL.listadeProductos;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);
        }
    }
}
