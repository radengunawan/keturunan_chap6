﻿using System;
using System.Collections.Generic;
using System.Text;

namespace keturunan_chap6
{
    class KerusakanPedang
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Contains the calculated damage.
        /// </summary>
        public int Damage { get; private set; }

        private int roll;

        /// <summary>
        /// Sets or gets the 3d6 roll.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        } // end Roll


        /// <summary>
        /// Calculates the damage based on the current properties.
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }//end CalculateDamage

        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        public KerusakanPedang(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }  // END 


        private bool flaming;

        /// <summary>
        /// True if the sword is flaming, false otherwise.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        } // END Flaming

        private bool magic;
        /// <summary>
        /// True if the sword is magic, false otherwise.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        } // END Magic

    }// END class
} // END namespace
