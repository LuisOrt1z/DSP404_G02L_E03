namespace parte3_Guia5
{
    partial class frmRegistroEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.LbIfechanac = new System.Windows.Forms.Label();
            this.LbIapellidos = new System.Windows.Forms.Label();
            this.LbInombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.IbIIsss = new System.Windows.Forms.Label();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.IbIRenta = new System.Windows.Forms.Label();
            this.IbISueldo = new System.Windows.Forms.Label();
            this.IbIContrato = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.LbIfechanac);
            this.groupBox1.Controls.Add(this.LbIapellidos);
            this.groupBox1.Controls.Add(this.LbInombres);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(443, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de empleados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(168, 137);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(169, 92);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 22);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(169, 50);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(132, 22);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // LbIfechanac
            // 
            this.LbIfechanac.AutoSize = true;
            this.LbIfechanac.Location = new System.Drawing.Point(36, 138);
            this.LbIfechanac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbIfechanac.Name = "LbIfechanac";
            this.LbIfechanac.Size = new System.Drawing.Size(123, 17);
            this.LbIfechanac.TabIndex = 2;
            this.LbIfechanac.Text = "Fecha nacimiento:";
            // 
            // LbIapellidos
            // 
            this.LbIapellidos.AutoSize = true;
            this.LbIapellidos.Location = new System.Drawing.Point(36, 92);
            this.LbIapellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbIapellidos.Name = "LbIapellidos";
            this.LbIapellidos.Size = new System.Drawing.Size(69, 17);
            this.LbIapellidos.TabIndex = 1;
            this.LbIapellidos.Text = "Apellidos:";
            // 
            // LbInombres
            // 
            this.LbInombres.AutoSize = true;
            this.LbInombres.Location = new System.Drawing.Point(36, 50);
            this.LbInombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbInombres.Name = "LbInombres";
            this.LbInombres.Size = new System.Drawing.Size(69, 17);
            this.LbInombres.TabIndex = 0;
            this.LbInombres.Text = "Nombres:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.IbIIsss);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.IbIRenta);
            this.groupBox2.Controls.Add(this.IbISueldo);
            this.groupBox2.Controls.Add(this.IbIContrato);
            this.groupBox2.Location = new System.Drawing.Point(481, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(571, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos laborales";
            // 
            // nudISSS
            // 
            this.nudISSS.Location = new System.Drawing.Point(411, 142);
            this.nudISSS.Margin = new System.Windows.Forms.Padding(4);
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(160, 22);
            this.nudISSS.TabIndex = 7;
            this.nudISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudISSS_KeyPress);
            // 
            // IbIIsss
            // 
            this.IbIIsss.AutoSize = true;
            this.IbIIsss.Location = new System.Drawing.Point(321, 144);
            this.IbIIsss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbIIsss.Name = "IbIIsss";
            this.IbIIsss.Size = new System.Drawing.Size(78, 17);
            this.IbIIsss.TabIndex = 6;
            this.IbIIsss.Text = "Tasa ISSS:";
            // 
            // nudRenta
            // 
            this.nudRenta.Location = new System.Drawing.Point(143, 135);
            this.nudRenta.Margin = new System.Windows.Forms.Padding(4);
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(160, 22);
            this.nudRenta.TabIndex = 5;
            this.nudRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudRenta_KeyPress);
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(179, 89);
            this.txtSueldoini.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(132, 22);
            this.txtSueldoini.TabIndex = 4;
            this.txtSueldoini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoini_KeyPress);
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(179, 38);
            this.dtpFechaContrato.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaContrato.TabIndex = 3;
            // 
            // IbIRenta
            // 
            this.IbIRenta.AutoSize = true;
            this.IbIRenta.Location = new System.Drawing.Point(47, 138);
            this.IbIRenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbIRenta.Name = "IbIRenta";
            this.IbIRenta.Size = new System.Drawing.Size(86, 17);
            this.IbIRenta.TabIndex = 2;
            this.IbIRenta.Text = "Tasa Renta:";
            // 
            // IbISueldo
            // 
            this.IbISueldo.AutoSize = true;
            this.IbISueldo.Location = new System.Drawing.Point(47, 92);
            this.IbISueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbISueldo.Name = "IbISueldo";
            this.IbISueldo.Size = new System.Drawing.Size(91, 17);
            this.IbISueldo.TabIndex = 1;
            this.IbISueldo.Text = "Sueldo base:";
            // 
            // IbIContrato
            // 
            this.IbIContrato.AutoSize = true;
            this.IbIContrato.Location = new System.Drawing.Point(47, 47);
            this.IbIContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbIContrato.Name = "IbIContrato";
            this.IbIContrato.Size = new System.Drawing.Size(107, 17);
            this.IbIContrato.TabIndex = 0;
            this.IbIContrato.Text = "Fecha contrato:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 256);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(172, 47);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(276, 256);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 47);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Proximo Empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(481, 256);
            this.btnAbrirPlanilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(164, 47);
            this.btnAbrirPlanilla.TabIndex = 4;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(708, 256);
            this.btnGenerarPlanilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(180, 47);
            this.btnGenerarPlanilla.TabIndex = 5;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 342);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(991, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmRegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistroEmpleados";
            this.Text = "Registro inicial de empleados";
            this.Load += new System.EventHandler(this.frmRegistroEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label LbIfechanac;
        private System.Windows.Forms.Label LbIapellidos;
        private System.Windows.Forms.Label LbInombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.Label IbIIsss;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Label IbIRenta;
        private System.Windows.Forms.Label IbISueldo;
        private System.Windows.Forms.Label IbIContrato;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

