using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class paiement
    {
        private string Idpaiement;

        public string Idpaiement1
        {
            get { return Idpaiement; }
            set { Idpaiement = value; }
        }
        private float montat;

        public float Montat
        {
            get { return montat; }
            set { montat = value; }
        }
        private string motif;

        public string Motif
        {
            get { return motif; }
            set { motif = value; }
        }
        private DateTime datepaiement;

        public DateTime Datepaiement
        {
            get { return datepaiement; }
            set { datepaiement = value; }
        }

        // LES CONSTRUCTEURS

        // initialisation

        public paiement()
        { 

        }

        // ajout et modification
        public paiement(string ID, float MO, string MOT, DateTime DAT)
        {
            this.Idpaiement = ID;
            this.montat = MO;
            this.motif = MOT;
            this.datepaiement = DAT;
        }
        // suppession
        public paiement(string ID)
        {
            this.Idpaiement = ID;
        }
    }
}
