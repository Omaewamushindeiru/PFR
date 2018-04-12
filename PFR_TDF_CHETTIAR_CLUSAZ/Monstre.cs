using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Monstre : Personnel
    {
        private Attraction affectation;
        private int cagnotte;

        public Attraction Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }

        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.affectation = affectation;
            this.cagnotte = cagnotte;
        }
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = null;
        }
        public Monstre(string[] ligne) : base(ligne)
        {
            this.cagnotte = int.Parse(ligne[6]);
        }

        public bool Affecter(int idAttraction, Parc parc)
        {
            for (int i = 0; i < parc.Attractions.Count(); i++) ;
            foreach (Attraction att in parc.Attractions)
                if ((att.Identifiant == idAttraction))
                    if (this.isOfSpec(att))
                    {
                        this.affectation = att;
                        att.Equipe.Add(this);
                        return true;
                    }
            return false;
        }
        public bool Desaffecter()
        {
            if (isAffected())
            {
                affectation.Equipe.Remove(this);
                affectation = null;
                return true;
            }
            return false;
        }

        public bool isOfSpec(Attraction attraction)
        {
            foreach (string type in attraction.Spec)
            {
                switch (type)
                {
                    case "zombie":
                        if (!(this is Zombie)) return false;
                        break;

                    case "fantome":
                        if (!(this is Fantome)) return false;
                        break;

                    case "vampire":
                        if (!(this is Vampire)) return false;
                        break;

                    case "loupgarou":
                        if (!(this is LoupGarou)) return false;
                        break;

                    case "demon":
                        if (!(this is Demon)) return false;
                        break;
                }
            }
            return true;
        }

        public bool isAffected()
        {
            return affectation == null;
        }



        public override string ToString()
        {
            return base.ToString() + " MONSTRE AFFECTATION:" + affectation + " CACGNOTTE:" + cagnotte;
        }

        public void ChangerCagnotte(int valeur, Parc p)
        {
            cagnotte += valeur;
            int idBoutique;
            if (cagnotte < 50)
            {
                Desaffecter();
                foreach (Boutique bou in p.Attractions)
                {
                    if (bou.Marchandise == TypeBoutique.barbeAPapa)
                    {
                        idBoutique = bou.Identifiant;
                        Affecter(idBoutique, p);
                        break;
                    }
                }
            }
            if (cagnotte > 500)
            {
                if (affectation.NbMinMonstre < affectation.Equipe.Count)
                {
                    Desaffecter();
                }
            }
        }
    }


}
