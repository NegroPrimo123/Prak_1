using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод диапазона
            Console.WriteLine("Введите начальное число:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное число:");
            int end = int.Parse(Console.ReadLine());

            // Выбор действия
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Вывести все числа из интервала");
            Console.WriteLine("2. Вывести четные числа из интервала");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintNumbers(start, end);
                    break;
                case 2:
                    PrintEvenNumbers(start, end);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1 или 2.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Ввод должен быть числом.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static void PrintNumbers(int start, int end)
    {
        Console.WriteLine($"Числа от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            Console.Write(i);
            if (i < end)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void PrintEvenNumbers(int start, int end)
    {
        Console.WriteLine($"Четные числа от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i < end - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
    }
}