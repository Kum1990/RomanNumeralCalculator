using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanToNumericConverter
{
    public static class RomanToNumeric
    {
        public static readonly Dictionary<char, int> RomanNumberDictionary;

        static RomanToNumeric()
        {
            RomanNumberDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        }

        static void Main(string[] args)
        {
            var userChoice = string.Empty;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a roman number to convert to numeric value: ");
                    var userInput = Console.ReadLine();

                    var result = ToNumber(userInput.ToUpper());

                    Console.WriteLine(string.Format("Result - {0}", result));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpceted error, please try again with a valid roman number.");
                }
                do
                {
                    Console.WriteLine("Do you want to convert a roman number to numeric value - Yes or No?");

                    userChoice = Console.ReadLine();
                    if (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No.");
                    }
                } while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");
            } while (userChoice.ToUpper() == "YES");
        }

        public static int ToNumber(string roman)
        {
            int total = 0;

            int current, previous = 0;
            char currentRoman, previousRoman = '\0';

            for (int i = 0; i < roman.Length; i++)
            {
                currentRoman = roman[i];

                previous = previousRoman != '\0' ? RomanNumberDictionary[previousRoman] : '\0';
                current = RomanNumberDictionary[currentRoman];

                if (previous != 0 && current > previous)
                {
                    total = total - (2 * previous) + current;
                }
                else
                {
                    total += current;
                }

                previousRoman = currentRoman;
            }

            return total;
        }
    }
}
