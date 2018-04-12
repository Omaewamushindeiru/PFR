using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{ 
    class Fantome : Monstre
    {
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {

        }

        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte) : base(matricule, nom, prenom, sexe, fonction, cagnotte)
        {
            this.Affectation = null;
        }

        public Fantome(string [] ligne) : base(ligne)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Il est de type Fantome";
        }
    }
}
