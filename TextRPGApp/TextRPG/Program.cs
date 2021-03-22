using System;
using System.ComponentModel;

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
                string menu = "\tN - Start New Game\n" 
                            + "\tX - Close Program\n";

                Console.WriteLine("Type one of the commands below to start.");
                Console.Write(menu);
                Console.Write("\nCommand: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("x"))
                {
                    Environment.Exit(0);
                }
                if(command.ToLower().Equals("n"))
                {
                    Hero hero = NewHero();

                    Console.WriteLine("\nYour hero:");
                    Console.WriteLine(hero.ToString() + "\n");
                }
            }
        }

        /// <summary>
        /// Creates a new hero.
        /// </summary>
        static Hero NewHero()
        {
            Hero hero = new Hero();

            string input;
            string errorMessage;

            do
            {
                // Reset the error message.
                errorMessage = string.Empty;

                Console.WriteLine("\nIs your character female or male? Press 0 for female or 1 for male.");
                input = Console.ReadLine();

                try
                {
                    hero.GenderChosen = (Gender)Int32.Parse(input);
                }
                catch (InvalidEnumArgumentException)
                {
                    errorMessage = "Invalid number. You must choose 0 or 1.";
                    Console.WriteLine(errorMessage);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid character. You must choose 0 or 1.";
                    Console.WriteLine(errorMessage);
                }

                if (errorMessage.Equals(string.Empty))
                {
                    break;
                }
            }
            while (!errorMessage.Equals(string.Empty));

            do
            {
                // Reset the error message.
                errorMessage = string.Empty;

                Console.WriteLine("\nChoose a race: Human (0), Elf (1) or Dwarf (2).");
                input = Console.ReadLine();

                try
                {
                    hero.RaceChosen = (Race)Int32.Parse(input);
                }
                catch (InvalidEnumArgumentException)
                {
                    errorMessage = "You must choose 0, 1 or 2.";
                    Console.WriteLine(errorMessage);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid character. You must choose 0, 1 or 2.";
                    Console.WriteLine(errorMessage);
                }

                if (errorMessage.Equals(string.Empty))
                {
                    break;
                }
            }
            while (!errorMessage.Equals(string.Empty));

            Console.WriteLine("\nChoose your character's name.");
            hero.Name = Console.ReadLine();

            do
            {
                // Reset the error message.
                errorMessage = string.Empty;

                Console.WriteLine("\nChoose a class: Warrior (0), Mage (1), Rogue (2) or Cleric (3). ");
                input = Console.ReadLine();

                try
                {
                    hero.ClassChosen = (CharacterClass)Int32.Parse(input);
                }
                catch (InvalidEnumArgumentException)
                {
                    errorMessage = "The value must be 0, 1, 2 or 3.";
                    Console.WriteLine(errorMessage);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid character. You must choose 0, 1, 2 or 3.";
                    Console.WriteLine(errorMessage);
                }

                if (errorMessage.Equals(string.Empty))
                {
                    break;
                }
            }
            while (!errorMessage.Equals(string.Empty));

            return hero;
        }
    }
}
