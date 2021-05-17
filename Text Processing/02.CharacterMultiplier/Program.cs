using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем ред и го сплитваме по спейс

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //правим си променлива result в която ще запишем резултата от метод, който ще се грижи
            //за цялото умножение на двата (в случая два) стринга

            int result = MultiplayWords(words[0], words[1]);
            
            //накрая трябва да отпечатаме този резултат

            Console.WriteLine(result);


        }

        private static int MultiplayWords(string first, string second)
        {
            //взимаме си минималната дължина от двата стринга(двете думи)
            // for цикъл до минималната дължина, ще ни подсигури, че двата стринга ще ги итерираме със сигурност
            //до там до където има символи и в двата. Взимаме двата чара и ги умножаваме. Свършат ли символите в един
            //от двата стринга, for цикъла ще приключи
            //0  1  2  3
            //а
            //а  а  а  а
            //знаейки, минималната дължина, ако има различни стрингове, за да съберем сулмата на останалите в по-дългия
            //стринг символи, ще почнем събирането от индекса == размера на мин. дължина
            //примера горе: мин дължина = 1, съответно почваме да събираме оставащите символи от 1-ви индекс
            //ако мин дължина ни е 2, почваме от индекс 2 и т.н

            int minLength = Math.Min(first.Length, second.Length);

            int sum = 0;

            for (int i = 0; i < minLength; i++)
                //до < MinLength, a не <= 
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                // трябва да добавим оставащите в по-дългия стринг символи и да добавим тяхната стойност
                //към SUM

                sum += SumRemainingChars(first, minLength);

            }
            else if (second.Length > first.Length)
            {
                sum += SumRemainingChars(second, minLength);
            }

            return sum;
        }

        private static int SumRemainingChars(string word, int idx)
        {
            //тук взимаме оставащите символи
            //минималната дължина отговаря на индекса, от който трябва да започнем събирането
            int sum = 0;

            for (int i = idx; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}
