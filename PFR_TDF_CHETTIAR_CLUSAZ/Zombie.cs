using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Zombie : Monstre
    {
        private int degreDecomposition;
        private CouleurZ teint;

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, CouleurZ teint, int degreDecomposition) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }
        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {

        }

    }
}
