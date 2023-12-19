using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class CreatePlayerCharacter
    {
        public GameCharacter RegisterPlayerCharacter()
        {
            Console.WriteLine("You wake up in the middle of a forest, You ponder what your name is (input name)");
            var name = Console.ReadLine();
            Console.WriteLine("You start looking yourself over, what kind of equipment do you carry?");
            Console.WriteLine("choose class by typing a number");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Rogue");
            Console.WriteLine("3.Archer");
            Console.WriteLine("4.Wizard");
            Console.WriteLine("5.Bard");
            Console.WriteLine("6.Farmer");
            Console.WriteLine("7.Village Idiot");
            Console.WriteLine("8. You recall dying(isekai)");
            var characterClass = Console.ReadLine();
            string description = "";
            string playerClass = "";
            switch (characterClass)
            {
                case "1":
                    playerClass = "Warrior";
                    description = $" a master of combat, specializing in the use of heavy armor and powerful weapons. Known for their strength and resilience, warriors excel in close-quarter battles,acting as the frontline defenders of their party.";
                    Console.WriteLine(name + " The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "2":
                    playerClass = "Rogue";
                    description = $" a master of shadows, with a preference using leather that is easy to maneuver in.";
                    Console.WriteLine(name + " The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "3":
                    playerClass = "Archer";
                    description = $"{playerClass} excels at ranged combat, using either a bow or crossbow they can hit targets with extreme precision!";
                    Console.WriteLine(name + " The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "4":
                    playerClass = "Wizard";
                    description = $"{playerClass}'s use the energy of the world called 'Mana' to cast powerful spells, most {playerClass} chose a path to go down, eg: fire, water, air, space";
                    Console.WriteLine(name + " The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "5":
                    playerClass = "Bard";
                    description = $"{playerClass} use instruments such as flutes, drums etc to channel the magic of the world into musical sounds to heal/buff their allies or de-buff their opponents. ";
                    Console.WriteLine(name + " The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;

                case "6":
                    playerClass = "Farmer";
                    description = $"a {playerClass} Working in the fields day and night {name} have made quite some muscles, {playerClass} Strength +3, charisma -1, people from other areas and highborn look down on {playerClass}.";
                    Console.WriteLine(name + "  The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "7":
                    playerClass = "Village Idiot";
                    description =
                        $"Coming from a lowly upbringing as the 7th child in a rural village {name} had extremely little education and guidance, honestly a miracle {name} have made it this far, people see {name} as the {playerClass}";
                    Console.WriteLine(name + "  The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "8":
                    playerClass = "Chosen One";
                    description = $"a person who have died and been reborn, some call it 'Isekaid' ";
                    Console.WriteLine(name + "  The" + " " + playerClass);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("Do you notice anything with your physical appearance? Yes/No");
            var input = Console.ReadLine();
                switch (input.ToLower())
                {
                case "yes":
                    Console.WriteLine("What!? How so? what do you look like?!(describe yourself, race etc)");
                    description = Console.ReadLine();
                    Console.WriteLine(name + "  The" + " " + playerClass + " is described as " + description);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                case "no":
                    Console.WriteLine("You take a deep breath and look at yourself:");
                    Console.WriteLine(name + "  The" + " " + playerClass + " is described as " + description);
                    Console.WriteLine("Hit a key to continue");
                    Console.ReadKey();
                    break;
                }
                return new GameCharacter(name, description,  100, 20, 200, playerClass);
        }
    }
}
