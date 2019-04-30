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
    public partial class FormReportedeProductos : Form
    {
        public FormReportedeProductos()
        {
            InitializeComponent();
        }

        public void CargarDatos (ProductosBL productosBL)
        {
            var bindinSource = new BindingSource();
            bindinSource.DataSource =
                from p in productosBL.listadeProductos
                select new {
                    Foto = p.Foto,
                    Id = p.Id,
                    Descripcion = p.Descripcion,
                    Precio = p.Precio,
                    Categoria = p.Categoria.Descripcion
                };

            var reporte = new ReportedeProductos();
            reporte.SetDataSource(bindinSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
