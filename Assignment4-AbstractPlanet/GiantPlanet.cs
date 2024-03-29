﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date July 25, 2017
 * Description: This is the GiantPlanet class
 * Version: 0.4 - Fixed the access level for the constructor
 */

namespace Assignment4_AbstractPlanet
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES
        string _type;

        // PUBLIC PROPERTIES

        // CONSTORUCTOR

        /// <summary>
        /// This is the main constructor for the GiantPlanet class
        /// It takes four parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name, diameter, mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public bool HasMoons()
        {
            if(this.MoonCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (this.RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
