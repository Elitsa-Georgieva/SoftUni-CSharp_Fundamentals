using System;

namespace _01._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // 1. ще проверим дали елемента, който в момента итерираме е >= 3 или <= 16
            // 2. ще проверим дали даден стринг съдържа само букви, числа, тире и долна черта - КАК? 
            // Можем да го проверим като итерираме всички символи, които са част от стринга и да проверяваме
            // дали този символ е един от позволените

            foreach (string username in usernames)
            {
                // ще си направим един къстъм метод, който ще връща true или false и ще очаква наякакъв username
                // който да проверява

                if (IsValid(username))
                {
                    //ако и двата метода връщат true - отпечатваме този username на конзолата
                    Console.WriteLine(username);
                }

            }
           
        }

        private static bool IsValid(string username)
        {
            // ще обединява двете условия, да има дължина между 3 и 16 символа и да съдържа само валидно символи
            return IsValidLength(username) && ContainsValidSymbols(username);
            // ако и двата метода връщат true - отпечатваме този username на конзолата
        }

        private static bool ContainsValidSymbols(string username)
        {
            foreach (char symbol in username)
            {
                //дали този символ е буква или цифра
                if (!char.IsLetterOrDigit(symbol) &&
                    symbol != '_' &&
                    symbol != '-')
                {
                    return false;
                }

            }

            return true;
        }

        private static bool IsValidLength(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }

        //прочитаме всички имена, форийчваме ги, проверяваме дали е валидно, ако е го отпечатваме, 
        //за да е валидно проверяваме в методите дали не съдържа непозволени символи и дали има валидна дължина
        
    }
}
