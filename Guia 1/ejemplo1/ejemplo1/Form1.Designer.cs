﻿namespace ejemplo1
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
            this.btnContar = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(80, 92);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 0;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(259, 92);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(75, 23);
            this.btnReinicio.TabIndex = 1;
            this.btnReinicio.Text = "Reinicio conteo";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(529, 134);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Salir programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "Evento se ejecuta al iniciar ejecución de Form1";
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnContar);
            this.Name = "Form1";
            this.Text = "Prueba de ambito de variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label1;
    }
}

