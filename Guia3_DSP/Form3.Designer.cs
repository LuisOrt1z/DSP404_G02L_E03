namespace Guia3_DSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 16;
            this.lstPalabras.Location = new System.Drawing.Point(24, 26);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(218, 260);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(279, 26);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(55, 16);
            this.lblpalabra.TabIndex = 1;
            this.lblpalabra.Text = "Palabra";
            // 
            // txtsignificado
            // 
            this.txtsignificado.Enabled = false;
            this.txtsignificado.Location = new System.Drawing.Point(282, 85);
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(148, 22);
            this.txtsignificado.TabIndex = 2;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(102, 302);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(285, 32);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtsignificado);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Form3";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Button btnsalir;
    }
}