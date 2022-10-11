using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static int health;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals: ");
            Console.WriteLine();

            health = 100;
            TakeDamage(20);
            ShowHUD();
            TakeDamage(20);

            if (health == 0)
            {
                Console.Clear();
                Console.WriteLine("You Died!!");
            }


            Console.ReadKey(true);
        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("You're going to take " + damage + " damage...");
            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
        }
    }
}
