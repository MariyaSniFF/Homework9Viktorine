//Задания к семинару 9. Рекурсия
Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("64) Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        System.Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        System.Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        System.Console.WriteLine("0 End");

        int numTask = SetNumber("task");

        int SetNumber(string numberName)
        {
            Console.Write($"Введите номер задачи {numberName}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        switch (numTask)
        {
            case 0: return; break;
            
            case 64: GetRealNumbers(); break;
            case 66: GetNaturalElementsSum(); break;
            case 68: GetAkkermanFunction(); break;
            default: System.Console.WriteLine("Error"); break;
        }

    }

}
void GetRealNumbers()
{
    // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    Console.WriteLine("Введите натуральное число больше 1:");
    int number = Convert.ToInt32(Console.ReadLine());

    void NumberCounter(int number)
    {
        if (number < 0) Console.Write("вы ввели не натуральное число"); // как остановить повторения тут??
        if (number == 0) return;
        Console.Write("{0,4}", number);
        NumberCounter(number - 1);
    }

    NumberCounter(number);
}
void GetNaturalElementsSum()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите M:");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите N:");
    int n = Convert.ToInt32(Console.ReadLine());

    void GetNumberSum(int m, int n, int sum)
    {
        if (m > n)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
            return;
        }
        sum = sum + (m++);
        GetNumberSum(m, n, sum);
    }

    GetNumberSum(m, n, 0);
}

void GetAkkermanFunction()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int functionAkkerman = akk(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int akk(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return akk(m - 1, 1);
        else return akk(m - 1, akk(m, n - 1));
    }
}