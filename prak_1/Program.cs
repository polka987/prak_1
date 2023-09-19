int a = 0, b = 0;
Console.WriteLine("1.Сложить 2 числа\n" +
    "2.Вычесть первое из второго\n" +
    "3.Перемножить два числа \n" +
    "4.Разделить первое на второе\n" +
    "5.Возвести в степень N первое число\n" +
    "6.Найти квадратный корень из числа\n" +
    "7.Найти 1 процент от числа \n" +
    "8.Найти факториал из числа\n" +
    "9.Выйти из программы");
while (1 == 1)
{
    
    Console.WriteLine("\nВведите операцию:");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Первое число");
    
    switch (value)
    {
        
        case 1:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (a + b));
            break;
        case 2:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: "+(b - a));
            break;
        case 3:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (b * a));
            break;
        case 4:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Не одно из введенных чисел не должно быть нулем");
            }
            else
            {
                Console.WriteLine("Результат: " + (a / b));
            }
            break;
        case 5:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + Math.Pow(a, b));
            break;
        case 6:
            Console.WriteLine("Корень из числа");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (Math.Sqrt(a)));
            break;
        case 7:
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + ( (double)a / 100));
            break;
        case 8:
            a = Convert.ToInt32(Console.ReadLine());
            b = 1;
            for (int i = 1; i <= a; i++)
            {
                b = b * i;
            }
            Console.WriteLine("Результат: " + b);
            break;
        case 9:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Ты бы ввел, если бы не был геем.");
            break;
    }
}