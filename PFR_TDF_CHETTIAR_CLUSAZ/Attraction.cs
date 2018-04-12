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
        #region attribus
        private int identifiant;
        private string nom;

        private List<Monstre> equipe;
        private int nbMinMonstre;

        private bool ouvert;
        private Maintenance maintenance;

        private List<string> spec;

        #region encapsulation
        public int Identifiant
        {
            get
            {
                return identifiant;
            }
        }
        public List<Monstre> Equipe
        {
            get { return equipe; }
        }
        public List<string> Spec
        {
            get
            {
                return spec;
            }
        }
        public int NbMinMonstre
        {
            get
            {
                return nbMinMonstre;
            }
        }
        #endregion

        #endregion

        #region constructeur
        public Attraction(int identifiant, string nom, int nbMinMonstre, bool ouvert, string spec)
        {
            this.equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.spec = new List<string>(spec.Split(' '));
        }
        public Attraction(string[] ligne)
        {
            this.equipe = new List<Monstre>();
            try { this.identifiant = int.Parse(ligne[1]); }
            catch (FormatException e) { this.identifiant = -1; } // Non Specifiee
            try { this.nbMinMonstre = int.Parse(ligne[3]); }
            catch (FormatException e) { this.nbMinMonstre = -1; } // Non Specifiee
            this.nom = ligne[2];
            this.ouvert = false;
            this.spec = new List<string>(ligne[5].Split(' '));
        }
        #endregion

        public override string ToString()
        {
            return "|ATTRACTION ID:" + identifiant + "|" + nom + "|NbMonstreMIN:" + nbMinMonstre + "|SPEC: (" + string.Join(";", spec.ToArray()) + ")|";
        }

        public void AddSpec(string type)
        {
            spec.Add(type);
        }
        public void RemoveSpec(string type)
        {
            spec.Remove(type);
        }
    }
}
