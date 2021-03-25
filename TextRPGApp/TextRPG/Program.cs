using System;
using System.ComponentModel;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.StartProgram();
            Console.ReadKey();
        }

        /// <summary>
        /// Starts the game 
        /// </summary>
        static void StartProgram()
        {
            MainMenu();
        }

        /// <summary>
        /// Shows the main menu and prompts the user for a command. 
        /// </summary>
        static void MainMenu()
        {
            string menu = "\t[N] - Start New Game\n"
                            + "\t[X] - Close Program\n";

            while (true)
            {
                Console.WriteLine("Type one of the commands below to start.");
                Console.Write(menu);
                string command = PromptForUserInput();

                if (command.Equals("x"))
                {
                    Environment.Exit(0);
                }
                if (command.Equals("n"))
                {
                    CreateNewCharacter();
                }
            } 
        }

        /// <summary>
        /// Prompts the user to enter a command.
        /// </summary>
        /// <returns>The user's input.</returns>
        static string PromptForUserInput()
        {
            string command;

            Console.Write("\nCommand: ");
            command = Console.ReadLine().ToLower();

            return command;
        }

        /// <summary>
        /// Starts the character creation process for a new character.
        /// </summary>
        static void CreateNewCharacter()
        {
            Hero hero = NewHero();

            Console.WriteLine("\nYour hero:");
            Console.WriteLine(hero.ToString() + "\n");

            Console.WriteLine("\nAre you happy with your choices?");
            Console.WriteLine("\nPress [Y] to start the game. Or [N] to go back to the menu.");
            string command = PromptForUserInput();

            if (command.Equals("y"))
            {
                // Start game
            }
            else
            {
                MainMenu();
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
                input = PromptForUserInput();

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
                input = PromptForUserInput();

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
            hero.Name = PromptForUserInput();

            do
            {
                // Reset the error message.
                errorMessage = string.Empty;

                Console.WriteLine("\nChoose a class: Warrior (0), Mage (1), Rogue (2) or Cleric (3). ");
                input = PromptForUserInput();

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
