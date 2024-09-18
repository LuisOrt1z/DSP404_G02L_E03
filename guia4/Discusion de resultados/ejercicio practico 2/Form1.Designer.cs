namespace ejercicio_practico_2
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
            this.txtlimiteinferior = new System.Windows.Forms.TextBox();
            this.dataGridMatriz = new System.Windows.Forms.DataGridView();
            this.btngenerarmatriz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlimitesuperior = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite inferior:";
            // 
            // txtlimiteinferior
            // 
            this.txtlimiteinferior.Location = new System.Drawing.Point(34, 94);
            this.txtlimiteinferior.Name = "txtlimiteinferior";
            this.txtlimiteinferior.Size = new System.Drawing.Size(100, 20);
            this.txtlimiteinferior.TabIndex = 1;
            // 
            // dataGridMatriz
            // 
            this.dataGridMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatriz.Location = new System.Drawing.Point(103, 152);
            this.dataGridMatriz.Name = "dataGridMatriz";
            this.dataGridMatriz.Size = new System.Drawing.Size(555, 193);
            this.dataGridMatriz.TabIndex = 2;
            // 
            // btngenerarmatriz
            // 
            this.btngenerarmatriz.Location = new System.Drawing.Point(348, 55);
            this.btngenerarmatriz.Name = "btngenerarmatriz";
            this.btngenerarmatriz.Size = new System.Drawing.Size(75, 23);
            this.btngenerarmatriz.TabIndex = 3;
            this.btngenerarmatriz.Text = "Crear matriz";
            this.btngenerarmatriz.UseVisualStyleBackColor = true;
            this.btngenerarmatriz.Click += new System.EventHandler(this.btngenerarmatriz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limite superior:";
            // 
            // txtlimitesuperior
            // 
            this.txtlimitesuperior.Location = new System.Drawing.Point(198, 94);
            this.txtlimitesuperior.Name = "txtlimitesuperior";
            this.txtlimitesuperior.Size = new System.Drawing.Size(100, 20);
            this.txtlimitesuperior.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtlimitesuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngenerarmatriz);
            this.Controls.Add(this.dataGridMatriz);
            this.Controls.Add(this.txtlimiteinferior);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlimiteinferior;
        private System.Windows.Forms.DataGridView dataGridMatriz;
        private System.Windows.Forms.Button btngenerarmatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlimitesuperior;
    }
}

