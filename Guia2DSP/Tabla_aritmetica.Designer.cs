namespace Guia2DSP
{
    partial class Tabla_aritmetica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabla_aritmetica));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbosuma = new System.Windows.Forms.ComboBox();
            this.cboresta = new System.Windows.Forms.ComboBox();
            this.cbomulti = new System.Windows.Forms.ComboBox();
            this.cbodiv = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbodiv);
            this.groupBox2.Controls.Add(this.cbomulti);
            this.groupBox2.Controls.Add(this.cboresta);
            this.groupBox2.Controls.Add(this.cbosuma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla aritmetica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(72, 37);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(221, 22);
            this.txtnumero.TabIndex = 1;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(419, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(137, 23);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(419, 53);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncalcular.Size = new System.Drawing.Size(137, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Multiplicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Division";
            // 
            // cbosuma
            // 
            this.cbosuma.FormattingEnabled = true;
            this.cbosuma.Location = new System.Drawing.Point(15, 73);
            this.cbosuma.Name = "cbosuma";
            this.cbosuma.Size = new System.Drawing.Size(103, 24);
            this.cbosuma.TabIndex = 4;
            // 
            // cboresta
            // 
            this.cboresta.FormattingEnabled = true;
            this.cboresta.Location = new System.Drawing.Point(149, 73);
            this.cboresta.Name = "cboresta";
            this.cboresta.Size = new System.Drawing.Size(103, 24);
            this.cboresta.TabIndex = 5;
            // 
            // cbomulti
            // 
            this.cbomulti.FormattingEnabled = true;
            this.cbomulti.Location = new System.Drawing.Point(291, 73);
            this.cbomulti.Name = "cbomulti";
            this.cbomulti.Size = new System.Drawing.Size(103, 24);
            this.cbomulti.TabIndex = 6;
            // 
            // cbodiv
            // 
            this.cbodiv.FormattingEnabled = true;
            this.cbodiv.Location = new System.Drawing.Point(436, 73);
            this.cbodiv.Name = "cbodiv";
            this.cbodiv.Size = new System.Drawing.Size(103, 24);
            this.cbodiv.TabIndex = 7;
            // 
            // Tabla_aritmetica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tabla_aritmetica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboresta;
        private System.Windows.Forms.ComboBox cbosuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbodiv;
        private System.Windows.Forms.ComboBox cbomulti;
    }
}

