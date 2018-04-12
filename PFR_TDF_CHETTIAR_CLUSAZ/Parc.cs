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


        public Parc(List<Attraction> attractions, List<Personnel> tousLePersonnel, )
        {
            this.attractions = new List<Attraction>();
            this.personnel = new List<Personnel>();
        }

       public static List<Attraction> ChargerFichierAttraction(string nomDuFichier)
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
                                listeAttractions.Add(new Boutique(temp[6], int.Parse(temp[1]), temp[2], int.Parse(temp[3]), false, temp[4]));
                                break;

                            case "DarkRide":
                                listeAttractions.Add(new Darkrides(int.Parse(temp[6]), temp[7]=="true", int.Parse(temp[1]), temp[2], int.Parse(temp[3]), false, temp[4]));
                                break;

                            case "RollerCoaster":
                                listeAttractions.Add(new Rollercoaster(
                                break;

                            case "Spectacles":

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
    }

}
    

