string operation;
do
{
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    Console.WriteLine("Выберите номер действия:");
    operation = Console.ReadLine();
    if (operation == "1")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 + num2);
    }
    else if (operation == "2")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 - num2);
    }
    else if (operation == "3")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 * num2);
    }
    else if (operation == "4")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        if (num2 != 0)
        {
            Console.WriteLine(num1 / num2);
        }
        else
        {
            Console.WriteLine("На ноль не делим");
        }
    }
    else if (operation == "5")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(num1, num2));
    }
    else if (operation == "6")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(num1));
    }
    else if (operation == "7")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 * 0.01);
    }
    else if (operation == "8")
    {
        Console.Write("Введите 1 число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double res = 1;
        if (num1 >= 0)
        {
            for (int i = 1; i < num1 + 1; i++)
            {
                res = res * i;
            }
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine("Я не могу найти факториал отрицательного числа");
        }
    }
    else if (operation == "9")
    {
        Console.WriteLine("Вычисления закончены!");
    }
    else
    {
        Console.WriteLine("Операция не распознана");
    }
} while (operation != "9");