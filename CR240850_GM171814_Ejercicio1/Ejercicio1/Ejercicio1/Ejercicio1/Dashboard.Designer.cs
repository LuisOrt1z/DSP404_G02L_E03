namespace Ejercicio1
{
    partial class Dashboard
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
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(697, 517);
            this.Name = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEntretenimiento;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabProgra;
        private System.Windows.Forms.TabPage tabGraficas;
        private System.Windows.Forms.Label txtNombre;
    }
}