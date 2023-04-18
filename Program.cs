using System;

namespace Classes_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Greetings greetings = new Greetings();
            //
            greetings.Welcome();

            //
            Console.WriteLine("What is your name squuire?");
            string userName = Console.ReadLine();

            //
            greetings.Hello(userName);
        }
    }
}
