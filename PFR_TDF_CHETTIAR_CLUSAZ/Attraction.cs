using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Attraction
    {
        private int identifiant;
        private string nom;

        private List<Monstre> equipe;
        private int nbMinMonstre;

        private bool ouvert;
        private Maintenance maintenance;

        private string spec;

        public Attraction(int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec)
        {
            this.equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.spec = spec;
        }

        public override string ToString()
        {
            return " ";
        }


    }
}
