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
        private int hitPoints;

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
        /// Gets and sets the character's hit points.
        /// </summary>
        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be lesser than 0.");
                }

                this.hitPoints = value;
            }
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
            this.hitPoints = 50;
        }

        /// <summary>
        /// Initializes the character with the specified gender, race, name
        /// and hit points.
        /// </summary>
        /// <param name="genderChosen">The character's gender.</param>
        /// <param name="raceChosen">The character's race.</param>
        /// <param name="name">The character's name.</param>
        public Character(Gender genderChosen, Race raceChosen, string name, int hitPoints)
        {
            this.GenderChosen = genderChosen;
            this.RaceChosen = raceChosen;
            this.Name = name;
            this.HitPoints = hitPoints;
        }

        public override string ToString()
        {
            return this.Name + " is a " 
                + this.GenderChosen + " " 
                + this.RaceChosen;
        }
    }
}
