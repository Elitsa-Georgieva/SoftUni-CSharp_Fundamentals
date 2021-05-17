using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем си стринговете

            //масив който да съдържа елементи разделени с няколко сепаратора - \t = tab като char
            string[] words = Console.ReadLine()
                .Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            //минаваме през всяка една дума
            foreach (var word in words)
            {
                //за всеки един масив трябва да вземем първия и последния символ
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];

                //A12b - трябва да вземем цифрите между двата първи и последен символ
                //започни събстринга от 1-ви индекс, което ни е втория символ
                // ако знаем, че стринга ни съдържа четири символа, изваждаме първи и последен, които със сигурност
                //са ни букви и резултата ще е това което искаме да събстрингнем
                double number = double.Parse(word.Substring(1, word.Length - 2));
                //връща стринг, затова си го парсваме

                if (char.IsUpper(firstLetter))
                {
                    //If it's uppercase you divide the number by the letter's position in the alphabet. 
                    //големите букви почват от 65 - ASCII
                    number /= firstLetter - 64; //това ни дава позицията на буквата в азбуката (A -> 65-64 = 1)
                }
                else
                {
                    //If it's lowercase you multiply the number with the letter's position in the alphabet. 
                    //малките букви почват от 97 - ASCII
                    number *= firstLetter - 96;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - 64;
                }
                else
                {
                    number += lastLetter - 96;
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");

        }
    }
}
