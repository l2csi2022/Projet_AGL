using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class Etudiant
    {
        private string numMat;

        public string NumMat
        {
            get { return numMat; }
            set { numMat = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string postnom;

        public string Postnom
        {
            get { return postnom; }
            set { postnom = value; }
        }
        private string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public Etudiant()
        {

        }
    }
}
