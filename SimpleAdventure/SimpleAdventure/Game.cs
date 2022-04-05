using System;
using System.Threading;

namespace SimpleAdventure
{
    internal class Game : MethodLibrary
    {
        public static void Gamepart1()
        {
            string UserInput;
            string charName = "";
            Int16 charAge = 0;
            string charSex = "milk";
            string playerStatus = "Healthy";
            double playerHP = 20;
            int playerGold = 5;
            double playerARMR = 10;
            double playerATK = 1;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("you have entered the first part of the game. Do you remember who you are?");
            Console.WriteLine("what is your name again?");
            charName = Console.ReadLine();
            Console.WriteLine("ah yes, " + charName + ". i remember you now. what was your age again?");
            while (true)
            {
                charAge = InputNumber();
                if (charAge > 120)
                { Console.WriteLine("You Weren't that old, try again."); }
                if (charAge < 120) { break; }
            }
            if (charAge >= 40)
            {
                Console.WriteLine(charAge + ", huh? you were quite old, weren't you?");
            }
            else if (charAge < 40)
            {
                Console.WriteLine(charAge + ", huh? still young i see.");
            }
            Console.WriteLine("and finally, what was your gender again?");
            UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "male":
                    charSex = "male";
                    break;

                case "female":
                    charSex = "female";
                    break;

            }
            if (charSex == "male" && charAge < 40)
            {
                Console.WriteLine("a young man, huh? you will do fine.");
            }
            if (charSex == "male" && charAge > 40)
            {
                Console.WriteLine("a old man, huh? be wary, wise one.");
            }
            if (charSex == "female" && charAge < 40)
            {
                Console.WriteLine("a young woman, huh? you will do fine.");
            }
            if (charSex == "female" && charAge > 40)
            {
                Console.WriteLine("a old woman, huh? be wary, wise one.");
            }
            Console.WriteLine("so your name is " + charName + ", your " + charAge + " years old, and your a " + charSex + ". \n i pray that your journey is safe, new one.");
            Thread.Sleep(8000);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("you awake in a Inn. the Innkeeper is shaking you awake. 'I thought you were damn near dead!' she proclaims. \n 'Your payment is due. pay now, or leave.' \n you must pay the Innkeeper 20 gold to continue staying.");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            Console.WriteLine("what is your course of action?");
            while (true)
            {
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "pay" || UserInput.ToLower() == "pay Innkeeper")
                {
                    if (playerGold >= 20) { Console.WriteLine("you actually cheated on this game? wtf is wrong with you lmao"); playerDeath(); }
                    Console.WriteLine("you give her all the gold you have, but it still isn't enough. \n 'Get Out! Before i get the Guards!' she pulls you out of bed and throws you out.");
                    playerGold = 0;
                    Console.WriteLine("-5 Gold...");
                    break;
                }
                else if (UserInput.ToLower() == "leave" || UserInput.ToLower() == "run")
                {
                    Console.WriteLine("you leave quickly before the Innkeeper gets angry. 'don't come back till you have money, you broke bastard!' the Innkeeper shouted.");
                    break;
                }
            }
            Thread.Sleep(7000);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("you are in a shabby part of town, on the break of dawn. around you are houses falling apart at every corner. \n there are people sitting on the streets, and one of them coughs violently. \n you are weak from hunger and thrist and if you don't get help soon, you may die..");
            playerStatus = "critical";
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            Console.WriteLine("what is your course of action?");
            while (true)
            {
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "leave" || UserInput.ToLower() == "walk away")
                {
                    Console.WriteLine("you try to leave but there is gate that is blocking you from entering the inner parts of the city. \n 'citzenship proof please' the guard says. you look at him confused. \n 'get out of here ya broke cunt.' the guard shoves you away from the gate. you fall and struggle to get back up.");
                    break;
                }
                else if (UserInput.ToLower() == "rob person" || UserInput.ToLower() == "steal food" || UserInput.ToLower() == "steal water" || UserInput.ToLower() == "steal")
                {
                    Console.WriteLine("you slowly sneak up on a man who has a leather bag with some food in it. \nyou quickly grasp some food and try to get away, but you trip, and fall onto the ground. \n the man pulls a makeshift shank and stabs you in the back and twists. because your so weak, your body just gives up, and you are left to bleed to death.");
                    playerDeath();
                }
                else Console.WriteLine("sorry, try again.");
            }
            Thread.Sleep(7000);
            Console.Clear();
            Console.WriteLine("lol");
            playerUI(playerStatus, playerHP, playerGold, playerARMR, playerATK);
            Console.WriteLine("what is your course of action?");
        }
    }
}
