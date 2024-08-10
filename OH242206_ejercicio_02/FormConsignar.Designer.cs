namespace ejercicio_2
{
    partial class FormConsignar
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblConsigar = new System.Windows.Forms.Label();
            this.txtCantidadConsigacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 79);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(21, 79);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblConsigar
            // 
            this.lblConsigar.AutoSize = true;
            this.lblConsigar.Location = new System.Drawing.Point(55, 9);
            this.lblConsigar.Name = "lblConsigar";
            this.lblConsigar.Size = new System.Drawing.Size(155, 13);
            this.lblConsigar.TabIndex = 5;
            this.lblConsigar.Text = "Ingrese la cantidad a consignar";
            // 
            // txtCantidadConsigacion
            // 
            this.txtCantidadConsigacion.Location = new System.Drawing.Point(39, 37);
            this.txtCantidadConsigacion.Multiline = true;
            this.txtCantidadConsigacion.Name = "txtCantidadConsigacion";
            this.txtCantidadConsigacion.Size = new System.Drawing.Size(190, 24);
            this.txtCantidadConsigacion.TabIndex = 4;
            // 
            // FormConsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 121);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblConsigar);
            this.Controls.Add(this.txtCantidadConsigacion);
            this.Name = "FormConsignar";
            this.Text = "Consignacion";
            this.Load += new System.EventHandler(this.FormConsignar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblConsigar;
        private System.Windows.Forms.TextBox txtCantidadConsigacion;
    }
}