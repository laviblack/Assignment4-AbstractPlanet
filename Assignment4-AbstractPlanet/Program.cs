using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date July 25, 2017
 * Description: Assignment4
 * Version: 0.4 - Added and implemented the WaitForAnyKey method
 */

namespace Assignment4_AbstractPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 9275, 1.8986e27, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 4879, 3.3011e23, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }
        static void WaitForAnyKey()
        {
            Console.Write("Press any key...");
            Console.Read();
        }
    }
}
