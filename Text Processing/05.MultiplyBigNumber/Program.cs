using System;
using System.Collections.Generic;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int multiplyer = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplayByNumber(number, multiplyer));

            
        }

        private static string MultiplayByNumber(string number, int multiplyer)
        {

            if (multiplyer == 0)
            {
                return "0";
            }

            int remainder = 0;
            List<string> result = new List<string>();


            for (int i = number.Length - 1; i >= 0; i--)
            {
                // тук number[i] ще ни даде char 3 със стойността му от ASCII == 51  - затова вадим от него
                // char 0, който е със стойност 48 и така получаваме стойността на цифрата 3, а не стойността на
                // char-a, която в началото беше '3'
                int digit = number[i] - '0'; // същото като = int.Parse(number[i].ToString());

                remainder += multiplyer * digit;

                if (remainder > 9)
                {
                    int remainderLastDigit = remainder % 10;
                    remainder /= 10;
                    // number = 99
                    //remainderLastDigit = 1
                    //remainder = 8
                    result.Add(remainderLastDigit.ToString());
                }
                else
                {
                    result.Add(remainder.ToString());
                    remainder = 0;
                }

            }
            // 8 8
            //   99 * 9
            //-------------
            //  891
            //ако накрая остане нещо в ремайндъра(в случая остава 8-ца) remainder > 0
            //запищи остатъка в резултата
            if (remainder > 0)
            {
                result.Add(remainder.ToString());
            }

            result.Reverse();

            return (string.Concat(result));
        }
    }
}
