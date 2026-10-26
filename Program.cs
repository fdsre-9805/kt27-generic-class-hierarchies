using System;

namespace ContainersApp
{
    class Program
    {
        static void Main()
        {
            StringContainer wordsContainer = new StringContainer();
            int wordsCount = ReadCount("Сколько строк добавить в StringContainer? ");
            for (int wordNumber = 1; wordNumber <= wordsCount; wordNumber++)
            {
                wordsContainer.Add(ReadText($"Строка {wordNumber}: "));
            }
            Console.WriteLine("PrintAllUpper():");
            wordsContainer.PrintAllUpper();

            Console.WriteLine();
            CountingContainer<int> numbersContainer = new CountingContainer<int>();
            int numbersCount = ReadCount("Сколько чисел добавить в CountingContainer<int>? ");
            for (int numberIndex = 1; numberIndex <= numbersCount; numberIndex++)
            {
                numbersContainer.Add(ReadNumber($"Число {numberIndex}: "));
            }
            Console.WriteLine($"Count: {numbersContainer.Count}, TotalAdded: {numbersContainer.TotalAdded}");

            Console.WriteLine();
            CountingContainer<string> textsContainer = new CountingContainer<string>();
            int textsCount = ReadCount("Сколько строк добавить в CountingContainer<string>? ");
            for (int textNumber = 1; textNumber <= textsCount; textNumber++)
            {
                textsContainer.Add(ReadText($"Строка {textNumber}: "));
            }
            Console.WriteLine($"Count: {textsContainer.Count}, TotalAdded: {textsContainer.TotalAdded}");
        }

        static int ReadCount(string prompt)
        {
            Console.Write(prompt);
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
            {
                Console.Write("Нужно целое число больше нуля: ");
            }
            return count;
        }

        static int ReadNumber(string prompt)
        {
            Console.Write(prompt);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Нужно целое число: ");
            }
            return number;
        }

        static string ReadText(string prompt)
        {
            Console.Write(prompt);
            string text = Console.ReadLine()!;
            while (text == "")
            {
                Console.Write("Строка не должна быть пустой: ");
                text = Console.ReadLine()!;
            }
            return text;
        }
    }
}
