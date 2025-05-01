using Practica_Recuperacion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Recuperacion
{
    public partial class EstudianteData : Form
    {
        private Estudiantes F1;
        public EstudianteData(Estudiantes Form1)
        {
            InitializeComponent();
            F1 = Form1;
        }

        private void EstudianteData_FormClosing(object sender, FormClosingEventArgs e)
        {
            F1.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                
                var Matricula = new SqlParameter("@Matricula", TBMatricula.Text);
                var Nombre = new SqlParameter("@Nombre", TBNombre.Text);
                var Curso = new SqlParameter("@Curso", TBCurso.Text);
                var Telefono = new SqlParameter("@Telefono", TBTelefono.Text);

                db.Database.ExecuteSqlCommand(
                    "EXEC sp_InsertarEstudiante @Matricula, @Nombre, @Curso, @Telefono",
                    Matricula,
                    Nombre,
                    Curso,
                    Telefono
                    );
                MessageBox.Show("Guardado Correctamente");
            }
            F1.Refrescar();
            this.Close();
        }
    }
}
