using System;
using LocaMat.Classes_Application;
using LocaMat.Business;
using LocaMat.DAL.Classes;
using LocaMat.Application.Classes_Application;

namespace LocaMat.Application.Classes_Application
{
    public class Menus
    {
        public static string MenuAccueil()
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

            return Console.ReadLine();

        }



        public static void MenuGestionAgences()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION DE LOCATION DE MATERIEL\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES AGENCES\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Liste des Agences", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Créer une Agence", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Modifier une Agence", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Supprimer une Agence", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu précédent", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    MethodesAgence.AfficherAgences();

                    break;

                case "2":
                    MethodesAgence.CreerAgence();
                    break;

                /*case "3":
                    ModifierAgence();
                    break;

                case "4":
                    SupprimerAgence();
                    break;

                case "r":
                case "R":
                    MenuAccueil();
                    break;*/

                case "q":
                case "Q":
                    break;
                default:
                    Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            Console.ReadKey();
        }

        /*public static void MenuGestionClients()
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
                    break;

                case "r":
                case "R":
                    MenuGestionCommerciale();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            Console.ReadKey();*/
    }
}
