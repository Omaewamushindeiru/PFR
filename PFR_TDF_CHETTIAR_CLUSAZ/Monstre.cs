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

        public Attraction Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }

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
        public Monstre(string[] ligne) : base(ligne)
        {
            this.cagnotte = int.Parse(ligne[6]);
        }

        public void AffecterAUneAttraction(int id, Parc parc)
        {
<<<<<<< HEAD
            //for(int i = 0; i< )
=======
            //checker si le type de monstre recommandé
>>>>>>> 4c42bf55e68296fe5f295a3b4f570ca5e1031b88
        }

        public override string ToString()
        {
            return base.ToString() + " MONSTRE AFFECTATION:" + affectation + " CACGNOTTE:" + cagnotte;
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
                //checker si il y a assez de monde sur l'attraction
            }
        }
    }


}
