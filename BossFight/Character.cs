using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public int Strength { get; private set; }

        public int Stamina { get; private set; }


        public Character(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public int Fight(Character fighter, Character receiver)
        {
            int damage = fighter.Strength;
            receiver.Health -= damage;
            return damage;
        }

        public void Recharge()
        {

        }

        public void GetBossStrength()
        {
            Random random = new Random();
            Strength = random.Next(0, 21);
        }
    }
}
