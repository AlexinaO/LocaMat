using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LocaMat.Application;
using LocaMat.DAL;


namespace LocaMat.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                var choix = Classes_Application.Menus.MenuAccueil();
                switch (choix)
                {
                    case 1:
                        Classes_Application.Menus.MenuGestionAgences();
                        break;

                    case 2:
                        Classes_Application.Menus.MenuGestionProduits();
                        break;
                    case 3:
                        Classes_Application.Menus.MenuGestionClients();
                        break;
                    case 4:
                        Classes_Application.Menus.MenuGestionLocations();
                        break;
                    case 5:
                        Classes_Application.Menus.MenuGestionOffresProduits();
                        break;
                    case Q:
                    case q:
                        Environment.Exit(0);
                        break;
                 }


            }
        }
    }
}
