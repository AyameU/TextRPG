﻿using System;
using System.ComponentModel;

namespace TextRPG
{
    /// <summary>
    /// Represents the main hero character of the story.
    /// </summary>
    public class Hero : Character
    {
        private CharacterClass characterClass;

        /// <summary>
        /// Gets and sets the hero's class.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the value is not a valid enumeration.
        /// </exception>
        public CharacterClass ClassChosen
        {
            get
            {
                return this.characterClass;
            }

            set
            {
                if (!Enum.IsDefined(typeof(CharacterClass), value))
                {
                    throw new InvalidEnumArgumentException("The value is not a valid enumeration.");
                }

                this.characterClass = value;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Hero()
        {
        }

        /// <summary>
        /// Initializes a hero character with the specified gender, race, name, class 
        /// and with hit points set to 50.
        /// </summary>
        public Hero(Gender genderChosen, Race raceChosen, string name, CharacterClass characterClass) 
            : base(genderChosen, raceChosen, name)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
            this.ClassChosen = characterClass;
            this.HitPoints = 50;
        }

        /// <summary>
        /// Returns a string representation of the hero's name, gender, race and class.
        /// </summary>
        /// <returns>
        /// A string representation of the hero's name, gender, race and class.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} is a {1} {2} {3} with {4} hit points.",
                                 this.Name, 
                                 this.GenderChosen, 
                                 this.RaceChosen, 
                                 this.ClassChosen, 
                                 this.HitPoints);
        }
    }
}
