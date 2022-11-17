namespace Presentacion
{
    partial class FormEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbTituloCortesia = new System.Windows.Forms.ComboBox();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBuscarSupervisor = new System.Windows.Forms.Button();
            this.tbFotoPath = new System.Windows.Forms.TextBox();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.tbEmpleadoSupervisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAnotaciones = new System.Windows.Forms.TextBox();
            this.tbFoto = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbTelefono);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.cbTituloCortesia);
            this.groupBox1.Controls.Add(this.tbExtension);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lbFechaNacimiento);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCodigoPostal);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCiudad);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.BeepOnError = true;
            this.mtbTelefono.Location = new System.Drawing.Point(172, 325);
            this.mtbTelefono.Mask = "000000000999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(90, 23);
            this.mtbTelefono.TabIndex = 27;
            this.mtbTelefono.ValidatingType = typeof(int);
            this.mtbTelefono.MaskChanged += new System.EventHandler(this.EstablecerFocoInicial);
            this.mtbTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ValidarInputRejectedTelefono);
            this.mtbTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidarTelefonoKeyUp);
            this.mtbTelefono.Leave += new System.EventHandler(this.ValidarTelefono);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(172, 61);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 23);
            this.tbNombre.TabIndex = 26;
            this.tbNombre.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(172, 292);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNacimiento.TabIndex = 25;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.CambiarFormatoFecha);
            // 
            // cbTituloCortesia
            // 
            this.cbTituloCortesia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTituloCortesia.FormattingEnabled = true;
            this.cbTituloCortesia.Items.AddRange(new object[] {
            "Ms.",
            "Dr.",
            "Mrs.",
            "Mr."});
            this.cbTituloCortesia.Location = new System.Drawing.Point(172, 28);
            this.cbTituloCortesia.Name = "cbTituloCortesia";
            this.cbTituloCortesia.Size = new System.Drawing.Size(121, 23);
            this.cbTituloCortesia.TabIndex = 24;
            this.cbTituloCortesia.SelectedIndexChanged += new System.EventHandler(this.ValidarTituloCortesia);
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(172, 358);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(90, 23);
            this.tbExtension.TabIndex = 23;
            this.tbExtension.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 361);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "Extensión";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 328);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 15);
            this.label19.TabIndex = 20;
            this.label19.Text = "Teléfono";
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(29, 295);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lbFechaNacimiento.TabIndex = 18;
            this.lbFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(172, 259);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(200, 23);
            this.tbPais.TabIndex = 15;
            this.tbPais.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "País";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(172, 226);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(90, 23);
            this.tbCodigoPostal.TabIndex = 13;
            this.tbCodigoPostal.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(172, 193);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(200, 23);
            this.tbRegion.TabIndex = 12;
            this.tbRegion.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(172, 160);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(200, 23);
            this.tbCiudad.TabIndex = 11;
            this.tbCiudad.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(172, 127);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(366, 23);
            this.tbDireccion.TabIndex = 10;
            this.tbDireccion.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(172, 94);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 23);
            this.tbApellido.TabIndex = 9;
            this.tbApellido.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Región";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título de cortesía";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBuscarSupervisor);
            this.groupBox2.Controls.Add(this.tbFotoPath);
            this.groupBox2.Controls.Add(this.dtpFechaContratacion);
            this.groupBox2.Controls.Add(this.tbEmpleadoSupervisor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbAnotaciones);
            this.groupBox2.Controls.Add(this.tbFoto);
            this.groupBox2.Controls.Add(this.tbTitulo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(647, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos profesionales";
            // 
            // btBuscarSupervisor
            // 
            this.btBuscarSupervisor.Location = new System.Drawing.Point(279, 287);
            this.btBuscarSupervisor.Name = "btBuscarSupervisor";
            this.btBuscarSupervisor.Size = new System.Drawing.Size(52, 23);
            this.btBuscarSupervisor.TabIndex = 22;
            this.btBuscarSupervisor.Text = "Buscar";
            this.btBuscarSupervisor.UseVisualStyleBackColor = true;
            this.btBuscarSupervisor.Click += new System.EventHandler(this.btBuscarSupervisor_Click);
            // 
            // tbFotoPath
            // 
            this.tbFotoPath.Location = new System.Drawing.Point(172, 95);
            this.tbFotoPath.Name = "tbFotoPath";
            this.tbFotoPath.Size = new System.Drawing.Size(366, 23);
            this.tbFotoPath.TabIndex = 21;
            this.tbFotoPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidarPhotoPath);
            this.tbFotoPath.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(172, 63);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaContratacion.TabIndex = 20;
            this.dtpFechaContratacion.ValueChanged += new System.EventHandler(this.CambiarFormatoFecha);
            // 
            // tbEmpleadoSupervisor
            // 
            this.tbEmpleadoSupervisor.Location = new System.Drawing.Point(172, 286);
            this.tbEmpleadoSupervisor.Name = "tbEmpleadoSupervisor";
            this.tbEmpleadoSupervisor.ReadOnly = true;
            this.tbEmpleadoSupervisor.Size = new System.Drawing.Size(90, 23);
            this.tbEmpleadoSupervisor.TabIndex = 19;
            this.tbEmpleadoSupervisor.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Empleado supervisor";
            // 
            // tbAnotaciones
            // 
            this.tbAnotaciones.Location = new System.Drawing.Point(172, 159);
            this.tbAnotaciones.Multiline = true;
            this.tbAnotaciones.Name = "tbAnotaciones";
            this.tbAnotaciones.Size = new System.Drawing.Size(366, 118);
            this.tbAnotaciones.TabIndex = 11;
            this.tbAnotaciones.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbFoto
            // 
            this.tbFoto.Location = new System.Drawing.Point(172, 127);
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.Size = new System.Drawing.Size(366, 23);
            this.tbFoto.TabIndex = 10;
            this.tbFoto.Click += new System.EventHandler(this.AbrirBusquedaFichero);
            this.tbFoto.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(172, 31);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(200, 23);
            this.tbTitulo.TabIndex = 7;
            this.tbTitulo.Leave += new System.EventHandler(this.ValidarCampo);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Anotaciones";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Foto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Foto path";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Fecha de contratacion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Título";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1095, 468);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(107, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(982, 468);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(107, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(63, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Los datos marcados con asterisco son obligatorios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleados";
            this.Activated += new System.EventHandler(this.EstablecerFocoInicial);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbCodigoPostal;
        private TextBox tbRegion;
        private TextBox tbCiudad;
        private TextBox tbDireccion;
        private TextBox tbApellido;
        private Label label7;
        private Label lbFechaNacimiento;
        private TextBox tbPais;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox tbEmpleadoSupervisor;
        private Label label9;
        private TextBox tbAnotaciones;
        private TextBox tbFoto;
        private TextBox tbTitulo;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbTituloCortesia;
        private TextBox tbExtension;
        private Label label20;
        private Label label19;
        private DateTimePicker dtpFechaContratacion;
        private OpenFileDialog openFileDialog1;
        private TextBox tbNombre;
        private TextBox tbFotoPath;
        private Button btCancelar;
        private Button btAceptar;
        private Label label11;
        private ErrorProvider errorProvider1;
        private MaskedTextBox mtbTelefono;
        private Button btBuscarSupervisor;
    }
}