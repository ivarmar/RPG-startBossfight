using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Bossfight
{
    internal class GameCharacter
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int Stamina { get; set; }

        public string PlayerClass { get; set; }



        public GameCharacter(string name, string description, int health, int strength, int stamina, string playerClass)
        {
            Name = name;
            Description = description;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            PlayerClass = playerClass;
        }

        public void Attack(IEnemy enemy, AttackType attackType)
        {
            switch (attackType)
            {
                case AttackType.Cleave:
                    CleaveAttack(enemy);
                    break;
            }
        }

        public enum AttackType
        {
            Cleave,
            Slash,
        }
        private void CleaveAttack(IEnemy enemy)
        {
            if (Stamina > 0 && Health > 1)
            {
                
                int CleaveDamage = HelperClass.RandomGenerator.GenerateRandomNumber(1, 10);
                Console.WriteLine($"{Name}, doing {CleaveDamage} damage to {enemy.Name}");
                enemy.Health -= CleaveDamage;
                var staminaLoss = 30;

                Stamina = (Stamina - staminaLoss < 0) ? 0 : Stamina - staminaLoss;


                

            }
            else if (Stamina  < 0)
            {
                Recharge();
            }
            else if (Health < 0)
            {
                Console.WriteLine("Game Over");
            }
        }

        public void Recharge()
        {
            Console.WriteLine("You gained 200 stamina and 10 health");
            Stamina += 200;
            Health += 10;
        }
    }
}
