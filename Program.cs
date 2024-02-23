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

void ShowNumbers(int M, int N)
{
    if(M == N)
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + " ");
    ShowNumbers(M + 1, N);
}
ShowNumbers(4, 8);

