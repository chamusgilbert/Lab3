using System;

namespace Labs

{
    class Lab3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name?");
            string name = Console.ReadLine();
            NumberJob(name);

        }
        public static void NumberJob(string name)
        {
            Console.WriteLine("Hello, " + name + ". Could you please give me a number?");
            bool isItInt = Int32.TryParse(Console.ReadLine(), out int number);

            if (isItInt == false)
            {
                Console.WriteLine("I'm afraid that is an invalid answer, try again " + name);
                NumberJob(name);
            }
            int square, cube;
            square = number * number;
            cube = number * number * number;

            Console.WriteLine(number + "    " + square + "  " + cube);


            Continue(name);
        }
        public static void Continue(string name)
        {
            Console.WriteLine("Would you like to continue, " + name + "? y/n");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes" || answer == "yea" || answer == "ya")
            {
                NumberJob(name);
            }
            else if (answer == "n" || answer == "no" || answer == "na" || answer == "nope")
            {
                Console.WriteLine("Goodbye " + name);
                return;
            }
            else
            {
                Console.WriteLine("I'm sorry " + name + ", I dont understand... Could you please try again?");
                Continue(name);
            }
        }
    }
}
