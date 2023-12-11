// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Прием размера массива
        Console.WriteLine("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Объявление массива для хранения случайных чисел
        int[] array = new int[size];
        // Исходный массив
        // Создание экземпляра класса
        Random r = new Random();

        // Заполнение массива числами
        for (int i = 0; i < size; i++)
            array[i] = r.Next(100);

        void PrintArray(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                PrintArray(array, i + 1);
            }

        }
        void ReversArray(int[] array, int i = 0)
        {
            // Реверсирование массива
            if (i < array.Length / 2)
            {
                int temp;
                // Меняем местами элементы
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
                i++;
                ReversArray(array, i);
            }
            else
            {
                return;
            }


        }
        void PrintnewArray(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                PrintnewArray(array, i + 1);
            }

    }
        {
            PrintArray(array);
    Console.WriteLine();
            ReversArray(array);
    PrintnewArray(array);
}
    }
}
