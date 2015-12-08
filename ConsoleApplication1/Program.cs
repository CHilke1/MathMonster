using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keep_running = true;
            do
            {
                Tester t = new Tester();
                keep_running = t.Run();
            }
            while (keep_running);
            Console.Write("Goodbye!");
            System.Threading.Thread.Sleep(1000);
        }
    }

    class Tester
    {
        public bool Run()
        {
                Console.WriteLine("1 - Happy numbers | 2 - Roman Numerals | 3 - Euclidean Theorem | 4 - Factorials | 5- Alternating Factorials");
                Console.Write("Enter number of program you wish to use.");
                string key_pressed = Console.ReadLine();
                switch (key_pressed)
                {
                case "1":
                    Console.Write("Enter the top range of happy numbers: ");
                    string input = Console.ReadLine();
                    int limit = Int32.Parse(input);
                    List<int> happy_numbers = new List<int>();
                    happy_numbers = devCodeCampExtendedMath.Math.HappyNumbers(limit);
                    for (int i = 0; i < happy_numbers.Count; i++)
                    {
                        Console.WriteLine(happy_numbers[i]);
                    }
                    break;
                case "2":
                    Console.Write("Type Roman numeral to convert: ");
                    input = Console.ReadLine();
                    input = input.ToUpper().Trim();
                    bool isRoman = true;
                    foreach (char numeral in input)
                    {
                        if ("IVXLCDM".IndexOf(numeral) == -1)
                        {
                            isRoman = false;
                            Console.WriteLine("Please enter a valid numeral");
                        }
                    }
                    if (isRoman)
                    {
                        int roman_numeral_equiv = devCodeCampExtendedMath.Math.RomanNumeraltoInt(ref input);
                        Console.WriteLine(roman_numeral_equiv);
                    }
                    break;
                case "3":
                    Console.Write("Type two numbers to factor seperated by a comma: ");
                    input = Console.ReadLine();
                    string[] inputs = input.Split(',');
                    if (inputs.Length != 2)
                    {
                        Console.WriteLine("Please enter exactly two numbers.");
                        break;
                    }
                    int Euc1 = Int32.Parse(inputs[0]);
                    int Euc2 = Int32.Parse(inputs[1]);
                    int GCD = devCodeCampExtendedMath.Math.Euclidean(Euc1, Euc2);
                    Console.WriteLine(GCD);
                    break;
                case "4":
                    Console.Write("Type a number to get the factorial !number: ");
                    input = Console.ReadLine();
                    int factorial = devCodeCampExtendedMath.Math.Factorial(Int32.Parse(input));
                    Console.WriteLine(factorial);
                    break;
                case "5":
                    Console.Write("Type a number to get the alternating factorial !number: ");
                    input = Console.ReadLine();
                    int alt_factorial = devCodeCampExtendedMath.Math.AlternatingFactorial(Int32.Parse(input));
                    Console.WriteLine(alt_factorial);
                    break;
                default:
                    Console.WriteLine("Please enter a value 1 - 4");
                    break;
                }
            bool keep_running = true;
            Console.Write("Do you wish to continue? (Y/N)");
            string kg = Console.ReadLine().Trim().ToLower();
            if (kg.Equals("n"))
            {
                keep_running = false;
            }
            return keep_running;
        }
    }
}
