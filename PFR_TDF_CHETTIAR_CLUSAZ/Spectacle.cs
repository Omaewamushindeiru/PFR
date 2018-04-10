using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Spectacle : Attraction
    {
        private Salle salle;
        private int horraire;

        public Spectacle (Salle salle, int horraire, int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec) : base(identifiant, nom, nbMinMonstre, ouvert, spec)
        {
            this.salle = salle;
            this.horraire = horraire;
        }

    }
}
