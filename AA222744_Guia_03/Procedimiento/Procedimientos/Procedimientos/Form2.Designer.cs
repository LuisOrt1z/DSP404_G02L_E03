namespace Procedimientos
{
    partial class Form2
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
            this.gbInformacon = new System.Windows.Forms.GroupBox();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.gbInformacon.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacon
            // 
            this.gbInformacon.Controls.Add(this.cbtipoinfo);
            this.gbInformacon.Controls.Add(this.txtEdad);
            this.gbInformacon.Controls.Add(this.lbedad);
            this.gbInformacon.Controls.Add(this.Lbdig_info);
            this.gbInformacon.Controls.Add(this.Lbtipo_info);
            this.gbInformacon.Controls.Add(this.txtInfo);
            this.gbInformacon.Location = new System.Drawing.Point(25, 28);
            this.gbInformacon.Name = "gbInformacon";
            this.gbInformacon.Size = new System.Drawing.Size(264, 138);
            this.gbInformacon.TabIndex = 0;
            this.gbInformacon.TabStop = false;
            this.gbInformacon.Text = "Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.dgdatos);
            this.gbMatriz.Location = new System.Drawing.Point(25, 194);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(593, 224);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.btnSalir);
            this.gbMantenimiento.Controls.Add(this.btPromedio);
            this.gbMantenimiento.Controls.Add(this.btLimpiar);
            this.gbMantenimiento.Controls.Add(this.btMostrar);
            this.gbMantenimiento.Controls.Add(this.btAgregar);
            this.gbMantenimiento.Location = new System.Drawing.Point(318, 28);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(300, 138);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Tipo de información";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(138, 60);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(120, 22);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfo_KeyPress);
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(6, 31);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(126, 16);
            this.Lbtipo_info.TabIndex = 1;
            this.Lbtipo_info.Text = "Tipo de información";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(6, 66);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(128, 16);
            this.Lbdig_info.TabIndex = 2;
            this.Lbdig_info.Text = "Digite la información";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(6, 98);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(40, 16);
            this.lbedad.TabIndex = 3;
            this.lbedad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(138, 95);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(81, 22);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(138, 28);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(120, 24);
            this.cbtipoinfo.TabIndex = 5;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(19, 22);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(84, 32);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(169, 22);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(114, 32);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(19, 60);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(114, 32);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.Location = new System.Drawing.Point(169, 60);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(84, 32);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = true;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(19, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(18, 36);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.RowHeadersWidth = 51;
            this.dgdatos.RowTemplate.Height = 24;
            this.dgdatos.Size = new System.Drawing.Size(558, 169);
            this.dgdatos.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacon);
            this.Name = "Form2";
            this.Text = "Formulario";
            this.gbInformacon.ResumeLayout(false);
            this.gbInformacon.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacon;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
    }
}