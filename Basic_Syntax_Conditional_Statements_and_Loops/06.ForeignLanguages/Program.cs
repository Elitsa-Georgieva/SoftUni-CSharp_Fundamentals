using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 125;
            //Console.WriteLine("{0:C}", num);

            string country = Console.ReadLine();
            string language = null;

            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
