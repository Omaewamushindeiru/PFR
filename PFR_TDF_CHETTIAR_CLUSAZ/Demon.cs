using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Demon : Monstre
    {
        private int force;

        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, int force) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = force;
        }

        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = -1;
        }
    }
}
