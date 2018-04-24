using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Sorcier : Personnel
    {
        private List<string> pouvoirs;
        private Grade tatouage;


        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Grade tatouage, List<string> pouvoirs) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.pouvoirs = new List<string>();
            this.tatouage = tatouage;
        }
        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction) : base(matricule, nom, prenom, sexe, fonction)
        {

        }
        public Sorcier (string[] ligne): base(ligne)
        {
            try { this.tatouage = (Grade)Enum.Parse(typeof(Grade), ligne[6]); }
            catch (ArgumentException) { this.tatouage = Grade.inconnu; }
            this.pouvoirs = ligne[7].Split('-').ToList<string>();
        }

        public override string ToString()
        {
            return base.ToString() + " Il est de type Sorcier et son grade est " + tatouage; // rajouter la liste des pouvoirs
        }
        public override string ToCVS()
        {
            return "Sorcier;" + base.ToCVS() + ";" + tatouage.ToString() + string.Join("-", pouvoirs) + ";";
        }

        public void ChangerGrade(Grade grade)
        {
            tatouage = grade;
        }

    }
}
