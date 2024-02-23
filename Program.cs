// int FindFactorial (int n)
// {
//     // Базовый случай - случай остановки рекурсии
//     if (n == 1) return 1;
//     // Рекурсивный случай  - случай вызова метода внутри метода
//     return n * FindFactorial (n - 1);
// }
// Console.WriteLine(FindFactorial(5));


// Задание 1.
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Пример
// 123 => 6 63 => 9

// int FindSumOfDigits (int n)
// {
//     // Базовый случай
//     if (n == 0) return 0; // 3 + 6 + 0 = 9
//     int result = n % 10 + FindSumOfDigits(n / 10);
//     return result;
// }
// Console.WriteLine(FindSumOfDigits(63));


// Задание 2.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Пример
// N=5 => 1 2 3 4 5

// void ShowNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// ShowNumbers(1, 5);



// Домашнее задание

//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void ShowNumbers(int M, int N)
// {
//     if(M == N)
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// Console.Write("Введите натуральное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// Console.Write("Введите натуральное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int SolveAkkermanFunction(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return SolveAkkermanFunction(n - 1, 1);
//     }
//     return SolveAkkermanFunction(n - 1, SolveAkkermanFunction(n, m - 1)); 
// }

// Console.WriteLine(SolveAkkermanFunction(n, m));



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    } 
    return array;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] initialArr = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", initialArr)} ]");

int j = initialArr.Length - 1;
void PrintReverseArray (int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j] + " ");
        return;
    }
    Console.Write(array[j] + " ");
    PrintReverseArray(array, j - 1);
}

PrintReverseArray(initialArr, j);




