using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Boutique : Attraction
    {
        private TypeBoutique marchandise;

        public Boutique(TypeBoutique marchandise, int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec) : base(identifiant, nom, nbMinMonstre, ouvert, spec)
        {
            this.marchandise = marchandise;
        }

        public Boutique(string[] ligne) : base(ligne)
        {
            
        }
    }
}
