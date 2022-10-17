using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFA1NikitaMyshuniaiev;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Runtime.InteropServices;

namespace WCFConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optionChoice = 0;
            A1WCF client = new A1WCF();

            while(optionChoice != 6)
            {
                Console.WriteLine("             WCF Assignment 1\n");

                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit\n");

                Console.Write("      Enter your choice: ");

                optionChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                int testNum;
                string testStr;
                string testTag;
                string testSortType;
                switch (optionChoice)
                {
                    case 1:
                        Console.WriteLine("             1. Prime number\n");
                        Console.Write("Input: ");
                        testNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Output: " + client.VerifyPrimeNumber(testNum));
                        Console.WriteLine("\n\n Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("             2. Sum of digits\n");
                        Console.Write("Input: ");
                        testNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Output: " + client.GetSumOfDigits(testNum));
                        Console.WriteLine("\n\n Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("             3. Reverse a string\n");
                        Console.Write("Input: ");
                        testStr = Console.ReadLine();
                        Console.WriteLine("Output: " + client.ReverseString(testStr));
                        Console.WriteLine("\n\n Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("             4. Print HTML tags\n");
                        Console.WriteLine("Input: ");
                        Console.Write("Tag: ");
                        testTag = Console.ReadLine();
                        Console.Write("Data: ");
                        testStr = Console.ReadLine();
                        Console.WriteLine("Output: " + client.PrintHTMLTag(testTag, testStr));
                        Console.WriteLine("\n\n Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("             5. Sort 5 numbers\n");
                        Console.WriteLine("Input: ");
                        Console.Write("Sort Type (Ascending/Descending): ");
                        testSortType = Console.ReadLine();
                        Console.Write("Data: ");
                        testStr = Console.ReadLine();
                        Console.WriteLine("Output: " + client.SortFiveNumbers(testSortType, testStr));
                        Console.WriteLine("\n\n Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
