using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * Date July 25, 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.1 - Created the TerrestrialPlanet class
 */

namespace Assignment4_AbstractPlanet
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES
        bool _oxygen;

        // PUBLIC PROPERTIES

        // CONSTRUCTOR
        TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public bool HasMoons()
        {
            return (this.MoonCount > 0);
        }

        public bool Habitable()
        {
            return _oxygen;
        }
    }
}
