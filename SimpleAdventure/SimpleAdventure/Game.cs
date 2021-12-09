using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("so your name is " + charName + ", your " + charAge + " years old, and your a " + charSex + ". \n i pray that your journey is smooth, new one.");
        }
    }
}
