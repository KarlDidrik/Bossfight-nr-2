using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight_nr_2
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }


        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Recharge()
        {
            Console.WriteLine("Not enough stamina, i need to recharge.");
            Stamina = 40;
        }

        public void Fight(GameCharacter opponent)
        {
            if (Stamina == 0)
            {
                Recharge();
            }
            else
            {
                int damage = opponent.Strength;
                Health -= damage;

                Console.WriteLine($"Enemy hit hero with {damage} damage, hero now has {Health} health left.");
                Stamina -= 10;
            }
        }
    }
}
