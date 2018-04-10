using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Darkrides : Attraction
    {
        private int duree;
        private bool estEnVehicule;

        public Darkrides(int duree, bool estEnVehicule, int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec) : base(identifiant, nom, nbMinMonstre, ouvert, spec)
        {
            this.duree = duree;
            this.estEnVehicule = estEnVehicule;
        }
    }
}
