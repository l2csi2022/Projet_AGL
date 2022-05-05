using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class operation
    {
        private string Idoperation;

        public string Idoperation1
        {
            get { return Idoperation; }
            set { Idoperation = value; }
        }
        private string designationoperation;

        public string Designationoperation
        {
            get { return designationoperation; }
            set { designationoperation = value; }
        }
        private float montant;

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        private DateTime dateoperation;

        public DateTime Dateoperation
        {
            get { return dateoperation; }
            set { dateoperation = value; }
        }
        //CREATION DES CONSTRUCTEURS

        //constructeur initial

        public operation()
        {

        }
        //constructeur de requettes (MODDIFICATION ET AJOUT)
        public operation(string ID, string DESIGN, float montant, DateTime date)
           {
               this.Idoperation = ID;
               this.designationoperation = DESIGN;
               this.montant = montant;
               this.dateoperation = date;
        }
        // constructeur de suppression
        public operation(string ID)
        {
            this.Idoperation = ID;
        }

    }
}
