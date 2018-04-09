using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Rollercoaster : Attraction
    {
        public enum TypeCategorie
        {
            assise, inversee, bobsleigh
        }

        private int tailleMin;
        private int ageMin;
        private TypeCategorie categorie;

        public Rollercoaster(int taille, int age, TypeCategorie type, int identifiant, string nom, int nbMinMonstre, bool ouvert):base(identifiant, nom, nbMinMonstre, ouvert)
        {
            tailleMin = taille;
            ageMin = age;

        }

    }
}
