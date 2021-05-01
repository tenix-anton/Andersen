using System;

namespace KaravikouForAndersen2
{
    class Program
    {
        static void Main()
        {
            string compareName = "Вячеслав";
            string enterName;
            Console.WriteLine("Введите имя и нажмите Enter");
            enterName = Console.ReadLine();
            if (enterName == compareName)
                Console.WriteLine("Привет, Вячеслав");

            else
                Console.WriteLine("Нет такого имени");
            Console.ReadKey();
        }
    }
}
