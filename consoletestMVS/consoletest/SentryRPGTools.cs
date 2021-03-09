using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace consoletest
{
    class SentryRPGTools
    {
        //Some variables I had to place here for combat to work....
        public static double cAttackRatio;
        public static double eAttackRatio;
        public static bool firstPhase = true;
        public static string userResponse;
        //Combat

        //Just supply an enemy name, enemy health, enemy attack, character health and character attack
        public static void Combat(string eName, double eHealth, double eBaseAttack, double cHealth, double cBaseAttack)
        {
            if (firstPhase)
            {
                cAttackRatio = cHealth / eHealth;
                eAttackRatio = eHealth / cHealth;

                Console.Clear();
                Console.WriteLine("You've entered combat");
                Console.WriteLine("You're fighting a " + eName + " with " + eHealth + " HP");
                Thread.Sleep(1000);

                Console.Clear();
                Console.WriteLine("Your enemy has " + eHealth + " HP whileist you have " + cHealth + " HP");
                Console.WriteLine("What do you wish to do?");

                userResponse = Console.ReadLine();
                if (userResponse == "Attack" || userResponse == "attack")
                {
                    eHealth = eHealth - cBaseAttack;
                    Console.WriteLine("You attack " + eName + " for " + cBaseAttack + " damage to the " + eName + " now has " + eHealth + "HP left");
                    if (eHealth > 0)
                    {
                        cHealth = cHealth - eBaseAttack;
                        Console.WriteLine(eName + " attacks you for " + eBaseAttack + " damage. You have " + cHealth + " HP left");
                    }
                    if (cHealth > 0 || eHealth > 0)
                    {
                        if (eHealth < 0)
                        {
                            Console.WriteLine("You stand victorious");
                        }
                        else if (cHealth > 0)
                        {
                            firstPhase = false;
                            SentryRPGTools.Combat(eName, eHealth, eBaseAttack, cHealth, cBaseAttack);
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("You are a fucking looser, you died to " + eName);
                        Console.WriteLine("If you want to retry you'll have to restart the game manually cuz we're too stupid to program that");
                    }
                }
            }
            else if (!firstPhase)
            {
                Console.Clear();
                Console.WriteLine("Your enemy has " + eHealth + " HP whileist you have " + cHealth + " HP");
                Console.WriteLine("What do you wish to do?");

                userResponse = Console.ReadLine();
                if (userResponse == "Attack" || userResponse == "attack")
                {
                    //Character attack calculation
                    double cAttack = cBaseAttack * ((cHealth / eHealth) / cAttackRatio);
                    eHealth = eHealth - cAttack;
                    Console.WriteLine("You attack " + eName + " for " + cAttack + " damage to the " + eName + " now has " + eHealth + "HP left");
                    if (eHealth > 0)
                    {
                        //Enemy attack calculation
                        double eAttack = eBaseAttack * ((eHealth / cHealth) / eAttackRatio);
                        cHealth = cHealth - eAttack;
                        Console.WriteLine(eName + " attacks you for " + eAttack + " damage. You have " + cHealth + " HP left");
                    }
                    if (cHealth > 0 || eHealth > 0)
                    {
                        if (eHealth < 0)
                        {
                            Console.WriteLine("You stand victorious");
                        }
                        else if (cHealth > 0)
                        {
                            firstPhase = false;
                            SentryRPGTools.Combat(eName, eHealth, eBaseAttack, cHealth, cBaseAttack);
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("You are a fucking looser, you died to " + eName);
                        Console.WriteLine("If you want to retry you'll have to restart the game manually cuz we're too stupid to program that");
                    }
                }
            }
        }

        //Inventory system go brrrrr
        public static string[,] InventoryInit(int inventorySlots, string[,] inventory)
        {
            for (int i = 0; i<inventorySlots-1; i++)
            {
                inventory[i,i] = "0";
                inventory[i,i] = "EMPTY SLOT";
            }
            return inventory;
        }
        public static string[,] InventoryAdd(int amount, string item, string[,] inventory)
        {
            //Linear search for space
            for (int i=0; i<inventory.Length+1; i++)
            {
                //If space, add specified item
                if (inventory[i,1]=="[EMPTY SLOT]")
                {
                    inventory[i, 0] = Convert.ToString(amount);
                    inventory[i, 1] = item;
                    break;
                }
                //Else allow player to drop an item
                else if (i>inventory.Length)
                {
                    Console.WriteLine("There's no place in your inventory");
                    Console.WriteLine("Do you want to drop an item? (yes/no)");
                    userResponse = Console.ReadLine();
                    if (userResponse.ToLower() == "yes")
                    {
                        SentryRPGTools.InventoryPrint(inventory);
                        Console.WriteLine("Choose an item to drop");
                        userResponse = Console.ReadLine();
                        for (int x=0; x < inventory.Length+1; x++)
                        {
                            if(Convert.ToInt32(userResponse) == x || userResponse.ToLower() == inventory[i,1].ToLower())
                            {
                                Console.WriteLine("Are you sure you want to drop " + inventory[x, 0] + " " + inventory[x, 1] + "? (yes/no)");
                                userResponse = Console.ReadLine();
                                if (userResponse.ToLower() == "yes")
                                {
                                    inventory[x, 0] = Convert.ToString(amount);
                                    inventory[x, 1] = item;
                                    Console.WriteLine("You picked up the " + item + ". It's now in inventory slot " + x);
                                    break;
                                }
                                else if (userResponse.ToLower() == "no")
                                {
                                    Console.WriteLine("You chose not pick up the " + item);
                                    break;
                                }
                            }
                        }
                    }
                    else if (userResponse.ToLower() == "no")
                    {
                        Console.WriteLine("You chose not pick up the " + item);
                    }
                }
                break;
            }
            return inventory;
        }

        public static void InventoryPrint(string[,] inventory)
        {
            for (int i = 0; i <= inventory.Length; i++)
            {
                Console.WriteLine((i+1) + " - " + inventory[i,0] + "p " + inventory[i,1]);
            }
        }
        //Save game data
        //Time to learn some SQL, remember to finish your research future me. 
        public static void SaveGame(int numOfDataToSave, string[,] saveData)
        {

        }
        public static void LoadingBar(int lineNr, int loadingDelay)
        {
            Console.Write("Oooooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oOoooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooOooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooOoooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooOooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooOoooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooOooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooOoooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooooOooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooooOoooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooooooOooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooooooOoooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);

        }

        public static void Quit()
        {
            Environment.Exit(0);
            return;
        }
    }
}
