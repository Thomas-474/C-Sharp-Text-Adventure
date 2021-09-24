using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Text_Adventure
{
    public class Character
    {
        public string race;
        public string mainClass;
        public string subclass;
        public int level;
        public int xp;

        public int maxHP;
        public int currentHP;
        public int maxMP;
        public int currentMP;

        public int strength;
        public int speed;
        public int intelligence;

        public string leftHand;
        public string rightHand;
        public string head;
        public string arms;
        public string chest;
        public string legs;
        public string classArmor;
        public string ring1;
        public string ring2;
        public int gold;
        public string[] charInventory;
    }

    public class Weapon
    {
        public string attackType;
        public int attackPower;
        public int attackRate;
        public int defensePower;
    }

    #region List of Stats
            /*
            http://howtomakeanrpg.com/a/how-to-make-an-rpg-stats.html?scrlybrkr

                Characters:
                    - Race
                    - Main Class
                    - Subclass
                    - Level
                    - XP

                    - Max HP
                    - Current HP
                    - Max MP
                    - Current MP

                    - Strength
                    - Speed
                    - Intelligence

                    - Left Hand
                    - Right Hand
                    - Head
                    - Arms
                    - Chest
                    - Legs
                    - Class Armor
                    - Ring 1
                    - Ring 2
                    - Gold
                    - Character Inventory
                   
                Weapons:
                    - Attack Type
                    - Attack Power
                    - Attack Rate
                    - Defense Power
            */
            #endregion

    class Program
    {
        // Empty Line
        static void EL() => Console.WriteLine("");

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dungeons, Dungeons, & More Dungeons!");
            Console.WriteLine("Start with creating your character.");
            Console.WriteLine("To make selections, enter only a number that corresponds with an option.");
            mainClassSelect();

            Console.ReadKey();
        }

        static void mainClassSelect()
        {
            EL();
            Console.WriteLine("Choose a Class:\n" +
                "  1. Knight\n" +
                "  2. Wizard\n" +
                "  3. Rogue");

            string userInput = Console.ReadLine();

            if (userInput == "1") {Character playerKnight = new Character();}
            else if (userInput == "2") {Character playerWizard = new Character();}
            else if (userInput == "3") {Character playerRogue = new Character();}
            else
            {
                Console.WriteLine("Error! Enter only a number that corresponds with one of the options. Do net spell out the number.");
                mainClassSelect();
            }
        }
    }
}
