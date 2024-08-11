namespace ejercicio_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblnumCuenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtSalir = new System.Windows.Forms.RadioButton();
            this.rbtTransferencia = new System.Windows.Forms.RadioButton();
            this.rbtConsignacion = new System.Windows.Forms.RadioButton();
            this.rbtRetiro = new System.Windows.Forms.RadioButton();
            this.rbtConsulta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 127);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 454);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(186, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 425);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.lblnumCuenta);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            // 
            // lblnumCuenta
            // 
            this.lblnumCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblnumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblnumCuenta.Location = new System.Drawing.Point(21, 51);
            this.lblnumCuenta.Name = "lblnumCuenta";
            this.lblnumCuenta.Size = new System.Drawing.Size(144, 23);
            this.lblnumCuenta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtSalir);
            this.groupBox1.Controls.Add(this.rbtTransferencia);
            this.groupBox1.Controls.Add(this.rbtConsignacion);
            this.groupBox1.Controls.Add(this.rbtRetiro);
            this.groupBox1.Controls.Add(this.rbtConsulta);
            this.groupBox1.Location = new System.Drawing.Point(34, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(181, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menú de opciones";
            // 
            // rbtSalir
            // 
            this.rbtSalir.AutoSize = true;
            this.rbtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtSalir.Location = new System.Drawing.Point(399, 138);
            this.rbtSalir.Name = "rbtSalir";
            this.rbtSalir.Size = new System.Drawing.Size(54, 21);
            this.rbtSalir.TabIndex = 4;
            this.rbtSalir.TabStop = true;
            this.rbtSalir.Text = "Salir";
            this.rbtSalir.UseVisualStyleBackColor = true;
            this.rbtSalir.CheckedChanged += new System.EventHandler(this.rbtSalir_CheckedChanged);
            // 
            // rbtTransferencia
            // 
            this.rbtTransferencia.AutoSize = true;
            this.rbtTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtTransferencia.Location = new System.Drawing.Point(205, 178);
            this.rbtTransferencia.Name = "rbtTransferencia";
            this.rbtTransferencia.Size = new System.Drawing.Size(121, 21);
            this.rbtTransferencia.TabIndex = 3;
            this.rbtTransferencia.TabStop = true;
            this.rbtTransferencia.Text = "Transferencias";
            this.rbtTransferencia.UseVisualStyleBackColor = true;
            this.rbtTransferencia.CheckedChanged += new System.EventHandler(this.rbtTransferencia_CheckedChanged);
            // 
            // rbtConsignacion
            // 
            this.rbtConsignacion.AutoSize = true;
            this.rbtConsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtConsignacion.Location = new System.Drawing.Point(15, 178);
            this.rbtConsignacion.Name = "rbtConsignacion";
            this.rbtConsignacion.Size = new System.Drawing.Size(126, 21);
            this.rbtConsignacion.TabIndex = 2;
            this.rbtConsignacion.TabStop = true;
            this.rbtConsignacion.Text = "Consignaciones";
            this.rbtConsignacion.UseVisualStyleBackColor = true;
            this.rbtConsignacion.CheckedChanged += new System.EventHandler(this.rbtConsignacion_CheckedChanged);
            // 
            // rbtRetiro
            // 
            this.rbtRetiro.AutoSize = true;
            this.rbtRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtRetiro.Location = new System.Drawing.Point(205, 70);
            this.rbtRetiro.Name = "rbtRetiro";
            this.rbtRetiro.Size = new System.Drawing.Size(131, 21);
            this.rbtRetiro.TabIndex = 1;
            this.rbtRetiro.TabStop = true;
            this.rbtRetiro.Text = "Retiro de fondos";
            this.rbtRetiro.UseVisualStyleBackColor = true;
            this.rbtRetiro.CheckedChanged += new System.EventHandler(this.rbtRetiro_CheckedChanged);
            // 
            // rbtConsulta
            // 
            this.rbtConsulta.AutoSize = true;
            this.rbtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtConsulta.Location = new System.Drawing.Point(15, 70);
            this.rbtConsulta.Name = "rbtConsulta";
            this.rbtConsulta.Size = new System.Drawing.Size(135, 21);
            this.rbtConsulta.TabIndex = 0;
            this.rbtConsulta.TabStop = true;
            this.rbtConsulta.Text = "Consula de saldo";
            this.rbtConsulta.UseVisualStyleBackColor = true;
            this.rbtConsulta.CheckedChanged += new System.EventHandler(this.rbtConsulta_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de cuenta:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtConsulta;
        private System.Windows.Forms.RadioButton rbtRetiro;
        private System.Windows.Forms.RadioButton rbtConsignacion;
        private System.Windows.Forms.RadioButton rbtTransferencia;
        private System.Windows.Forms.RadioButton rbtSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnumCuenta;
    }
}