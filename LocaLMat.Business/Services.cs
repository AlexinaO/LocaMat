using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LocaMat.DAL.Data;

namespace LocaLMat.Business
{
    public class Services
    {
        public IEnumerable<TClasseChoisie> FaireListe <TClasseChoisie > ()
            where TClasseChoisie:class
        {
            using (var contexte = new Contexte())
            {
                return contexte.Set<TClasseChoisie>().ToList();
            }
        }
    }
}
