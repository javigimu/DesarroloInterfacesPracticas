namespace Presentacion
{
    partial class FormValidarUsuario
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
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btValidarEmpleado = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Location = new System.Drawing.Point(229, 39);
            this.tbIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(183, 23);
            this.tbIdEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce tu id de empleado";
            // 
            // btValidarEmpleado
            // 
            this.btValidarEmpleado.Location = new System.Drawing.Point(176, 100);
            this.btValidarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValidarEmpleado.Name = "btValidarEmpleado";
            this.btValidarEmpleado.Size = new System.Drawing.Size(82, 22);
            this.btValidarEmpleado.TabIndex = 2;
            this.btValidarEmpleado.Text = "Acceder";
            this.btValidarEmpleado.UseVisualStyleBackColor = true;
            this.btValidarEmpleado.Click += new System.EventHandler(this.btValidarEmpleado_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // FormValidarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.btValidarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "FormValidarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormValidarUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidarUsuario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbIdEmpleado;
        private Label label1;
        private Button btValidarEmpleado;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}