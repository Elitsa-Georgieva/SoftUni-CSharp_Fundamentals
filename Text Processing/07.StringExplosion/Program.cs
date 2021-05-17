using System;
using System.Linq.Expressions;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int bomb = 0;
            //for цикъл, ще гледаме клетката в дясно, когато намерим символ >


            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                //ако текущия символ е >, гледаме в дясно и към текущата бомба да добавим стойността на бомбата
                //която стои вдясно, т.е новата бомба която сме открили
                if (symbol == '>')
                {
                    //към бомбата добавяме СТОЙНОСТТА НА числото, което стои вдясно от символа >
                    bomb += text[i + 1] - '0'; // text[i+1] връща числото като текст, а ние искаме числената му
                    //стойност
                    // добавяме си символа към sb result-a
                    result.Append(symbol);
                }
                else if (bomb > 0)
                {
                    //игнорваме текущия символ и бомбата намаля с единица
                    bomb -= 1;
                    //все едно е гръмнала клетката на която се намираме
                }
                else
                {
                    // ако символа не е '>' и не е Bomba > 0(избухнала бомба, която е почнала да трие символи)
                    result.Append(symbol);
                }
            }
            Console.WriteLine(result);
        }
    }
}
