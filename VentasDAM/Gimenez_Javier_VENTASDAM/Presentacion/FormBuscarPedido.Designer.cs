namespace Presentacion
{
    partial class FormBuscarPedido
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
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.dtpFechaBusqueda = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(299, 21);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(131, 23);
            this.btBuscarCliente.TabIndex = 0;
            this.btBuscarCliente.Text = "Buscar por Cliente";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // dtpFechaBusqueda
            // 
            this.dtpFechaBusqueda.Location = new System.Drawing.Point(763, 22);
            this.dtpFechaBusqueda.Name = "dtpFechaBusqueda";
            this.dtpFechaBusqueda.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaBusqueda.TabIndex = 2;
            this.dtpFechaBusqueda.ValueChanged += new System.EventHandler(this.dtpFechaBusqueda_ValueChanged);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(1240, 713);
            this.dataGridViewPedidos.TabIndex = 3;
            this.dataGridViewPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellDoubleClick);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(933, 796);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(155, 44);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1094, 796);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(155, 44);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar Filtrado";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(451, 24);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(150, 19);
            this.cbCliente.TabIndex = 6;
            this.cbCliente.Text = "Mostrar pedidos cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            this.cbCliente.CheckStateChanged += new System.EventHandler(this.cbCliente_CheckStateChanged);
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Location = new System.Drawing.Point(654, 23);
            this.cbFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(87, 19);
            this.cbFecha.TabIndex = 7;
            this.cbFecha.Text = "FiltrarFecha";
            this.cbFecha.UseVisualStyleBackColor = true;
            this.cbFecha.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // FormBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 791);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.dtpFechaBusqueda);
            this.Controls.Add(this.btBuscarCliente);
            this.MaximumSize = new System.Drawing.Size(1280, 898);
            this.MinimumSize = new System.Drawing.Size(1280, 773);
            this.Name = "FormBuscarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarPedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscarPedido_FormClosing);
            this.Load += new System.EventHandler(this.FormBuscarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btBuscarCliente;
        private DateTimePicker dtpFechaBusqueda;
        private DataGridView dataGridViewPedidos;
        private Button btAceptar;
        private Button btCancelar;
        private CheckBox cbCliente;
        private CheckBox cbFecha;
    }
}