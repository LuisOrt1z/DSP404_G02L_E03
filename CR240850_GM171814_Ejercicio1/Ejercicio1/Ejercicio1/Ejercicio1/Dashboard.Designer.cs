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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabEntre = new System.Windows.Forms.TabPage();
            this.tabLibro = new System.Windows.Forms.TabPage();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.tabGrafica = new System.Windows.Forms.TabPage();
            this.charGraficos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2.SuspendLayout();
            this.tabGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charGraficos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabEntre);
            this.tabControl2.Controls.Add(this.tabLibro);
            this.tabControl2.Controls.Add(this.tabProgram);
            this.tabControl2.Controls.Add(this.tabGrafica);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(782, 554);
            this.tabControl2.TabIndex = 0;
            // 
            // tabEntre
            // 
            this.tabEntre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabEntre.BackgroundImage")));
            this.tabEntre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEntre.Location = new System.Drawing.Point(4, 25);
            this.tabEntre.Name = "tabEntre";
            this.tabEntre.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntre.Size = new System.Drawing.Size(774, 525);
            this.tabEntre.TabIndex = 0;
            this.tabEntre.Text = "Entretenimiento";
            this.tabEntre.UseVisualStyleBackColor = true;
            // 
            // tabLibro
            // 
            this.tabLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLibro.BackgroundImage")));
            this.tabLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLibro.Location = new System.Drawing.Point(4, 25);
            this.tabLibro.Name = "tabLibro";
            this.tabLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibro.Size = new System.Drawing.Size(774, 525);
            this.tabLibro.TabIndex = 1;
            this.tabLibro.Text = "Libros";
            this.tabLibro.UseVisualStyleBackColor = true;
            // 
            // tabProgram
            // 
            this.tabProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProgram.BackgroundImage")));
            this.tabProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProgram.Location = new System.Drawing.Point(4, 25);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Size = new System.Drawing.Size(774, 525);
            this.tabProgram.TabIndex = 2;
            this.tabProgram.Text = "Programacion";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // tabGrafica
            // 
            this.tabGrafica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabGrafica.BackgroundImage")));
            this.tabGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGrafica.Controls.Add(this.charGraficos);
            this.tabGrafica.Location = new System.Drawing.Point(4, 25);
            this.tabGrafica.Name = "tabGrafica";
            this.tabGrafica.Size = new System.Drawing.Size(774, 525);
            this.tabGrafica.TabIndex = 3;
            this.tabGrafica.Text = "Graficos";
            this.tabGrafica.UseVisualStyleBackColor = true;
            // 
            // charGraficos
            // 
            this.charGraficos.BackColor = System.Drawing.Color.Transparent;
            this.charGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charGraficos.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.charGraficos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charGraficos.Legends.Add(legend1);
            this.charGraficos.Location = new System.Drawing.Point(30, 90);
            this.charGraficos.Name = "charGraficos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charGraficos.Series.Add(series1);
            this.charGraficos.Size = new System.Drawing.Size(352, 325);
            this.charGraficos.TabIndex = 0;
            this.charGraficos.Text = "chart1";
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl2.ResumeLayout(false);
            this.tabGrafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charGraficos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEntretenimiento;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabProgra;
        private System.Windows.Forms.TabPage tabGraficas;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabEntre;
        private System.Windows.Forms.TabPage tabLibro;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart charGraficos;
    }
}