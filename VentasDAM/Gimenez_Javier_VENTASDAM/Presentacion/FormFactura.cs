using Microsoft.Reporting.WinForms;
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
    public partial class FormFactura : Form
    {
        private readonly ReportViewer reportViewer;
        Order? pedido;

        public FormFactura()
        {
            InitializeComponent();
            Text = "Report Viewer";
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            //ReportItemSchemas();
        }

        protected override void OnLoad(EventArgs e)
        {
            FormBuscarPedido formBuscarPedido = new FormBuscarPedido();
            formBuscarPedido.Owner = this;
            this.Hide();
            formBuscarPedido.ShowDialog();
            pedido = formBuscarPedido.GetPedido();
            // preparo todos los datos del pedido, incluyendo sus order_details
            if (pedido != null)
            {
                pedido = Gestion.DatosPedido(pedido.OrderId);
                if (pedido != null)
                {
                    Informe.Load(reportViewer.LocalReport, pedido);
                    reportViewer.RefreshReport();
                    base.OnLoad(e);
                }
            }
            else
            {
                Mensaje.MostrarErrorGenerico("No ha seleccionado ninguna factura");
                Close();
            }
        }        

        private void ReportItemSchemas()
        {
            var types = new[] { typeof(Informe), typeof(ElementosInforme) };
            var xri = new System.Xml.Serialization.XmlReflectionImporter();
            var xss = new System.Xml.Serialization.XmlSchemas();
            var xse = new System.Xml.Serialization.XmlSchemaExporter(xss);
            foreach (var type in types)
            {
                var xtm = xri.ImportTypeMapping(type);
                xse.ExportTypeMapping(xtm);
            }
            using var sw = new System.IO.StreamWriter("ReportItemSchemas.xsd", false, Encoding.UTF8);
            for (int i = 0; i < xss.Count; i++)
            {
                var xs = xss[i];
                xs.Id = "ReportItemSchemas";
                xs.Write(sw);
            }
        }

        private void FormFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

    }
}
