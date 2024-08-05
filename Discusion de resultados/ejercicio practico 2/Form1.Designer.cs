namespace ejercicio_practico_2
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
            this.txtdimension = new System.Windows.Forms.TextBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.dgvmatrizoriginal = new System.Windows.Forms.DataGridView();
            this.lblingresar = new System.Windows.Forms.Label();
            this.dgvtraspuesta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizoriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraspuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdimension
            // 
            this.txtdimension.Location = new System.Drawing.Point(182, 49);
            this.txtdimension.Multiline = true;
            this.txtdimension.Name = "txtdimension";
            this.txtdimension.Size = new System.Drawing.Size(131, 27);
            this.txtdimension.TabIndex = 0;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(367, 53);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 23);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // dgvmatrizoriginal
            // 
            this.dgvmatrizoriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatrizoriginal.Location = new System.Drawing.Point(26, 160);
            this.dgvmatrizoriginal.Name = "dgvmatrizoriginal";
            this.dgvmatrizoriginal.Size = new System.Drawing.Size(356, 150);
            this.dgvmatrizoriginal.TabIndex = 2;
            // 
            // lblingresar
            // 
            this.lblingresar.AutoSize = true;
            this.lblingresar.Location = new System.Drawing.Point(304, 9);
            this.lblingresar.Name = "lblingresar";
            this.lblingresar.Size = new System.Drawing.Size(162, 13);
            this.lblingresar.TabIndex = 3;
            this.lblingresar.Text = "Ingrese la dimension de su matriz";
            // 
            // dgvtraspuesta
            // 
            this.dgvtraspuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtraspuesta.Location = new System.Drawing.Point(418, 160);
            this.dgvtraspuesta.Name = "dgvtraspuesta";
            this.dgvtraspuesta.Size = new System.Drawing.Size(359, 150);
            this.dgvtraspuesta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "matriz original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "matriz transpuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtraspuesta);
            this.Controls.Add(this.lblingresar);
            this.Controls.Add(this.dgvmatrizoriginal);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtdimension);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizoriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraspuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdimension;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.DataGridView dgvmatrizoriginal;
        private System.Windows.Forms.Label lblingresar;
        private System.Windows.Forms.DataGridView dgvtraspuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

