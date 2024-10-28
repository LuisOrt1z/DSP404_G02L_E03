namespace DiscucionDeesultados
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnInsertarElemento = new System.Windows.Forms.Button();
            this.btnRemoverElemento = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(105, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 212);
            this.listBox1.TabIndex = 0;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(304, 89);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(75, 23);
            this.btnCrearLista.TabIndex = 1;
            this.btnCrearLista.Text = "Crear lista vacía";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(304, 133);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarLista.TabIndex = 2;
            this.btnMostrarLista.Text = "Mostrar lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            // 
            // btnInsertarElemento
            // 
            this.btnInsertarElemento.Location = new System.Drawing.Point(304, 178);
            this.btnInsertarElemento.Name = "btnInsertarElemento";
            this.btnInsertarElemento.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarElemento.TabIndex = 3;
            this.btnInsertarElemento.Text = "Insertar elemento";
            this.btnInsertarElemento.UseVisualStyleBackColor = true;
            // 
            // btnRemoverElemento
            // 
            this.btnRemoverElemento.Location = new System.Drawing.Point(304, 229);
            this.btnRemoverElemento.Name = "btnRemoverElemento";
            this.btnRemoverElemento.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverElemento.TabIndex = 4;
            this.btnRemoverElemento.Text = "Remover elemento";
            this.btnRemoverElemento.UseVisualStyleBackColor = true;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(105, 89);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(155, 20);
            this.txtElemento.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(304, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 404);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnRemoverElemento);
            this.Controls.Add(this.btnInsertarElemento);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnInsertarElemento;
        private System.Windows.Forms.Button btnRemoverElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnSalir;
    }
}

