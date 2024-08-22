namespace form2
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
            lblEmpresa = new Label();
            lblMonto = new Label();
            txtEmpresa = new TextBox();
            txtMonto = new TextBox();
            txtTiempo = new TextBox();
            lblTiempo = new Label();
            rdbInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            txtTasaInterEX = new TextBox();
            lstResul = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            lblTasaInter = new Label();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(64, 49);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(118, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de empresa:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(64, 138);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(113, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto prestamo ($)";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(188, 49);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(482, 23);
            txtEmpresa.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(179, 130);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(154, 23);
            txtMonto.TabIndex = 3;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(479, 135);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(191, 23);
            txtTiempo.TabIndex = 4;
            txtTiempo.Text = "2";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(376, 138);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(83, 15);
            lblTiempo.TabIndex = 5;
            lblTiempo.Text = "Tiempo (años)";
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Checked = true;
            rdbInteres1.Location = new Point(66, 221);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(47, 19);
            rdbInteres1.TabIndex = 6;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12%";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.CheckedChanged += rdbInteres1_CheckedChanged;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(179, 221);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(56, 19);
            rdbInteres2.TabIndex = 7;
            rdbInteres2.TabStop = true;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(308, 221);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(96, 19);
            rdbInteres3.TabIndex = 8;
            rdbInteres3.TabStop = true;
            rdbInteres3.Text = "otro, indique:";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(410, 220);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(166, 23);
            txtTasaInterEX.TabIndex = 9;
            txtTasaInterEX.Text = "0";
            // 
            // lstResul
            // 
            lstResul.Enabled = false;
            lstResul.FormattingEnabled = true;
            lstResul.ItemHeight = 15;
            lstResul.Location = new Point(66, 283);
            lstResul.Name = "lstResul";
            lstResul.Size = new Size(604, 109);
            lstResul.TabIndex = 10;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(166, 416);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(121, 23);
            btnAnalisis.TabIndex = 11;
            btnAnalisis.Text = "Analisis financiero";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(428, 416);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(125, 23);
            btnFin.TabIndex = 12;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.Location = new Point(64, 191);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(81, 15);
            lblTasaInter.TabIndex = 13;
            lblTasaInter.Text = "Tasa intereses:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTasaInter);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lstResul);
            Controls.Add(txtTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rdbInteres1);
            Controls.Add(lblTiempo);
            Controls.Add(txtTiempo);
            Controls.Add(txtMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpresa);
            Name = "Form1";
            Text = "calculo del monto a pagar por un prestamo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private Label lblMonto;
        private TextBox txtEmpresa;
        private TextBox txtMonto;
        private TextBox txtTiempo;
        private Label lblTiempo;
        private RadioButton rdbInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox txtTasaInterEX;
        private ListBox lstResul;
        private Button btnAnalisis;
        private Button btnFin;
        private Label lblTasaInter;
    }
}
