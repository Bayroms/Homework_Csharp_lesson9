// Start();

// void Start()
// {
//     while(true)
//     {
//         Console.ReadLine();
//         Console.Clear();

//         System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
//         System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
//         System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
//         System.Console.WriteLine("Enter 0 to end");

//         int NumTask = int.Parse(Console.ReadLine());
//         switch (NumTask)
//         {
//             case 0: return; break;
//             case 64: ; break;
//             case 66: ; break;
//             case 68: ; break;
//             default: System.Console.WriteLine("Enter number of task or 0"); break; 
//         }
//     }
// }

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
IntFromOneToN();
void IntFromOneToN()
{
    int n = SetNumber("Enter number N ");
    Func(n,1);
}


void Func(int i, int n)
{
    Console.Write(i-- + ", ");
    if (i > n)
        Func(i, n);
    else
        Console.Write(1);

}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




int SetNumber(string name)
{
    string[] arr = name.Split(" ");
    System.Console.WriteLine(name);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[,] GetRandomMatrix(int rows, int colums, int MinValue = -100, int MaxValue = 100)
{
    int[,] matrix = new int[rows, colums];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(MinValue, MaxValue + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}