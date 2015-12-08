using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public static class Math
    {
        public Math()
        {
        }

        private uint Happy(uint number)
        {
            string test = number.ToString; //convert number to string
            char[] char_array;
            char_array = test.ToCharArray(0, test.Length - 1); // convert to array
            uint sum = 0;
            foreach (char c in char_array)
            {
                int val = (int)Char.GetNumericValue(c);
                sum += Math.Pow(c, 2);
            }
            return sum;
        }

        private uint isHappy (uint number)
        {
            if (num == 1)
            {
                return true;
            }
            else if (HappyNumbers == 4)
            {
                return false;
            }
            else
            {
                HashSet<uint> seen_numbers = new HashSet<uint>();
                while (number > 1 && !seen_numbers.Contains(number))
                {
                    seen_numbers.Add(number);
                    number = Happy(number);
                }
                return number == 1;
            }
            
        }

        public List<uint> HappyNumbers(unint num)
        {
            for (int counter=1; counter <= num; counter++)
            {

            }
        }
    }
}
