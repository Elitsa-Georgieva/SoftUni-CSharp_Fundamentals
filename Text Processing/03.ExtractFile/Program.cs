using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the path to a file and subtracts the file name and its extension.

            string[] pathParts = Console.ReadLine()
                .Split("\\");

                //взимаме си последния стринг от pathParts, т.е последния елемент от този масив
            string fileWithExtension = pathParts[pathParts.Length - 1];




            ////.............ДРУГО РЕШЕНИЕ:
            ////
            //int extensionIdx = fileWithExtension.LastIndexOf(".") 
            //// ................взимаме индекса на последната точка
            ////.................и вадим от началото на последния стринг разделен с \ до точката (това ни еимето на фаила)
            ////.................и от точката до края на последния стринг (екстеншъна)

            //string fileName = fileWithExtension.Substring(0, extensionIdx);
            //string extension = fileWithExtension.Substring(extensionIdx + 1);

            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {extension}");





            string[] fileParts = fileWithExtension.Split(".", StringSplitOptions.RemoveEmptyEntries);
            //C:\Projects\Data-Structures\LinkedList.Old.cs - вход
            // "LinkedList" "Old" "cs" - изход

            string extension = fileParts[fileParts.Length - 1];

            string fileName = fileWithExtension.Replace($".{extension}", "");

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
