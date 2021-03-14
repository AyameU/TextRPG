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
        /// Creates a new hero.
        /// </summary>
        static Hero NewHero()
        {
            Hero hero = new Hero();
            string input;

            Console.WriteLine("\nIs your character female or male? Press 0 for female or 1 for male.");
            input = Console.ReadLine();

            try
            {
                hero.GenderChosen = (Gender)Int32.Parse(input);
            }
            catch (InvalidEnumArgumentException)
            {
                Console.WriteLine("You must choose 0 or 1.");
            }

            Console.WriteLine("\nChoose a race: Human (0), Elf (1) or Dwarf (2).");
            input = Console.ReadLine();

            try
            {
                hero.RaceChosen = (Race)Int32.Parse(input);
            }
            catch (InvalidEnumArgumentException)
            {
                Console.WriteLine("You must choose 0, 1 or 2.");
            }

            Console.WriteLine("\nChoose your character's name.");
            hero.Name = Console.ReadLine();

            Console.WriteLine("\nSet your character's hit points. Choose a value between 1 and 100.");

            try
            {
                hero.HitPoints = Int32.Parse(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The value must be between 1 and 100.");
            }

            Console.WriteLine("\nChoose a class: Warrior (0), Mage (1), Rogue (2) or Cleric (3). ");
            input = Console.ReadLine();

            try
            {
                hero.ClassChosen = (CharacterClass)Int32.Parse(input);
            }
            catch (InvalidEnumArgumentException)
            {
                Console.WriteLine("The value must be 0, 1, 2 or 3.");
            }

            return hero;
        }
    }
}
