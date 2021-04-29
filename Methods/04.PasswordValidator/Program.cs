using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool IsValid = true;

            if (!HasValidLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                IsValid = false;
            }

            if (ContainsInvalidCharacters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                IsValid = false;
            }

            if (!ContainsDigits(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                IsValid = false;
            }

            if (IsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsDigits(string password, int count)
        {
            int fountDigitsCount = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    fountDigitsCount += 1;

                    if (fountDigitsCount == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool ContainsInvalidCharacters(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasValidLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
