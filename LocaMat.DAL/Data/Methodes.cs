using LocaMat.DAL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL.Data
{
    public class Methodes
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
    }
}
