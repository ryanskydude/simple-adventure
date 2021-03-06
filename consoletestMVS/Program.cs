using System;

namespace consoletest
{
    public static class Game
    {


        public static void StartGame()
        {
            double releaseVersion = 0.1;
            string branchLevel = "alpha";
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
            Console.WriteLine("Release Ver: " + releaseVersion + branchLevel);
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
            double armorToughness = 0.1;
            double attackDamage = 10.50 - armorToughness;
            double enemyAttack = 5.00;
            double enemyHP = 20.00;
            double playerHP = 20.00;
            double playerHealing = 0;
            bool dead = false;
            Console.WriteLine("You Enter the Temple, It's Walls shining a blue hue. 'my first quest' you thought, as you entered. what do you do?");
            string userAction = Console.ReadLine();
            if (userAction == "walk" || userAction == "run")
            {
                Console.WriteLine("you move deeper into the temple, when suddenly, a goblin appears! what will you do?");
            }
            userAction = Console.ReadLine();
            armorToughness = 2.5;
            while (!dead)
            {
                Console.WriteLine("The Goblin stands before you, growling in gibberish. \n HP: " + enemyHP + "\n Your HP: " + playerHP);
                if (userAction == "attack" || userAction == "Attack")
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
                if (enemyHP <= 0 || playerHP <= 0)
                {
                    dead = true;
                }
            }
            if (playerHP <= 0)
            {
                Console.WriteLine("you have perished.");
                Console.WriteLine("ending achieved! weak");
                Environment.Exit(6);
            }
            if (enemyHP <= 0)
            {
                Console.WriteLine("you have killed the goblin!");
            }
            Console.WriteLine("as you proceed further into the temple, 2 entrances appear. will you take the left or the right?");
            userAction = Console.ReadLine();
            if (userAction == "left")
            {
                Console.WriteLine("a chest lays before you. what do you do?");
                userAction = Console.ReadLine();
                if (userAction == "open")
                {
                    Console.WriteLine("you open the chest! you found: \n 10 healing items! \n Steel sword! attack increased!");
                    playerHealing = 10;
                    attackDamage = attackDamage + 5;
                    Console.WriteLine("you head back and head down the right path.");
                    userAction = Console.ReadLine();
                }

            }
            else if (userAction == "right")
            {
                Console.WriteLine("you head down the hallway, noticing the walls are changing color.");
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("the Walls turn a red hue. you know your reaching the end of the temple. what will you do?");
            userAction = Console.ReadLine();
            if (userAction == "walk" || userAction == "run")
            {
                Console.WriteLine("you proceed down the path way. the path breaks into a open room, the size of a cathedral. \n the goblin lord stands infront of you, sharpening his cleaver.");
                Console.WriteLine("\"you have come, human.\" he speaks with a coarse voice, clearly new to english.");
                userAction = Console.ReadLine();
                Console.WriteLine("\"honestly, i did not expect you here. but, i have a deal for you.\" he said, as he picked up his cleaver and stowed it over his shoulder.");
                Console.WriteLine("\"i could give you the best equipment the goblin army has, and a little gold to come with it. \n all you have to do is let me go. what do you think?\" he looks at you with comforting eyes.");
                Console.WriteLine("Trade offered! you will get: \n 300 gold \n dark steel armor (+ 20 health) \n dark steel sword (+10 damage) \n will you accept?");

                userAction = Console.ReadLine();
                if(userAction == "accept" || userAction == "accept the trade")
                {
                    Console.WriteLine("\"you have made a good decision. here, take it.\" he hands you the gifts, as he escapes through a trap door.");
                    Console.WriteLine("you head home, with your new gear on, and way richer than before. ending achieved! Greedy");
                    Console.WriteLine("Thanks for playing my demo of my new game: simple adventure! as i learn to code, the newer games and versions will be released. check my github often!");
                    Console.ReadLine();
                    Environment.Exit(10);
                }
                else if(userAction == "decline" || userAction == "attack")
                {
                    Console.WriteLine("\"you have made a poor decision! face my cleaver!\"");
                    enemyHP = 60;
                    enemyAttack = 10;
                    dead = false;
                }
                while(!dead)
                {
                    Console.WriteLine("the Goblin Lord stands before you, his cleaver ready to swing. \n Goblin Lord HP: " + enemyHP + " \n Your HP: " + playerHP + " \n Healing items: " + playerHealing + " \n what will you do?");
                    userAction = Console.ReadLine();
                    if(userAction == "attack" || userAction == "Attack")
                    {
                        Console.WriteLine("you slash at him with your sword, dealing " + attackDamage + "!");
                            enemyHP = enemyHP - attackDamage;
                        Console.WriteLine("the Goblin Lord swings his cleaver at you, dealing " + enemyAttack + "!");
                            playerHP = playerHP - enemyAttack;
                    }
                    if(userAction == "heal")
                    {
                        Console.WriteLine("you consume a healing item, Restoring 15 HP!");
                        playerHealing --;
                        playerHP = playerHP + 15;
                        Console.WriteLine("The Goblin Lord swings his cleaver at you, dealing " + enemyAttack + "!");
                        playerHP = playerHP - 10;

                    }
                    if (playerHP <= 0 || enemyHP <= 0)
                    {
                        dead = true;
                    }
                    
                }
                if(playerHP <= 0)
                {
                    Console.WriteLine("The Goblin King Stands before you. \"foolish human. you should of accepted the trade.\"");
                    Console.WriteLine("he lifted his cleaver over his head, bringing it down on your neck, you head coming clean off.");
                    Console.WriteLine("you have perished. \n ending achieved! slayed by the Lord");
                    Console.WriteLine("Thanks for playing my demo of my new game: simple adventure! as i learn to code, the newer games and versions will be released. check my github often!");
                    userAction = Console.ReadLine();
                    Environment.Exit(10);
                }
                if(enemyHP <= 0)
                {
                    Console.WriteLine("you run up the the Goblin Lord, jump up and swing at his neck. his green ugly head rolls around on the floor. \n the Goblin Lord is defeated.");
                    Console.WriteLine("you walk to your home village, bearing the Lords head. the town praises your heroic deeds.");
                    Console.WriteLine("Ending achieved! True Hero");
                    Console.WriteLine("Thanks for playing my demo of my new game: simple adventure! as i learn to code, the newer games and versions will be released. check my github often!");
                    userAction = Console.ReadLine();
                    Environment.Exit(10);
                }
            }
        }   

    }


    class Item
    {
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game.StartGame();
            Console.WriteLine("The Game has Shut Down. you shouldn't be seeing this enless i messed up.");
            Console.ReadKey();
        }
    }
}

