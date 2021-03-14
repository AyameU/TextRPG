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
            string command = "";

            while (true)
            {
                string menu = "\tN - Start New Game\n" + "\tX - Close Program\n";

                Console.WriteLine("Type one of the commands below to start.");
                Console.Write(menu);
                Console.Write("\nCommand: ");
                command = Console.ReadLine();

                if (command == "x" ||  command == "X")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Hero hero = Program.NewHero();

                    Console.WriteLine("Your hero:");
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
            Gender gender = (Gender) Int32.Parse(input);

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

        /*
        static Gender SetGender(string input)
        {
            Gender gender;

            switch (input)
            {
                case "female":
                    gender = Gender.Female;
                    break;
                case "male":
                    gender = Gender.Male;
                    break;
            }

            return gender;
        }

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
