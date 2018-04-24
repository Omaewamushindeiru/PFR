using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFR_TDF_CHETTIAR_CLUSAZ
{
    class Program
    {
        static void scenario()
        {
            Parc p = new Parc("../../../Listing.csv");
            p.AfficherAttractionsConsole(Parc.NoFilter);
            p.AfficherPersonnelConsole(Parc.NoFilter);
            p.WriteFile("../../../save.csv");
        }

        static void Main(string[] args)
        {
            scenario();
            Console.ReadKey();
        }
    }
}
