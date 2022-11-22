namespace Presentacion
{
    partial class FormBusquedaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewBuscar = new System.Windows.Forms.DataGridView();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por Nombre Cliente / Nombre Empresa";
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.Location = new System.Drawing.Point(293, 17);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(453, 23);
            this.tbBuscarCliente.TabIndex = 1;
            this.tbBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FiltrarClientes);
            // 
            // dataGridViewBuscar
            // 
            this.dataGridViewBuscar.AllowUserToAddRows = false;
            this.dataGridViewBuscar.AllowUserToDeleteRows = false;
            this.dataGridViewBuscar.Location = new System.Drawing.Point(39, 51);
            this.dataGridViewBuscar.Name = "dataGridViewBuscar";
            this.dataGridViewBuscar.RowHeadersWidth = 21;
            this.dataGridViewBuscar.RowTemplate.Height = 25;
            this.dataGridViewBuscar.Size = new System.Drawing.Size(707, 462);
            this.dataGridViewBuscar.TabIndex = 2;
            this.dataGridViewBuscar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfirmarSeleccion);
            this.dataGridViewBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfirmarSeleccion);
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(526, 526);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(102, 23);
            this.btSeleccionar.TabIndex = 3;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(644, 526);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(102, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.dataGridViewBuscar);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormBusquedaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusquedaCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MostrarFormPadre);
            this.Load += new System.EventHandler(this.CrearColumnas);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbBuscarCliente;
        private DataGridView dataGridViewBuscar;
        private Button btSeleccionar;
        private Button btCancelar;
    }
}