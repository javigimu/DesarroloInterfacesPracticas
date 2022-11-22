using Modelos;
using Negocio;
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

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public partial class FormPrincipal : Form
    {
        private int empleadoSeleccionadoId;
        private string? empleadoSeleccionadoNombre;
        private byte[]? empleadoSeleccionadoFoto;
        private FormBusqueda? formBuscarEmpleado;
        private FormProductos? formProductos;
        private bool cerrarPulsandoSalir;

        public FormPrincipal()
        {
            InitializeComponent();
            cerrarPulsandoSalir = false;
        }

        public void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormSeleccionUsuario fsu = new FormSeleccionUsuario();
            fsu.Owner = this;
            this.Hide();
            fsu.ShowDialog();
  
            empleadoSeleccionadoId = fsu.EmpleadoSeleccionadoId;
            if (empleadoSeleccionadoId != -1)
            {
                using (Gestion g = new Gestion())
                {
                    empleadoSeleccionadoNombre = g.ObtenerNombreEmpleado(empleadoSeleccionadoId);
                    empleadoSeleccionadoFoto = g.ObtenerFotoEmpleado(empleadoSeleccionadoId);

                    Image? fotoEmpleado = byteArrayToImage(empleadoSeleccionadoFoto);
                    lbNombreEmpleado.Text = empleadoSeleccionadoNombre;
                    pbFotoEmpleado.Image = fotoEmpleado;
                }
            }
            else
            {
                Close();
            }
        }

        /// <summary>
        /// Convierte un array de bytes en una imagen
        /// </summary>
        /// <param name="imagenEnBytes"></param>
        /// <returns>Imagen convertida</returns>
        public Image? byteArrayToImage(byte[]? imagenEnBytes)
        {
            if (imagenEnBytes != null)
            {
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image? img = (Image?)converter.ConvertFrom(imagenEnBytes);
                return img;
            }
            return null;
        }

        private void LanzarFormEmpleadosInsertar(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados('i');
            formEmpleados.Owner = this;
            this.Hide();
            formEmpleados.Show();            
        }

        private void LanzarFormEmpleadosModificar(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados('m');
            formEmpleados.Owner = this;
            this.Hide();
            formEmpleados.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormBuscarEmpleado();
            Employee? emp = formBuscarEmpleado?.GetEmpleado();
            if (emp != null)
            {
                using (Gestion gestion = new Gestion())
                {
                    try
                    {
                        gestion.BorrarEmployee(emp);
                        Mensaje.MostrarProcesoFinalizadoCorrectamente("Borrado", "empleado");
                    }catch (Exception ex)
                    {
                        Mensaje.MostrarExcepcionBorrado(ex);
                    }
                }
            }
        }

        private void MostrarFormBuscarEmpleado()
        {
            formBuscarEmpleado = new FormBusqueda(true);
            formBuscarEmpleado.Owner = this;
            this.Hide();
            formBuscarEmpleado.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = 
                Mensaje.ConfirmarOpcion("¿Está usted seguro de que quiere salir?");
            if (respuesta == DialogResult.OK)
            {
                cerrarPulsandoSalir = true;
                Close();
            }
        }

        private void ConfirmarCierreAplicacion(object sender, FormClosingEventArgs e)
        {
            if (empleadoSeleccionadoId != -1 && !cerrarPulsandoSalir)
            {
                DialogResult respuesta =
                    Mensaje.ConfirmarOpcion("¿Está usted seguro de que quiere salir?");
                if (respuesta != DialogResult.OK)
                    e.Cancel = true;
            }
        }


        private void modificarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FormProductos(empleadoSeleccionadoId);
            formProductos.Owner = this;
            this.Hide();
            formProductos.ShowDialog();
        }

        private void LanzarFormPedido(char opcion)
        {
            FormPedidos formPedidos = new FormPedidos(empleadoSeleccionadoId, opcion);
            formPedidos.Owner = this;
            this.Hide();
            formPedidos.Show();
        }


        private void tsbNuevoPedido_Click(object sender, EventArgs e)
        {
            LanzarFormPedido('i');
        }

        private void tsmPedidoNuevo_Click(object sender, EventArgs e)
        {
            LanzarFormPedido('i');
        }

        private void tsmPedidoModificar_Click(object sender, EventArgs e)
        {
            LanzarFormPedido('m');
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Owner = this;            
            ab.ShowDialog();
        }

        private void totalPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraficoClientePedido formGraficoClientePedido = new FormGraficoClientePedido();
            formGraficoClientePedido.Owner = this;
            this.Hide();
            formGraficoClientePedido.Show();            
        }

        private void productosPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraficoProductoCategoria formGraficoProductoCategoria = new FormGraficoProductoCategoria();
            formGraficoProductoCategoria.Owner = this;
            this.Hide();
            formGraficoProductoCategoria.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            formFactura.Owner = this;
            this.Hide();
            formFactura.Show();
        }
    }
}
