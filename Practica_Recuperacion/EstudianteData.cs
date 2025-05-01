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
        public int? id;
        Estudiante temp;
        public EstudianteData(Estudiantes Form1, int? id = null)
        {
            InitializeComponent();
            F1 = Form1;
            this.id = id;
            if (id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {

                temp = db.Estudiantes.Find(id);
                TBMatricula.Text = temp.Matricula;
                TBNombre.Text = temp.Nombre;
                TBCurso.Text = temp.Curso;
                TBTelefono.Text = temp.Telefono;
            }
        }

        private void EstudianteData_FormClosing(object sender, FormClosingEventArgs e)
        {
            F1.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                if (id == null)
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
                else
                {
                    var Estudiante_UID = new SqlParameter("@Estudiante_UID", id);
                    var Matricula = new SqlParameter("@Matricula", TBMatricula.Text);
                    var Nombre = new SqlParameter("@Nombre", TBNombre.Text);
                    var Curso = new SqlParameter("@Curso", TBCurso.Text);
                    var Telefono = new SqlParameter("@Telefono", TBTelefono.Text);
                    db.Database.ExecuteSqlCommand(
                        "EXEC sp_ActualizarEstudiante @Estudiante_UID, @Matricula, @Nombre, @Curso, @Telefono",
                        Estudiante_UID,
                        Matricula,
                        Nombre,
                        Curso,
                        Telefono
                        );
                    MessageBox.Show("Guardado Correctamente");
                }
            }
            F1.Refrescar();
            this.Close();
        }
    }
}
