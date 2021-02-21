using System;
using System.ComponentModel;

namespace TextRPG
{
    public class Hero : Character
    {
        private CharClass charClass;

        public CharClass ClassChosen
        {
            get
            {
                return this.charClass;
            }

            set
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
