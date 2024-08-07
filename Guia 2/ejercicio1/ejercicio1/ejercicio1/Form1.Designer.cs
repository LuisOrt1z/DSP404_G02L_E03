namespace ejercicio1
{
    partial class frmFactorial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumero = new Label();
            lblFactorial = new Label();
            txtNumero = new TextBox();
            txtFactorial = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(252, 97);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(443, 97);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(55, 15);
            lblFactorial.TabIndex = 1;
            lblFactorial.Text = "Factorial:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(220, 145);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(425, 145);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(100, 23);
            txtFactorial.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(231, 199);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(443, 199);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmFactorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumero);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Name = "frmFactorial";
            Text = "Calculando el factorial de un numero";
            Load += frmFactorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblFactorial;
        private TextBox txtNumero;
        private TextBox txtFactorial;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
