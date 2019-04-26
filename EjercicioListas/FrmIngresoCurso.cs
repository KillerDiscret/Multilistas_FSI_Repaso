using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListas
{
    
    public partial class FrmIngresoCurso : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();


        public FrmIngresoCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!objmatricula.CursoExiste(textcodcurso.Text))
            {
                CCurso curso = new CCurso();
                curso.Codigo = textcodcurso.Text;
                curso.Nombre = txtBoxNombre.Text;
                objmatricula.InsertarCurso(curso);

            }
            txtBoxNombre.Clear();
            textcodcurso.Clear();
            textcodcurso.Focus();


        }
    }
}
