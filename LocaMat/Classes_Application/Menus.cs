﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using

namespace LocaMat.Classes_Application
{
    public class Menus
    {
        public static void MenuAccueil()
        {
            Console.Clear();

            Esthetisme.MiseEnFormeTexte("APPLICATION DE LOCATION DE MATERIEL\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Cette application permet de gérer du matériel de location\n\n", ConsoleColor.DarkCyan, centre: false);
            Esthetisme.MiseEnFormeTexte("MENU\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Gestion des Agences", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Gestion des Produits", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Gestion des Clients", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Gestion des Locations", centre: false);
            Esthetisme.MiseEnFormeTexte("5. Gestion des Offres Produits", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);
        }
    
        {
            
            

            return Console.ReadLine();
        }

        public static void MenuGestionVoyages()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES VOYAGES\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Voir les dossiers en attente", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Voir les dossiers en cours", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Voir les dossiers refusés", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Voir les dossiers acceptés", centre: false);
            Esthetisme.MiseEnFormeTexte("5. Voir la liste des voyages", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu précédent", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            var choix2 = Console.ReadLine();

            switch (choix2)
            {
                /*case "1":
                    ListerLesDossierEnAttente();
                    break;

                case "2":
                    ListerLesDossiersEnCours();
                    break;

                case "3":
                    ListerLesDossiersRefusé();
                    break;

                case "4":
                    ListerLesDossiersAcceptés();
                    break;

                case "5":
                    ListeDesVoyages();
                    break;*/

                case "r":
                case "R":
                    MenuGestionCommerciale();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                    Classes.Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            Console.ReadKey();
        }

        public static void MenuGestionClients()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES CLIENTS\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Voir la liste des clients", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Rechercher un client", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Créer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Supprimer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu gestion commerciale", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            var choix3 = Console.ReadLine();

            switch (choix3)
            {
                /*case "1":
                    VoirListeDesClients();
                    break;

                case "2":
                    RechercherUnClient();
                    break;

                case "3":
                    CreerUnClient();
                    break;

                case "4":
                    SupprimerClient();
                    break;*/

                case "r":
                case "R":
                    MenuGestionCommerciale();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                    Classes.Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            Console.ReadKey();

        }
    }
}