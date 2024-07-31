namespace ejerciciopractico3
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtboxnums = new System.Windows.Forms.TextBox();
            this.lstinputdnums = new System.Windows.Forms.ListBox();
            this.gbinputting = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbinputdnumbers = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbiggestnegative = new System.Windows.Forms.ListBox();
            this.lblupdatednums = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstpositivenums = new System.Windows.Forms.ListBox();
            this.lblpositivenums = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstnegativeaverage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstporcentajenums = new System.Windows.Forms.ListBox();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.gbinputting.SuspendLayout();
            this.gbinputdnumbers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(19, 46);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(104, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Ingrese los numeros:";
            // 
            // txtboxnums
            // 
            this.txtboxnums.Location = new System.Drawing.Point(22, 78);
            this.txtboxnums.Name = "txtboxnums";
            this.txtboxnums.Size = new System.Drawing.Size(100, 20);
            this.txtboxnums.TabIndex = 3;
            // 
            // lstinputdnums
            // 
            this.lstinputdnums.FormattingEnabled = true;
            this.lstinputdnums.Location = new System.Drawing.Point(25, 19);
            this.lstinputdnums.Name = "lstinputdnums";
            this.lstinputdnums.Size = new System.Drawing.Size(155, 134);
            this.lstinputdnums.TabIndex = 4;
            // 
            // gbinputting
            // 
            this.gbinputting.Controls.Add(this.btnexit);
            this.gbinputting.Controls.Add(this.btnclean);
            this.gbinputting.Controls.Add(this.btnadd);
            this.gbinputting.Controls.Add(this.lblnumero);
            this.gbinputting.Controls.Add(this.txtboxnums);
            this.gbinputting.Location = new System.Drawing.Point(108, 12);
            this.gbinputting.Name = "gbinputting";
            this.gbinputting.Size = new System.Drawing.Size(397, 162);
            this.gbinputting.TabIndex = 5;
            this.gbinputting.TabStop = false;
            this.gbinputting.Text = "ingreso de datos";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(250, 129);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "salir";
            this.btnexit.UseVisualStyleBackColor = true;

            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(250, 75);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 5;
            this.btnclean.Text = "limpiar";
            this.btnclean.UseVisualStyleBackColor = true;

            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(250, 19);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbinputdnumbers
            // 
            this.gbinputdnumbers.Controls.Add(this.lstinputdnums);
            this.gbinputdnumbers.Location = new System.Drawing.Point(531, 12);
            this.gbinputdnumbers.Name = "gbinputdnumbers";
            this.gbinputdnumbers.Size = new System.Drawing.Size(212, 162);
            this.gbinputdnumbers.TabIndex = 6;
            this.gbinputdnumbers.TabStop = false;
            this.gbinputdnumbers.Text = "numeros ingresados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbiggestnegative);
            this.groupBox1.Controls.Add(this.lblupdatednums);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 249);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lstbiggestnegative
            // 
            this.lstbiggestnegative.FormattingEnabled = true;
            this.lstbiggestnegative.Location = new System.Drawing.Point(19, 47);
            this.lstbiggestnegative.Name = "lstbiggestnegative";
            this.lstbiggestnegative.Size = new System.Drawing.Size(128, 186);
            this.lstbiggestnegative.TabIndex = 4;
            // 
            // lblupdatednums
            // 
            this.lblupdatednums.AutoSize = true;
            this.lblupdatednums.Location = new System.Drawing.Point(16, 16);
            this.lblupdatednums.Name = "lblupdatednums";
            this.lblupdatednums.Size = new System.Drawing.Size(138, 13);
            this.lblupdatednums.TabIndex = 1;
            this.lblupdatednums.Text = "numeros negativos mayores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstpositivenums);
            this.groupBox2.Controls.Add(this.lblpositivenums);
            this.groupBox2.Location = new System.Drawing.Point(218, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lstpositivenums
            // 
            this.lstpositivenums.FormattingEnabled = true;
            this.lstpositivenums.Location = new System.Drawing.Point(19, 47);
            this.lstpositivenums.Name = "lstpositivenums";
            this.lstpositivenums.Size = new System.Drawing.Size(128, 186);
            this.lstpositivenums.TabIndex = 4;
            // 
            // lblpositivenums
            // 
            this.lblpositivenums.AutoSize = true;
            this.lblpositivenums.Location = new System.Drawing.Point(25, 16);
            this.lblpositivenums.Name = "lblpositivenums";
            this.lblpositivenums.Size = new System.Drawing.Size(91, 13);
            this.lblpositivenums.TabIndex = 1;
            this.lblpositivenums.Text = "numeros positivos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstnegativeaverage);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(418, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 249);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lstnegativeaverage
            // 
            this.lstnegativeaverage.FormattingEnabled = true;
            this.lstnegativeaverage.Location = new System.Drawing.Point(19, 47);
            this.lstnegativeaverage.Name = "lstnegativeaverage";
            this.lstnegativeaverage.Size = new System.Drawing.Size(128, 186);
            this.lstnegativeaverage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "promedio numeros negativos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstporcentajenums);
            this.groupBox4.Controls.Add(this.lblporcentaje);
            this.groupBox4.Location = new System.Drawing.Point(623, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 249);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lstporcentajenums
            // 
            this.lstporcentajenums.FormattingEnabled = true;
            this.lstporcentajenums.Location = new System.Drawing.Point(19, 47);
            this.lstporcentajenums.Name = "lstporcentajenums";
            this.lstporcentajenums.Size = new System.Drawing.Size(128, 186);
            this.lstporcentajenums.TabIndex = 4;
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Location = new System.Drawing.Point(10, 16);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(137, 13);
            this.lblporcentaje.TabIndex = 1;
            this.lblporcentaje.Text = "porcentaje numeros y ceros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbinputdnumbers);
            this.Controls.Add(this.gbinputting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbinputting.ResumeLayout(false);
            this.gbinputting.PerformLayout();
            this.gbinputdnumbers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtboxnums;
        private System.Windows.Forms.ListBox lstinputdnums;
        private System.Windows.Forms.GroupBox gbinputting;
        private System.Windows.Forms.GroupBox gbinputdnumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbiggestnegative;
        private System.Windows.Forms.Label lblupdatednums;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstpositivenums;
        private System.Windows.Forms.Label lblpositivenums;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstnegativeaverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstporcentajenums;
        private System.Windows.Forms.Label lblporcentaje;
    }
}

