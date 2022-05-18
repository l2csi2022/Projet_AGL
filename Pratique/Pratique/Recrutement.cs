using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class Recrutement
    {
        private int id_recrutement;

        public int Id_recrutement
        {
            get { return id_recrutement; }
            set { id_recrutement = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
    }
}
