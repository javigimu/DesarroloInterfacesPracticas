namespace Presentacion
{
    partial class FormBusqueda
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
            this.tbTextoBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewBuscar = new System.Windows.Forms.DataGridView();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto de búsqueda";
            // 
            // tbTextoBuscar
            // 
            this.tbTextoBuscar.Location = new System.Drawing.Point(145, 39);
            this.tbTextoBuscar.Name = "tbTextoBuscar";
            this.tbTextoBuscar.Size = new System.Drawing.Size(331, 23);
            this.tbTextoBuscar.TabIndex = 1;
            this.tbTextoBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FiltrarEmpleados);
            // 
            // dataGridViewBuscar
            // 
            this.dataGridViewBuscar.AllowUserToAddRows = false;
            this.dataGridViewBuscar.AllowUserToDeleteRows = false;
            this.dataGridViewBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscar.Location = new System.Drawing.Point(10, 74);
            this.dataGridViewBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBuscar.Name = "dataGridViewBuscar";
            this.dataGridViewBuscar.RowHeadersWidth = 51;
            this.dataGridViewBuscar.RowTemplate.Height = 29;
            this.dataGridViewBuscar.Size = new System.Drawing.Size(1241, 776);
            this.dataGridViewBuscar.TabIndex = 2;
            this.dataGridViewBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfirmarSeleccion);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(145, 14);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(123, 19);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre y apellido";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.CambiarFiltrado);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(274, 14);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(107, 19);
            this.rbId.TabIndex = 6;
            this.rbId.Text = "Id de empleado";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar filtrado";
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbId);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.dataGridViewBuscar);
            this.Controls.Add(this.tbTextoBuscar);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FormBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MostrarFormPadre);
            this.Load += new System.EventHandler(this.CrearColumnas);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbTextoBuscar;
        private DataGridView dataGridViewBuscar;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private Label label2;
    }
}