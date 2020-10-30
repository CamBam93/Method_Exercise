using System;

namespace Method_Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There...");
            Console.WriteLine("Who are you?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Well Hello {userName}");
            Console.WriteLine("How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            var userLoc = Console.ReadLine();

            Console.WriteLine("What's your favorite Animal?");
            var userAnimal = Console.ReadLine();

            Console.WriteLine("Who's your favorite Actor?");
            var userActor = Console.ReadLine();

            Console.WriteLine("What color is your favorite?");
            var userColor = Console.ReadLine();

            Console.WriteLine("Here's a little story for you!");
            Console.WriteLine("hit enter to continue....");
            Console.ReadLine();
            Console.WriteLine($"One day a man named {userName} was visiting a small town just outside of {userLoc}");
            Console.WriteLine($"{userName} had no real reason to be here other than they were bored");
            Console.WriteLine($"{userName} was {userAge} and today was just a normal day until..");
            Console.WriteLine($"Out of absolutly nowhere {userActor} apeared somehow riding a {userAnimal}!");
            Console.WriteLine($"{userName} was shocked to see {userActor} so close to {userLoc}");
            Console.WriteLine($"{userActor} still riding a {userAnimal} approached {userName} with 2 {userColor} bags");
            Console.WriteLine($"The {userColor} bags were full of cash");
            Console.WriteLine($"{userActor} rode off into they sunset atop his {userAnimal} mount...");

            Console.WriteLine("How many dollars do you think are in the first bag?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How about the second bag?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"Wow thats {sum} dollars!");

            int mult = Mult(num1, num2);
            Console.WriteLine("Lets multiply those numbers just cause!");
            Console.WriteLine($"the total is {mult}");
        }

        public static int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
