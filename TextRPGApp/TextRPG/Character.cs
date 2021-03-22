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
        /// Occurs when the character's hit points are less than or equal to zero.
        /// </summary>
        public event EventHandler CharacterDeath;

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
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the enumerator is not valid.
        /// </exception>
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
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the enumerator is not valid. 
        /// </exception>
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
        /// Gets and sets the character's hit points.
        /// </summary>
        public int HitPoints
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor, with hit points set to 50.
        /// </summary>
        public Character()
        {
            this.HitPoints = 50;
        }

        /// <summary>
        /// Initializes the character with the specified gender, race, name
        /// and hit points to 50.
        /// </summary>
        /// <param name="genderChosen">The character's gender.</param>
        /// <param name="raceChosen">The character's race.</param>
        /// <param name="name">The character's name.</param>
        public Character(Gender genderChosen, Race raceChosen, string name)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
            this.HitPoints = 50;
        }

        /// <summary>
        /// Returns a string representation of a character's name, gender and race.
        /// </summary>
        /// <returns>
        /// A string representation of a character's name, gender and race.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} is a {1} {2} with {3} hit points.",
                                 this.Name,
                                 this.GenderChosen,
                                 this.RaceChosen,
                                 this.HitPoints);
        }

        /// <summary>
        /// Raises the character death event.
        /// </summary>
        protected virtual void OnCharacterDeath()
        {
            if (this.CharacterDeath != null)
            {
                this.CharacterDeath(this, new EventArgs());
            }
        }
    }
}
