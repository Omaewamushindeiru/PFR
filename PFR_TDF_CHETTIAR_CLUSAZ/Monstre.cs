using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Monstre : Personnel
    {
        private Attraction affectation;
        private int cagnotte;

        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.affectation = affectation;
            this.cagnotte = cagnotte;
        }
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction) : base(matricule, nom, prenom, sexe, fonction)
        {

        }

        public Attraction Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }
    }


}
