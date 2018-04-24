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
        public List<Attraction> Attractions
        {
            get
            {
                return attractions;
            }

            set
            {
                attractions = value;
            }
        }
        public List<Personnel> Personnel
        {
            get
            {
                return personnel;
            }

            set
            {
                personnel = value;
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
                        case "sorcier":
                            ListePersonnel.Add(new Sorcier(temp));
                            break;
                        case "monstre":
                            ListePersonnel.Add(new Monstre(temp, this));
                            break;

                        case "zombie":
                            ListePersonnel.Add(new Zombie(temp, this));
                            break;

                        case "fantome":
                            ListePersonnel.Add(new Fantome(temp, this));
                            break;

                        case "vampire":
                            ListePersonnel.Add(new Vampire(temp, this));
                            break;
                        case "loupgarou":
                            ListePersonnel.Add(new LoupGarou(temp, this));
                            break;
                        case "demon":
                            ListePersonnel.Add(new Demon(temp, this));
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
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return listeAttractions;
        }

        public void WriteFile(string filename)
        {
            List<string> file = new List<string>();
            foreach(Attraction a in attractions)
            {
                file.Add(a.ToCVS());
            }
            string temp;
            foreach(Personnel p in personnel)
            {
                temp = p.ToCVS(); 
                if (!(p is Zombie || p is Fantome || p is LoupGarou || p is Vampire || p is Demon || p is Sorcier)) temp = "Monstre;" + temp;
                file.Add(temp);
            }
            //if (!File.Exists("save.csv"))
            //{
                // Create a file to write to.
                File.WriteAllLines(filename, file.ToArray());
            //}
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
        public static FiltrePersonnel OnlyMonsterType(Type t)
        {
            FiltrePersonnel filtre = delegate (Personnel pers)
            {
                return t.Equals(pers.GetType());
            };
            return filtre;
        }
        public static bool OnlySorcier(Personnel sorcier)
        {
            return sorcier is Sorcier;
        }
        public static bool OnlyMonstre(Personnel monstre)
        {
            return monstre is Monstre;
        }
        public static bool OnlyDemon(Personnel demon)
        {
            return demon is Demon;
        }
        public static bool OnlyFantome(Personnel fantome)
        {
            return fantome is Fantome;
        }
        public static bool OnlyLoupGarou(Personnel loupGarou)
        {
            return loupGarou is LoupGarou;
        }
        public static bool OnlyVampire(Personnel vampire)
        {
            return vampire is Vampire;
        }
        public static bool OnlyZombie(Personnel zombie)
        {
            return zombie is Zombie;
        }
        public static FiltrePersonnel CagnotteOver(int cagnotte, FiltrePersonnel filtre)
        {
            FiltrePersonnel newFiltre = delegate (Personnel pers)
            {
                if (filtre(pers) && pers is Monstre) return (pers as Monstre).Cagnotte >= cagnotte;
                return false;
            };
            return newFiltre;
        }

    }

}


