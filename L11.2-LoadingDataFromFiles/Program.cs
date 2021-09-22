using System;
using System.IO;

namespace L11._2_LoadingDataFromFiles
{
    class Program
    {
        static int GetFileSum(string pFile)
        {
            int sum = 0;

            StreamReader reader = new StreamReader(pFile);

            string line = reader.ReadLine();
            string[] values = line.Split(',');

            foreach (string value in values)
            {
                sum += int.Parse(value);
            }

            reader.Close();

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Output The Sum");
            Console.WriteLine("Enter 1 to read a well formatted file");
            Console.WriteLine("Enter 2 to read a badly formatted file");
            Console.WriteLine("Enter 3 to read a file that does not exist");

            int selection = int.Parse(Console.ReadLine());

            string filename = "";

            switch (selection)
            {
                case 1:
                    filename = "WellFormattedFile.txt";
                    break;
                case 2:
                    filename = "BadlyFormattedFile.txt";
                    break;
                case 3:
                    filename = "FileThatDoesntExist.txt";
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            int sum = GetFileSum(filename);
            Console.WriteLine("sum is " + sum);
        }
    }
}