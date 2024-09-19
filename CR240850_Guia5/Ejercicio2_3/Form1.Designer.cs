namespace Ejercicio2
{
    partial class frmRegistoEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lblnombres = new System.Windows.Forms.Label();
            this.Lblapellidos = new System.Windows.Forms.Label();
            this.lblfechanac = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblRenta = new System.Windows.Forms.Label();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.lblISSS = new System.Windows.Forms.Label();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblfechanac);
            this.groupBox1.Controls.Add(this.Lblapellidos);
            this.groupBox1.Controls.Add(this.Lblnombres);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales de los empleados";
            // 
            // Lblnombres
            // 
            this.Lblnombres.AutoSize = true;
            this.Lblnombres.Location = new System.Drawing.Point(7, 36);
            this.Lblnombres.Name = "Lblnombres";
            this.Lblnombres.Size = new System.Drawing.Size(66, 16);
            this.Lblnombres.TabIndex = 0;
            this.Lblnombres.Text = "Nombres:";
            // 
            // Lblapellidos
            // 
            this.Lblapellidos.AutoSize = true;
            this.Lblapellidos.Location = new System.Drawing.Point(7, 82);
            this.Lblapellidos.Name = "Lblapellidos";
            this.Lblapellidos.Size = new System.Drawing.Size(67, 16);
            this.Lblapellidos.TabIndex = 1;
            this.Lblapellidos.Text = "Apellidos:";
            // 
            // lblfechanac
            // 
            this.lblfechanac.AutoSize = true;
            this.lblfechanac.Location = new System.Drawing.Point(7, 131);
            this.lblfechanac.Name = "lblfechanac";
            this.lblfechanac.Size = new System.Drawing.Size(116, 16);
            this.lblfechanac.TabIndex = 2;
            this.lblfechanac.Text = "Fecha nacimiento:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(122, 30);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(171, 22);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(122, 76);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(171, 22);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(140, 125);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.lblISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.lblContrato);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Location = new System.Drawing.Point(401, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro inicial de empleados";
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(122, 30);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(242, 22);
            this.dtpFechaContrato.TabIndex = 5;
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(122, 79);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(171, 22);
            this.txtSueldoini.TabIndex = 3;
            this.txtSueldoini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoini_KeyPress);
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(7, 36);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(101, 16);
            this.lblContrato.TabIndex = 2;
            this.lblContrato.Text = "Fecha Contrato:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(7, 82);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(87, 16);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo base:";
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(7, 131);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(75, 16);
            this.lblRenta.TabIndex = 0;
            this.lblRenta.Text = "Tasa renta:";
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(89, 124);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(82, 22);
            this.nudRenta.TabIndex = 6;
            this.nudRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudRenta_KeyPress);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(212, 128);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(75, 16);
            this.lblISSS.TabIndex = 7;
            this.lblISSS.Text = "Tasa ISSS:";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(293, 125);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(88, 22);
            this.nudISSS.TabIndex = 8;
            this.nudISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudISSS_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 189);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 41);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo Empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(212, 188);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 41);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Proximo Empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(426, 189);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(155, 41);
            this.btnAbrirPlanilla.TabIndex = 9;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(627, 189);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(155, 41);
            this.btnGenerarPlanilla.TabIndex = 10;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 240);
            this.dataGridView1.TabIndex = 11;
            // 
            // frmRegistoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistoEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRegistoEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblfechanac;
        private System.Windows.Forms.Label Lblapellidos;
        private System.Windows.Forms.Label Lblnombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}