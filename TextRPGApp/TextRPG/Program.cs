using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.StartGame();

            Console.ReadKey();
        }

        /// <summary>
        /// Starts the game 
        /// </summary>
        static void StartGame()
        {
            string command;

            while (true)
            {
                string menu = "\tN - Start New Game\n" + "\tX - Close Program\n";

                Console.WriteLine("Type one of the commands below to start.");
                Console.Write(menu);
                Console.Write("\nCommand: ");
                command = Console.ReadLine();

                if (command == "x" ||  command == "X")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Hero hero = NewHero();

                    Console.WriteLine("\nYour hero:");
                    Console.WriteLine(hero + "\n");
                }
            }
        }

        /// <summary>
        /// Creates a new character object.
        /// </summary>
        static Hero NewHero()
        {
            string input;

            Console.WriteLine("\nIs your character female or male? Press 0 for female or 1 for male.");
            input = Console.ReadLine();
            Gender gender = Gender.Female;

            try
            {
                gender = ValidateGender(input);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You must choose 0 or 1.");
                Console.WriteLine("\nIs your character female or male? Press 0 for female or 1 for male.");
                input = Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value cannot be empty");
                Console.WriteLine("\nIs your character female or male? Press 0 for female or 1 for male.");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nChoose a race: Human, Elf or Dwarf.");
            input = Console.ReadLine();
            Race race = (Race)Int32.Parse(input);

            Console.WriteLine("\nChoose your character's name.");
            string name = Console.ReadLine();

            Console.WriteLine("\nSet your character's hit points.");
            int hitPoints = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose a class: Warrior, Mage, Rogue or Cleric. ");
            input = Console.ReadLine();
            CharacterClass charClass = (CharacterClass)Int32.Parse(input);

            Hero hero = new Hero(gender, race, name, hitPoints, charClass);

            return hero;
        }

        /// <summary>
        /// Validates the character gender.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The specified gender.</returns>
        static Gender ValidateGender(string input)
        {
            int num = Int32.Parse(input);

            if (num < 0 || num > 1)
            {
                throw new ArgumentOutOfRangeException("The input must be 0 or 1.");
            }
            if(input is null)
            {
                throw new ArgumentNullException("The input cannot be null.");
            }
            else
            {
                Gender gender = num == 0 ? Gender.Female : Gender.Male;

                return gender;
            }
        }

        /*
        static Race SetRace(string input)
        {
            Race race;

            switch (input)
            {
                case "human":
                    race = Race.Human;
                    break;
                case "elf":
                    race = Race.Elf;
                    break;
                case "dwarf":
                    race = Race.Dwarf;
                    break;
            }

            return race;
        }

        static CharClass SetCharClass(string input)
        {
            CharClass charClass;

            switch(input)
            {
                case "warrior":
                    charClass = CharClass.Warrior;
                    break;
                case "mage":
                    charClass = CharClass.Mage;
                    break;
                case "rogue":
                    charClass = CharClass.Rogue;
                    break;
                case "cleric":
                    charClass = CharClass.Cleric;
                    break;
            }

            return charClass;
        }
        */
    }
}
