using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleAdventure
{
    public class MethodLibrary
    {
        public static void Init()
        {
            double releaseVersion = 0.6;
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
            Thread.Sleep(2000);
        }


        public static Int16 InputNumber()
        {
            string input = Console.ReadLine();
            try
            {
                return Convert.ToInt16(input);
            }
            catch (Exception FormatException)
            {
                Console.WriteLine("Please insert a Arabic numeral instead of text.");
                return InputNumber();
            }
        }

        public static void playerUI(string playerStatus, double playerHP, int playerGold, double PlayerARMR, double PlayerATK)
        {
            Console.WriteLine("Player status is: " + playerStatus);
            Console.WriteLine();
            Console.WriteLine("HP: " + playerHP + " Gold: " + playerGold + " Armor: " + PlayerARMR + " Attack: " + PlayerATK);
        }

        public static void playerDeath()
        {
            Console.WriteLine("you have died. relaunch the game to make a new character.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
