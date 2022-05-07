using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class adherant
    {
        private int Numadherant;

        public int Numadherant1
        {
            get { return Numadherant; }
            set { Numadherant = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
    }
}
