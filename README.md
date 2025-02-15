# TextRPG
My attempt at a text-based console RPG to practice the fundamentals of C#.

I've created a basic activity diagram outlining the opening menu and character creation interface. I am going to start there.

**Update 1 - Mar. 13** - Enum classes are easy. Everything else not so much...

**Update 2 - Mar. 13** - I'm overthinking things. I have way too many things happening in my Program file and the methods are overly long. I need to refactor the entire character creation process to utilize the exception handling in the hero class. Right now I'm duplicating a lot of code and validation just to instantiate a new hero object. I could use the default constructor (which I totally have right now... /s) instead and validate everything with the property setters.

**Update 3 - Mar. 14** - Refactored the character creation "screen" to use the default constructor and class properties instead of the mess of code I had before. It technically works now, unless exceptions are thrown. I handle the exceptions but the user isn't prompted to re-enter the input and it moves to the next step. I need to prompt the user for input until the input is valid.

**Update 4 - Mar. 22** - Changed the character creation screen to prompt the user (until death if they choose to be stubborn) for input until they give a valid value. Added some exception handling to deal with invalid characters (like a letter when a number is expected) and invalid enums.

The option to set the character's hit points has been removed from the character creation. I don't want anyone using an absurd amount like 2,147,483,647 or something else akin to godhood. Everybody can just start on an even playing field at 50 HP. I deleted the related constructors from the Hero and Character classes and changed the character default constructor slightly.

Things work so far, but here's a list of things I should implement:
* Duplicate code in the do-while loops of the character creation screen, should be rewritten.
* A lot of code in the Program.cs file that really should go in its own class.
* I could turn this into a WinForms app, now that I'm learning it.

**Update 5 - Mar. 25** - Rewrote some of my longer blocks of code in Program.cs into smaller, more reusable methods. For example, I now have a PromptUserForInput() method that prompts the user for input. This cut down on a lot of duplicate code. The main method now consists of just one line of code to show the main menu.
