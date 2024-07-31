namespace ejerciciopractico4
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
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lbldivisaorigen = new System.Windows.Forms.Label();
            this.lbldivisaaconvertir = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.cbdivisasfrom = new System.Windows.Forms.ComboBox();
            this.cbdivisasto = new System.Windows.Forms.ComboBox();
            this.lblconvertida = new System.Windows.Forms.Label();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(79, 56);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(48, 13);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "cantidad";
            // 
            // lbldivisaorigen
            // 
            this.lbldivisaorigen.AutoSize = true;
            this.lbldivisaorigen.Location = new System.Drawing.Point(257, 56);
            this.lbldivisaorigen.Name = "lbldivisaorigen";
            this.lbldivisaorigen.Size = new System.Drawing.Size(72, 13);
            this.lbldivisaorigen.TabIndex = 1;
            this.lbldivisaorigen.Text = "de esta divisa";
            // 
            // lbldivisaaconvertir
            // 
            this.lbldivisaaconvertir.AutoSize = true;
            this.lbldivisaaconvertir.Location = new System.Drawing.Point(442, 56);
            this.lbldivisaaconvertir.Name = "lbldivisaaconvertir";
            this.lbldivisaaconvertir.Size = new System.Drawing.Size(57, 13);
            this.lbldivisaaconvertir.TabIndex = 2;
            this.lbldivisaaconvertir.Text = "converti a:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(48, 87);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // cbdivisasfrom
            // 
            this.cbdivisasfrom.FormattingEnabled = true;
            this.cbdivisasfrom.Location = new System.Drawing.Point(226, 87);
            this.cbdivisasfrom.Name = "cbdivisasfrom";
            this.cbdivisasfrom.Size = new System.Drawing.Size(146, 21);
            this.cbdivisasfrom.TabIndex = 4;
            // 
            // cbdivisasto
            // 
            this.cbdivisasto.FormattingEnabled = true;
            this.cbdivisasto.Location = new System.Drawing.Point(410, 87);
            this.cbdivisasto.Name = "cbdivisasto";
            this.cbdivisasto.Size = new System.Drawing.Size(142, 21);
            this.cbdivisasto.TabIndex = 5;
            // 
            // lblconvertida
            // 
            this.lblconvertida.AutoSize = true;
            this.lblconvertida.Location = new System.Drawing.Point(337, 175);
            this.lblconvertida.Name = "lblconvertida";
            this.lblconvertida.Size = new System.Drawing.Size(0, 13);
            this.lblconvertida.TabIndex = 7;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(605, 87);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 8;
            this.btnconvertir.Text = "convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(314, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CONVERSION:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.lblconvertida);
            this.Controls.Add(this.cbdivisasto);
            this.Controls.Add(this.cbdivisasfrom);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lbldivisaaconvertir);
            this.Controls.Add(this.lbldivisaorigen);
            this.Controls.Add(this.lblcantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lbldivisaorigen;
        private System.Windows.Forms.Label lbldivisaaconvertir;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox cbdivisasfrom;
        private System.Windows.Forms.ComboBox cbdivisasto;
        private System.Windows.Forms.Label lblconvertida;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label label1;
    }
}

