using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class Combat
    {
        public bool Combatant { get; set; }


        public Combat(bool combat)
        {
            Combatant = combat;
        }

        public void StartCombat(GameCharacter Player, params IEnemy[] enemies)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (Player == null || enemies == null || enemies.Length == 0)
            {
                Console.WriteLine("Invalid characters for combat.");
                return;
            }

            Console.WriteLine($"{Player.Name} engages in combat with:");

            foreach (var enemy in enemies)
            {
                Console.WriteLine($" - {enemy.Name} ({enemy.Health} HP)");
            }

            while (Player.Health > 0 && enemies.Any(e => e.Health > 0))
            {

                foreach (var enemy in enemies)
                {
                    if (enemy.Health > 0)
                    {
                        Player.Attack(enemy, GameCharacter.AttackType.Cleave);
                    }
                }

                foreach (var enemy in enemies)

                {
                    if (enemy.Health > 0)
                    {
                        enemy.Attack(Player);
                    }
                }

                Console.WriteLine($"{Player.Name} - {Player.Health} HP");
                Console.WriteLine($"Remaining stamina: {Player.Stamina}.");
                foreach (var enemy in enemies)
                {
                    Console.WriteLine($"{enemy.Name} - {enemy.Health} HP");
                    Console.WriteLine($"Remaining stamina: {enemy.Stamina}.");

                }

                Console.WriteLine("Continue by pressing a key");
                Console.ReadKey();
                Console.Clear();

                System.Threading.Thread.Sleep(1000);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            StopCombat(Player, enemies);

        }

        public void StopCombat(GameCharacter Player, params IEnemy[] enemies)
        {
            if (Player.Health > 0)
            {
                foreach (var enemy in enemies)
                {
                    Console.WriteLine($" - {Player.Name} defeats {enemy.Name}");
                    Console.WriteLine($"{Player.Name} has {Player.Health} HP and {Player.Stamina}");
                }
            }
            else
            {
                Console.Write("Enemies ");
                foreach (var enemy in enemies)
                {
                    Console.Write($"{enemy.Name}, ");
                }

                Console.WriteLine($"slaughter {Player.Name}");
            }
        }
    }
}
