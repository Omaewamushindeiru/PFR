﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Personnel : Parc
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

    }


}
