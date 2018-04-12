using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
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
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = null;
        }

        public Attraction Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }

        public int Cagnotte { get => cagnotte; set => cagnotte = value; }

        public override string ToString()
        {
            return base.ToString() + " Monstre : Il est affecté à " + affectation + " sa cagnotte s'élève à " + cagnotte;
        }

        public void ChangerCagnotte( int valeur )
        {
            cagnotte += valeur;
            
            if( cagnotte < 50)
            {
               // fonction affecter désaffecter
            }
            if (cagnotte > 500)
            {

            }
        }
    }


}
