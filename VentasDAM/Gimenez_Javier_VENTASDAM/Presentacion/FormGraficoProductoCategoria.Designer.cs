using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    partial class FormGraficoProductoCategoria
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
            this.SuspendLayout();
            // 
            // FormGraficoProductoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FormGraficoProductoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGraficoProductoCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGraficoProductoCategoria_FormClosing);
            this.Load += new System.EventHandler(this.FormGraficoProductoCategoria_Load);
            this.ResumeLayout(false);

            /// Gráfico Pedidos y Clientes
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            this.chart1 = new Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 9);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            //series1.Label = "#PERCENT{P0}";
            series1.Legend = "Legend1";            
            series1.Name = "Productos_Categoria";
            this.chart1.Series.Add(series1);
            this.chart1.Series["Productos_Categoria"].ChartType = SeriesChartType.Pie;
            this.chart1.Size = new System.Drawing.Size(1170, 840);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // FormGraficoPedidoCliente
            this.Controls.Add(this.chart1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }
        private Chart chart1;
        #endregion
    }
}