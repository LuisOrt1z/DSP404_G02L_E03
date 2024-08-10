namespace Procedimientos
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtsignificado
            // 
            this.txtsignificado.Enabled = false;
            this.txtsignificado.Location = new System.Drawing.Point(236, 107);
            this.txtsignificado.Multiline = true;
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(228, 160);
            this.txtsignificado.TabIndex = 1;
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(236, 41);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(55, 16);
            this.lblpalabra.TabIndex = 2;
            this.lblpalabra.Text = "Palabra";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(82, 297);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(306, 44);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 16;
            this.lstPalabras.Location = new System.Drawing.Point(26, 41);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(170, 228);
            this.lstPalabras.TabIndex = 4;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 356);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.txtsignificado);
            this.Name = "Form3";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ListBox lstPalabras;
    }
}