namespace Procedimientos
{
    partial class frmReves
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblReves = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtReves = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(41, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero:";
            // 
            // lblReves
            // 
            this.lblReves.AutoSize = true;
            this.lblReves.Location = new System.Drawing.Point(41, 121);
            this.lblReves.Name = "lblReves";
            this.lblReves.Size = new System.Drawing.Size(59, 16);
            this.lblReves.TabIndex = 1;
            this.lblReves.Text = "Al revés:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 41);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(241, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 41);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(44, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(316, 22);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtReves
            // 
            this.txtReves.Enabled = false;
            this.txtReves.Location = new System.Drawing.Point(44, 160);
            this.txtReves.Name = "txtReves";
            this.txtReves.Size = new System.Drawing.Size(316, 22);
            this.txtReves.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(149, 269);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtReves);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblReves);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmReves";
            this.Text = "Mostrar un número al revés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblReves;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtReves;
        private System.Windows.Forms.Button btnSalir;
    }
}