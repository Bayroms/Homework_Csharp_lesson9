Start();

void Start()
{
    while(true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        System.Console.WriteLine("Enter 0 to end");

        int NumTask = int.Parse(Console.ReadLine());
        switch (NumTask)
        {
            case 0: return; break;
            case 64: IntFromOneToN(); break;
            case 66: SumFromMToN(); break;
            case 68: AccermanRecursion(); break;
            default: System.Console.WriteLine("Enter number of task or 0"); break; 
        }
    }
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void IntFromOneToN()
{
    int num = SetNumber("Enter number N ");
    if (num > 1) Func(1, num);
    else System.Console.WriteLine("Enter number greater than 1");
}


void Func(int i, int num)
{
    Console.Write(num-- + ", ");
    if (num > i)
        Func(i, num);
    else
        Console.Write(1);
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumFromMToN()
{
    int m = SetNumber("Enter number M ");
    int n = SetNumber("Enter number N ");
    int result = GetSum(m, n);
    System.Console.WriteLine("Sum of natural elements between M to N = " + result);
}

int GetSum(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void AccermanRecursion()
{
    int m = SetNumber("Enter number M ");
    int n = SetNumber("Enter number N ");
    if (n > -1 && m > -1)
    {
        Console.WriteLine($"A{(m,n)} = " + Accerman(m,n));
    }
    else System.Console.WriteLine("Enter positive numbers or 0");
}

int Accerman(int m, int n)
{
    if (n == 0) return Accerman(m - 1, 1);
    if (m == 0) return n + 1;
    return Accerman(m - 1, Accerman(m, n - 1));
}


int SetNumber(string name)
{
    string[] arr = name.Split(" ");
    System.Console.WriteLine(name);
    int num = int.Parse(Console.ReadLine());
    return num;
}