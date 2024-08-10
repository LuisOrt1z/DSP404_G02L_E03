namespace Problema2
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.dgvTraspuesta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(251, 42);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 32);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(13, 47);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(100, 22);
            this.txtFilas.TabIndex = 1;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(135, 47);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 22);
            this.txtColumnas.TabIndex = 2;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(13, 161);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(324, 212);
            this.dgvMatriz.TabIndex = 3;
            // 
            // dgvTraspuesta
            // 
            this.dgvTraspuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraspuesta.Location = new System.Drawing.Point(383, 161);
            this.dgvTraspuesta.Name = "dgvTraspuesta";
            this.dgvTraspuesta.RowHeadersWidth = 51;
            this.dgvTraspuesta.RowTemplate.Height = 24;
            this.dgvTraspuesta.Size = new System.Drawing.Size(324, 212);
            this.dgvTraspuesta.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(621, 42);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matriz Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matriz Traspuesta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rango: 1 a 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTraspuesta);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Calculo de matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.DataGridView dgvTraspuesta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

