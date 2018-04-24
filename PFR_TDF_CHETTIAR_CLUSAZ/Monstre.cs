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

        public int Cagnotte
        {
            get
            {
                return cagnotte;
            }

        }

        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.affectation = affectation;
            affectation.Equipe.Add(this);
            this.cagnotte = cagnotte;
        }
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = null;
        }
        public Monstre(string[] ligne, Parc parc) : base(ligne)
        {
            int.TryParse(ligne[6], out cagnotte);
            int attraction = 0;
            if(int.TryParse(ligne[7], out attraction)) Console.WriteLine(Affecter(attraction, parc));
        }

        public bool Affecter(int idAttraction, Parc parc)
        {
            if (!isAffected())
                foreach (Attraction att in parc.Attractions)
                {
                    Console.WriteLine("b");

                    if ((att.Identifiant == idAttraction))
                    {
                        Console.WriteLine("a");
                        if (this.isOfSpec(att))
                        {
                            Console.WriteLine("test");
                            this.affectation = att;
                            att.Equipe.Add(this);
                            return true;
                        }
                    }
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
            //Console.WriteLine("ets");
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
            return affectation != null;
        }

        public override string ToString()
        {
            return base.ToString() + " MONSTRE AFFECTATION:(" + affectation + ") CACGNOTTE:" + cagnotte;
        }
        public override string ToCVS()
        {
            try { return base.ToCVS() + cagnotte + ";" + Affectation.Identifiant + ";"; }
            catch (NullReferenceException) { return base.ToCVS() + cagnotte + ";;"; }
        }

        public void ChangerCagnotte( int valeur )
        {
            cagnotte += valeur;
            
            if( cagnotte < 50)
            {
               // fonction affecter désaffecter
            }
            if (cagnotte > 500)
            {
                //checker si il y a assez de monde sur l'attraction
            }
        }
    }


}
