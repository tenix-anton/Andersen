using System;

namespace KaravikouForAndersen1
{
    class Program
    {
        static void Main()
        {
            int compareNumber = 7;
            int userNumber;
            m1:
            try
            {
                Console.WriteLine("Введите число и нажмите Enter");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > compareNumber)
                {
                    Console.WriteLine("Привет");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Вы ввели недопустимый символ");
                goto m1;
            }
            Console.ReadKey();
        }
    }
}
