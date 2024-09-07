namespace Ejercicio1
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
            this.lbltema = new System.Windows.Forms.Label();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(26, 56);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(80, 13);
            this.lbltema.TabIndex = 0;
            this.lbltema.Text = "Ingrese nùmero";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Location = new System.Drawing.Point(179, 47);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(263, 353);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(29, 157);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(131, 43);
            this.btnCalculo.TabIndex = 2;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.Location = new System.Drawing.Point(6, 29);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(114, 316);
            this.lstTabla1.TabIndex = 0;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.Location = new System.Drawing.Point(139, 29);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(114, 316);
            this.lstTabla2.TabIndex = 1;
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(29, 76);
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
            this.nupBase.Size = new System.Drawing.Size(120, 20);
            this.nupBase.TabIndex = 4;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmGuia04ejerc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.lbltema);
            this.Name = "frmGuia04ejerc1";
            this.Text = "frmGuia04ejerc1";
            this.Load += new System.EventHandler(this.frmGuia04ejerc1_Load);
            this.grbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nupBase;
    }
}

