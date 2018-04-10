using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Rollercoaster : Attraction
    {

        private int tailleMin;
        private int ageMin;
        private string categorie;

        public Rollercoaster(int tailleMin, int ageMin, string categorie, int identifiant, string nom, int nbMinMonstre, bool ouvert , string spec):base(identifiant, nom, nbMinMonstre, ouvert, spec)
        {
            this.tailleMin = tailleMin;
            this.ageMin = ageMin;
            this.categorie = categorie;
        }

    }
}
