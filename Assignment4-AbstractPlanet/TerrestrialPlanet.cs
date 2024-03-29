﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date July 25, 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.3 - Fixed the access level for the constructor
 */

namespace Assignment4_AbstractPlanet
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES
        bool _oxygen;

        // PUBLIC PROPERTIES

        // CONSTRUCTOR

        /// <summary>
        /// This is the main constructor for the TerrestrialPlanet class
        /// It takes four parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
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
