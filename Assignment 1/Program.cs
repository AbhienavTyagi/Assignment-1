using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chosing a pet and naming him!
            Console.WriteLine("please choose the type of pet \n 1.Dog \n 2.Rabbit \n 3.Cat");
            Console.WriteLine("user input: ");
            String pet = Console.ReadLine();
            Console.WriteLine("You've choosen "  + pet + ". What would you like to name your pet?");
            String petName = Console.ReadLine();
            Console.WriteLine("Welcome," + petName + "! Let's take good care of him.");

            int Hunger = 5;
            int Health = 5;
            int Happiness = 5;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMain Menu: \n 1. Feed " + petName + "\n 2. Play with " + petName + "\n 3. Let " + petName + " rest \n 4. Check " + petName + "'s status \n 5. Exit"); 
                Console.Write("\n Enter Input : ");
                string interact = Console.ReadLine();

                if (interact == "1")    //feeding the pet
                {
                    Hunger --;
                    Health++;
                    Console.WriteLine("You fed " + petName + ". His hunger decreases, and health improves slightly.");
                }
                else if (interact == "2")   //playing with pet
                {
                    Happiness++;    
                    Hunger++;
                    Console.WriteLine("You played with " + petName + ". His happiness increases but he's a bit hungry.");
                }
                else if (interact == "3")   // Rest for pet
                {
                    Health++; 
                    Happiness--; 
                    Console.WriteLine("You let " + petName + " rest. Now " + petName + "'s health improved, however happiness slightly decreased.");
                }
                // Check the status of pet
                else if (interact == "4")
                {
                    Console.WriteLine("\nStatus of " + petName + ":");
                    Console.WriteLine("- Hunger: " + Hunger);
                    Console.WriteLine("- Happiness: " + Happiness);
                    Console.WriteLine("- Health: " + Health);
                }
                //Exit
                else if (interact == "5")
                {
                    Console.WriteLine("Thank You for playing with " + petName + ". Goodbye!");
                    exit = true;
                    break;
                }
                // Handle invalid input
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a vaid choice.");
                }

                // Time based changes: each action represents the passing of an hour

                if (interact != "4" && interact != "2" && interact != "3") //Condition for Feeding the pet
                {
                   
                    Hunger--;
                    Health++;
                    //Happiness--;
                    Console.WriteLine("\nOne hour time passes... Hunger DECREASES, Happiness has NO CHANGE and Health INCREASES after one action");
                }
                if (interact != "4" && interact != "1" && interact !="3") //Condition for Playing with pet
                {

                    Hunger++;
                    //Health--;
                    Happiness++;
                    Console.WriteLine("\nOne hour time passes... Hunger INCREASES, Happiness INCREASES and Health has NO CHANGE after one action");
                }
                if (interact != "4" && interact != "1" && interact != "2") //Condition for resting of pet
                {

                    //Hunger++;
                    Health++;
                    Happiness--;
                    Console.WriteLine("\nOne hour time passes... Hunger has NO CHANGE, Happiness DECREASES and Health INCREASES after one action");
                }

                // Consequences for neglect
                if (interact != "4")
                {
                    if (Hunger >= 8)
                    {
                        Health --;
                        Console.WriteLine(petName + " is very hungry! Health is deteriorated and is refusing to play.\n");
                    }
                    if (Happiness <= 2)
                    {
                        Health --;
                        Console.WriteLine(petName + " is very unhappy! Health is deteriorated.\n");
                    }
                }
            }
        }
    }
}
