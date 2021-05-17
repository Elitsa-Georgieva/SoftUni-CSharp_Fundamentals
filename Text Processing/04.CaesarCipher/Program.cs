using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //encrypted version of the same text
            //shifting each character with three positions forward
            //A would be replaced by D, B would become E, and so on

            //Input: Programming is cool! Output: Surjudpplqj#lv#frro$

            //ASCII P= 80 //+3 == 83 == S

            //четем стринг от конзолата, минаваме през всеки символ и го трансформираме, като му добавим стойност
            // тройка [(това ни дава int), този int го кастваме към char този char можем да го долепяме в някакъв
            // stringBuilder ] и това ще ни даде нов символ.

            string text = Console.ReadLine();
            StringBuilder encriptedText = new StringBuilder();

            foreach (char letter in text)
            {
                char encriptedLetter = (char)(letter + 3); // (char)(letter) е cript!!!

                encriptedText.Append(encriptedLetter);
            }
            Console.WriteLine(encriptedText);
        }
    }
}
