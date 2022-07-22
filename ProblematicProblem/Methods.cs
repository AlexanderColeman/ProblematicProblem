using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProblematicProblem
{
    public class Methods
    {
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        public static bool Greeting()
        {
            Console.Write("Hello, welcome to the random activity generator! ");
            string userInput = "";
            bool cont = false;


            while (true)
            {
                Console.Write("Would you like to generate a random activity ? yes / no: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    cont = true;
                    break;
                }
                else if (userInput == "no")
                {
                    cont = false;
                    Console.WriteLine("Maybe another day see ya");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input\n");

                }
            }
            return cont;
        }



        public static string GetName()
        {
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        public static int GetAge()
        {
            Console.WriteLine();

            while (true)
            {
                Console.Write("What is your age? ");
                var isANumber = int.TryParse(Console.ReadLine(), out int age);

                if (isANumber == true)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("\nthat was not a valid age please try again.");
                }

            }

        }

        public static void SeeActivities()
        {
            bool seeList = false;

            while (true)
            {
                Console.Write("\nWould you like to see the current list of activities? Sure/No thanks: \n");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "sure")
                {
                    seeList = true;
                    break;
                }
                else if (userInput == "no thanks" || userInput == "no")
                {
                    Console.WriteLine("Thats ok maybe next time.");
                    break;
                }
                else
                {
                    Console.WriteLine("that was not a valid input");
                }
            }

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity}, ");
                    Thread.Sleep(250);
                }
            }
        }

        public static void AddActivities()
        {
            Console.WriteLine();
            bool addToList = false;

            while (true)
            {
                Console.Write("\nWould you like to add any activities before we generate one? yes/no: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    addToList = true;
                    break;

                }

                else if (userInput == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("that was not a valid input");
                }
            }


            while (addToList)
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);

                foreach (string activity in activities)
                {
                    Console.Write($"{activity}, ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add more? yes/no: ");

                string addAnotherToList = Console.ReadLine();

                if (addAnotherToList == "yes")
                {
                    continue;
                }
                else if (addAnotherToList == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nthat was not a valid input");
                }
            }

        }

        public static void ChooseAnActivity(int userAge, string userName)
        {
            bool cont = true;

            while (cont)
            {

                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                Random rng = new Random();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }

                Console.Write("\nAh got it! ");
                while (true)
                {
                    Console.Write($"{userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "keep")
                    {
                        cont = false;
                        break;
                    }
                    else if (userInput == "redo")
                    {
                        cont = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThat was not a valid input");
                    }

                }

            }


        }
    }
}


