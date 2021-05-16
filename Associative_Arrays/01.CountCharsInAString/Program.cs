using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //a -> 2
            //char -> int

            Dictionary<char, int> counts = new Dictionary<char, int>();
            //прочитаме си думата от конзолата
            string word = Console.ReadLine();

            //минаваме през всяка една буква в думата
            foreach (char letter in word)
            {
                //по условие, когато имаме спейсове, трябва да ги игнорираме и да не правим нищо с тях,
                //т.е. да не ги включваме в аутпута
                if (letter == ' ')
                {
                    continue;
                }
                //ако counts  съдържа буквата, ние вече там се записали някаква стойност - 1;
                //=> трябва да добавим 1 към value-то на кay letter в counts (counts[letter] "counts от letter") 
                if (counts.ContainsKey(letter))
                {
                    counts[letter] += 1;
                }
                else
                {
                    counts.Add(letter, 1);
                }
            }

            //след като миневм през всички букви в counts
            //минаваме през речника counts, през всяка kvp
            //kvp.Key ще даде буквата , а kvp.Value - колко пъти се е срещала
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
