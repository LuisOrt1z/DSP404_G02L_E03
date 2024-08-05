namespace arreglounidimensional
{
    partial class frmarreglo
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lsldesorden = new System.Windows.Forms.ListBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(189, 99);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(85, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "ingresar numero:";
            // 
            // lsldesorden
            // 
            this.lsldesorden.FormattingEnabled = true;
            this.lsldesorden.Location = new System.Drawing.Point(140, 210);
            this.lsldesorden.Name = "lsldesorden";
            this.lsldesorden.Size = new System.Drawing.Size(154, 173);
            this.lsldesorden.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btAgregar.Location = new System.Drawing.Point(541, 46);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(116, 32);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(303, 96);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(156, 20);
            this.txtNum.TabIndex = 3;
            // 
            // btOrdenar
            // 
            this.btOrdenar.BackColor = System.Drawing.Color.Khaki;
            this.btOrdenar.Location = new System.Drawing.Point(541, 112);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(116, 29);
            this.btOrdenar.TabIndex = 5;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = false;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.Location = new System.Drawing.Point(376, 210);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(154, 173);
            this.lstOrdenada.TabIndex = 6;
            // 
            // frmarreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lsldesorden);
            this.Controls.Add(this.lblnumero);
            this.Name = "frmarreglo";
            this.Text = "Ordenar";
            this.Load += new System.EventHandler(this.frmarreglo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.ListBox lsldesorden;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.ListBox lstOrdenada;
    }
}

