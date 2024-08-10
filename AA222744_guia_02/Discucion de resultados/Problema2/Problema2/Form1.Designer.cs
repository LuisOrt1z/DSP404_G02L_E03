namespace Problema2
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
            this.lblAviso = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(182, 117);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(163, 16);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.Text = "Ingrese minimo 4 numeros\r\n";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 16;
            this.lstNumeros.Location = new System.Drawing.Point(394, 68);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(251, 180);
            this.lstNumeros.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(536, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 38);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista de numeros";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(166, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 38);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(24, 68);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 22);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresa numeros:";
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(24, 152);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(321, 52);
            this.lstResultados.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Resultados:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(234, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 40);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 302);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " desviación típica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}

