using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
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



    }
}
