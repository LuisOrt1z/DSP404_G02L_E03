namespace Ejercicio1
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEntretenimiento = new System.Windows.Forms.TabPage();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.tabProgra = new System.Windows.Forms.TabPage();
            this.tabGraficas = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtNombre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEntretenimiento);
            this.tabControl1.Controls.Add(this.tabLibros);
            this.tabControl1.Controls.Add(this.tabProgra);
            this.tabControl1.Controls.Add(this.tabGraficas);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEntretenimiento
            // 
            this.tabEntretenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabEntretenimiento.Name = "tabEntretenimiento";
            this.tabEntretenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntretenimiento.Size = new System.Drawing.Size(778, 525);
            this.tabEntretenimiento.TabIndex = 0;
            this.tabEntretenimiento.Text = "Entretenimientos";
            this.tabEntretenimiento.UseVisualStyleBackColor = true;
            // 
            // tabLibros
            // 
            this.tabLibros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabLibros.Location = new System.Drawing.Point(4, 25);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(778, 525);
            this.tabLibros.TabIndex = 1;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // tabProgra
            // 
            this.tabProgra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabProgra.Location = new System.Drawing.Point(4, 25);
            this.tabProgra.Name = "tabProgra";
            this.tabProgra.Size = new System.Drawing.Size(778, 525);
            this.tabProgra.TabIndex = 2;
            this.tabProgra.Text = "Programación";
            this.tabProgra.UseVisualStyleBackColor = true;
            // 
            // tabGraficas
            // 
            this.tabGraficas.Controls.Add(this.txtNombre);
            this.tabGraficas.Controls.Add(this.chart1);
            this.tabGraficas.Location = new System.Drawing.Point(4, 25);
            this.tabGraficas.Name = "tabGraficas";
            this.tabGraficas.Size = new System.Drawing.Size(778, 525);
            this.tabGraficas.TabIndex = 3;
            this.tabGraficas.Text = "Graficas";
            this.tabGraficas.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(30, 93);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 333);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(113, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 32);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Grafico";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabGraficas.ResumeLayout(false);
            this.tabGraficas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEntretenimiento;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabProgra;
        private System.Windows.Forms.TabPage tabGraficas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label txtNombre;
    }
}