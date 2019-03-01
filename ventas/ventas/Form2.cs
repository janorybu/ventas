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
        private object listadeCategoriasBindingSource1;

        public Form2()
        {
            InitializeComponent();

            var clientesBL = new ClienteBL();

            listadeClientesBindingSource1.DataSource = clientesBL.ListadeClientes;

            var categoriasBl = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBl.ListadeCategorias;

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            
           

        }

        private void idLabel1_Click(object sender, EventArgs e)
        {

        }

        private void categoriaIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriaIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listadeCategoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
