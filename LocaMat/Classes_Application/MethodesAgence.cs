﻿using LocaMat.DAL.Classes;
using System;
using LocaMat.DAL;

namespace LocaMat.DAL.Data
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

        private static void ModifierAgence()
        {
            Console.WriteLine();
            Console.WriteLine("Modifier une Agence");
            var agence = ChoisirAgence();
            Console.Write("Nouvelle adresse :");
            agence.Adresse = Console.ReadLine();

            var serviceAgence = new ServicesAgence();
            serviceAgence.ModifierAgence(agence);
        }

        private static Agence ChoisirAgence()
        {
            ListerAgences();
            Console.WriteLine("Quelle agence (Id)?");


        }
    }
}
