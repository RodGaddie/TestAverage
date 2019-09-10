using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first test score");

            var responseFromUser1 = int.Parse (Console.ReadLine());

            Console.WriteLine("What is your second test score");

            var responseFromUser2 = int.Parse (Console.ReadLine());

            Console.WriteLine("What is your third test score");

            var responseFromUser3 = int.Parse (Console.ReadLine());

            var TestAverage = (responseFromUser1 + responseFromUser2 + responseFromUser3) /3;

             Console.WriteLine($"your test average is {TestAverage}");





                
        }
    }
}
