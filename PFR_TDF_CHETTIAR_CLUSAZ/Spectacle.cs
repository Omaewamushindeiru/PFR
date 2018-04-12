using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Spectacle : Attraction
    {
        private Salle salle;
        private List<DateTime> horraire;

        public Spectacle (Salle salle, List<DateTime> horraire, int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec, Parc parc) : base(identifiant, nom, nbMinMonstre, ouvert, spec, parc)
        {
            this.salle = salle;
            this.horraire = horraire;
        }

        public Spectacle (string[] ligne , Parc parc) : base (ligne, parc)
        {
            Salle salle = new Salle(ligne[6],int.Parse(ligne[6]),false,this);
            parc.Salles.Add(salle);
            this.salle = salle;
            this.horraire = new List<DateTime>();
            string[] temp = ligne[8].Split(' ');
            foreach (string s in temp)
            {
                horraire.Add(DateTime.Parse(s));
            }
        }

    }
}
