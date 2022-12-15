using System;
using System.Diagnostics.Tracing;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            string nextBooks = Console.ReadLine();

            while (nextBooks != "No More Books")
            {              
                if (favouriteBook == nextBooks)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBooks = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");

            }
        }
    }
}
