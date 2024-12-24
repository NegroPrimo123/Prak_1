using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            ShowMenu();
            int action = GetUser Choice();

            Console.Clear(); // Очистка консоли

            switch (action)
            {
                case 1:
                    ShowAverageCalculatorTask();
                    AverageCalculator();
                    break;
                case 2:
                    ShowCalculatorTask();
                    Calculator();
                    break;
                case 3:
                    ShowTemperatureConverterTask();
                    TemperatureConverter();
                    break;
                case 4:
                    ShowFileNameExtractorTask();
                    FileNameExtractor();
                    break;
                case 5:
                    ShowLongestWordFinderTask();
                    LongestWordFinder();
                    break;
                case 6:
                    ShowArrayMultiplierTask();
                    ArrayMultiplier();
                    break;
                case 7:
                    ShowMinMaxFinderTask();
                    MinMaxFinder();
                    break;
                case 8:
                    ShowNumberPyramidTask();
                    NumberPyramid();
                    break;
                case 9:
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }

            // Сообщение о завершении задачи
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
            Console.Clear(); // Очистка консоли перед повторным отображением меню
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Нахождение среднего значения четырех чисел");
        Console.WriteLine("2. Калькулятор");
        Console.WriteLine("3. Конвертация температуры");
        Console.WriteLine("4. Определение имени файла по пути");
        Console.WriteLine("5. Нахождение самого длинного слова в предложении");
        Console.WriteLine("6. Перемножение двух массивов значений");
        Console.WriteLine("7. Нахождение максимального и минимального числа из пяти введенных");
        Console.WriteLine("8. Вывод 'пирамиды' из чисел");
        Console.WriteLine("9. Выход");
    }

    static int GetUser Choice()
    {
        Console.Write("Введите номер действия: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void ShowAverageCalculatorTask()
    {
        Console.WriteLine("Задание: Нахождение среднего значения четырех чисел.");
        Console.WriteLine("Введите четыре числа, и программа вычислит их среднее значение.");
    }

    static void ShowCalculatorTask()
    {
        Console.WriteLine("Задание: Калькулятор.");
        Console.WriteLine("Введите два числа и выберите действие (сложение, вычитание, умножение, деление, остаток).");
    }

    static void ShowTemperatureConverterTask()
    {
        Console.WriteLine("Задание: Конвертация температуры.");
        Console.WriteLine("Выберите шкалу вводимой температуры и введите значение для конвертации.");
    }

    static void ShowFileNameExtractorTask()
    {
        Console.WriteLine("Задание: Определение имени файла по пути.");
        Console.WriteLine("Введите путь к файлу, и программа извлечет имя файла.");
    }

    static void ShowLongestWordFinderTask()
    {
        Console.WriteLine("Задание: Нахождение самого длинного слова в предложении.");
        Console.WriteLine("Введите предложение, и программа найдет самое длинное слово.");
    }

    static void ShowArrayMultiplierTask()
    {
        Console.WriteLine("Задание: Перемножение двух массивов значений.");
        Console.WriteLine("Введите два массива чисел, и программа перемножит их элементы.");
    }

    static void ShowMinMaxFinderTask()
    {
        Console.WriteLine("Задание: Нахождение максимального и минимального числа из пяти введенных.");
        Console.WriteLine("Введите пять чисел, и программа определит максимальное и минимальное значения.");
    }

    static void ShowNumberPyramidTask()
    {
        Console.WriteLine("Задание: Вывод 'пирамиды' из чисел.");
        Console.WriteLine("Введите количество ступеней, и программа выведет пирамиду чисел.");
    }

    // Остальные функции остаются без изменений
    static void AverageCalculator()
    {
        Console.WriteLine("Введите четыре числа:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"Среднее значение: {average}");
    }

    static void Calculator()
    {
        Console.WriteLine("Введите два числа:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Выберите действие: 1. Сложение 2. Вычитание 3. Умножение 4. Деление 5. Остаток");
        int choice = Convert.ToInt32(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
            case 5:
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }
        Console.WriteLine($"Результат: {result}");
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("Выберите шкалу вводимой температуры: 1. Цельсий 2. Кельвин 3. Фаренгейт");
        int scaleFrom = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите температуру:");
        double temperature = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Выберите шкалу для конвертации: 1. Цельсий 2. Кельвин 3. Фаренгейт");
        int scaleTo = Convert.ToInt32(Console.ReadLine());

        double convertedTemperature = 0;

        if (scaleFrom == 1) // Цельсий
        {
            if (scaleTo == 2) // Кельвин
                convertedTemperature = temperature + 273.15;
            else if (scaleTo == 3) // Фаренгейт
                convertedTemperature = (temperature * 9 / 5) + 32;
        }
        else if (scaleFrom == 2) // Кельвин
        {
            if (scaleTo == 1) // Цельсий
                convertedTemperature = temperature - 273.15;
            else if (scaleTo == 3) // Фаренгейт
                convertedTemperature = (temperature - 273.15) * 9 / 5 + 32;
        }
        else if (scaleFrom == 3) // Фаренгейт
        {
            if (scaleTo == 1) // Цельсий
                convertedTemperature = (temperature - 32) * 5 / 9;
            else if (scaleTo == 2) // Кельвин
                convertedTemperature = (temperature - 32) * 5 / 9 + 273.15;
        }

        Console.WriteLine($"Конвертированная температура: {convertedTemperature}");
    }

    static void FileNameExtractor()
    {
        Console.WriteLine("Введите путь до файла:");
        string path = Console.ReadLine();
        string fileName = path.Substring(path.LastIndexOf('/') + 1);
        Console.WriteLine($"Имя файла: {fileName}");
    }

    static void LongestWordFinder()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
    }

    static void ArrayMultiplier()
    {
        Console.WriteLine("Введите значения для первого массива через пробел:");
        string[] firstArrayInput = Console.ReadLine().Split(' ');
        Console.WriteLine("Введите значения для второго массива через пробел:");
        string[] secondArrayInput = Console.ReadLine().Split(' ');

        int length = Math.Min(firstArrayInput.Length, secondArrayInput.Length);
        int[] resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            int num1 = Convert.ToInt32(firstArrayInput[i]);
            int num2 = Convert.ToInt32(secondArrayInput[i]);
            resultArray[i] = num1 * num2;
        }

        Console.WriteLine("Результат: " + string.Join(" ", resultArray));
    }

    static void MinMaxFinder()
    {
        Console.WriteLine("Введите пять чисел через пробел:");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
                maxNumber = number;
            if (number < minNumber)
                minNumber = number;
        }

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
    }

    static void NumberPyramid()
    {
        Console.WriteLine("Введите количество ступеней:");
        int levels = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= levels; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}