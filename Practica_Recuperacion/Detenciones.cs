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
        public Detenciones()
        {
            InitializeComponent();
            Modelo MD = new Modelo();
            var lst2 = MD.Refrescar_Det();
            DGVVista.DataSource = lst2.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BMove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Estudiantes();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
