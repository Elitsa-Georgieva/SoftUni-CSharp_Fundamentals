using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }

            Console.WriteLine(text);

            //string[] words = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //string text = Console.ReadLine();

            //foreach (var word in words)
            //{
            //    text = (text.Replace(word, new string('*', word.Length)));
            //    //заменяме всяка дума с един стринг, който ще го конструираме по следния начин - ще
            //    //използваме символа '*' и ще го повторим Length пъти

            //}

            //Console.WriteLine(text);
        }
    }
}



