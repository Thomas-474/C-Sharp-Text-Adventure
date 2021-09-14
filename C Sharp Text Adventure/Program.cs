using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stats
                http://howtomakeanrpg.com/a/how-to-make-an-rpg-stats.html?scrlybrkr

                Characters:
                    - Max HP
                    - Current HP
                    - Max MP
                    - Current MP
                    - Strength
                    - Speed
                    - Intelligence

                Weapons:
                    - Attack Type
                    - Attack Rate
                    - Defense Power
            */

            // string[] charStats = new string[] {maxHP, currentHP, maxMP, currentMP, strength, speed, intelligence};

            Console.WriteLine("Enter only the number that corresponds with each option to make the selection\n");
            Console.WriteLine("Choose a Class:\n  1. Knight\n  2. Wizard\n  3. Rogue");
            Console.ReadKey();


            Console.ReadKey();
        }

    }
}
