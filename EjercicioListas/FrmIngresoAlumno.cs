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
    public partial class FrmIngresoAlumno : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();


        public FrmIngresoAlumno()
        {
            InitializeComponent();
        }

        private void FrmIngresoAlumno_Load(object sender, EventArgs e)
        {
            //lo puesto entre comillas " " es el atributo de la clase
            lboxcursos.DisplayMember = "Nombre";
            lboxcursos.ValueMember = "Codigo";
            //le decimos de donde estamos sacando esos valores para ponerlos en el listbox
            lboxcursos.DataSource = CMatriculaUPC.Cursos;
            lboxcursos.SelectedIndex = -1;
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {
            CAlumno alumno = new CAlumno();
            alumno.TIU = Convert.ToInt32(txttiu.Text);
            alumno.NombreCompleto = txtnombre.Text;
            foreach (CCurso curso in lboxcursos.SelectedItems)
            {
                objmatricula.InsertarAlumnoEnCurso(curso.Codigo, alumno);
            }
            txttiu.Clear();
            txtnombre.Clear();
            lboxcursos.SelectedIndex = -1;
            txttiu.Focus();
        }
    }
}
