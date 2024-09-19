namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripciontextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.Cantidadtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.detalledataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detalledataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // clientetextbox
            // 
            this.clientetextbox.Location = new System.Drawing.Point(68, 13);
            this.clientetextbox.Name = "clientetextbox";
            this.clientetextbox.Size = new System.Drawing.Size(597, 22);
            this.clientetextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(68, 64);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(159, 22);
            this.idtextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // descripciontextbox
            // 
            this.descripciontextbox.Location = new System.Drawing.Point(397, 61);
            this.descripciontextbox.Name = "descripciontextbox";
            this.descripciontextbox.Size = new System.Drawing.Size(391, 22);
            this.descripciontextbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(68, 119);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(248, 22);
            this.preciotxt.TabIndex = 7;
            // 
            // Cantidadtextbox
            // 
            this.Cantidadtextbox.Location = new System.Drawing.Point(407, 116);
            this.Cantidadtextbox.Name = "Cantidadtextbox";
            this.Cantidadtextbox.Size = new System.Drawing.Size(120, 22);
            this.Cantidadtextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(559, 112);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(106, 30);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // detalledataGridView1
            // 
            this.detalledataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalledataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalledataGridView1.Location = new System.Drawing.Point(16, 177);
            this.detalledataGridView1.Name = "detalledataGridView1";
            this.detalledataGridView1.RowHeadersWidth = 51;
            this.detalledataGridView1.RowTemplate.Height = 24;
            this.detalledataGridView1.Size = new System.Drawing.Size(772, 261);
            this.detalledataGridView1.TabIndex = 11;
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(682, 111);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(106, 30);
            this.BtnPagar.TabIndex = 12;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Location = new System.Drawing.Point(682, 13);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(106, 30);
            this.BtnAsignar.TabIndex = 13;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.detalledataGridView1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Cantidadtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripciontextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientetextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalledataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripciontextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox Cantidadtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView detalledataGridView1;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnAsignar;
    }
}

