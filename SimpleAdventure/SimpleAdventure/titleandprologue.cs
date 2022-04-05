using System;
using System.Threading;

namespace SimpleAdventure
{
    class MainClass : MethodLibrary
    {
        public static void Main(string[] args)
        {
            //Initiates the game with info and title screen
            Init();

            //some text and variables are placed here.
            string UserInput;
            string charName = "";
            Int16 charAge = 0;
            string charSex = "milk";
            string playerStatus = "Healthy";
            double playerHP = 20;
            int playerGold = 5;
            double playerARMR = 10;
            double playerATK = 1;

            Console.Clear();
            /*some really long writeline because im lazy.
              it also serves as the tutorial*/
            Console.WriteLine("Welcome to Simple Adventure! \n This is my first game that i have been developing in my spare time. \n This is a text based adventure game, meaning you have to type your actions. \n Remember that you have only one life, \n not all actions are available, \n and try to be simple when entering a answer. example, inspect object. \n Im pretty new to coding. \n Press any key to continue");
            Console.ReadKey();

            //skips the prologue if you want
            Console.WriteLine("would you like to skip the prologue?");
            while(true)
            {
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "yes")
                {
                    Game.Gamepart1();
                    Console.WriteLine("Thank you for playing!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (UserInput.ToLower() == "no")
                {
                    break;
                }
            }

            //this is character creation
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("Welcome to Character Creation! we will start with your name.");
            UserInput = Console.ReadLine();
            charName = UserInput;
            Console.WriteLine("Your name is " + charName + "!");
            Thread.Sleep(800);
            Console.WriteLine("What is your age? Age will affect gameplay!");
            while (true)
            {
                charAge = InputNumber();
                if (charAge > 120)
                { Console.WriteLine("too old! Try Again!"); }
                if (charAge < 120) { break; }
            }
            Console.WriteLine("Your age is " + charAge + "!");
            Thread.Sleep(800);
            Console.WriteLine("What is your gender? Gender will affect gameplay!");
            UserInput = Console.ReadLine(); //this switch is gonna make you mad cause its the only switch in character creation
            switch (UserInput)
            {
                case "male":
                    charSex = "male";
                    break;

                case "female":
                    charSex = "female";
                    break;

                case "milk":
                    charSex = "milk";
                    break;

            }
            Console.WriteLine("Your gender is " + charSex + "!");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("This is you! \n name: " + charName + " \n age: " + charAge + " \n gender: " + charSex + " \n enjoy the game!");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear(); // this is the start of the game. tullemania helped with the BIG BOI words.
            //if you're a milk, you're just a milk. you can't do anything.
            if (charSex == "milk")
            {
                //this is art
                Console.WriteLine("Since you are just milk, you are unable to do anything that would require a consciousness. " +
                    "\nYou may think this is quite the disappointing outcome, but is it really any worse than the other possibilities? " +
                    "\nSure you could have gone on a grand adventure and all, but remember, the choice was yours. " +
                    "\nThis was all indeed your own doing. You have no one to blame but yourself. " +
                    "\nSo here you are, getting what you deserve. " +
                    "\nHaving your existence be nothing but some spilled milk rotting for each day that goes until you are no more. " +
                    "\nRemember and grieved by no one. " +
                    "only a milkdrinker would cry over spilled milk. \n \n-Tullemania, The intellectually challenged \n");
                playerDeath();
            }
            Console.WriteLine("You regain your consciousness inside of a damp and dark prison cell, unbeknownst to the reason your here.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            //here is how i loop a question if they put the wrong thing, instead of ending the game
            while (true)
            {
                Console.WriteLine("What is your course of action?");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "inspect prison cell" || UserInput.ToLower() == "investigate prison cell")
                {
                    if (charAge > 80)
                    {
                        Console.WriteLine("you wither around the cell, before giving up. you lay on the cold ground, your frail old body giving in.");
                        playerDeath();
                    }
                    Console.WriteLine("you take a look at your surroundings. Its a cold, dark and damp prison cell. \n There are bars on a small window, letting out minimal moonlight as your only light source. \n The door is sealed by 3 locks. Next to the door lies some old shackles.");
                    break;
                }
                else if (UserInput.ToLower() == "do a 360 no scope") //funny easter egg
                {
                    Console.WriteLine("you do a 360, pull a sniper out of your ass, and no scope. \n the bullet reflects and hits you in the head.");
                    playerDeath();
                    break;
                }
                else
                {
                    Console.WriteLine("response invaild. Try Again.");
                }
            }
            Thread.Sleep(5800);
            Console.Clear();
            Console.WriteLine("you wait around the cell, unsure what to do. \n suddenly, a person is at the door. \n 'find a way.' he utters in a quiet coarse voice. \n the door unlocks.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            while (true)
            {
                Console.WriteLine("What is your course of action?");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "open door" || UserInput.ToLower() == "exit prison cell")
                {
                    Console.WriteLine("you open the door to the prison cell quietly, \n taking a peek into the long dark hallways. \n you notice there are no guards, and look around. \n there are prison cells lining the walls.");
                    break;
                }
                else
                {
                    Console.WriteLine("response invaild. Try Again.");
                }
            }

            Thread.Sleep(5800);
            Console.Clear();
            Console.WriteLine("you stand in the dark hallway. \n a torch lit room with its door cracked open stood to your left. \n a wooden door laid on your right, with a window showing the moon above it.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            while (true)
            {
                Console.WriteLine("What is your course of action?");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "go left" || UserInput.ToLower() == "left")
                {
                    Console.WriteLine("you sneak towards the torch lit room, and peak into the door. \n the room was empty and there was chest in the middle. you open it and recieve: \n Iron Sword! +5 ATK \n \n you return back to the hallway and head towards the moon lit door.");
                    playerATK = 5;
                    break;
                }
                else if (UserInput.ToLower() == "go right" || UserInput.ToLower() == "right")
                {
                    Console.WriteLine("you sneak towards the moonlit door.");
                    break;
                }
                else
                {
                    Console.WriteLine("response invaild. Try Again.");
                }
            }
            Thread.Sleep(5800);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine(" you walk outside, breathing in the fresh air. \n suddenly, a guard spots you and yells 'You Shouldn't be out here! Prisoner!' he rushes towards you. \n he swings at you but you dodge it barely.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            while (true)
            {
                Console.WriteLine("What is your course of action?");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "attack guard" || UserInput.ToLower() == "attack")
                {
                    if (playerATK == 5) { Console.WriteLine("you swing the iron sword you got at the guard. you slice his neck, and he falls to the ground. \n you walk towards the horse stalls, your sword covered in blood."); break; }
                    if (playerATK == 1)
                    { Console.WriteLine("you punch the guard in the face, putting nothing but a dent in his helmet.");
                        Console.WriteLine("he slashes, striking your right arm, causing a huge wound to open. \n you quickly dodge his second attack and run for the horse stall.");
                        playerStatus = "injured";
                        playerHP = 10;
                        break;
                    }
                }
                else if (UserInput.ToLower() == "run" || UserInput.ToLower() == "guard")
                {
                    if (playerATK == 1) 
                    { 
                        Console.WriteLine("with nothing to fight or block with, you run towards the horse stall. \n he chases after you, stabbing you in the back. \n you trip and fall on to the ground, where he quickly stabs his sword through your skull."); 
                        switch (charSex)
                        {

                            case "male":
                                Console.WriteLine("'scum.' he mutters.");
                                break;

                            case "female":
                                Console.WriteLine("'Bitch.' he mutters.");
                                break;
                        }
                        playerDeath(); 
                    }
                    if (playerATK == 5)
                    {
                        Console.WriteLine("you wait for his next attack, then parry it with the sword you got. you quickly stab him straight through his head. \n as his body hits the ground, you run towards the horse stall.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("response invaild. Try Again.");
                }
            }
            Thread.Sleep(5800);
            Console.Clear();
            Console.WriteLine("you quickly get on the horse and ride your way away from the prison. you have escaped this hell.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("you have completed the prologue. would you like to continue?");
            while (true)
            {
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "yes")
                {
                    Game.Gamepart1();
                }
                if (UserInput.ToLower() == "no")
                {
                    Console.WriteLine("thank you for playing!");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }
        }
        
    }

}
