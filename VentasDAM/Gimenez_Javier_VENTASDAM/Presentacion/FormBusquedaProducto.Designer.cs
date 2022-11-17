namespace Presentacion
{
    partial class FormBusquedaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarYSalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(129, 16);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(382, 23);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewProductos.Location = new System.Drawing.Point(20, 45);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowTemplate.Height = 25;
            this.dataGridViewProductos.Size = new System.Drawing.Size(752, 459);
            this.dataGridViewProductos.TabIndex = 2;
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick);
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(472, 510);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(147, 37);
            this.btAnyadir.TabIndex = 3;
            this.btAnyadir.Text = "Añadir Producto";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(625, 510);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(147, 37);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar y Salir";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.cancelarYSalirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // cancelarYSalirToolStripMenuItem
            // 
            this.cancelarYSalirToolStripMenuItem.Name = "cancelarYSalirToolStripMenuItem";
            this.cancelarYSalirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cancelarYSalirToolStripMenuItem.Text = "Cancelar y Salir";
            this.cancelarYSalirToolStripMenuItem.Click += new System.EventHandler(this.cancelarYSalirToolStripMenuItem_Click);
            // 
            // FormBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAnyadir);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormBusquedaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusquedaProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaProducto_FormClosing);
            this.Load += new System.EventHandler(this.FormBusquedaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private DataGridView dataGridViewProductos;
        private Button btAnyadir;
        private Button btCancelar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem cancelarYSalirToolStripMenuItem;
    }
}