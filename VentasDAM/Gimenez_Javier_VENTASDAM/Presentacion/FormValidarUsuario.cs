using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public partial class FormValidarUsuario : Form
    {
        private int empleadoId;
        public bool ValidacionCorrecta { get; set; }

        public FormValidarUsuario()
        {
            InitializeComponent();
        }

        public FormValidarUsuario(int empleadoId) :this()
        {
            this.empleadoId = empleadoId;
            ValidacionCorrecta = false;
        }

        private void btValidarEmpleado_Click(object sender, EventArgs e)
        {
            int empleado;
            if (Int32.TryParse(tbIdEmpleado.Text.Trim(), out empleado) && 
                empleadoId == Convert.ToInt32(empleado))
            {
                ValidacionCorrecta = true;
                Close();
            }
            else
            {
                tbIdEmpleado.Text = "";
                Mensaje.MostrarErrorDeValidacion("Id de empleado incorrecto");
                tbIdEmpleado.Focus();
            }
        }

        private void FormValidarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {           
             Owner.Show();
        }
    }
}
