using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocaMat.DAL.Classes
{
    public class Location
    {
        public int Id { get; set; }

        public int IdProduit { get; set; }
        [ForeignKey("IdProduit")]
        public virtual Produit Produit { get; set; }

        public int IdAgence { get; set; }
        [ForeignKey("IdAgence")]
        public virtual Agence Agence { get; set; }

        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }

        public DateTime Datedebut { get; set; }

        public DateTime DateFin { get; set; }

        public int Quantite { get; set; }

        public Decimal TotalFacture { get; set; }
    }
}
