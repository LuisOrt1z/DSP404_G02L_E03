namespace ejercicio_2
{
    partial class FormTransferencia
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
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.txtCantidadTransferencia = new System.Windows.Forms.TextBox();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(155, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Location = new System.Drawing.Point(55, 68);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(149, 13);
            this.lblTransferencia.TabIndex = 5;
            this.lblTransferencia.Text = "Ingrese la cantidad a transferir";
            // 
            // txtCantidadTransferencia
            // 
            this.txtCantidadTransferencia.Location = new System.Drawing.Point(34, 96);
            this.txtCantidadTransferencia.Multiline = true;
            this.txtCantidadTransferencia.Name = "txtCantidadTransferencia";
            this.txtCantidadTransferencia.Size = new System.Drawing.Size(190, 24);
            this.txtCantidadTransferencia.TabIndex = 4;
            // 
            // lblCuentaDestino
            // 
            this.lblCuentaDestino.AutoSize = true;
            this.lblCuentaDestino.Location = new System.Drawing.Point(65, 9);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(126, 13);
            this.lblCuentaDestino.TabIndex = 9;
            this.lblCuentaDestino.Text = "Ingrese la cuenta destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(34, 37);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(190, 24);
            this.txtDestino.TabIndex = 8;
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 185);
            this.Controls.Add(this.lblCuentaDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTransferencia);
            this.Controls.Add(this.txtCantidadTransferencia);
            this.Name = "FormTransferencia";
            this.Text = "FormTransferencia";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblCuentaDestino;
        public System.Windows.Forms.TextBox txtDestino;
        public System.Windows.Forms.TextBox txtCantidadTransferencia;
    }
}