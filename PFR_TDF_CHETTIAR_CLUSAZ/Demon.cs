using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Demon : Monstre
    {
        private int force;

        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, int force) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = force;
        }
        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte,int force) : base(matricule, nom, prenom, sexe, fonction, cagnotte)
        {
            this.force = force;
            this.Affectation = null;
        }
        public Demon(string[] ligne, Parc parc):base(ligne, parc)
        {
            int.TryParse(ligne[8],out force);
        }

        public override string ToString()
        {
            return base.ToString() + " DEMON FORCE: " + force;
        }
        public override string ToCVS()
        {
            return "Demon;" + base.ToCVS() + ";" + force + ";";
        }

        public void ChangerForce(int valeur)
        {
            force = valeur;
        }

    }
}
