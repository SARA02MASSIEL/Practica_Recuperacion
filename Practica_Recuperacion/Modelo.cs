using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_Recuperacion.Models;

namespace Practica_Recuperacion
{
    internal class Modelo
    {
        public List<Practica_Recuperacion.Models.Estudiante> Refrescar_Est()
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                var lst = from d in db.Estudiantes select d;
                return lst.ToList();
            }
        }

        public List<Practica_Recuperacion.Models.Detencione> Refrescar_Det()
        {
            using (SchoolBDEntities db = new SchoolBDEntities())
            {
                var lst2 = from d in db.Detenciones select d;
                return lst2.ToList();
            }
        }

        public int? GetId(DataGridView asd)
        {
            try
            {
                return int.Parse(asd.Rows[asd.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

    }
}
