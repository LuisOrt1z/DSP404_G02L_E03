namespace Problema3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstPositivos = new System.Windows.Forms.ListBox();
            this.lstNegativos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstPreguntas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVacPositivos = new System.Windows.Forms.Button();
            this.btnVacNegativos = new System.Windows.Forms.Button();
            this.btnVacLista = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblRestantes = new System.Windows.Forms.Label();
            this.lstRespuestas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa numeros:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 54);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 27);
            this.txtNumero.TabIndex = 1;
            // 
            // lstPositivos
            // 
            this.lstPositivos.FormattingEnabled = true;
            this.lstPositivos.ItemHeight = 20;
            this.lstPositivos.Items.AddRange(new object[] {
            "(Lista numeros positivos)"});
            this.lstPositivos.Location = new System.Drawing.Point(21, 169);
            this.lstPositivos.Name = "lstPositivos";
            this.lstPositivos.Size = new System.Drawing.Size(281, 124);
            this.lstPositivos.TabIndex = 2;
            // 
            // lstNegativos
            // 
            this.lstNegativos.FormattingEnabled = true;
            this.lstNegativos.ItemHeight = 20;
            this.lstNegativos.Items.AddRange(new object[] {
            "(Lista numeros negativos)"});
            this.lstNegativos.Location = new System.Drawing.Point(337, 169);
            this.lstNegativos.Name = "lstNegativos";
            this.lstNegativos.Size = new System.Drawing.Size(286, 124);
            this.lstNegativos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(158, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 29);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar numero";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstPreguntas
            // 
            this.lstPreguntas.FormattingEnabled = true;
            this.lstPreguntas.ItemHeight = 20;
            this.lstPreguntas.Items.AddRange(new object[] {
            "(Incógnita)"});
            this.lstPreguntas.Location = new System.Drawing.Point(21, 350);
            this.lstPreguntas.Name = "lstPreguntas";
            this.lstPreguntas.Size = new System.Drawing.Size(323, 44);
            this.lstPreguntas.TabIndex = 5;
            this.lstPreguntas.SelectedIndexChanged += new System.EventHandler(this.lstPreguntas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numeros positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numeros negativos";
            // 
            // btnVacPositivos
            // 
            this.btnVacPositivos.Enabled = false;
            this.btnVacPositivos.Location = new System.Drawing.Point(159, 122);
            this.btnVacPositivos.Name = "btnVacPositivos";
            this.btnVacPositivos.Size = new System.Drawing.Size(143, 29);
            this.btnVacPositivos.TabIndex = 8;
            this.btnVacPositivos.Text = "Vaciar positivos";
            this.btnVacPositivos.UseVisualStyleBackColor = true;
            this.btnVacPositivos.Click += new System.EventHandler(this.btnVacPositivos_Click);
            // 
            // btnVacNegativos
            // 
            this.btnVacNegativos.Enabled = false;
            this.btnVacNegativos.Location = new System.Drawing.Point(480, 122);
            this.btnVacNegativos.Name = "btnVacNegativos";
            this.btnVacNegativos.Size = new System.Drawing.Size(143, 29);
            this.btnVacNegativos.TabIndex = 9;
            this.btnVacNegativos.Text = "Vaciar negativos";
            this.btnVacNegativos.UseVisualStyleBackColor = true;
            this.btnVacNegativos.Click += new System.EventHandler(this.btnVacNegativos_Click);
            // 
            // btnVacLista
            // 
            this.btnVacLista.Enabled = false;
            this.btnVacLista.Location = new System.Drawing.Point(480, 50);
            this.btnVacLista.Name = "btnVacLista";
            this.btnVacLista.Size = new System.Drawing.Size(143, 37);
            this.btnVacLista.TabIndex = 10;
            this.btnVacLista.Text = "Vaciar todo";
            this.btnVacLista.UseVisualStyleBackColor = true;
            this.btnVacLista.Click += new System.EventHandler(this.btnVacLista_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAviso.Location = new System.Drawing.Point(98, 312);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 11;
            this.lblAviso.Text = "label4";
            // 
            // lblRestantes
            // 
            this.lblRestantes.AutoSize = true;
            this.lblRestantes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRestantes.Location = new System.Drawing.Point(159, 19);
            this.lblRestantes.Name = "lblRestantes";
            this.lblRestantes.Size = new System.Drawing.Size(50, 20);
            this.lblRestantes.TabIndex = 12;
            this.lblRestantes.Text = "label5";
            // 
            // lstRespuestas
            // 
            this.lstRespuestas.FormattingEnabled = true;
            this.lstRespuestas.ItemHeight = 20;
            this.lstRespuestas.Items.AddRange(new object[] {
            "(Resultado)"});
            this.lstRespuestas.Location = new System.Drawing.Point(350, 350);
            this.lstRespuestas.Name = "lstRespuestas";
            this.lstRespuestas.Size = new System.Drawing.Size(273, 44);
            this.lstRespuestas.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(225, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 43);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir del programa";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 473);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstRespuestas);
            this.Controls.Add(this.lblRestantes);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnVacLista);
            this.Controls.Add(this.btnVacNegativos);
            this.Controls.Add(this.btnVacPositivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPreguntas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstNegativos);
            this.Controls.Add(this.lstPositivos);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Incógnitas de numeros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private ListBox lstPositivos;
        private ListBox lstNegativos;
        private Button btnAgregar;
        private ListBox lstPreguntas;
        private Label label2;
        private Label label3;
        private Button btnVacPositivos;
        private Button btnVacNegativos;
        private Button btnVacLista;
        private Label lblAviso;
        private Label lblRestantes;
        private ListBox lstRespuestas;
        private Label label6;
        private Button btnSalir;
    }
}