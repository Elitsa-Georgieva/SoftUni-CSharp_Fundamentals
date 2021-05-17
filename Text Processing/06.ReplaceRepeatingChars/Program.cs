using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char prevSymbol = '\0'; // празен символ(празен чар) '\0'

            StringBuilder result = new StringBuilder();

            foreach (char letter in text)
            {
                //text = aaaaabbbbbcdddeeeedssaa
                //letter = 97'a'
                // prevSymbol = 0 '\0'
                //result {a}
                //prevSymbol = 97'a'

                //letter = 97 'a'
                //prevSymbol = 97 'a'
                // пропускаме if-a

                //6-та итерация
                //letter = 98'b'
                //prevSymbol = 97'a'
                //result {ab...}

                //ако letter-a е различен от предишния символ, трябва да запищем тази буква към резултат -
                //правим sb 
                if (letter != prevSymbol)
                {
                    result.Append(letter);
                }
                //тук трябва да кажем, че предния символ е равен на текущата буква
                prevSymbol = letter;
                //на следващата итерация тази буква ще се сравнява със следващата
            }
            Console.WriteLine(result);
        }
    }
}
