﻿namespace Ejercicio3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.nudN1 = new System.Windows.Forms.NumericUpDown();
            this.nudN2 = new System.Windows.Forms.NumericUpDown();
            this.lblResul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Uno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Dos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operaciones Disponibles";
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Location = new System.Drawing.Point(328, 82);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(121, 21);
            this.cmbOperaciones.TabIndex = 3;
            this.cmbOperaciones.SelectedIndexChanged += new System.EventHandler(this.cmbOperaciones_SelectedIndexChanged);
            // 
            // nudN1
            // 
            this.nudN1.Location = new System.Drawing.Point(112, 47);
            this.nudN1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudN1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN1.Name = "nudN1";
            this.nudN1.Size = new System.Drawing.Size(159, 20);
            this.nudN1.TabIndex = 4;
            this.nudN1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudN2
            // 
            this.nudN2.Location = new System.Drawing.Point(112, 118);
            this.nudN2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudN2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN2.Name = "nudN2";
            this.nudN2.Size = new System.Drawing.Size(159, 20);
            this.nudN2.TabIndex = 5;
            this.nudN2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(258, 193);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(35, 13);
            this.lblResul.TabIndex = 6;
            this.lblResul.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 232);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.nudN2);
            this.Controls.Add(this.nudN1);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.NumericUpDown nudN1;
        private System.Windows.Forms.NumericUpDown nudN2;
        private System.Windows.Forms.Label lblResul;
    }
}

