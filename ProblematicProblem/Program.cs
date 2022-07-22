using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.Greeting();
            string userName = Methods.GetName();
            int userAge = Methods.GetAge();
            Methods.SeeActivities();
            Methods.AddActivities();
            Methods.ChooseAnActivity(userAge, userName);
            Console.WriteLine("\nThanks for letting me guess a random activity for you come back anytime.");
        }
    }
}
