using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    abstract class Personnel
    {
        #region attribus
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private TypeSexe sexe;
        #endregion

        #region constructeur
        public Personnel(int matricule, string nom, string prenom, TypeSexe sexe, string fonction)
        {
            this.fonction = fonction;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
        }
        public Personnel(string[] ligne)
        {
            this.matricule = int.Parse(ligne[1]);
            this.nom = ligne[2];
            this.prenom = ligne[3];
            this.sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), ligne[4]);
            this.fonction = ligne[5];
        }
        #endregion

        public override string ToString()
        {
            return "PERSONNEL ID:" + matricule + " " + nom + " " + prenom + " SEXE:" + sexe + " FONCTION:" + fonction;
        }
        virtual public string ToCVS()
        {
            return matricule + ";" + nom + ";" + prenom + ";" + sexe + ";" + fonction + ";";
        }

        static public int TriZombieDecompo(Personnel p1, Personnel p2)
        {
            int result = 0;
            if (p1 is Zombie && p2 is Zombie) result = (p1 as Zombie).DegreDecomposition.CompareTo((p2 as Zombie).DegreDecomposition);
            else if (p1 is Zombie) result = 1;
            else if (p2 is Zombie) result = -1;
            return result;
        }

        public void ChangerFonction(string NouvelleFonction)
        {
            fonction = NouvelleFonction;
        }
        
           
        }
    }



