using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Vampire : Monstre
    {
        private float indiceLuminosite;

        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, float indiceLuminosite) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceLuminosite = indiceLuminosite;
        }
        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceLuminosite = -1;
        }
    }
}
