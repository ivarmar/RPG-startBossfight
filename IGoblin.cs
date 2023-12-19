using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal interface IGoblin
    {
       
    }
    internal class Goblin : IEnemy
    {
        public string Name { get; }
        public int Health { get; set; }

        public int Stamina { get; set; }

        public Goblin(string name, int health, int stamina)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
        }

        public void Attack(GameCharacter target)
        {
            SlashAttack(target);
        }

        private void SlashAttack(GameCharacter target)
        {

            int SlashDamage = HelperClass.RandomGenerator.GenerateRandomNumber(5, 10);
            Console.WriteLine($"{Name} Slashes his rusty sword!");
            target.Health -= SlashDamage;
            Stamina -= SlashDamage -3;
            Console.WriteLine($"{target.Name} took {SlashDamage} damage!");
        }
    }

    internal class Worgen : IEnemy
    {
        public string Name { get; }
        public int Health { get; set; }

        public int Stamina { get; set; }

        public Worgen(string name, int health, int stamina)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
        }

        public void Attack(GameCharacter target)
        {
            BiteAttack(target);
        }

        private void BiteAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name} lunges towards you!");

            int BiteDamage = HelperClass.RandomGenerator.GenerateRandomNumber(1, 11);
            target.Health -= BiteDamage;
            Stamina -= BiteDamage;

            if (BiteDamage == 10)
            {
                Console.WriteLine($"{Name} crits with {BiteDamage}! {Name} gains 'BloodLust'!");
                BloodLust(target);

            }
            else
            {
                Console.WriteLine($"{target.Name} took {BiteDamage}  bite damage!");
            }
        }

        private void BloodLust(GameCharacter target)
        {
            Console.WriteLine($"{Name} tastes the blood flowing from your veins into his mouth, becoming hungry for more! ");
            
            int BloodLust = HelperClass.RandomGenerator.GenerateRandomNumber(1, 5);
            if (BloodLust is 3 or 2)
            {
                Console.WriteLine($"{Name} goes in for another bite!");
                BiteAttack(target);
                Console.WriteLine($"{target.Name} has {target.Health} Health.");
                Console.WriteLine($"{Name} becomes vigorated and heals from your blood!");
                Health += 3;
                Console.WriteLine($"{Name} restored 3 HP, and now has {Health} Health.");
            }

        }
    }
}
