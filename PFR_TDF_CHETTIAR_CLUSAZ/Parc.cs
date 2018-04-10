﻿using System;
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

       static void AffecterAUneAttraction(List<Attraction> listeAttractions,Monstre monMonstre)
        {
            for(int i =0; i < listeAttractions.Count(); i++)
            {
                if (listeAttractions[i] == monMonstre.Affectation)
                {
                    listeAttractions[i].Equipe.Add(monMonstre);

                }
            }
        }

       static void ChargerFichier(string nomDuFichier, List<Personnel> personnel)
        {
            try
            {
                StreamReader fichier = new StreamReader(nomDuFichier);

                string ligne = fichier.ReadLine();

                while (ligne != null)
                {


                    string[] temp = ligne.Split(';');       // to lower ?

                    if (temp[0].ToLower() == "sorcier")
                    {
                        personnel.Add(new Sorcier(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], (Grade)Enum.Parse(typeof(Grade), temp[6]), temp[7].Split('-').ToList<string>()));
                    }
                    else
                    {


                        if (temp[0].ToLower() == "monstre")
                        {
                            personnel.Add(new Monstre(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]),));
                        }
                        if (temp[0].ToLower() == "demon")
                        {
                            personnel.Add(new Demon(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]), (Attraction)Convert.ChangeType(temp[7], typeof(int)), Int32.Parse(temp[8])));
                        }
                        if (temp[0].ToLower() == "fantome")
                        {
                            personnel.Add(new Fantome(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]), (Attraction)Convert.ChangeType(temp[7], typeof(int))));
                        }
                        if (temp[0].ToLower() == "loupgarou")
                        {
                            personnel.Add(new LoupGarou(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]), (Attraction)Convert.ChangeType(temp[7], typeof(int)), Single.Parse(temp[8])));
                        }
                        if (temp[0].ToLower() == "vampire")
                        {
                            personnel.Add(new Vampire(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]), (Attraction)Convert.ChangeType(temp[7], typeof(int)), Single.Parse(temp[8])));
                        }
                        if (temp[0].ToLower() == "zombie")
                        {
                            personnel.Add(new Zombie(Int32.Parse(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]), temp[5], Int32.Parse(temp[6]), (Attraction)Convert.ChangeType(temp[7], typeof(int)), (CouleurZ)Enum.Parse(typeof(CouleurZ), temp[8]), Int32.Parse(temp[9])));
                        }
                    }

                }
            }
            catch
            {

            }
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
                                listeAttractions.Add();
                                break;

                            case "DarkRide":

                                break;

                            case "RollerCoaster":

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
    

