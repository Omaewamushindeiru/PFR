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
        private List<Attraction> Attractions;
        private List<Personnel> Personnel;


        public Parc(List<Attraction> attractions, List<Personnel> tousLePersonnel)
        {
            this.Attractions = new List<Attraction>();
            this.Personnel = new List<Personnel>();
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
                    if (temp[1].Length == 3)
                        switch (temp[0])
                        {
                            case "Boutique":
                                listeAttractions.Add(new Boutique(temp, this));
                                break;

                            case "DarkRide":
                                listeAttractions.Add(new Darkrides(temp));
                                break;

                            case "RollerCoaster":
                                listeAttractions.Add(new Rollercoaster(temp, this));
                                break;

                            case "Spectacles":
                                listeAttractions.Add(new Spectacle(temp, this));
                                break;

                        }
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
            foreach (Attraction att in Attractions) if (filtre(att)) Console.WriteLine(att);
        }
        public void EcrireAttractionCVS(FiltreAttraction filtre)
        {

        }
    }

}
    

