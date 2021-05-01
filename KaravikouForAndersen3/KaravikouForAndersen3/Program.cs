using System;

namespace KaravikouForAndersen3
{
    class Program
    {
        static void Main()
        {
        m1:
            Console.WriteLine("Введите количество элементов в массиве:");
            try
            {
                int numberOfItems = int.Parse(Console.ReadLine());
                int[] array = new int[numberOfItems];
                for (int i = 0; i < array.Length; i++)
                {
                m2:
                    try
                    {
                        Console.WriteLine($"Введите элемент массива под индексом {i}:");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели недопустимый символ");
                        goto m2;
                    }
                }
                Console.WriteLine("В данном массиве элементы кратные 3 являются:");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели недопустимый символ");
                goto m1;
            }
            Console.ReadKey();
        }
    }
}
