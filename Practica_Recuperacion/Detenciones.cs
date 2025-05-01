using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Recuperacion
{
    public partial class Detenciones : Form
    {
        Modelo MD = new Modelo();
        public Detenciones()
        {
            InitializeComponent();
            Refrescar();
        }
        public void Refrescar()
        {
            var lst2 = MD.Refrescar_Det();
            DGVVista.DataSource = lst2.ToList();
        }

        private void BMove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Estudiantes();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            DetencionesData F2 = new DetencionesData(this);
            F2.Show();
            this.Hide();
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            int? id = MD.GetId(DGVVista);

            if (id != null)
            {
                DetencionesData F2 = new DetencionesData(this, id);
                F2.Show();
                this.Hide();
            }
        }
    }
}
