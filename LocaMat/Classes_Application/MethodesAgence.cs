using LocaMat.DAL.Classes;
using System;
using LocaMat.Business;
using LocaMat.Classes_Application;
using System.Data.Entity;

namespace LocaMat.Application.Classes_Application
{
    public class MethodesAgence
    {
        private static void CreerAgence()
        {
            Console.WriteLine();
            Console.WriteLine("Créer une nouvelle Agence");
            Console.Write("Entrer la ville :");
            var villeAgence = Console.ReadLine();
            Console.Write("Entrer l'adresse :");
            var adresseAgence = Console.ReadLine();
            var agence = new Agence();
            agence.Ville = villeAgence;
            agence.Adresse = adresseAgence;
        }

        /*private static void ModifierAgence()
        {
            Console.WriteLine();
            Console.WriteLine("Modifier une Agence");
            var agence = ChoisirAgence();
            Console.Write("Nouvelle adresse :");
            agence.Adresse = Console.ReadLine();

            var serviceAgence = new ServicesAgence();
            serviceAgence.ModifierAgence(agence);
        }*/

        /*private static Agence ChoisirAgence()
        {
            AfficherAgences();
            Console.WriteLine("Quelle agence (Id)?");
            var idAgence = int.Parse(Console.ReadLine());

            var serviceAgence = new ServicesAgence();
            serviceAgence.GetAgence(idAgence);
        }*/

        public static void AfficherAgences()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("LISTE DES AGENCES");
            var service = new Services();
            var agences = service.FaireListe<Agence>();
            foreach (var agence in agences)
            {
                Console.WriteLine($"{agence.Ville} ({agence.Id})");

            }



        }
    }
}
