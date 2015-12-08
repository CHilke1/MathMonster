using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public static class Math
    {
        private static int Happy(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }

        private static bool isHappy(int number)
        {
            if (number == 1)
            {
                return true;
            }
            else if (number == 4)
            {
                return false;
            }
            else
            {
                return isHappy(Happy(number));
            }
        }

        public static List<int> HappyNumbers(int num)
        {
            List<int> happyNumbers = new List<int>();
            for (int counter = 1; counter <= num; counter++)
            {
                if (isHappy(counter))
                {
                    happyNumbers.Add(counter);
                }
            }
            return happyNumbers;
        }

        private enum RomanDigit
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public static int RomanNumeraltoInt (ref string roman)
        {
            int ptr = 0;

            ArrayList values = new ArrayList();
            int maxDigit = 1000;
            while (ptr < roman.Length)
            {
                char numeral = roman[ptr];
                int digit = (int)Enum.Parse(typeof(RomanDigit), numeral.ToString());

                if (digit > maxDigit)
                    return 0;

                int nextDigit = 0;
                if (ptr < roman.Length - 1)
                {
                    char nextNumeral = roman[ptr + 1];
                    nextDigit = (int)Enum.Parse(typeof(RomanDigit), nextNumeral.ToString());

                    if (nextDigit > digit)
                    {
                        maxDigit = digit - 1;
                        digit = nextDigit - digit;
                        ptr++;
                    }
                }

                values.Add(digit);
                ptr++;
            }
            int total = 0;
            foreach (int digit in values)
            {
                total += digit;
            }
            return total;
        }

        public static int Euclidean(int num1, int num2)
        {
            int factor1 = num1;
            int factor2 = num2;
            while (num1 != 0 && num2 != 0) {
                {
                    if (num1 > num2)
                        num1 %= num2;
                    else
                        num2 %= num1;
                }
            }
            return System.Math.Max(num1, num2);
        }

        public static int Factorial(int num)
        {
            int factorial = 1;
            if (num == 0 || num == 1) {
                return 1;
            }
            while (num > 1)
            {  
                factorial *= num;
                num = num - 1;
            }
            return System.Math.Abs(factorial);
        }

        public static int AlternatingFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            int factorial = 1;
            int total = 0;
            bool sign = true;
            for (int i = 1; i <= num; i++)
            {
                factorial = Factorial(i);
                if (!sign)
                {
                    total -= factorial; 
                }
                else
                {
                    total += factorial;
                }
                sign = !sign;
            }
            return System.Math.Abs(total);
        }

        private static int Negative(int num)
        {
            return num * -1;
        }
    }
}
