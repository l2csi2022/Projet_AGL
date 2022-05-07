using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class prime
    {
        private int idprime;

        public int Idprime
        {
            get { return idprime; }
            set { idprime = value; }
        }
        private float montant;

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        private string motifprime;

        public string Motifprime
        {
            get { return motifprime; }
            set { motifprime = value; }
        }
        private DateTime datepaieme;

        public DateTime Datepaieme
        {
            get { return datepaieme; }
            set { datepaieme = value; }
        }
    }
}
