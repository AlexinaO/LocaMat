using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LocaMat.DAL.Data
{
    public class Contexte : DbContext
    {
        public DbSet<Agence> Agences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OffreProduit> OffresProduits { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
