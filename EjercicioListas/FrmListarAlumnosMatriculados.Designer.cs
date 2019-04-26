namespace EjercicioListas
{
    partial class FrmListarAlumnosMatriculados
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
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxcursos = new System.Windows.Forms.ListBox();
            this.lboxalumnos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(41, 23);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(39, 13);
            this.lb.TabIndex = 0;
            this.lb.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumnos Matriculados";
            // 
            // lboxcursos
            // 
            this.lboxcursos.FormattingEnabled = true;
            this.lboxcursos.Location = new System.Drawing.Point(44, 55);
            this.lboxcursos.Name = "lboxcursos";
            this.lboxcursos.Size = new System.Drawing.Size(120, 160);
            this.lboxcursos.TabIndex = 2;
            this.lboxcursos.SelectedIndexChanged += new System.EventHandler(this.lboxcursos_SelectedIndexChanged);
            // 
            // lboxalumnos
            // 
            this.lboxalumnos.FormattingEnabled = true;
            this.lboxalumnos.Location = new System.Drawing.Point(220, 55);
            this.lboxalumnos.Name = "lboxalumnos";
            this.lboxalumnos.Size = new System.Drawing.Size(120, 160);
            this.lboxalumnos.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmListarAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxalumnos);
            this.Controls.Add(this.lboxcursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Name = "FrmListarAlumnosMatriculados";
            this.Text = "FrmListarAlumnosMatriculados";
            this.Load += new System.EventHandler(this.FrmListarAlumnosMatriculados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxcursos;
        private System.Windows.Forms.ListBox lboxalumnos;
        private System.Windows.Forms.Button button1;
    }
}