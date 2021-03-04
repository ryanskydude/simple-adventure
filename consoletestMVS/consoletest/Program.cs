using System;

namespace consoletest
{
    public static class Game
    {

        public static void StartGame()
        {
            String title = @"

 _____ _                 _      
/  ___(_)               | |     
\ `--. _ _ __ ___  _ __ | | ___ 
 `--. \ | '_ ` _ \| '_ \| |/ _ \
/\__/ / | | | | | | |_) | |  __/
\____/|_|_| |_| |_| .__/|_|\___|
                  | |           
                  |_|           
  ___      _                 _                  
 / _ \    | |               | |                 
/ /_\ \ __| |_   _____ _ __ | |_ _   _ _ __ ___ 
|  _  |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
| | | | (_| |\ V /  __/ | | | |_| |_| | | |  __/
\_| |_/\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|";

            Console.ForegroundColor = ConsoleColor.Red;
            //this is the code for the title big man
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine("By SamuraiWeebR");
            Console.WriteLine("This is A Very Basic Game.");
            Console.WriteLine("DISCLAIMER: This is game is really simple. i doubt you will enjoy it. \n do you accept the fact that this game could be quick or crap?");
            string userResponse = Console.ReadLine();
            //eula to tell someone to fuck off if they gonna judge
            if (userResponse == "Yes")
            {
                Console.WriteLine("Then enjoy the experience.");
            }
            else if (userResponse == "No" || userResponse == "no")
            {
                Console.WriteLine("Then Go Away.");
                Environment.Exit(5);
            }
            //here comes the fun part
            Console.WriteLine("What is your name?");
            string characterName = Console.ReadLine();
            Console.WriteLine("Your Name is " + characterName + "!");
            Console.WriteLine("What is your age?");
            var characterAge = Convert.ToInt16(Console.ReadLine());
            if (characterAge < 18)
            {
                Console.WriteLine("You can't be UnderAge!");
                return;
            }
            else if (characterAge > 18)
            {
                Console.WriteLine("Your Age is " + characterAge + "!");
            }
            //game starts now.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //the fuckin variables that semi work.
            double armorToughness = 0.1;
            double attackDamage = 10.50 - armorToughness;
            double enemyAttack = 5.00;
            double enemyHP = 20.00;
            double playerHP = 20.00;
            bool dead = false;
           //all right now its the game
            Console.WriteLine("You Enter the Temple, It's Walls shining a blue hue. 'my first quest' you thought, as you entered. what do you do?");
            string userAction = Console.ReadLine();
            if (userAction == "walk" || userAction == "run")
            {
                Console.WriteLine("you move deeper into the temple, when suddenly, a goblin appears! what will you do?");
            }
            userAction = Console.ReadLine();
            armorToughness = 2.5;
            //shitty fight code
            while (!dead)
            {
                Console.WriteLine("The Goblin stands before you, growling in gibberish. \n HP: " + enemyHP + "\n Your HP: " + playerHP);
                if (userAction == "Attack" || userAction == "attack")
                {
                    Console.WriteLine("You attack the Goblin for " + attackDamage + "!");
                    enemyHP = enemyHP - attackDamage;
                    Console.WriteLine("He has " + enemyHP + " hp left!");
                    playerHP = playerHP - enemyAttack;
                    Console.WriteLine("The Goblin hits you with his dagger! \n You have " + playerHP + " HP left!");
                }
                else if (userAction == "run" || userAction == "run away")
                {
                    Console.WriteLine("the Goblin stops you from running. you are cornered!");
                    Console.WriteLine("The Goblin hits you with his dagger!");
                    playerHP = playerHP - enemyAttack;
                    Console.WriteLine("you have " + playerHP + " HP left!");
                }
                Console.ReadLine();
                if(enemyHP >= 0 || playerHP >= 0)
                {
                    dead = true;
                }
            }
            //once again, shit code that when i learn how to do better, is gonna get removed.
            
            if (playerHP <= 0)
            {
                Console.WriteLine("You have perished.");
            }
            else if (enemyHP <= 0)
            {
                Console.WriteLine("You have defeated the Goblin!");
            }

        }
    }
    class Item { 
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game.StartGame();
            //this is entirely for debug purpose and is probably gonna get removed for the release.
            Console.WriteLine("The Game has Shut Down. if your seeing this, it probably crashed.");
            Console.ReadKey();
        }
    }
}
