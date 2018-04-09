using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class LoupGarou : Monstre
    {
        private float indiceCruaute;

        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, float indiceCruaute) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceCruaute = indiceCruaute;
        }
        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation) { }

    }
}
