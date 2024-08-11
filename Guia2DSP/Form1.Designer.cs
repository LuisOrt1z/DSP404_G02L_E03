namespace Procedimientos
{
    partial class frmFactorial
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(54, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(227, 33);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(62, 16);
            this.lblFactorial.TabIndex = 1;
            this.lblFactorial.Text = "Factorial:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(82, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(230, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(57, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 22);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtFactorial
            // 
            this.txtFactorial.Enabled = false;
            this.txtFactorial.Location = new System.Drawing.Point(230, 65);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(105, 22);
            this.txtFactorial.TabIndex = 5;
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 188);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmFactorial";
            this.Text = "Calculando el factorial de un numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtFactorial;
    }
}

