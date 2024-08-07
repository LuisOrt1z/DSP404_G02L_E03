namespace usodecolecciones
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
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(123, 84);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(154, 251);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // txtsignificado
            // 
            this.txtsignificado.Enabled = false;
            this.txtsignificado.Location = new System.Drawing.Point(367, 203);
            this.txtsignificado.Multiline = true;
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(169, 132);
            this.txtsignificado.TabIndex = 1;
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(411, 109);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(43, 13);
            this.lblpalabra.TabIndex = 2;
            this.lblpalabra.Text = "Palabra";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(172, 396);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(287, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.txtsignificado);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Button btnsalir;
    }
}

