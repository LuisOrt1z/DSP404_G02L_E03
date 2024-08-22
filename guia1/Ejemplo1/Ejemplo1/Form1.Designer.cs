namespace Ejemplo1
{
    partial class Form1
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
            this.btncontar = new System.Windows.Forms.Button();
            this.btnreincio = new System.Windows.Forms.Button();
            this.btnfin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncontar
            // 
            this.btncontar.Location = new System.Drawing.Point(109, 58);
            this.btncontar.Name = "btncontar";
            this.btncontar.Size = new System.Drawing.Size(129, 55);
            this.btncontar.TabIndex = 0;
            this.btncontar.Text = "Contar";
            this.btncontar.UseVisualStyleBackColor = true;
            this.btncontar.Click += new System.EventHandler(this.btncontar_Click);
            // 
            // btnreincio
            // 
            this.btnreincio.Location = new System.Drawing.Point(586, 58);
            this.btnreincio.Name = "btnreincio";
            this.btnreincio.Size = new System.Drawing.Size(122, 58);
            this.btnreincio.TabIndex = 1;
            this.btnreincio.Text = "reincio";
            this.btnreincio.UseVisualStyleBackColor = true;
            this.btnreincio.Click += new System.EventHandler(this.btnreincio_Click);
            // 
            // btnfin
            // 
            this.btnfin.Location = new System.Drawing.Point(582, 192);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(126, 73);
            this.btnfin.TabIndex = 2;
            this.btnfin.Text = "salir";
            this.btnfin.UseVisualStyleBackColor = true;
            this.btnfin.Click += new System.EventHandler(this.btnfin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfin);
            this.Controls.Add(this.btnreincio);
            this.Controls.Add(this.btncontar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontar;
        private System.Windows.Forms.Button btnreincio;
        private System.Windows.Forms.Button btnfin;
        private System.Windows.Forms.Label label1;
    }
}

