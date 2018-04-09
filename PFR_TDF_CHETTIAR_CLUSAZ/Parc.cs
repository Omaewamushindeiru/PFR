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
        private string nom;
        private string adresse;

        private List<Personnel> personnel;
        private List<Attraction> attraction;

        public delegate Personnel CreatePerso(string[] parameter);

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
                            case "":

                                break;

                            case "":

                                break;

                            case "":

                                break;

                            case "":

                                break;

                            case "":

                                break;
                        }
                    listeAttractions.Add();
                }

            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return listeAttractions;
        }
    }

}
