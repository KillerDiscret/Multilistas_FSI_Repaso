namespace EjercicioListas
{
    partial class FrmIngresoAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttiu = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lboxcursos = new System.Windows.Forms.ListBox();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cursos";
            // 
            // txttiu
            // 
            this.txttiu.Location = new System.Drawing.Point(60, 80);
            this.txttiu.Name = "txttiu";
            this.txttiu.Size = new System.Drawing.Size(133, 20);
            this.txttiu.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(60, 181);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // lboxcursos
            // 
            this.lboxcursos.FormattingEnabled = true;
            this.lboxcursos.Location = new System.Drawing.Point(303, 59);
            this.lboxcursos.Name = "lboxcursos";
            this.lboxcursos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxcursos.Size = new System.Drawing.Size(120, 173);
            this.lboxcursos.TabIndex = 5;
            // 
            // btnmatricular
            // 
            this.btnmatricular.Location = new System.Drawing.Point(101, 316);
            this.btnmatricular.Name = "btnmatricular";
            this.btnmatricular.Size = new System.Drawing.Size(92, 23);
            this.btnmatricular.TabIndex = 6;
            this.btnmatricular.Text = "MATRICULA";
            this.btnmatricular.UseVisualStyleBackColor = true;
            this.btnmatricular.Click += new System.EventHandler(this.btnmatricular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmIngresoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnmatricular);
            this.Controls.Add(this.lboxcursos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttiu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresoAlumno";
            this.Text = "FrmIngresoAlumno";
            this.Load += new System.EventHandler(this.FrmIngresoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttiu;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ListBox lboxcursos;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.Button button2;
    }
}