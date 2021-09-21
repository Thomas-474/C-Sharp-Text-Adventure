using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Text_Adventure
{
    public class Character
    {
        public int race;
        public int charClass;
        public int subclass;

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
        public string[] charInventory;
    }

    class Program
    {
        static void NL() => Console.WriteLine("");

        static void Main(string[] args)
        {
            #region List of Stats
            /*
            http://howtomakeanrpg.com/a/how-to-make-an-rpg-stats.html?scrlybrkr

                Characters:
                    - Race
                    - Class
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

                    - leftHand
                    - rightHand
                    - head
                    - arms
                    - chest
                    - legs
                    - classArmor
                    - ring1
                    - ring2
                    - charInventory
                   
                Weapons:
                    - Attack Type
                    - Attack Rate
                    - Defense Power
            */
            #endregion

            Console.WriteLine("To make a selection enter only the number that corresponds with an option");
            NL();
            Console.WriteLine("Choose a Class:\n" +
                "  1. Knight\n" +
                "  2. Wizard\n" +
                "  3. Rogue");
            //int userInput = Console.ReadLine();
            //Console.WriteLine(userInput);

            // Character playableKnight = new Character();

            Console.ReadKey();
        }

    }
}
