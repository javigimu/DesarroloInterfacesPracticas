namespace Presentacion
{
    partial class FormPedidos
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
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.btSeleccionarCliente = new System.Windows.Forms.Button();
            this.lbFechaPedido = new System.Windows.Forms.Label();
            this.dtpFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.cbShipVia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreEnvio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAnyadirProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.tbTotalSinIva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btFinalizarPedido = new System.Windows.Forms.Button();
            this.btBorrarPedido = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAnyadirProducto = new System.Windows.Forms.Button();
            this.btEliminarProducto = new System.Windows.Forms.Button();
            this.lbTextoPedido = new System.Windows.Forms.Label();
            this.lbPedidoId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(154, 41);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(290, 23);
            this.tbCliente.TabIndex = 2;
            // 
            // btSeleccionarCliente
            // 
            this.btSeleccionarCliente.Location = new System.Drawing.Point(12, 40);
            this.btSeleccionarCliente.Name = "btSeleccionarCliente";
            this.btSeleccionarCliente.Size = new System.Drawing.Size(120, 23);
            this.btSeleccionarCliente.TabIndex = 3;
            this.btSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btSeleccionarCliente.Click += new System.EventHandler(this.btSeleccionarCliente_Click);
            // 
            // lbFechaPedido
            // 
            this.lbFechaPedido.AutoSize = true;
            this.lbFechaPedido.Location = new System.Drawing.Point(12, 80);
            this.lbFechaPedido.Name = "lbFechaPedido";
            this.lbFechaPedido.Size = new System.Drawing.Size(94, 15);
            this.lbFechaPedido.TabIndex = 4;
            this.lbFechaPedido.Text = "Fecha de pedido";
            // 
            // dtpFechaRequerida
            // 
            this.dtpFechaRequerida.Location = new System.Drawing.Point(138, 109);
            this.dtpFechaRequerida.Name = "dtpFechaRequerida";
            this.dtpFechaRequerida.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaRequerida.TabIndex = 5;
            this.dtpFechaRequerida.ValueChanged += new System.EventHandler(this.CambiarFormatoFecha);
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Location = new System.Drawing.Point(138, 143);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaEnvio.TabIndex = 6;
            this.dtpFechaEnvio.ValueChanged += new System.EventHandler(this.CambiarFormatoFecha);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Requerida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de envío";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(138, 74);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaPedido.TabIndex = 9;
            this.dtpFechaPedido.ValueChanged += new System.EventHandler(this.CambiarFormatoFecha);
            // 
            // cbShipVia
            // 
            this.cbShipVia.FormattingEnabled = true;
            this.cbShipVia.Location = new System.Drawing.Point(586, 16);
            this.cbShipVia.Name = "cbShipVia";
            this.cbShipVia.Size = new System.Drawing.Size(163, 23);
            this.cbShipVia.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de envío";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Peso";
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(586, 48);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(163, 23);
            this.tbPeso.TabIndex = 13;
            this.tbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormatearPrecio);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre del envío";
            // 
            // tbNombreEnvio
            // 
            this.tbNombreEnvio.Location = new System.Drawing.Point(139, 16);
            this.tbNombreEnvio.Name = "tbNombreEnvio";
            this.tbNombreEnvio.Size = new System.Drawing.Size(331, 23);
            this.tbNombreEnvio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección de envío";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(139, 50);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(331, 23);
            this.tbDireccion.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ciudad de envío";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(139, 84);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(331, 23);
            this.tbCiudad.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Región";
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(139, 118);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(331, 23);
            this.tbRegion.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Codigo Postal";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(586, 80);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(163, 23);
            this.tbCodigoPostal.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pais";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(586, 112);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(163, 23);
            this.tbPais.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPeso);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNombreEnvio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbShipVia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCodigoPostal);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCiudad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(484, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 152);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del envío";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Nombre,
            this.PrecioUnidad,
            this.Cantidad,
            this.Descuento});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 390);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ProductId
            // 
            this.ProductId.FillWeight = 126.9036F;
            this.ProductId.HeaderText = "ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 93.27411F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 450;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.FillWeight = 93.27411F;
            this.PrecioUnidad.HeaderText = "Precio (und)";
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.ReadOnly = true;
            this.PrecioUnidad.Width = 216;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 93.27411F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 217;
            // 
            // Descuento
            // 
            this.Descuento.FillWeight = 93.27411F;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 215;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAnyadirProducto,
            this.tsmiEliminarProducto});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 48);
            // 
            // tsmiAnyadirProducto
            // 
            this.tsmiAnyadirProducto.Name = "tsmiAnyadirProducto";
            this.tsmiAnyadirProducto.Size = new System.Drawing.Size(169, 22);
            this.tsmiAnyadirProducto.Text = "Añadir Producto";
            this.tsmiAnyadirProducto.Click += new System.EventHandler(this.tsmiAnyadirProducto_Click);
            // 
            // tsmiEliminarProducto
            // 
            this.tsmiEliminarProducto.Name = "tsmiEliminarProducto";
            this.tsmiEliminarProducto.Size = new System.Drawing.Size(169, 22);
            this.tsmiEliminarProducto.Text = "Eliminar Producto";
            this.tsmiEliminarProducto.Click += new System.EventHandler(this.tsmiEliminarProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.tbIva);
            this.groupBox2.Controls.Add(this.tbTotalSinIva);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(154, 632);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 200);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(161, 135);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(208, 23);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIva
            // 
            this.tbIva.Location = new System.Drawing.Point(161, 93);
            this.tbIva.Name = "tbIva";
            this.tbIva.ReadOnly = true;
            this.tbIva.Size = new System.Drawing.Size(208, 23);
            this.tbIva.TabIndex = 4;
            this.tbIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbIva.Leave += new System.EventHandler(this.tbIva_Leave);
            // 
            // tbTotalSinIva
            // 
            this.tbTotalSinIva.Location = new System.Drawing.Point(161, 51);
            this.tbTotalSinIva.Name = "tbTotalSinIva";
            this.tbTotalSinIva.ReadOnly = true;
            this.tbTotalSinIva.Size = new System.Drawing.Size(208, 23);
            this.tbTotalSinIva.TabIndex = 3;
            this.tbTotalSinIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total Pedido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "IVA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total sin IVA";
            // 
            // btFinalizarPedido
            // 
            this.btFinalizarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFinalizarPedido.Location = new System.Drawing.Point(640, 783);
            this.btFinalizarPedido.Name = "btFinalizarPedido";
            this.btFinalizarPedido.Size = new System.Drawing.Size(181, 51);
            this.btFinalizarPedido.TabIndex = 29;
            this.btFinalizarPedido.Text = "Finalizar Pedido";
            this.btFinalizarPedido.UseVisualStyleBackColor = true;
            this.btFinalizarPedido.Click += new System.EventHandler(this.btFinalizarPedido_Click);
            // 
            // btBorrarPedido
            // 
            this.btBorrarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBorrarPedido.Location = new System.Drawing.Point(846, 783);
            this.btBorrarPedido.Name = "btBorrarPedido";
            this.btBorrarPedido.Size = new System.Drawing.Size(181, 51);
            this.btBorrarPedido.TabIndex = 30;
            this.btBorrarPedido.Text = "Resetear Pedido";
            this.btBorrarPedido.UseVisualStyleBackColor = true;
            this.btBorrarPedido.Click += new System.EventHandler(this.btBorrarPedido_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalir.Location = new System.Drawing.Point(1052, 783);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(181, 49);
            this.btSalir.TabIndex = 31;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAnyadirProducto
            // 
            this.btAnyadirProducto.Location = new System.Drawing.Point(12, 199);
            this.btAnyadirProducto.Name = "btAnyadirProducto";
            this.btAnyadirProducto.Size = new System.Drawing.Size(132, 23);
            this.btAnyadirProducto.TabIndex = 32;
            this.btAnyadirProducto.Text = "Añadir Producto";
            this.btAnyadirProducto.UseVisualStyleBackColor = true;
            this.btAnyadirProducto.Click += new System.EventHandler(this.btAnyadirProducto_Click);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.Location = new System.Drawing.Point(155, 199);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(132, 23);
            this.btEliminarProducto.TabIndex = 33;
            this.btEliminarProducto.Text = "Eliminar Producto";
            this.btEliminarProducto.UseVisualStyleBackColor = true;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // lbTextoPedido
            // 
            this.lbTextoPedido.AutoSize = true;
            this.lbTextoPedido.Location = new System.Drawing.Point(13, 9);
            this.lbTextoPedido.Name = "lbTextoPedido";
            this.lbTextoPedido.Size = new System.Drawing.Size(44, 15);
            this.lbTextoPedido.TabIndex = 34;
            this.lbTextoPedido.Text = "Pedido";
            this.lbTextoPedido.Visible = false;
            // 
            // lbPedidoId
            // 
            this.lbPedidoId.AutoSize = true;
            this.lbPedidoId.Location = new System.Drawing.Point(63, 9);
            this.lbPedidoId.Name = "lbPedidoId";
            this.lbPedidoId.Size = new System.Drawing.Size(54, 15);
            this.lbPedidoId.TabIndex = 35;
            this.lbPedidoId.Text = "PedidoId";
            this.lbPedidoId.Visible = false;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.lbPedidoId);
            this.Controls.Add(this.lbTextoPedido);
            this.Controls.Add(this.btEliminarProducto);
            this.Controls.Add(this.btAnyadirProducto);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrarPedido);
            this.Controls.Add(this.btFinalizarPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaEnvio);
            this.Controls.Add(this.dtpFechaRequerida);
            this.Controls.Add(this.lbFechaPedido);
            this.Controls.Add(this.btSeleccionarCliente);
            this.Controls.Add(this.tbCliente);
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbCliente;
        private Button btSeleccionarCliente;
        private Label lbFechaPedido;
        private DateTimePicker dtpFechaRequerida;
        private DateTimePicker dtpFechaEnvio;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFechaPedido;
        private ComboBox cbShipVia;
        private Label label3;
        private Label label4;
        private TextBox tbPeso;
        private Label label5;
        private TextBox tbNombreEnvio;
        private Label label6;
        private TextBox tbDireccion;
        private Label label7;
        private TextBox tbCiudad;
        private Label label8;
        private TextBox tbRegion;
        private Label label9;
        private TextBox tbCodigoPostal;
        private Label label10;
        private TextBox tbPais;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ContextMenuStrip cmsProductos;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiAnyadirProducto;
        private ToolStripMenuItem tsmiEliminarProducto;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox tbTotal;
        private TextBox tbIva;
        private TextBox tbTotalSinIva;
        private Button btFinalizarPedido;
        private Button btBorrarPedido;
        private Button btSalir;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnidad;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descuento;
        private Button btAnyadirProducto;
        private Button btEliminarProducto;
        private Label lbTextoPedido;
        private Label lbPedidoId;
    }
}