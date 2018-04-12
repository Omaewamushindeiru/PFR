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

        public Rollercoaster(float tailleMin, int ageMin, TypeCategorie categorie, int identifiant, string nom, int nbMinMonstre, bool ouvert , string spec, Parc parc):base(identifiant, nom, nbMinMonstre, ouvert, spec, parc)
        {
            this.tailleMin = tailleMin;
            this.ageMin = ageMin;
            this.categorie = categorie;
        }

        public Rollercoaster(string[] ligne, Parc parc) : base(ligne,parc)
        {
            if (ligne[6].ToLower() == "bobsleigh") categorie = TypeCategorie.bobsleigh;
            if (ligne[6].ToLower() == "bobsleigh") categorie = TypeCategorie.bobsleigh;
            if (ligne[6].ToLower() == "bobsleigh") categorie = TypeCategorie.bobsleigh;

            tailleMin = float.Parse(ligne[8]);
            ageMin = int.Parse(ligne[7]);
        }

    }
}
