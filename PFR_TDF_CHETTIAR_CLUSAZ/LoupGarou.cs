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
        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte,float indiceCruaute) : base(matricule, nom, prenom, sexe, fonction, cagnotte)
        {
            this.indiceCruaute = indiceCruaute;
            this.Affectation = null;

        }

        public override string ToString()
        {
            return base.ToString() + " Il est de type LoupGarou et son indice de cruaute est de " + indiceCruaute;
        }

    }
}
