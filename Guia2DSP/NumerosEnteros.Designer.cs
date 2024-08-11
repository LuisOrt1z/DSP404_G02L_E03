namespace Guia2DSP
{
    partial class NumerosEnteros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumerosEnteros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPositivos = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMayorNegativo = new System.Windows.Forms.TextBox();
            this.txtPromNegativos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorcPositivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorcNegativos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCeros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero entre -40 y 45:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mayor numero negativo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de positivos:";
            // 
            // txtPositivos
            // 
            this.txtPositivos.Enabled = false;
            this.txtPositivos.Location = new System.Drawing.Point(245, 108);
            this.txtPositivos.Name = "txtPositivos";
            this.txtPositivos.Size = new System.Drawing.Size(164, 22);
            this.txtPositivos.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(39, 37);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(268, 22);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // txtMayorNegativo
            // 
            this.txtMayorNegativo.Enabled = false;
            this.txtMayorNegativo.Location = new System.Drawing.Point(39, 108);
            this.txtMayorNegativo.Name = "txtMayorNegativo";
            this.txtMayorNegativo.Size = new System.Drawing.Size(164, 22);
            this.txtMayorNegativo.TabIndex = 5;
            // 
            // txtPromNegativos
            // 
            this.txtPromNegativos.Enabled = false;
            this.txtPromNegativos.Location = new System.Drawing.Point(455, 108);
            this.txtPromNegativos.Name = "txtPromNegativos";
            this.txtPromNegativos.Size = new System.Drawing.Size(164, 22);
            this.txtPromNegativos.TabIndex = 7;
            this.txtPromNegativos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio de negativos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPorcPositivos
            // 
            this.txtPorcPositivos.Enabled = false;
            this.txtPorcPositivos.Location = new System.Drawing.Point(39, 177);
            this.txtPorcPositivos.Name = "txtPorcPositivos";
            this.txtPorcPositivos.Size = new System.Drawing.Size(164, 22);
            this.txtPorcPositivos.TabIndex = 9;
            this.txtPorcPositivos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Porcentaje de positivos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPorcNegativos
            // 
            this.txtPorcNegativos.Enabled = false;
            this.txtPorcNegativos.Location = new System.Drawing.Point(245, 177);
            this.txtPorcNegativos.Name = "txtPorcNegativos";
            this.txtPorcNegativos.Size = new System.Drawing.Size(164, 22);
            this.txtPorcNegativos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Porcentaje de negativos:";
            // 
            // txtCeros
            // 
            this.txtCeros.Enabled = false;
            this.txtCeros.Location = new System.Drawing.Point(455, 177);
            this.txtCeros.Name = "txtCeros";
            this.txtCeros.Size = new System.Drawing.Size(164, 22);
            this.txtCeros.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ceros registrados:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(445, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(280, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(101, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // NumerosEnteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 273);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCeros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPorcNegativos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPorcPositivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPromNegativos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMayorNegativo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPositivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "NumerosEnteros";
            this.Text = "NumerosEnteros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPositivos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtMayorNegativo;
        private System.Windows.Forms.TextBox txtPromNegativos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorcPositivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPorcNegativos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCeros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
    }
}