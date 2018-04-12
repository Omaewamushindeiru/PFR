using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Vampire : Monstre
    {
        private double indiceLuminosite;

        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, float indiceLuminosite) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceLuminosite = indiceLuminosite;
        }
        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, float indiceLuminosite) : base(matricule, nom, prenom, sexe, fonction, cagnotte)
        {
            this.indiceLuminosite = indiceLuminosite;
            this.Affectation = null;
        }
        public Vampire(string[] ligne) : base(ligne)
        {
            this.indiceLuminosite = double.Parse(ligne[8]);
        }
        public override string ToString()
        {
            return base.ToString() + " Il est de type Vampire et son indice de luminosite est de " + indiceLuminosite;
        }
    }
}
