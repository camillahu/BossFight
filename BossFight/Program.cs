using BossFight;

Run();
 void Run()
 {
     bool running = true;
     

     var hero = new Character("Hero", 100, 20, 40);
     var boss = new Character("Boss", 400, 0, 10);
     var ui = new UserInterface();
     
    
     while (running)
     { 
        boss.GetBossStrength();
        ui.HeroHittingBoss(hero, boss);
        ui.BossHittingHero(boss, hero);
     }
}




