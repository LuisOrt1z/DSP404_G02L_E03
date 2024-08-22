namespace Guia1_DSP
{
    partial class Form3
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
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCUM = new System.Windows.Forms.Label();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(28, 27);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(82, 16);
            this.lblApe1.TabIndex = 0;
            this.lblApe1.Text = "1er Apellido:";
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(28, 68);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(86, 16);
            this.lblApe2.TabIndex = 1;
            this.lblApe2.Text = "2do Apellido:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(28, 110);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(63, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombres";
            // 
            // lblCUM
            // 
            this.lblCUM.AutoSize = true;
            this.lblCUM.Location = new System.Drawing.Point(31, 150);
            this.lblCUM.Name = "lblCUM";
            this.lblCUM.Size = new System.Drawing.Size(91, 16);
            this.lblCUM.TabIndex = 3;
            this.lblCUM.Text = "Valor de CUM";
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(130, 21);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(214, 22);
            this.txtApe1.TabIndex = 4;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(130, 62);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(214, 22);
            this.txtApe2.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 104);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(214, 22);
            this.txtNom.TabIndex = 6;
            // 
            // txtCUM
            // 
            this.txtCUM.Location = new System.Drawing.Point(130, 144);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(214, 22);
            this.txtCUM.TabIndex = 7;
            this.txtCUM.Text = "0.0";
            // 
            // txtResul
            // 
            this.txtResul.Enabled = false;
            this.txtResul.Location = new System.Drawing.Point(31, 193);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(313, 22);
            this.txtResul.TabIndex = 8;
            this.txtResul.Text = "Resultado de evaluacion\r\n";
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(34, 234);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(126, 48);
            this.btnAnalisis.TabIndex = 9;
            this.btnAnalisis.Text = "Calcular UV";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(202, 234);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(127, 48);
            this.btnFin.TabIndex = 10;
            this.btnFin.Text = "Salir del\r\nprograma";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 308);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtCUM);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.lblCUM);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCUM;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}