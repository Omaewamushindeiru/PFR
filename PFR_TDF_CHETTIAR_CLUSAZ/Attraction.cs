using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Attraction
    {
        private Parc parc;

        private int identifiant;
        private string nom;

        private List<Monstre> equipe;
        private int nbMinMonstre;

        private bool ouvert;
        private Maintenance maintenance;

        private List<string> spec;

        public Attraction(int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec, Parc parc)
        {
            this.equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.spec = new List<string>(spec.Split(' '));
            this.parc = parc;
        }

        public Attraction(string[] ligne, Parc parc)
        {
            this.equipe = new List<Monstre>();
            try { this.identifiant = int.Parse(ligne[1]); }
            catch (FormatException e) { this.identifiant = -1; } // Non Specifiee
            try { this.nbMinMonstre = int.Parse(ligne[3]); }
            catch (FormatException e) { this.nbMinMonstre = -1; } // Non Specifiee
            this.nom = ligne[2];
            this.ouvert = false;
            this.spec = new List<string>(ligne[5].Split(' '));
            this.parc = parc;
        }

        public override string ToString()
        {
            return "MONSTRE ID:" + identifiant + " " + nom + " NbMonstreMIN:" + nbMinMonstre + " SPEC: (" + string.Join(";",spec.ToArray()) + ")";
        }


    }
}
