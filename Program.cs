class Calculator
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1 процент");
            Console.WriteLine("8. Найти факториал");
            Console.WriteLine("9. Выйти из программы");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num2 = double.Parse(Console.ReadLine());
                    double sum = num1 + num2;
                    Console.WriteLine($"Сумма чисел: {sum}");
                    break;

                case 2:
                    Console.WriteLine("Введите первое число:");
                    double num3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num4 = double.Parse(Console.ReadLine());
                    double difference = num3 - num4;
                    Console.WriteLine($"Разность чисел: {difference}");
                    break;

                case 3:
                    Console.WriteLine("Введите первое число:");
                    double num5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num6 = double.Parse(Console.ReadLine());
                    double product = num5 * num6;
                    Console.WriteLine($"Произведение чисел: {product}");
                    break;

                case 4:
                    Console.WriteLine("Введите первое число:");
                    double num7 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num8 = double.Parse(Console.ReadLine());

                    if (num8 == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                    }
                    else
                    {
                        double quotient = num7 / num8;
                        Console.WriteLine($"Частное чисел: {quotient}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Введите число:");
                    double baseNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    int exponent = int.Parse(Console.ReadLine());
                    double result = Math.Pow(baseNum, exponent);
                    Console.WriteLine($"Результат возведения в степень: {result}");
                    break;

                case 6:
                    Console.WriteLine("Введите число:");
                    double number = double.Parse(Console.ReadLine());
                    double sqrt = Math.Sqrt(number);
                    Console.WriteLine($"Квадратный корень из числа: {sqrt}");
                    break;

                case 7:
                    Console.WriteLine("Введите число:");
                    double inputNum = double.Parse(Console.ReadLine());
                    double percent = inputNum / 100;
                    Console.WriteLine($"1 процент от числа: {percent}");
                    break;

                case 8:
                    Console.WriteLine("Введите число:");
                    int factorialNum = int.Parse(Console.ReadLine());
                    int factorial = 1;

                    for (int i = 1; i <= factorialNum; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine($"Факториал числа: {factorial}");
                    break;

                case 9:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

            Console.WriteLine("===================================");
        }

        Console.WriteLine("Программа завершена");
    }
}
