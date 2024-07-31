namespace ejerciciopractico2
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
            this.lblingresonums = new System.Windows.Forms.Label();
            this.lblprom = new System.Windows.Forms.Label();
            this.lbldesviacion = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncalculoprom = new System.Windows.Forms.Button();
            this.btncalculodesviacion = new System.Windows.Forms.Button();
            this.lstprom = new System.Windows.Forms.TextBox();
            this.lstdesviacion = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lbldesvia = new System.Windows.Forms.Label();
            this.lbldeviar = new System.Windows.Forms.Label();
            this.brnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblingresonums
            // 
            this.lblingresonums.AutoSize = true;
            this.lblingresonums.Location = new System.Drawing.Point(335, 32);
            this.lblingresonums.Name = "lblingresonums";
            this.lblingresonums.Size = new System.Drawing.Size(97, 13);
            this.lblingresonums.TabIndex = 0;
            this.lblingresonums.Text = "Ingrese 4 numeros:";
            // 
            // lblprom
            // 
            this.lblprom.AutoSize = true;
            this.lblprom.Location = new System.Drawing.Point(138, 238);
            this.lblprom.Name = "lblprom";
            this.lblprom.Size = new System.Drawing.Size(51, 13);
            this.lblprom.TabIndex = 1;
            this.lblprom.Text = "Promedio";
            // 
            // lbldesviacion
            // 
            this.lbldesviacion.AutoSize = true;
            this.lbldesviacion.Location = new System.Drawing.Point(585, 238);
            this.lbldesviacion.Name = "lbldesviacion";
            this.lbldesviacion.Size = new System.Drawing.Size(60, 13);
            this.lbldesviacion.TabIndex = 2;
            this.lbldesviacion.Text = "Desviacion";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(332, 70);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(347, 115);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncalculoprom
            // 
            this.btncalculoprom.Location = new System.Drawing.Point(141, 196);
            this.btncalculoprom.Name = "btncalculoprom";
            this.btncalculoprom.Size = new System.Drawing.Size(75, 23);
            this.btncalculoprom.TabIndex = 7;
            this.btncalculoprom.Text = "calcular";
            this.btncalculoprom.UseVisualStyleBackColor = true;
            this.btncalculoprom.Click += new System.EventHandler(this.btncalculoprom_Click);
            // 
            // btncalculodesviacion
            // 
            this.btncalculodesviacion.Location = new System.Drawing.Point(570, 196);
            this.btncalculodesviacion.Name = "btncalculodesviacion";
            this.btncalculodesviacion.Size = new System.Drawing.Size(75, 23);
            this.btncalculodesviacion.TabIndex = 8;
            this.btncalculodesviacion.Text = "calcular";
            this.btncalculodesviacion.UseVisualStyleBackColor = true;
            this.btncalculodesviacion.Click += new System.EventHandler(this.btncalculodesviacion_Click);
            // 
            // lstprom
            // 
            this.lstprom.Enabled = false;
            this.lstprom.Location = new System.Drawing.Point(141, 272);
            this.lstprom.Multiline = true;
            this.lstprom.Name = "lstprom";
            this.lstprom.Size = new System.Drawing.Size(75, 41);
            this.lstprom.TabIndex = 9;
            // 
            // lstdesviacion
            // 
            this.lstdesviacion.Enabled = false;
            this.lstdesviacion.Location = new System.Drawing.Point(570, 272);
            this.lstdesviacion.Multiline = true;
            this.lstdesviacion.Name = "lstdesviacion";
            this.lstdesviacion.Size = new System.Drawing.Size(75, 41);
            this.lstdesviacion.TabIndex = 10;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(154, 275);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 11;
            // 
            // lbldesvia
            // 
            this.lbldesvia.AutoSize = true;
            this.lbldesvia.Location = new System.Drawing.Point(585, 286);
            this.lbldesvia.Name = "lbldesvia";
            this.lbldesvia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldesvia.Size = new System.Drawing.Size(0, 13);
            this.lbldesvia.TabIndex = 12;
            // 
            // lbldeviar
            // 
            this.lbldeviar.AutoSize = true;
            this.lbldeviar.Location = new System.Drawing.Point(591, 275);
            this.lbldeviar.Name = "lbldeviar";
            this.lbldeviar.Size = new System.Drawing.Size(0, 13);
            this.lbldeviar.TabIndex = 13;
            // 
            // brnlimpiar
            // 
            this.brnlimpiar.Location = new System.Drawing.Point(302, 308);
            this.brnlimpiar.Name = "brnlimpiar";
            this.brnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.brnlimpiar.TabIndex = 14;
            this.brnlimpiar.Text = "limpiar";
            this.brnlimpiar.UseVisualStyleBackColor = true;
            this.brnlimpiar.Click += new System.EventHandler(this.brnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(423, 308);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.brnlimpiar);
            this.Controls.Add(this.lbldeviar);
            this.Controls.Add(this.lbldesvia);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lstdesviacion);
            this.Controls.Add(this.lstprom);
            this.Controls.Add(this.btncalculodesviacion);
            this.Controls.Add(this.btncalculoprom);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbldesviacion);
            this.Controls.Add(this.lblprom);
            this.Controls.Add(this.lblingresonums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblingresonums;
        private System.Windows.Forms.Label lblprom;
        private System.Windows.Forms.Label lbldesviacion;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncalculoprom;
        private System.Windows.Forms.Button btncalculodesviacion;
        private System.Windows.Forms.TextBox lstprom;
        private System.Windows.Forms.TextBox lstdesviacion;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lbldesvia;
        private System.Windows.Forms.Label lbldeviar;
        private System.Windows.Forms.Button brnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

