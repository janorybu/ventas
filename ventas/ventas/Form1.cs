using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;

namespace ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void cargarDatos(ProductosBL productosBl, CategoriaBL categoriaBL)
        {
            
            listadeProductosBindingSource.DataSource = productosBl.listadeProductos;
            listadeCategoriasBindingSource.DataSource = categoriaBL.ListadeCategorias;
        }

        private void listadeProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo != "")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);
            }
        }
    }
   }


