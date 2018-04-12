using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Parc
    {
        private List<Attraction> attractions;
        private List<Personnel> personnel;
        private List<Salle> salles;

        public List<Salle> Salles
        {
            get
            {
                return salles;
            }

            set
            {
                salles = value;
            }
        }

        public Parc(List<Attraction> attractions, List<Personnel> tousLePersonnel, List<Salle> salles)
        {
            this.attractions = attractions;
            this.personnel = tousLePersonnel;
            this.Salles = salles;
        }

        public Parc(string nomDuFichier)
        {
            salles = new List<Salle>();
            attractions = ChargerFichierAttraction(nomDuFichier);
            personnel = ChargerFichierPersonnel(nomDuFichier);
        }


        public List<Personnel> ChargerFichierPersonnel(string nomDuFichier)
        {
            List<Personnel> ListePersonnel = new List<Personnel>();
            try
            {
                StreamReader fichier = new StreamReader(nomDuFichier);
                string ligne = fichier.ReadLine();
                while (ligne != null)
                {

                    string[] temp = ligne.Split(';');       // to lower ?

                    switch (temp[0].ToLower())
                    {
                        case "monstre":
                            ListePersonnel.Add(new Monstre(temp));
                            break;

                        case "zombie":
                            ListePersonnel.Add(new Zombie(temp));
                            break;

                        case "fantome":
                            ListePersonnel.Add(new Fantome(temp));
                            break;

                        case "vampire":
                            ListePersonnel.Add(new Vampire(temp));
                            break;
                        case "loupgarou":
                            ListePersonnel.Add(new LoupGarou(temp));
                            break;
                        case "demon":
                            ListePersonnel.Add(new Demon(temp));
                            break;
                    }

                    ligne = fichier.ReadLine();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return ListePersonnel;
        }
        public List<Attraction> ChargerFichierAttraction(string nomDuFichier)
        {
            List<Attraction> listeAttractions = new List<Attraction>();
            try
            {
                StreamReader fichier = new StreamReader(nomDuFichier);
                string ligne = fichier.ReadLine();
                while (ligne != null)
                {
                    string[] temp = ligne.Split(';');       // to lower ?
                    switch (temp[0])
                    {
                        case "Boutique":
                            listeAttractions.Add(new Boutique(temp));
                            break;

                        case "DarkRide":
                            listeAttractions.Add(new Darkrides(temp));
                            break;

                        case "RollerCoaster":
                            listeAttractions.Add(new Rollercoaster(temp));
                            break;

                        case "Spectacles":
                            listeAttractions.Add(new Spectacle(temp, this));
                            break;
                    }

                    ligne = fichier.ReadLine();

                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return listeAttractions;
        }

        public delegate bool FiltreAttraction(Attraction attraction);
        public void AfficherAttractionsConsole(FiltreAttraction filtre)
        {
            foreach (Attraction att in attractions) if (filtre(att)) Console.WriteLine(att);
        }
        public void EcrireAttractionCVS(FiltreAttraction filtre)
        {

        }

        public static bool NoFilter(Attraction attraction)
        {
            return true;
        }

        public delegate bool FiltrePersonnel(Personnel attraction);
        public void AfficherPersonnelConsole(FiltrePersonnel filtre)
        {
            foreach (Personnel per in personnel) if (filtre(per)) Console.WriteLine(per);
        }
        public void EcrirePersonnelCVS(FiltrePersonnel filtre)
        {

        }

        public static bool NoFilter(Personnel attraction)
        {
            return true;
        }
    }

}


