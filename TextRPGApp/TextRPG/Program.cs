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

            do
            {
                Program.PrintStartMenu();
                command = Console.ReadLine();

                Program.NewCharacter();
            }
            while (command != "x" || command != "X");
        }

        /// <summary>
        /// Prints the start menu.
        /// </summary>
        static void PrintStartMenu()
        {
            string menu = "N - Start New Game\n" + "X - Close Program\n";

            Console.WriteLine("Type one of the commands below to start.");
            Console.Write(menu);
        }

        /// <summary>
        /// Creates a new character object.
        /// </summary>
        static void NewCharacter()
        {
            string gender;
            string race;
            string charClass;
            string name;

            Character character = new Character(gender, race, charClass, name);
        }
    }
}
