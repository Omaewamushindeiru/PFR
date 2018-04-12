using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Darkrides : Attraction
    {
        private TimeSpan duree;
        private bool estEnVehicule;

        public Darkrides(TimeSpan duree, bool estEnVehicule, int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec, Parc parc) : base(identifiant, nom, nbMinMonstre, ouvert, spec, parc)
        {
            this.duree = duree;
            this.estEnVehicule = estEnVehicule;
        }

        public Darkrides(string[] ligne, Parc parc) : base(ligne, parc)
        {
            duree = TimeSpan.Parse(ligne[6]);
            estEnVehicule = (ligne[7] == "true");
        }
    }
}
