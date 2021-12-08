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
            Console.WriteLine("Welcome to Simple Adventure! \n This is my first game that i have been developing in my spare time. \n This is a text based adventure game, meaning you have to type your actions. \n Remember that not all actions are available, \n and try to be simple when entering a answer. example, inspect object. \n Im pretty new to coding. \n Press any key to continue");
            Console.ReadKey();

            //this is character creation
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("Welcome to Character Creation! we will start with your name.");
            UserInput = Console.ReadLine();
            charName = UserInput;
            Console.WriteLine("Your name is " + charName + "!");
            Thread.Sleep(800);
            Console.WriteLine("What is your age? Age will affect gameplay!");
            charAge = InputNumber();
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
                Console.WriteLine("Since you are just milk you are unable to do anything that would require a consciousness. " +
                    "You may think this is quite the disappointing outcome but is it really any worse than the other possibilities? " +
                    "Sure you could have gone on a grand adventure and all, but remember, the choice was yours. " +
                    "This was all indeed your own doing. You have no one to blame but yourself. " +
                    "So here you are, getting what you deserve. " +
                    "Having your existence be some spilled milk rotting for each day that goes until you are no more. " +
                    "Remember and grieved by no one. " +
                    "Since only a milkdrinker would cry over spilled milk. -Tullemania The intellectually challenged");
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
            Thread.Sleep(4800);
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

            Thread.Sleep(4800);
            Console.Clear();
            Console.WriteLine("you stand in the dark hallway. \n a torch lit room with its door cracked open, was to your left. \n a wooden door was to your right, with a window showing the moon above it.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            while (true) 
            {
                 Console.WriteLine("What is your course of action?");
                 UserInput= Console.ReadLine();
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
            }
            Thread.Sleep(4800);
            Console.Clear();
            Console.WriteLine(" you walk outside, breathing in the fresh air. \n suddenly, a guard spots you and yells 'You Shouldn't be out here! Prisoner!' he rushes towards you. \n he swings at you but you dodge it barely.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            while (true)
            {
                Console.WriteLine("What is your course of action?");
                if (UserInput.ToLower() == "attack guard" || UserInput.ToLower() == "attack")
                {
                    if(playerATK == 5) { Console.WriteLine("you swing the iron sword you got at the guard. you slice his neck, and he falls to the ground."); }
                    if(playerATK == 1) 
                    { Console.WriteLine("you punch the guard in the face, putting nothing but a dent in his helmet.");
                      Console.WriteLine("")
                    }
                }
            }
        }
    }

}
