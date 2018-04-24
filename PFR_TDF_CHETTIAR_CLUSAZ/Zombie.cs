using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Zombie : Monstre
    {
        private int degreDecomposition;
        private CouleurZ teint;

        public int DegreDecomposition
        {
            get
            {
                return degreDecomposition;
            }
        }

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, CouleurZ teint, int degreDecomposition) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }
        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, CouleurZ teint, int degreDecomposition) : base(matricule, nom, prenom, sexe, fonction, cagnotte)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
            this.Affectation = null;
        }
        public Zombie(string[] ligne, Parc parc) : base(ligne, parc)
        {
            this.degreDecomposition = int.Parse(ligne[9]);
            this.teint = (CouleurZ)Enum.Parse(typeof(CouleurZ), ligne[8]);
        }
        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Il est de type Zombie, son degré de décomposition est de " + degreDecomposition + " et son teint est " + teint;
        }
        public override string ToCVS()
        {
            return "Zombie;" + base.ToCVS() + teint.ToString() + ";" + degreDecomposition + ";";
        }

        public void ChangerTeint(CouleurZ couleur)
        {
            teint = couleur;
        }
        public void ChangerDegreDecomposition(int degre)
        {
            degreDecomposition = degre;
        }

        }
    }
