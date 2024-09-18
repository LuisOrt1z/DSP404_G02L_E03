namespace ejercicio_practico_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.lstpromedio = new System.Windows.Forms.ListBox();
            this.btnagregarnota = new System.Windows.Forms.Button();
            this.btnmostrarpromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nota (0.00 a 10.00)";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(131, 119);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 1;
            // 
            // lstpromedio
            // 
            this.lstpromedio.FormattingEnabled = true;
            this.lstpromedio.Location = new System.Drawing.Point(403, 52);
            this.lstpromedio.Name = "lstpromedio";
            this.lstpromedio.Size = new System.Drawing.Size(179, 173);
            this.lstpromedio.TabIndex = 2;
            // 
            // btnagregarnota
            // 
            this.btnagregarnota.Location = new System.Drawing.Point(64, 168);
            this.btnagregarnota.Name = "btnagregarnota";
            this.btnagregarnota.Size = new System.Drawing.Size(102, 23);
            this.btnagregarnota.TabIndex = 3;
            this.btnagregarnota.Text = "Agregar nota";
            this.btnagregarnota.UseVisualStyleBackColor = true;
            this.btnagregarnota.Click += new System.EventHandler(this.btnagregarnota_Click);
            // 
            // btnmostrarpromedio
            // 
            this.btnmostrarpromedio.Location = new System.Drawing.Point(196, 168);
            this.btnmostrarpromedio.Name = "btnmostrarpromedio";
            this.btnmostrarpromedio.Size = new System.Drawing.Size(102, 23);
            this.btnmostrarpromedio.TabIndex = 4;
            this.btnmostrarpromedio.Text = "mostrar promedios";
            this.btnmostrarpromedio.UseVisualStyleBackColor = true;
            this.btnmostrarpromedio.Click += new System.EventHandler(this.btnmostrarpromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrarpromedio);
            this.Controls.Add(this.btnagregarnota);
            this.Controls.Add(this.lstpromedio);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.ListBox lstpromedio;
        private System.Windows.Forms.Button btnagregarnota;
        private System.Windows.Forms.Button btnmostrarpromedio;
    }
}

