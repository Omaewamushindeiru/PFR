using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Rollercoaster : Attraction
    {

        private float tailleMin;
        private int ageMin;
        private TypeCategorie categorie;

        public Rollercoaster(float tailleMin, int ageMin, TypeCategorie categorie, int identifiant, string nom, int nbMinMonstre, bool ouvert , string spec):base(identifiant, nom, nbMinMonstre, ouvert, spec)
        {
            this.tailleMin = tailleMin;
            this.ageMin = ageMin;
            this.categorie = categorie;
        }
        public Rollercoaster(string[] ligne) : base(ligne)
        {
            categorie = (TypeCategorie)Enum.Parse(typeof(TypeCategorie), ligne[6]);
            tailleMin = float.Parse(ligne[8]);
            ageMin = int.Parse(ligne[7]);
        }

    }
}
