# TextRPG
My attempt at a text-based console RPG to practice the fundamentals of C#.

I've created a basic activity diagram outlining the opening menu and character creation interface. I am going to start there.

**Update 1** - Enum classes are easy. Everything else not so much...

**Update 2** - I'm overthinking things. I have way too many things happening in my Program file and the methods are overly long. I need to refactor the entire character creation process to utilize the exception handling in the hero class. Right now I'm duplicating a lot of code and validation just to instantiate a new hero object. I could use the default constructor (which I totally have right now... /s) instead and validate everything with the property setters.
