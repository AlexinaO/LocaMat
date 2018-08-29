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
        public static void FaireListe(IEnumerable <ClasseChoisie>)
        {
            using (var contexte = new Contexte())
            {
                return contexte.ClasseChoisie
                    .OrderBy(x => x.ClasseChoisie).ToList();
            }
        }
    }
}
