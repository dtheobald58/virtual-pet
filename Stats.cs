using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetTheobald
{
    class Stats
    {
        //fields
        private string name;
        private int hunger = 10;
        private int happiness = 10;
        private int thirst = 10;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Happiness
        {
            get { return this.happiness; }
            set { this.happiness = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        //constructors
        public Stats()
        {
         
        }

        public Stats (string Name)
        {
            this.Name = Name;
        }

        //methods
        public string Start ()
        {
            Console.Write("Congratulations on your new pet worm!!!  It's... cute... I guess.\nWhat's its name?");
            Console.WriteLine();
            Console.WriteLine("(Please enter the name of your pet)");
            Name = Console.ReadLine();

            return this.Name;
        }

        public void DisplayStats()
        {
            Console.WriteLine("HAPPINESS: [" + happiness + "]");
            Console.WriteLine("HUNGER: [" + hunger + "]");
            Console.WriteLine("THIRST: [" + thirst + "]");
        }

        public void Interact(int userInput)
        {
            Console.WriteLine("What would you like to do with " + name + "?");
            Console.WriteLine();
            Console.Write("Enter \"1\" to feed " + name + ". \nEnter \"2\" to play with " + name + ". \nEnter \"3\" to quench " + name + "'s thirst.\n");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Hunger++;
                Thirst--;
                Thirst--;
                Happiness++;
            }
            else if (userInput == 2)
            {
                Happiness++;
                Hunger--;
                Thirst--;
            }
            else if (userInput == 3)
            {
                Thirst++;
                Hunger--;
                Hunger--;
                Happiness++;
            }
            else
            {
                Thirst--;
                Hunger--;
                Happiness--;
            }
        }

        public void Portrait ()
        {
            Console.WriteLine("                           _____");
            Console.WriteLine("                          / o  o\\");
            Console.WriteLine("                          |  )-(|");
            Console.WriteLine("                          |     |");
            Console.WriteLine("           ____           |     |");
            Console.WriteLine("          / _  \\         /     /");
            Console.WriteLine("         / / \\  \\_______/     /");
            Console.WriteLine("     ___/ /   \\              /");
            Console.WriteLine("    (____/     \\____________/");
        }


    }
}
