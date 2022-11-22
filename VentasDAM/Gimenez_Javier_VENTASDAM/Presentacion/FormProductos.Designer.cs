namespace Presentacion
{
    partial class FormProductos
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
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidadPorUnidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUnidadesStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUnidadesPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNivelRepedidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiscontinuo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btSalirDelFormlario = new System.Windows.Forms.Button();
            this.gbProductoSeleccionado = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFiltradoNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.gbProductoSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.AllowUserToAddRows = false;
            this.dataGridViewCategorias.AllowUserToDeleteRows = false;
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoriaId,
            this.Nombre,
            this.Descripción,
            this.Imagen});
            this.dataGridViewCategorias.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.RowHeadersWidth = 51;
            this.dataGridViewCategorias.RowTemplate.Height = 25;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(1240, 204);
            this.dataGridViewCategorias.TabIndex = 0;
            this.dataGridViewCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarProductos);
            // 
            // CategoriaId
            // 
            this.CategoriaId.FillWeight = 67.3968F;
            this.CategoriaId.HeaderText = "CategoriaId";
            this.CategoriaId.MinimumWidth = 6;
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.ReadOnly = true;
            this.CategoriaId.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 83.1712F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 247;
            // 
            // Descripción
            // 
            this.Descripción.FillWeight = 192.5754F;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 571;
            // 
            // Imagen
            // 
            this.Imagen.FillWeight = 56.85658F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por nombre de categoría";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.ProductoId,
            this.NombreProducto});
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 302);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 25;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1240, 320);
            this.dataGridViewProductos.TabIndex = 3;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarProducto);
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 31.59225F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // ProductoId
            // 
            this.ProductoId.FillWeight = 50.80787F;
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.MinimumWidth = 6;
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 201;
            // 
            // NombreProducto
            // 
            this.NombreProducto.FillWeight = 217.5998F;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 861;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad por unidad";
            // 
            // tbCantidadPorUnidad
            // 
            this.tbCantidadPorUnidad.Location = new System.Drawing.Point(157, 56);
            this.tbCantidadPorUnidad.Name = "tbCantidadPorUnidad";
            this.tbCantidadPorUnidad.ReadOnly = true;
            this.tbCantidadPorUnidad.Size = new System.Drawing.Size(248, 23);
            this.tbCantidadPorUnidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio por unidad";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(576, 89);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(128, 23);
            this.tbPrecio.TabIndex = 9;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormatearPrecio);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidades en stock";
            // 
            // tbUnidadesStock
            // 
            this.tbUnidadesStock.Location = new System.Drawing.Point(575, 26);
            this.tbUnidadesStock.Name = "tbUnidadesStock";
            this.tbUnidadesStock.ReadOnly = true;
            this.tbUnidadesStock.Size = new System.Drawing.Size(129, 23);
            this.tbUnidadesStock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades en pedido";
            // 
            // tbUnidadesPedido
            // 
            this.tbUnidadesPedido.Location = new System.Drawing.Point(576, 56);
            this.tbUnidadesPedido.Name = "tbUnidadesPedido";
            this.tbUnidadesPedido.ReadOnly = true;
            this.tbUnidadesPedido.Size = new System.Drawing.Size(128, 23);
            this.tbUnidadesPedido.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nivel de repedidos";
            // 
            // tbNivelRepedidos
            // 
            this.tbNivelRepedidos.Location = new System.Drawing.Point(158, 87);
            this.tbNivelRepedidos.Name = "tbNivelRepedidos";
            this.tbNivelRepedidos.ReadOnly = true;
            this.tbNivelRepedidos.Size = new System.Drawing.Size(128, 23);
            this.tbNivelRepedidos.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Discontinuo";
            // 
            // tbDiscontinuo
            // 
            this.tbDiscontinuo.Location = new System.Drawing.Point(158, 122);
            this.tbDiscontinuo.Name = "tbDiscontinuo";
            this.tbDiscontinuo.ReadOnly = true;
            this.tbDiscontinuo.Size = new System.Drawing.Size(128, 23);
            this.tbDiscontinuo.TabIndex = 17;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(158, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(248, 23);
            this.tbNombre.TabIndex = 5;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(443, 129);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(118, 55);
            this.btActualizar.TabIndex = 20;
            this.btActualizar.Text = "Actualizar Precio";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizarPrecio_Click);
            // 
            // btSalirDelFormlario
            // 
            this.btSalirDelFormlario.Location = new System.Drawing.Point(576, 129);
            this.btSalirDelFormlario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalirDelFormlario.Name = "btSalirDelFormlario";
            this.btSalirDelFormlario.Size = new System.Drawing.Size(128, 55);
            this.btSalirDelFormlario.TabIndex = 21;
            this.btSalirDelFormlario.Text = "Salir";
            this.btSalirDelFormlario.UseVisualStyleBackColor = true;
            this.btSalirDelFormlario.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // gbProductoSeleccionado
            // 
            this.gbProductoSeleccionado.Controls.Add(this.label2);
            this.gbProductoSeleccionado.Controls.Add(this.btSalirDelFormlario);
            this.gbProductoSeleccionado.Controls.Add(this.tbNombre);
            this.gbProductoSeleccionado.Controls.Add(this.btActualizar);
            this.gbProductoSeleccionado.Controls.Add(this.label3);
            this.gbProductoSeleccionado.Controls.Add(this.tbCantidadPorUnidad);
            this.gbProductoSeleccionado.Controls.Add(this.label4);
            this.gbProductoSeleccionado.Controls.Add(this.label5);
            this.gbProductoSeleccionado.Controls.Add(this.tbUnidadesPedido);
            this.gbProductoSeleccionado.Controls.Add(this.tbDiscontinuo);
            this.gbProductoSeleccionado.Controls.Add(this.label6);
            this.gbProductoSeleccionado.Controls.Add(this.tbPrecio);
            this.gbProductoSeleccionado.Controls.Add(this.tbUnidadesStock);
            this.gbProductoSeleccionado.Controls.Add(this.label8);
            this.gbProductoSeleccionado.Controls.Add(this.tbNivelRepedidos);
            this.gbProductoSeleccionado.Controls.Add(this.label7);
            this.gbProductoSeleccionado.Location = new System.Drawing.Point(251, 627);
            this.gbProductoSeleccionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProductoSeleccionado.Name = "gbProductoSeleccionado";
            this.gbProductoSeleccionado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProductoSeleccionado.Size = new System.Drawing.Size(724, 223);
            this.gbProductoSeleccionado.TabIndex = 22;
            this.gbProductoSeleccionado.TabStop = false;
            this.gbProductoSeleccionado.Text = "Producto seleccionado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filtrar por nombre";
            // 
            // tbFiltradoNombre
            // 
            this.tbFiltradoNombre.Location = new System.Drawing.Point(121, 272);
            this.tbFiltradoNombre.Name = "tbFiltradoNombre";
            this.tbFiltradoNombre.Size = new System.Drawing.Size(392, 23);
            this.tbFiltradoNombre.TabIndex = 24;
            this.tbFiltradoNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FiltrarProductosPorNombre);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.tbFiltradoNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbProductoSeleccionado);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCategorias);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProductos_FormClosing);
            this.Load += new System.EventHandler(this.CargarCategorias);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.gbProductoSeleccionado.ResumeLayout(false);
            this.gbProductoSeleccionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewCategorias;
        private Label label1;
        private DataGridView dataGridViewProductos;
        private Label label2;
        private Label label3;
        private TextBox tbCantidadPorUnidad;
        private Label label4;
        private TextBox tbPrecio;
        private Label label5;
        private TextBox tbUnidadesStock;
        private Label label6;
        private TextBox tbUnidadesPedido;
        private Label label7;
        private TextBox tbNivelRepedidos;
        private Label label8;
        private TextBox tbDiscontinuo;
        private DataGridViewTextBoxColumn CategoriaId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewImageColumn Imagen;
        private TextBox tbNombre;
        private Button btActualizar;
        private Button btSalirDelFormlario;
        private GroupBox gbProductoSeleccionado;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn NombreProducto;
        private Label label9;
        private TextBox tbFiltradoNombre;
    }
}