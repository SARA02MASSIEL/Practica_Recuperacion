using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_Recuperacion.Models;

namespace Practica_Recuperacion
{
    public partial class Estudiantes : Form
    {
        Modelo MD = new Modelo();
        public Estudiantes()
        {
            InitializeComponent();
            Refrescar();
        }

        public void Refrescar()
        {
            var lst = MD.Refrescar_Est();
            DGVVista.DataSource = lst.ToList();
        }

        private void BMove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Detenciones();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            EstudianteData F2 = new EstudianteData(this);
            F2.Show();
            this.Hide();
        }
    }
}
