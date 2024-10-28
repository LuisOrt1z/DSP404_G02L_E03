namespace DiscucionDeesultados
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
            this.bynAgregarNota = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bynAgregarNota
            // 
            this.bynAgregarNota.Location = new System.Drawing.Point(185, 21);
            this.bynAgregarNota.Name = "bynAgregarNota";
            this.bynAgregarNota.Size = new System.Drawing.Size(84, 23);
            this.bynAgregarNota.TabIndex = 0;
            this.bynAgregarNota.Text = "Agregar Nota";
            this.bynAgregarNota.UseVisualStyleBackColor = true;
            this.bynAgregarNota.Click += new System.EventHandler(this.bynAgregarNota_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular Estadisticas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(68, 21);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 2;
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.Location = new System.Drawing.Point(68, 69);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(120, 186);
            this.listBoxNotas.TabIndex = 3;
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.Location = new System.Drawing.Point(231, 69);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(120, 186);
            this.listBoxResultados.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 289);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.listBoxNotas);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bynAgregarNota);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bynAgregarNota;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.ListBox listBoxResultados;
    }
}