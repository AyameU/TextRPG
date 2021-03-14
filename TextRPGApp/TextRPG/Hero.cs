using System;
using System.ComponentModel;

namespace TextRPG
{
    /// <summary>
    /// Represents the main hero character of the story.
    /// </summary>
    public class Hero : Character
    {
        private CharClass charClass;

        /// <summary>
        /// Gets and sets the hero's class.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the value is not a valid enumeration.
        /// </exception>
        public CharClass ClassChosen
        {
            get
            {
                return this.charClass;
            }

            private set
            {
                if (!Enum.IsDefined(typeof(CharClass), value))
                {
                    throw new InvalidEnumArgumentException("The value is not a valid enumeration.");
                }

                this.charClass = value;
            }
        }

        /// <summary>
        /// Initializes a hero character with the specified gender, race, name, class 
        /// and with hit points set to 50.
        /// </summary>
        public Hero(Gender genderChosen, Race raceChosen, string name, CharClass charClass) 
            : base(genderChosen, raceChosen, name)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
            this.ClassChosen = charClass;
        }

        /// <summary>
        /// Initializes a hero character with the specified gender, race, name, class 
        /// and hit points.
        /// </summary>
        public Hero(Gender genderChosen, Race raceChosen, string name, int hitPoints, CharClass charClass)
            : base(genderChosen, raceChosen, name, hitPoints)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
            this.HitPoints = hitPoints;
            this.ClassChosen = charClass;
        }

        /// <summary>
        /// Returns a string representation of the hero.
        /// </summary>
        /// <returns>A string representation of the hero.</returns>
        public override string ToString()
        {
            return this.Name + " is a " 
                + this.GenderChosen + " " 
                + this.RaceChosen + " " 
                + this.ClassChosen;
        }
    }
}
