using System;
using System.IO;

namespace L11_3_ReusableMenu
{
    class Program
    {
        static int GetValueInRange(string pPrompt, int pMin, int pMax)
        {
            int result;
            do
            {
                Console.WriteLine(pPrompt);
                Console.WriteLine("Enter a value that is higher than " + pMin +
                    " and lower than " + (pMax - 1) + " inclusive");

                string input = Console.ReadLine();

                result = int.Parse(input);

            } while (result < pMin || result >= pMax);

            return result;
        }

        static int GetSelectionFromMenu(string pPrompt, string[] pOptions)
        {
            for(int i = 0; i < pOptions.Length; i++)
            {
                pPrompt += "\r\n" + (i + 1) + ". " + pOptions[i];
            }

            return GetValueInRange(pPrompt, 1, pOptions.Length + 1) - 1;
        }

        static void OutputFileContents(string pFile)
        {
            StreamReader reader = new StreamReader(pFile);

            while(!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Output file contents");

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

            int selection = GetSelectionFromMenu("Select a file to load", files);

            OutputFileContents(files[selection]);

        }
    }
}