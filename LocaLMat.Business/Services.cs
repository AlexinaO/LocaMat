﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LocaMat.DAL.Data;
using LocaMat.DAL.Classes;

namespace LocaMat.Business
{
    public class Services
    {
        public IEnumerable<TClasseChoisie> FaireListe<TClasseChoisie>()
            where TClasseChoisie : class
        {
            using (var contexte = new Contexte())
            {
                return contexte.Set<TClasseChoisie>().ToList();
            }
        }

        /*public static void Creer(class TClasseChoisie)
        {
            if (TClasseChoisie == Agence | TClasseChoisie == Location | TClasseChoisie == OffreProduit)
            {
                Console.Write($"Créer une nouvelle {TClasseChoisie} :");
            else Console.Write($"Créer un {TClasseChoisie} :");
            }
            var */
        
       
     }
}
