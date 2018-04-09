using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Fantome : Monstre
    {
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {

        }
    }
}
