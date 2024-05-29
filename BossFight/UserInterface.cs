using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class UserInterface
    {
        public void HeroHittingBoss(Character hero, Character boss)
        {
            int damage = hero.Fight(hero, boss);
            Console.WriteLine($"{hero.Name} hit {boss.Name} with {damage} damage.");
            if (boss.Health <= 0) WinScreen(hero);
            else Console.WriteLine($"{boss.Name} has {boss.Health} health left");
            Console.WriteLine();
        }
        public void BossHittingHero(Character boss, Character hero)
        {  
            int damage = boss.Fight(boss, hero);
            Console.WriteLine($"{boss.Name} hit {hero.Name} with {damage} damage.");
            if (hero.Health <= 0) WinScreen(boss);
            else Console.WriteLine($"{hero.Name} has {hero.Health} health left");
            Console.WriteLine();
        }

        public void WinScreen(Character winner)
        {
            Console.WriteLine();
            Console.WriteLine($"{winner.Name} is the winner with {winner.Health} health left!");
            Console.WriteLine();
            Environment.Exit(1);
        }
    }
}
