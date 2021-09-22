using System;

namespace L11._1_GetNumberFromUser
{
     class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter a number");

            string input = Console.ReadLine();

            int number = int.Parse(input);

            if(number > 10)
            {
                Console.WriteLine(number + " is greater than 10");
            }
            else
            {
                Console.WriteLine(number + " is less than or equal to 10");
            }  
        }
    }
}
