namespace Forrajeria
{
    partial class EstadisticaControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraficoCircular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGraficoBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblCantidades = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoCircular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraficoCircular
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraficoCircular.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraficoCircular.Legends.Add(legend1);
            this.chartGraficoCircular.Location = new System.Drawing.Point(29, 88);
            this.chartGraficoCircular.Name = "chartGraficoCircular";
            this.chartGraficoCircular.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartGraficoCircular.Series.Add(series1);
            this.chartGraficoCircular.Size = new System.Drawing.Size(554, 491);
            this.chartGraficoCircular.TabIndex = 0;
            this.chartGraficoCircular.Text = "chart1";
            // 
            // chartGraficoBarras
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraficoBarras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraficoBarras.Legends.Add(legend2);
            this.chartGraficoBarras.Location = new System.Drawing.Point(601, 88);
            this.chartGraficoBarras.Name = "chartGraficoBarras";
            this.chartGraficoBarras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartGraficoBarras.Series.Add(series2);
            this.chartGraficoBarras.Size = new System.Drawing.Size(710, 491);
            this.chartGraficoBarras.TabIndex = 2;
            this.chartGraficoBarras.Text = "chart1";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(465, 60);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(118, 25);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            // 
            // lblCantidades
            // 
            this.lblCantidades.AutoSize = true;
            this.lblCantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidades.Location = new System.Drawing.Point(24, 60);
            this.lblCantidades.Name = "lblCantidades";
            this.lblCantidades.Size = new System.Drawing.Size(131, 25);
            this.lblCantidades.TabIndex = 4;
            this.lblCantidades.Text = "Cantidades";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.Location = new System.Drawing.Point(822, 60);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(218, 25);
            this.lblTotales.TabIndex = 5;
            this.lblTotales.Text = "Ventas Registradas";
            // 
            // EstadisticaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 605);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblCantidades);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.chartGraficoBarras);
            this.Controls.Add(this.chartGraficoCircular);
            this.Name = "EstadisticaControl";
            this.Text = "EstadisticaControl";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoCircular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficoCircular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficoBarras;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCantidades;
        private System.Windows.Forms.Label lblTotales;
    }
}