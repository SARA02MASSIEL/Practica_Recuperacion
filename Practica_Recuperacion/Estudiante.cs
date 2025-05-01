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
        public Estudiantes()
        {
            InitializeComponent();
            Modelo MD = new Modelo();
            var lst = MD.Refrescar_Est();
            DGVVista.DataSource = lst.ToList();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BMove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Detenciones();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
