using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Salle
    {
        private string nom;
        private int capacite;
        private bool disponible;
        private Spectacle spectacle;

        public Salle (string nom, int capacite, bool disponible)
        {
            this.nom = nom;
            this.capacite = capacite;
            this.disponible = disponible;
            spectacle = null;
        }
    }
}
