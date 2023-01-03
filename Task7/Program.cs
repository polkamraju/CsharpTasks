using System;
using System.IO;

namespace Task7
{
    class Program
    {
        static string inputFileName = "C:\\Users\\rpolkam\\source\\repos\\Tasks\\Task7\\Data\\input.txt";
        static string outputFileName = "C:\\Users\\rpolkam\\source\\repos\\Tasks\\Task7\\Data\\output.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("This program  reads a text file and make a copy in another file by changing the lowercase letters to uppercase.");
            string contents = File.ReadAllText(inputFileName);
            contents = contents.ToUpper();
            File.WriteAllText(outputFileName, contents);
        }
    }
}
