namespace ejercicio_practico_1
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.btnMostrarElementos = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero a ingresar a la tabla:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(86, 87);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(304, 58);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(176, 225);
            this.lstNumeros.TabIndex = 2;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(570, 84);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(127, 23);
            this.btnCrearLista.TabIndex = 3;
            this.btnCrearLista.Text = "Crear lista vacia";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // btnMostrarElementos
            // 
            this.btnMostrarElementos.Location = new System.Drawing.Point(570, 125);
            this.btnMostrarElementos.Name = "btnMostrarElementos";
            this.btnMostrarElementos.Size = new System.Drawing.Size(127, 23);
            this.btnMostrarElementos.TabIndex = 4;
            this.btnMostrarElementos.Text = "Mostrar elementos";
            this.btnMostrarElementos.UseVisualStyleBackColor = true;
            this.btnMostrarElementos.Click += new System.EventHandler(this.btnMostrarElementos_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(570, 166);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(127, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar elemento";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(570, 214);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(127, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover primer número";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnMostrarElementos);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnMostrarElementos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnRemover;
    }
}

