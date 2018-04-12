using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Personnel
    {
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private TypeSexe sexe;


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

        public override string ToString()
        {
            return "PERSONNEL ID:" + matricule + " " + nom + " " + prenom + " SEXE:" + sexe + " FONCTION:" + fonction;
        }

        public void ChangerFonction(string NouvelleFonction)
        {
            fonction = NouvelleFonction;
        }
        
           
        }
    }



