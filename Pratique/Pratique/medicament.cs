using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class medicament
    {
        private string codemalade;

        public string Codemalade
        {
            get { return codemalade; }
            set { codemalade = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private DateTime datefabrication;

        public DateTime Datefabrication
        {
            get { return datefabrication; }
            set { datefabrication = value; }
        }
        private DateTime dateexpration;

        public DateTime Dateexpration
        {
            get { return dateexpration; }
            set { dateexpration = value; }
        }

        // CREATION DES CONSTRUCTEURS
        public medicament()
        {
         
        }
        public medicament(string CODE, string DES, DateTime DATEFAB, DateTime DATEEXP)
        {
            this.codemalade = CODE;
            this.designation = DES;
            this.datefabrication = DATEFAB;
            this.dateexpration = DATEEXP;
        }
        public medicament(string CODE)
        {
            this.codemalade = CODE;
        }
    }
}
