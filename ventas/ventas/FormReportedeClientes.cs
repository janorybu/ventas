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
    public partial class FormReportedeClientes : Form
    {
        public FormReportedeClientes()
        {
            InitializeComponent();
        }
        public void CargarDatos(ClientesBL clientesBL)
        {
            var bindinSource = new BindingSource();
            bindinSource.DataSource =
                from c in clientesBL.ListadeClientes
                select new
                {
                    Foto = c.Foto,
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    Ciudad = c.Ciudad,
                    Direccion = c.Direccion,
                    Categoria = c.Categoria


                   
                };

            var reporte = new ReporteedeClientes();
            reporte.SetDataSource(bindinSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
