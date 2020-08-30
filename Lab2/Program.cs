using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, please type your name below:");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, would you like to use our room generator? y/n? Type y for yes or n for no y/n?");
            var userResponse = Console.ReadLine();

            while (userResponse == "y")
            {
                Console.WriteLine("Please enter the length of the room here");
                var length = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width of the room here");
                var width = int.Parse(Console.ReadLine());
                var area = length * width;
                var perimeter = length * 2 + width * 2;
                Console.WriteLine($"The perimeter of your room is {perimeter} n/ The area of your room is {area}");
                Console.Read();
                Console.WriteLine("Would you like to use our room generator again? y/n? Type y for yes or n for no y/n?");
                userResponse = Console.ReadLine();
            }
            Console.WriteLine("Thank you for visiting our console application");
        }
    }
}
