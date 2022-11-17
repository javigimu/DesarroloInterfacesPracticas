using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Gimenez</autor>
    /// </summary>
    public partial class FormEmpleados : Form
    {
        FormBusqueda? formBuscarEmpleado;
        Employee? empleadoModificado;

        bool primeraActivacionForm;
        char opcionInsertarOModificar;
        bool tituloCortesiaValidado;
        bool nombreValidado;
        bool apellidoValidado;
        bool direccionValidada;
        bool ciudadValidada;
        bool regionValidada;
        bool codigoPostalValidado;
        bool paisValidado;
        bool telefonoValidado;
        bool extensionValidada;
        bool tituloValidado;
        bool fotoPathValidado;
        bool fotoValidada;
        bool anotacionesValidado;
        bool fechaNacimientoValidada;
        bool fechaContratacionValidada;

        bool nombreMarcado;
        bool apellidoMarcado;
        bool fechaNacimientoSeleccionada;
        bool fechaContratacionSeleccionada;

        byte[]? fotoNuevoEmpleado;

        public FormEmpleados()
        {
            InitializeComponent();
        }

        public FormEmpleados(char opcion) : this()
        {
            opcionInsertarOModificar = opcion;
            InicializarBooleanos();
        }

        private void InicializarBooleanos()
        {
            primeraActivacionForm = true;
            tituloCortesiaValidado = true;
            nombreValidado = false;
            apellidoValidado = false;
            direccionValidada = true;
            ciudadValidada = true;
            regionValidada = true;
            codigoPostalValidado = true;
            paisValidado = true;
            telefonoValidado = true;
            extensionValidada = true;
            tituloValidado = true;
            fotoPathValidado = true;
            fotoValidada = true;
            anotacionesValidado = true;
            fechaNacimientoValidada = true;
            fechaContratacionValidada = true;

            nombreMarcado = false;
            apellidoMarcado = false;
            fechaNacimientoSeleccionada = false;
            fechaContratacionSeleccionada = false;

            fotoNuevoEmpleado = null;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarFormatoFechasInicial();
            if (opcionInsertarOModificar == 'i')
                btAceptar.Text = "Insertar";
            else if (opcionInsertarOModificar == 'm')
            {
                btAceptar.Text = "Modificar";
                MostrarFormBuscarEmpleado();
                empleadoModificado = formBuscarEmpleado?.GetEmpleado();
                if (empleadoModificado != null)
                    RellenarCampos(empleadoModificado);
            }
        }

        private void btBuscarSupervisor_Click(object sender, EventArgs e)
        {
            MostrarFormBuscarEmpleado();
            Employee? emp = formBuscarEmpleado?.GetEmpleado();
            if (emp != null)
            {
                tbEmpleadoSupervisor.Text = emp.EmployeeId.ToString();
            }            
        }

        private void RellenarCampos(Employee emp)
        {
            nombreValidado = true;
            apellidoValidado = true;
            tbNombre.Text = emp.FirstName;
            tbApellido.Text = emp.LastName;
            tbTitulo.Text = emp.Title;
            cbTituloCortesia.SelectedItem = emp.TitleOfCourtesy;
            ConfigurarFormatoFechasInicial();
            if (emp.BirthDate != null)
                dtpFechaNacimiento.Value = (DateTime)emp.BirthDate;
            if (emp.HireDate != null)
                dtpFechaContratacion.Value = (DateTime)emp.HireDate;
            tbDireccion.Text = emp.Address;
            tbCiudad.Text = emp.City;
            tbRegion.Text = emp.Region;
            tbCodigoPostal.Text = emp.PostalCode;
            tbPais.Text = emp.Country;
            mtbTelefono.Text = emp.HomePhone;
            tbExtension.Text = emp.Extension;
        
            
            if (emp.Photo != null)
            {
                string nombreFichero = "fotos/empleado" + emp.EmployeeId + ".jpg";
                File.WriteAllBytes(nombreFichero, emp.Photo);
                tbFoto.Text = nombreFichero;
            }

            tbAnotaciones.Text = emp.Notes;
            tbEmpleadoSupervisor.Text = emp.ReportsTo.ToString();
            tbFotoPath.Text = emp.PhotoPath;
        }

        // Configura el formato inicial de las fechas para permitir que el usuario no seleccione ninguna fecha
        private void ConfigurarFormatoFechasInicial()
        {
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = " ";
            dtpFechaContratacion.Format = DateTimePickerFormat.Custom;
            dtpFechaContratacion.CustomFormat = " ";     
        }

        // cambia el formato de la fecha una vez que el usuario seleccione una
        private void CambiarFormatoFecha(object sender, EventArgs e)
        {
            string dtpName = ((DateTimePicker)sender).Name;
            if (dtpName == "dtpFechaNacimiento")
            {
                dtpFechaNacimiento.CustomFormat = "yyyy/MM/dd";
                ValidarFechaNacimiento();
            }
            else if (dtpName == "dtpFechaContratacion")
            { 
                dtpFechaContratacion.CustomFormat = "yyyy/MM/dd";
                ValidarFechaContratacion();
            }            
        }             

        private void AbrirBusquedaFichero(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecciona una imagen para el empleado";
            openFileDialog1.Filter = "Imagenes (*.jpg; *.jpeg; *.png; *.tif; *.gif)|*.jpg;*.jpeg;*.png;*.tif;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                File.Exists(openFileDialog1.FileName))
            {
                tbFoto.Text = openFileDialog1.FileName;
            }
        }

        private void MostrarFormPrincipal()
        {
            Owner.Show();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            MostrarFormPrincipal();
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (ValidacionesOk())
            {
                string nombre = tbNombre.Text;
                string apellido = tbApellido.Text;
                string? titulo = tbTitulo.Text == "" ? null : tbTitulo.Text;
                string? tituloCortesia = null;
                if (cbTituloCortesia.SelectedIndex >= 0)
                    tituloCortesia = cbTituloCortesia.SelectedItem.ToString();
                DateTime? fechaNacimiento = null;
                if (fechaNacimientoSeleccionada)
                    fechaNacimiento = dtpFechaNacimiento.Value;
                DateTime? fechaContratacion = null;
                if (fechaContratacionSeleccionada)
                    fechaContratacion = dtpFechaContratacion.Value;
                string? direccion = tbDireccion.Text == "" ? null : tbDireccion.Text;
                string? ciudad = tbCiudad.Text == "" ? null : tbCiudad.Text;
                string? region = tbRegion.Text == "" ? null : tbRegion.Text;
                string? codigoPostal = tbCodigoPostal.Text == "" ? null : tbCodigoPostal.Text;
                string? pais = tbPais.Text == "" ? null : tbPais.Text;
                string? telefono = mtbTelefono.Text == "" ? null : mtbTelefono.Text;
                string? extension = tbExtension.Text == "" ? null : tbExtension.Text;
                byte[]? foto = null;
                if (tbFoto.Text != "")
                    foto = File.ReadAllBytes(tbFoto.Text);
                string? anotaciones = tbAnotaciones.Text == "" ? null : tbAnotaciones.Text;
                string? fotoPath = tbFotoPath.Text == "" ? null : tbFotoPath.Text;
                string? empleadoSupervisor = tbEmpleadoSupervisor.Text == "" ? "-1" : tbEmpleadoSupervisor.Text;

                Employee empleado = new Employee(0, nombre, apellido, titulo, tituloCortesia,
                    fechaNacimiento, fechaContratacion, direccion, ciudad, region, codigoPostal,
                    pais, telefono, extension, foto, anotaciones, fotoPath, Convert.ToInt32(empleadoSupervisor));


                using (Gestion gestion = new Gestion())
                {
                    try
                    {
                        if (opcionInsertarOModificar == 'i')
                        {
                            gestion.InsertarEmployee(empleado);
                            Mensaje.MostrarProcesoFinalizadoCorrectamente("empleado", "inserción");
                        }
                        else if (opcionInsertarOModificar == 'm')
                        {
                            if (empleadoModificado != null)
                                empleado.EmployeeId = empleadoModificado.EmployeeId;
                            gestion.ActualizarEmployee(empleado);
                            Mensaje.MostrarProcesoFinalizadoCorrectamente("empleado", "modificación");
                        }                       
                    }
                    catch (ArgumentException ae)
                    {
                        Mensaje.MostrarExcepcion(ae);
                    }                    
                }
                VaciarCampos();   
            }
            else
            {
                if (!nombreValidado && !nombreMarcado)
                    MarcarError(tbNombre, "Debes introducir el nombre");
                if (!apellidoValidado && !apellidoMarcado)
                    MarcarError(tbApellido, "Debes introduir el apellido");

                Mensaje.MostrarErrorDeValidacion("Error de validación, revise los campos en rojo");
            }
        }

        private bool ValidacionesOk()
        {
            return tituloCortesiaValidado && nombreValidado && apellidoValidado && direccionValidada &&
                ciudadValidada && regionValidada && codigoPostalValidado && paisValidado &&
                telefonoValidado && extensionValidada && tituloValidado && fotoPathValidado &&
                fotoValidada && anotacionesValidado && fechaNacimientoValidada && fechaContratacionValidada;
        }

        private void MostrarFormBuscarEmpleado()
        {
            formBuscarEmpleado = new FormBusqueda(false);
            formBuscarEmpleado.Owner = this;
            this.Hide();
            formBuscarEmpleado.ShowDialog();
        }

        private void FormEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            MostrarFormPrincipal();
        }

        #region "validaciones"

        private void ValidarTituloCortesia(object sender, EventArgs e)
        {
            tituloCortesiaValidado = MarcarCampoOk(cbTituloCortesia);
        }

        /// <summary>
        /// Validación de un campo textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidarCampo(object sender, EventArgs e)
        {
            // compruebo si se acaba de activar el formulario para que no marque casillas en rojo sin intervención del usuario
            if (primeraActivacionForm)
            {
                primeraActivacionForm = false;
            }
            else
            {
                string error = "";
                int resultado = 0;

                // Validación de los campos TextBox
                TextBox? tbSender = sender as TextBox;
                switch (tbSender?.Name)
                {
                    case "tbNombre":                    
                        resultado = Validaciones.ValidarCadena(tbNombre.Text, 10, false);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Nombre no permite más de 10 carácteres" + Environment.NewLine;
                                    break;
                                case 2:
                                    error = "El campo Nombre no puede estar vacío" + Environment.NewLine;
                                    break;
                            }
                            nombreValidado = MarcarError(tbNombre, error);
                        }
                        else
                        {
                            nombreValidado = MarcarCampoOk(tbNombre);
                        }

                        nombreMarcado = true;
                        break;                    

                    case "tbApellido":                    
                        resultado = Validaciones.ValidarCadena(tbApellido.Text, 20, false);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Apellido no permite más de 20 carácteres" + Environment.NewLine;
                                    break;
                                case 2:
                                    error = "El campo Apellido no puede estar vacío" + Environment.NewLine;
                                    break;
                            }
                            apellidoValidado = MarcarError(tbApellido, error);
                        }
                        else
                        {
                            apellidoValidado = MarcarCampoOk(tbApellido);
                        }

                        apellidoMarcado = true;
                        break;                    
                
                    case "tbDireccion":                    
                        resultado = Validaciones.ValidarCadena(tbDireccion.Text, 60, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Dirección no permite más de 60 carácteres" + Environment.NewLine;
                                    break;
                            }
                            direccionValidada = MarcarError(tbDireccion, error);
                        }
                        else
                        {
                            direccionValidada = MarcarCampoOk(tbDireccion);                            
                        }

                        break;                    

                    case "tbCiudad":                    
                        resultado = Validaciones.ValidarCadena(tbCiudad.Text, 15, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Ciudad no permite más de 15 carácteres" + Environment.NewLine;
                                    break;
                            }
                            ciudadValidada = MarcarError(tbCiudad, error);
                        }
                        else
                        {
                            ciudadValidada = MarcarCampoOk(tbCiudad);                           
                        }

                        break;                    

                    case "tbRegion":                    
                        resultado = Validaciones.ValidarCadena(tbRegion.Text, 15, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Region no permite más de 15 carácteres" + Environment.NewLine;
                                    break;
                            }
                            regionValidada = MarcarError(tbRegion, error);
                        }
                        else
                        {
                            regionValidada = MarcarCampoOk(tbRegion);                           
                        }

                        break;                    

                    case "tbCodigoPostal":                    
                        resultado = Validaciones.ValidarCadena(tbCodigoPostal.Text, 10, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Codigo Postal no permite más de 10 carácteres" + Environment.NewLine;
                                    break;
                            }
                            codigoPostalValidado = MarcarError(tbCodigoPostal, error);
                        }
                        else
                        {
                            codigoPostalValidado = MarcarCampoOk(tbCodigoPostal);                            
                        }

                        break;                    

                    case "tbPais":                    
                        resultado = Validaciones.ValidarCadena(tbPais.Text, 15, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Pais no permite más de 15 carácteres" + Environment.NewLine;
                                    break;
                            }
                            paisValidado = MarcarError(tbPais, error);
                        }
                        else
                        {
                            paisValidado = MarcarCampoOk(tbPais);                           
                        }

                        break;                                          

                    case "tbExtension":                    
                        resultado = Validaciones.ValidarCadena(tbExtension.Text, 4, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Extension no permite más de 4 carácteres" + Environment.NewLine;
                                    break;
                            }
                            extensionValidada = MarcarError(tbExtension, error);
                        }
                        else
                            extensionValidada = MarcarCampoOk(tbExtension);

                        break;

                    case "tbTitulo":
                        resultado = Validaciones.ValidarCadena(tbTitulo.Text, 30, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Título no permite más de 30 carácteres" + Environment.NewLine;
                                    break;
                            }
                            tituloValidado = MarcarError(tbTitulo, error);
                        }
                        else
                            tituloValidado = MarcarCampoOk(tbTitulo);

                        break;

                    case "tbFotoPath": 
                        resultado = Validaciones.ValidarURL(tbFotoPath.Text, 255, true);
                        if (resultado > 0)
                        {
                            switch (resultado)
                            {
                                case 1:
                                    error = "El campo Foto Path no permite más de 255 carácteres" + Environment.NewLine;
                                    break;
                                case 2:
                                    error = "El campo Foto Path no puede estar vacío" + Environment.NewLine;
                                    break;
                                case 3:
                                    error = "La URL del campo Foto Path no está bien formada" + Environment.NewLine;
                                    break;
                            }
                            fotoPathValidado = MarcarError(tbFotoPath, error);
                        }
                        else
                            fotoPathValidado = MarcarCampoOk(tbFotoPath);

                        break;

                    case "tbFoto":
                        if (tbFoto.Text.Length > 0)
                        {
                                  fotoNuevoEmpleado = File.ReadAllBytes(tbFoto.Text);
                        }
                        fotoValidada = MarcarCampoOk(tbFoto);

                        break;

                    case "tbAnotaciones":                                              
                        anotacionesValidado = MarcarCampoOk(tbAnotaciones);

                        break;

                    case "tbEmpleadoSupervisor":                       

                        break;
                }
            }
        }

        /// <summary>
        /// método para validar que el teléfono tenga un mínimo de 9 caracteres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidarTelefono(object sender, EventArgs e)
        {
            int resultado = Validaciones.ValidarTelefono(mtbTelefono.Text, 9);
            string error = "";

            if (resultado > 0)
            {
                switch (resultado)
                {
                    case 1:
                        error = "El campo Teléfono debe tener al menos 9 caracteres" + Environment.NewLine;
                        break;
                }
                telefonoValidado = MarcarError(mtbTelefono, error);
            }
            else
                telefonoValidado = MarcarCampoOk(mtbTelefono);
        }

        private void ValidarPhotoPath(object sender, KeyEventArgs e)
        {
            ValidarCampo(sender, e);
        }

        private void ValidarTelefonoKeyUp(object sender, KeyEventArgs e)
        {
            ValidarTelefono(sender, e);
        }

        /// <summary>
        /// Valida el telefono tomando sus input rejected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidarInputRejectedTelefono(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbTelefono.MaskFull)
            {
                telefonoValidado = MarcarCampoOk(mtbTelefono);
            }
            else if (mtbTelefono.TextLength >= 9)
            {
                telefonoValidado = MarcarCampoOk(mtbTelefono);
            }           
        }

        /// <summary>
        /// Validar que la fecha de nacimiento sea anterior a la fecha actual
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private void ValidarFechaNacimiento()
        {
            fechaNacimientoSeleccionada = true;
            string error = "";
            int resultado = Validaciones.ValidarFechaNacimiento(dtpFechaNacimiento);

            if (resultado > 0)
            {
                switch (resultado)
                {
                    case 1:
                        error = "El campo Fecha Nacimiento debe ser inferior a la fecha actual" + Environment.NewLine;
                        break;
                }
                fechaNacimientoValidada = MarcarError(dtpFechaNacimiento, error);
            }
            else
            {
                fechaNacimientoValidada = MarcarCampoOk(dtpFechaNacimiento);
            }
            dtpFechaNacimiento.Focus();
        }

        /// <summary>
        /// Marca la validacion correcta de la fecha de contratación, ya que no tiene filtros
        /// </summary>
        private void ValidarFechaContratacion()
        {
            fechaContratacionSeleccionada = true;
            fechaContratacionValidada = MarcarCampoOk(dtpFechaContratacion);
            dtpFechaContratacion.Focus();
        }

        /// <summary>
        /// Marca la casilla en rojo y muestra un tip con la información del error
        /// </summary>
        /// <param name="tb">textbox validado</param>
        /// <param name="error">texto informativo del error</param>
        /// <returns>false para indicar que el campo no está validado correctamente</returns>
        private bool MarcarError(TextBox tb, string error)
        {
            ToolTip TTIP = new ToolTip();
            tb.BackColor = Color.LightCoral;
            TTIP.SetToolTip(tb, error);
            errorProvider1.SetError(tb, error);
            return false;
        }

        /// <summary>
        /// Marca error en un masked text box
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private bool MarcarError(MaskedTextBox tb, string error)
        {
            ToolTip TTIP = new ToolTip();
            tb.BackColor = Color.LightCoral;
            TTIP.SetToolTip(tb, error);
            errorProvider1.SetError(tb, error);
            return false;
        }

        /// <summary>
        /// Marca error en un campo DateTimePicker
        /// </summary>
        /// <param name="dtp"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private bool MarcarError(DateTimePicker dtp, string error)
        {
            ToolTip TTIP = new ToolTip();
            dtp.BackColor = Color.LightCoral;
            TTIP.SetToolTip(dtp, error);
            errorProvider1.SetError(dtp, error);
            dtp.ShowCheckBox = false;
            return false;
        }

        private bool MarcarCampoOk(System.Windows.Forms.ComboBox cb)
        {
            cb.BackColor = Color.LightGreen;
            return true;
        }

        private void DesmarcarCampo(Control ctr)
        {
            ctr.BackColor = Color.White;
            errorProvider1.SetError(ctr, "");
        }


        /// <summary>
        /// Marca la casilla en verde para visualizar que la validación es correcta
        /// </summary>
        /// <param name="tb">textbox validado</param>
        /// <returns>true para indicar que el campo está validado correctamente</returns>
        private bool MarcarCampoOk(TextBox tb)
        {
            ToolTip TTIP = new ToolTip();
            tb.BackColor = Color.LightGreen;
            TTIP.SetToolTip(tb, "");
            errorProvider1.SetError(tb, "");
            return true;
        }

        /// <summary>
        /// Marca la casilla en verde en un masked text box
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        private bool MarcarCampoOk(MaskedTextBox tb)
        {
            ToolTip TTIP = new ToolTip();
            tb.BackColor = Color.LightGreen;
            TTIP.SetToolTip(tb, "");
            errorProvider1.SetError(tb, "");
            return true;
        }

        /// <summary>
        /// Marca la casilla en verde en un DateTimePicker
        /// </summary>
        /// <param name="dtp"></param>
        /// <returns></returns>
        private bool MarcarCampoOk(DateTimePicker dtp)
        {
            ToolTip TTIP = new ToolTip();
            TTIP.SetToolTip(dtp, "");            
            errorProvider1.SetError(dtp, "");
            dtp.ShowCheckBox = true;
            return true;
        }
        #endregion

        /// <summary>
        /// función para establecer inicialmente el foco en un campo, en este caso el textbox Nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EstablecerFocoInicial(object sender, EventArgs e)
        {
            tbNombre.Focus();
        }

        /// <summary>
        /// resetea todos los datos de los campos al origen
        /// </summary>
        private void VaciarCampos()
        {
            tbNombre.Text = "";            
            tbApellido.Text = "";
            tbTitulo.Text = "";
            cbTituloCortesia.SelectedIndex = -1;
            ConfigurarFormatoFechasInicial();
            tbDireccion.Text = "";
            tbCiudad.Text = "";
            tbRegion.Text = "";
            tbCodigoPostal.Text = "";
            tbPais.Text = "";
            mtbTelefono.Text = "";
            tbExtension.Text = "";
            tbFoto.Text = "";                
            tbAnotaciones.Text = "";
            tbEmpleadoSupervisor.Text = "";
            tbFotoPath.Text = "";
            DesmarcarCampos();
        }

        /// <summary>
        /// desmarca todos los campos para que no indiquen estado de ok o error
        /// e inicializa los valores de las variables booleanas
        /// </summary>
        private void DesmarcarCampos()
        {
            DesmarcarCampo(tbNombre);
            DesmarcarCampo(tbApellido);
            DesmarcarCampo(tbTitulo);
            DesmarcarCampo(tbDireccion);
            DesmarcarCampo(tbCiudad);
            DesmarcarCampo(tbRegion);
            DesmarcarCampo(tbCodigoPostal);
            DesmarcarCampo(tbPais);
            DesmarcarCampo(mtbTelefono);
            DesmarcarCampo(tbExtension);
            DesmarcarCampo(tbFoto);
            DesmarcarCampo(tbAnotaciones);
            DesmarcarCampo(tbEmpleadoSupervisor);
            DesmarcarCampo(tbFotoPath);
            InicializarBooleanos();
        }
       
    }  
}
