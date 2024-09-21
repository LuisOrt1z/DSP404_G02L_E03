namespace Procedimientos
{
    partial class frmGuia04ejerc1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTema = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTema
            // 
            this.lbTema.AutoSize = true;
            this.lbTema.Location = new System.Drawing.Point(30, 46);
            this.lbTema.Name = "lbTema";
            this.lbTema.Size = new System.Drawing.Size(100, 16);
            this.lbTema.TabIndex = 0;
            this.lbTema.Text = "Ingrese numero";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(33, 156);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(120, 45);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(33, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Location = new System.Drawing.Point(174, 12);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(374, 328);
            this.grbResult.TabIndex = 3;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.ItemHeight = 16;
            this.lstTabla2.Location = new System.Drawing.Point(189, 21);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(179, 292);
            this.lstTabla2.TabIndex = 1;
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.ItemHeight = 16;
            this.lstTabla1.Location = new System.Drawing.Point(6, 21);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(177, 292);
            this.lstTabla1.TabIndex = 0;
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(33, 75);
            this.nupBase.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            65536});
            this.nupBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 22);
            this.nupBase.TabIndex = 4;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmGuia04ejerc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 369);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lbTema);
            this.Name = "frmGuia04ejerc1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGuia04ejerc1_Load);
            this.grbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTema;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.NumericUpDown nupBase;
    }
}

