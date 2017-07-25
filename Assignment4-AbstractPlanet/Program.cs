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
 * Version: 0.2 - Implemented the GiantPlanet class
 */

namespace Assignment4_AbstractPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 9275, 1.8986e27, "Gas");
            Console.WriteLine(giantPlanet.ToString());
        }
    }
}
