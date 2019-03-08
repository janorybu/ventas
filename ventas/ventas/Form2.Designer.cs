namespace ventas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label nombreLabel1;
            this.listadeCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.listadeClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonoTextBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listadeClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listadeCiudadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ciudadLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCiudadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(451, 185);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 12;
            ciudadLabel.Text = "Ciudad:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(451, 140);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(451, 19);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 16;
            idLabel2.Text = "Id:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(451, 59);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 18;
            nombreLabel1.Text = "Nombre:";
            // 
            // listadeCategoriasBindingSource
            // 
            this.listadeCategoriasBindingSource.AllowNew = true;
            this.listadeCategoriasBindingSource.DataSource = typeof(ventas.Modelos.Categoria);
            // 
            // listadeProductosDataGridView
            // 
            this.listadeProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeProductosDataGridView.Location = new System.Drawing.Point(3, 267);
            this.listadeProductosDataGridView.Name = "listadeProductosDataGridView";
            this.listadeProductosDataGridView.Size = new System.Drawing.Size(402, 199);
            this.listadeProductosDataGridView.TabIndex = 10;
            // 
            // listadeClientesBindingSource1
            // 
            this.listadeClientesBindingSource1.AllowNew = true;
            this.listadeClientesBindingSource1.DataSource = typeof(ventas.Modelos.Cliente);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource1, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(528, 178);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciudadTextBox.TabIndex = 13;
            // 
            // direccionTextBox1
            // 
            this.direccionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource1, "Direccion", true));
            this.direccionTextBox1.Location = new System.Drawing.Point(528, 132);
            this.direccionTextBox1.Name = "direccionTextBox1";
            this.direccionTextBox1.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox1.TabIndex = 15;
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource1, "Id", true));
            this.idTextBox2.Location = new System.Drawing.Point(528, 12);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(100, 20);
            this.idTextBox2.TabIndex = 17;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource1, "Nombre", true));
            this.nombreTextBox1.Location = new System.Drawing.Point(528, 52);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox1.TabIndex = 19;
            // 
            // telefonoTextBox1
            // 
            this.telefonoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource1, "Telefono", true));
            this.telefonoTextBox1.Location = new System.Drawing.Point(528, 93);
            this.telefonoTextBox1.Name = "telefonoTextBox1";
            this.telefonoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadeClientesBindingSource1, "CategoriaId", true));
            this.comboBox2.DataSource = this.listadeClientesBindingSource1;
            this.comboBox2.DisplayMember = "Categoria";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(528, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Categorias";
            // 
            // listadeClientesDataGridView
            // 
            this.listadeClientesDataGridView.AutoGenerateColumns = false;
            this.listadeClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.listadeClientesDataGridView.DataSource = this.listadeClientesBindingSource1;
            this.listadeClientesDataGridView.Location = new System.Drawing.Point(421, 267);
            this.listadeClientesDataGridView.Name = "listadeClientesDataGridView";
            this.listadeClientesDataGridView.Size = new System.Drawing.Size(474, 199);
            this.listadeClientesDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CategoriaId";
            this.dataGridViewTextBoxColumn10.HeaderText = "CategoriaId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn11.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // listadeCiudadesBindingSource1
            // 
            this.listadeCiudadesBindingSource1.AllowNew = true;
            this.listadeCiudadesBindingSource1.DataSource = typeof(ventas.Modelos.Ciudad);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(993, 507);
            this.Controls.Add(this.listadeClientesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox1);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(this.telefonoTextBox1);
            this.Controls.Add(this.listadeProductosDataGridView);
            this.Name = "Form2";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCiudadesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listadeClientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listadeClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.BindingSource listadeCiudadesBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.BindingSource listadeCategoriasBindingSource;
        private System.Windows.Forms.DataGridView listadeProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource listadeClientesBindingSource1;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox direccionTextBox1;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox telefonoTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listadeClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource listadeCiudadesBindingSource1;
    }
}