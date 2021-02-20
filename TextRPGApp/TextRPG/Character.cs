using System;
using System.ComponentModel;

namespace TextRPG
{
    /// <summary>
    /// Represents a character.
    /// </summary>
    public abstract class Character
    {
        private Gender genderChosen;
        private Race raceChosen;

        /// <summary>
        /// Gets and sets the character name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the gender chosen.
        /// </summary>
        public Gender GenderChosen
        {
            get
            {
                return this.genderChosen;
            }

            set
            {
                if(!Enum.IsDefined(typeof(Gender), value))
                {
                    throw new InvalidEnumArgumentException("The value is not a valid enumeration.");
                }

                this.genderChosen = value;
            }
        }

        /// <summary>
        /// Gets and sets the race chosen.
        /// </summary>
        public Race RaceChosen
        {
            get
            {
                return this.raceChosen;
            }

            set
            {
                if(!Enum.IsDefined(typeof(Race), value))
                {
                    throw new InvalidEnumArgumentException("The value is not a valid enumeration.");
                }

                this.raceChosen = value;
            }
        }

        /// <summary>
        /// Initializes the character with the specified gender, race and name.
        /// </summary>
        /// <param name="genderChosen">The character's gender.</param>
        /// <param name="raceChosen">The character's race.</param>
        /// <param name="name">The character's name.</param>
        public Character(Gender genderChosen, Race raceChosen, string name)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
        }
    }
}
