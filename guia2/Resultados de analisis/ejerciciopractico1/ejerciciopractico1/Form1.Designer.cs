namespace ejerciciopractico1
{
    partial class frmfibonacci
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
            this.lbltext = new System.Windows.Forms.Label();
            this.lblserie = new System.Windows.Forms.Label();
            this.txtboxnum = new System.Windows.Forms.TextBox();
            this.lslNumeros = new System.Windows.Forms.ListBox();
            this.btncalculo = new System.Windows.Forms.Button();
            this.btnlimpiaf = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(201, 60);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(93, 13);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "ingrese el numero:";
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(201, 199);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(103, 13);
            this.lblserie.TabIndex = 1;
            this.lblserie.Text = "la serie fibonacci es:";
            // 
            // txtboxnum
            // 
            this.txtboxnum.Location = new System.Drawing.Point(204, 98);
            this.txtboxnum.Name = "txtboxnum";
            this.txtboxnum.Size = new System.Drawing.Size(100, 20);
            this.txtboxnum.TabIndex = 2;
            // 
            // lslNumeros
            // 
            this.lslNumeros.FormattingEnabled = true;
            this.lslNumeros.Location = new System.Drawing.Point(204, 246);
            this.lslNumeros.Name = "lslNumeros";
            this.lslNumeros.Size = new System.Drawing.Size(267, 186);
            this.lslNumeros.TabIndex = 3;
            // 
            // btncalculo
            // 
            this.btncalculo.Location = new System.Drawing.Point(363, 108);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(75, 23);
            this.btncalculo.TabIndex = 4;
            this.btncalculo.Text = "Calcular";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // btnlimpiaf
            // 
            this.btnlimpiaf.Location = new System.Drawing.Point(363, 149);
            this.btnlimpiaf.Name = "btnlimpiaf";
            this.btnlimpiaf.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiaf.TabIndex = 5;
            this.btnlimpiaf.Text = "Limpiar";
            this.btnlimpiaf.UseVisualStyleBackColor = true;
            this.btnlimpiaf.Click += new System.EventHandler(this.btnlimpiaf_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(363, 189);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmfibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiaf);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.lslNumeros);
            this.Controls.Add(this.txtboxnum);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.lbltext);
            this.Name = "frmfibonacci";
            this.Text = "Calculo de serie fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtboxnum;
        private System.Windows.Forms.ListBox lslNumeros;
        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.Button btnlimpiaf;
        private System.Windows.Forms.Button btnsalir;
    }
}

