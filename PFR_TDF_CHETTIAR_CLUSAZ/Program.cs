using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Parc p = new Parc("Listing.csv");
            p.AfficherAttractionsConsole(Parc.NoFilter);
            p.AfficherPersonnelConsole(Parc.NoFilter);
            Console.ReadKey();
        }
    }
}
