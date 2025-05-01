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
    public partial class DetencionesData : Form
    {
        private Detenciones F1;
        public DetencionesData(Detenciones Form1)
        {
            InitializeComponent();
            F1 = Form1;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                var Estudiante_UID = new SqlParameter("@Estudiante_UID", NUPEstudianteID.Value);
                var Fecha = new SqlParameter("@Fecha", DTPFecha.Value);
                var Total = new SqlParameter("@Total", NUPTotal.Value);
                var Estado = new SqlParameter("@Estado", CBEstado.Text);
                var Motivo = new SqlParameter("@Motivo", CBMotivo.Text);
                var Tipo = new SqlParameter("@Tipo", CBTipo.Text);

                db.Database.ExecuteSqlCommand(
                    "EXEC sp_InsertarDetencion @Estudiante_UID, @Fecha, @Total, @Estado, @Motivo, @Tipo",
                    Estudiante_UID,
                    Fecha,
                    Total,
                    Estado,
                    Motivo,
                    Tipo
                    );
                MessageBox.Show("Guardado Correctamente");
            }
            F1.Refrescar();
            this.Close();
        }

        private void DetencionesData_FormClosing(object sender, FormClosingEventArgs e)
        {
            F1.Show();
        }

        private void DetencionesData_Load(object sender, EventArgs e)
        {

        }
    }
}
