namespace Presentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedidoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedidoModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoEmpleado = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoPedido = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimirFactura = new System.Windows.Forms.ToolStripButton();
            this.lbNombreEmpleado = new System.Windows.Forms.Label();
            this.pbFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.LanzarFormEmpleadosInsertar);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.LanzarFormEmpleadosModificar);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPrecioToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // modificarPrecioToolStripMenuItem
            // 
            this.modificarPrecioToolStripMenuItem.Name = "modificarPrecioToolStripMenuItem";
            this.modificarPrecioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modificarPrecioToolStripMenuItem.Text = "Modificar Precio";
            this.modificarPrecioToolStripMenuItem.Click += new System.EventHandler(this.modificarPrecioToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPedidoNuevo,
            this.tsmPedidoModificar});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // tsmPedidoNuevo
            // 
            this.tsmPedidoNuevo.Name = "tsmPedidoNuevo";
            this.tsmPedidoNuevo.Size = new System.Drawing.Size(125, 22);
            this.tsmPedidoNuevo.Text = "Nuevo";
            this.tsmPedidoNuevo.Click += new System.EventHandler(this.tsmPedidoNuevo_Click);
            // 
            // tsmPedidoModificar
            // 
            this.tsmPedidoModificar.Name = "tsmPedidoModificar";
            this.tsmPedidoModificar.Size = new System.Drawing.Size(125, 22);
            this.tsmPedidoModificar.Text = "Modificar";
            this.tsmPedidoModificar.Click += new System.EventHandler(this.tsmPedidoModificar_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalPedidosToolStripMenuItem,
            this.productosPorCategoríaToolStripMenuItem});
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // totalPedidosToolStripMenuItem
            // 
            this.totalPedidosToolStripMenuItem.Name = "totalPedidosToolStripMenuItem";
            this.totalPedidosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.totalPedidosToolStripMenuItem.Text = "Total Pedidos por cliente";
            this.totalPedidosToolStripMenuItem.Click += new System.EventHandler(this.totalPedidosToolStripMenuItem_Click);
            // 
            // productosPorCategoríaToolStripMenuItem
            // 
            this.productosPorCategoríaToolStripMenuItem.Name = "productosPorCategoríaToolStripMenuItem";
            this.productosPorCategoríaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosPorCategoríaToolStripMenuItem.Text = "Productos por categoría";
            this.productosPorCategoríaToolStripMenuItem.Click += new System.EventHandler(this.productosPorCategoríaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.74751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNombreEmpleado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbFotoEmpleado, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.684976F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.31503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 840);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 3);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoEmpleado,
            this.tsbNuevoPedido,
            this.tsbImprimirFactura});
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevoEmpleado
            // 
            this.tsbNuevoEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoEmpleado.Image")));
            this.tsbNuevoEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoEmpleado.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbNuevoEmpleado.Name = "tsbNuevoEmpleado";
            this.tsbNuevoEmpleado.Size = new System.Drawing.Size(24, 24);
            this.tsbNuevoEmpleado.Text = "toolStripButton1";
            this.tsbNuevoEmpleado.ToolTipText = "Insertar Empleado";
            this.tsbNuevoEmpleado.Click += new System.EventHandler(this.LanzarFormEmpleadosInsertar);
            // 
            // tsbNuevoPedido
            // 
            this.tsbNuevoPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoPedido.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoPedido.Image")));
            this.tsbNuevoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoPedido.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbNuevoPedido.Name = "tsbNuevoPedido";
            this.tsbNuevoPedido.Size = new System.Drawing.Size(24, 24);
            this.tsbNuevoPedido.Text = "toolStripButton2";
            this.tsbNuevoPedido.ToolTipText = "Nuevo Pedido";
            this.tsbNuevoPedido.Click += new System.EventHandler(this.tsbNuevoPedido_Click);
            // 
            // tsbImprimirFactura
            // 
            this.tsbImprimirFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimirFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimirFactura.Image")));
            this.tsbImprimirFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimirFactura.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbImprimirFactura.Name = "tsbImprimirFactura";
            this.tsbImprimirFactura.Size = new System.Drawing.Size(24, 24);
            this.tsbImprimirFactura.Text = "toolStripButton3";
            this.tsbImprimirFactura.ToolTipText = "Imprimir Factura";
            this.tsbImprimirFactura.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // lbNombreEmpleado
            // 
            this.lbNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombreEmpleado.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbNombreEmpleado, 2);
            this.lbNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombreEmpleado.Location = new System.Drawing.Point(1089, 0);
            this.lbNombreEmpleado.Name = "lbNombreEmpleado";
            this.lbNombreEmpleado.Size = new System.Drawing.Size(123, 19);
            this.lbNombreEmpleado.TabIndex = 5;
            this.lbNombreEmpleado.Text = "Nombre empleado";
            // 
            // pbFotoEmpleado
            // 
            this.pbFotoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotoEmpleado.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFotoEmpleado.ErrorImage")));
            this.pbFotoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoEmpleado.Image")));
            this.pbFotoEmpleado.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFotoEmpleado.InitialImage")));
            this.pbFotoEmpleado.Location = new System.Drawing.Point(1225, 0);
            this.pbFotoEmpleado.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pbFotoEmpleado.Name = "pbFotoEmpleado";
            this.pbFotoEmpleado.Size = new System.Drawing.Size(36, 36);
            this.pbFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoEmpleado.TabIndex = 6;
            this.pbFotoEmpleado.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasDam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmarCierreAplicacion);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem modificarPrecioToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem tsmPedidoNuevo;
        private ToolStripMenuItem tsmPedidoModificar;
        private ToolStripMenuItem estadísticasToolStripMenuItem;
        private ToolStripMenuItem totalPedidosToolStripMenuItem;
        private ToolStripMenuItem productosPorCategoríaToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbNombreEmpleado;
        private PictureBox pbFotoEmpleado;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevoEmpleado;
        private ToolStripButton tsbNuevoPedido;
        private ToolStripButton tsbImprimirFactura;
    }
}