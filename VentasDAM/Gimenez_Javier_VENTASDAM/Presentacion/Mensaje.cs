using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Mensaje
    {
        public static void MostrarProcesoFinalizadoCorrectamente(string objeto, string operacion)
        {
            MessageBox.Show(objeto + " " + operacion + " finalizada correctamente");
        }

        public static void MostrarErrorDeValidacion(string texto)
        {
            MessageBox.Show(texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarExcepcion(ArgumentException e)
        {
            MessageBox.Show("Error: " + e.Message);
        }

        public static void MostrarExcepcionBorrado(Exception e)
        {
            MessageBox.Show("Error: No se puede eliminar porque tiene información en otras tablas\n " + e.Message);
        }

        public static DialogResult ConfirmarSeleccion(Object o, string texto)
        {
            DialogResult respuesta = DialogResult.Cancel;
            if (o is Employee)
            {
                Employee emp = (Employee)o;
                respuesta = MessageBox.Show(
                       texto + " " + emp.EmployeeId + " " + emp.FirstName
                           + " " + emp.LastName,
                       "Cancelar",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Information);
            }
            return respuesta;
        }

        public static DialogResult ConfirmarOpcion(string texto)
        {
            DialogResult respuesta = DialogResult.Cancel;
            respuesta = MessageBox.Show(
                    texto,
                    "Cancelar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            return respuesta;
        }

        public static void MostrarErrorGenerico(string error)
        {
            MessageBox.Show(error);
        }
    }
}
