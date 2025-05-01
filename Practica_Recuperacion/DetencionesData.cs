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
        public int? id;
        Detencione temp;
        public DetencionesData(Detenciones Form1, int? id = null)
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
                temp = db.Detenciones.Find(id);
                NUPEstudianteID.Value = Convert.ToDecimal(temp.Estudiante_UID);
                DTPFecha.Value = temp.Fecha ?? DateTime.Now;
                NUPTotal.Value = Convert.ToDecimal(temp.Total);
                CBEstado.Text = temp.Estado;
                CBMotivo.Text = temp.Motivo;
                CBTipo.Text = temp.Tipo;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                if (id == null)
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
                }
                else
                {
                    var ID_Detencion = new SqlParameter("@ID_Detencion", id);
                    var Estudiante_UID = new SqlParameter("@Estudiante_UID", NUPEstudianteID.Value);
                    var Fecha = new SqlParameter("@Fecha", DTPFecha.Value);
                    var Total = new SqlParameter("@Total", NUPTotal.Value);
                    var Estado = new SqlParameter("@Estado", CBEstado.Text);
                    var Motivo = new SqlParameter("@Motivo", CBMotivo.Text);
                    var Tipo = new SqlParameter("@Tipo", CBTipo.Text);

                    db.Database.ExecuteSqlCommand(
                        "EXEC sp_ActualizarDetencion @ID_Detencion, @Estudiante_UID, @Fecha, @Total, @Estado, @Motivo, @Tipo",
                        ID_Detencion,
                        Estudiante_UID,
                        Fecha,
                        Total,
                        Estado,
                        Motivo,
                        Tipo
                        );
                }
                MessageBox.Show("Guardado Correctamente");
            }
            F1.Refrescar();
            this.Close();
        }

        private void DetencionesData_FormClosing(object sender, FormClosingEventArgs e)
        {
            F1.Show();
        }
    }
}
