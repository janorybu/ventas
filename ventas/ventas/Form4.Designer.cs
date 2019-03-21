namespace ventas
{
    partial class Form4
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.listadeProveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.listadeProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeCiudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ciudadLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCiudadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(55, 194);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 3;
            ciudadLabel.Text = "Ciudad:";
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(128, 191);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciudadTextBox.TabIndex = 4;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(55, 111);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(128, 108);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(55, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(128, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(55, 73);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 70);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(55, 151);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(128, 148);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // listadeProveedoresDataGridView
            // 
            this.listadeProveedoresDataGridView.AutoGenerateColumns = false;
            this.listadeProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeProveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.listadeProveedoresDataGridView.DataSource = this.listadeProveedoresBindingSource;
            this.listadeProveedoresDataGridView.Location = new System.Drawing.Point(119, 165);
            this.listadeProveedoresDataGridView.Name = "listadeProveedoresDataGridView";
            this.listadeProveedoresDataGridView.Size = new System.Drawing.Size(692, 176);
            this.listadeProveedoresDataGridView.TabIndex = 12;
            // 
            // listadeProveedoresBindingSource
            // 
            this.listadeProveedoresBindingSource.DataSource = typeof(ventas.Modelos.Proveedores);
            // 
            // listadeCategoriasBindingSource
            // 
            this.listadeCategoriasBindingSource.DataSource = typeof(ventas.Modelos.Categoria);
            // 
            // listadeCiudadesBindingSource
            // 
            this.listadeCiudadesBindingSource.DataSource = typeof(ventas.Modelos.Ciudad);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoriaId";
            this.dataGridViewTextBoxColumn1.DataSource = this.listadeProveedoresBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn7.DataSource = this.listadeCategoriasBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 361);
            this.Controls.Add(this.listadeProveedoresDataGridView);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Name = "Form4";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCiudadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeProveedoresBindingSource;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.BindingSource listadeCiudadesBindingSource;
        private System.Windows.Forms.DataGridView listadeProveedoresDataGridView;
        private System.Windows.Forms.BindingSource listadeCategoriasBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}