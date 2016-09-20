using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetTheobald
{
    class Program
    {
        static void Main(string[] args)
        {
            Stats worm = new Stats();
            int userNum = 0;
            worm.Portrait();
            worm.Start();

            Console.Clear();
            worm.Portrait();
            Console.Clear();
            Console.Write("I hope you didn't think it would be easy to care for a pet worm.\n" + worm.Name + " looks like a handful (and a monster).\n\n");
            
            do
            {
                worm.Portrait();
                worm.DisplayStats();
                worm.Interact(userNum);
                Console.Clear();
            } while (worm.Hunger > 0 && worm.Thirst > 0 && worm.Happiness > 0);

            Console.WriteLine("I've got some bad news... " + worm.Name + " was drafted into the worm army.");
            Console.WriteLine();
            Console.Write("Don't try to write any letters, " + worm.Name + " won't write back,\nbecause " + worm.Name + " is a worm, and worms don't have arms.\n\nBut they do have wars.\n\n\n\n");
        }
    }
}
