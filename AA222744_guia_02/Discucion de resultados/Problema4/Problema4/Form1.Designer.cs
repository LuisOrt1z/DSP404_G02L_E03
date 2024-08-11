namespace Problema4
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNativa = new System.Windows.Forms.ComboBox();
            this.cmbExtranjera = new System.Windows.Forms.ComboBox();
            this.btnIntercambio = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNativa = new System.Windows.Forms.Label();
            this.lblEstranjera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 63);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 22);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde la divisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "A la divisa";
            // 
            // cmbNativa
            // 
            this.cmbNativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNativa.FormattingEnabled = true;
            this.cmbNativa.Items.AddRange(new object[] {
            "Dólar estadounidense",
            "Euro",
            "Yen japonés",
            "Libra esterlina",
            "Franco suizo"});
            this.cmbNativa.Location = new System.Drawing.Point(183, 61);
            this.cmbNativa.Name = "cmbNativa";
            this.cmbNativa.Size = new System.Drawing.Size(171, 24);
            this.cmbNativa.TabIndex = 4;
            this.cmbNativa.SelectedIndexChanged += new System.EventHandler(this.cmbNativa_SelectedIndexChanged);
            // 
            // cmbExtranjera
            // 
            this.cmbExtranjera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtranjera.FormattingEnabled = true;
            this.cmbExtranjera.Items.AddRange(new object[] {
            "Dólar estadounidense",
            "Euro",
            "Yen japonés",
            "Libra esterlina",
            "Franco suizo"});
            this.cmbExtranjera.Location = new System.Drawing.Point(426, 61);
            this.cmbExtranjera.Name = "cmbExtranjera";
            this.cmbExtranjera.Size = new System.Drawing.Size(171, 24);
            this.cmbExtranjera.TabIndex = 5;
            this.cmbExtranjera.SelectedIndexChanged += new System.EventHandler(this.cmbExtranjera_SelectedIndexChanged);
            // 
            // btnIntercambio
            // 
            this.btnIntercambio.Location = new System.Drawing.Point(360, 47);
            this.btnIntercambio.Name = "btnIntercambio";
            this.btnIntercambio.Size = new System.Drawing.Size(60, 50);
            this.btnIntercambio.TabIndex = 6;
            this.btnIntercambio.Text = "->\r\n<-";
            this.btnIntercambio.UseVisualStyleBackColor = true;
            this.btnIntercambio.Click += new System.EventHandler(this.btnIntercambio_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(180, 116);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(266, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 36);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNativa
            // 
            this.lblNativa.AutoSize = true;
            this.lblNativa.Location = new System.Drawing.Point(310, 24);
            this.lblNativa.Name = "lblNativa";
            this.lblNativa.Size = new System.Drawing.Size(0, 16);
            this.lblNativa.TabIndex = 10;
            // 
            // lblEstranjera
            // 
            this.lblEstranjera.AutoSize = true;
            this.lblEstranjera.Location = new System.Drawing.Point(553, 24);
            this.lblEstranjera.Name = "lblEstranjera";
            this.lblEstranjera.Size = new System.Drawing.Size(0, 16);
            this.lblEstranjera.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 232);
            this.Controls.Add(this.lblEstranjera);
            this.Controls.Add(this.lblNativa);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnIntercambio);
            this.Controls.Add(this.cmbExtranjera);
            this.Controls.Add(this.cmbNativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Form1";
            this.Text = "Conversor de monedas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNativa;
        private System.Windows.Forms.ComboBox cmbExtranjera;
        private System.Windows.Forms.Button btnIntercambio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNativa;
        private System.Windows.Forms.Label lblEstranjera;
    }
}

