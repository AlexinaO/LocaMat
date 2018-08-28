using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL.Classes
{
    public class OffreProduit
    {
        public int Id { get; set; }

        public int IdProduit { get; set; }

        public int IdAgence { get; set; }

        public int Quantite { get; set; }
    }
}
