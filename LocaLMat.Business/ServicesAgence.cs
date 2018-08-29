using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LocaMat.DAL.Data;
using LocaMat.DAL.Classes;

namespace LocaMat.Business
{
    public class ServicesAgence
    {
        public void CreerAgence(Agence agence)
        {
            using (var contexte = new Contexte())
            {
                contexte.Agences.Add(agence);
                contexte.SaveChanges();
            }
        }

        public void ModifierAgence(Agence agence)
        {
            using (var contexte = new Contexte())
            {
                contexte.Agences.Attach(agence);
                contexte.Entry(agence).State = EntityState.Modified;
                contexte.SaveChanges();
            }
        }

        public void SupprimerAgence(Agence agence)
        {
            using (var contexte = new Contexte())
            {
                contexte.Entry(agence).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
        /*public IEnumerable<Agence> ListerAgences()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Marques
                    .Include(x => x.Modeles)
                    .OrderBy(x => x.Nom).ToList();
            }
        }*/
    }
}
