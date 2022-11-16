/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

Messager("Введите число М: ");
int M = InputNum();
Messager("Введите число N: ");
int N = InputNum();
Messager($"M = {M}; N = {N} -> ");

OutputOfEvenNaturalNumbers(M, N);

void Messager(string message)
{
    Console.Write(message);
}

int InputNum()
{
    return Convert.ToInt32(Console.ReadLine()); ;
}

void OutputOfEvenNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if(m%2 == 0)
    {
        Console.Write($"{m} ");
    }
    
    OutputOfEvenNaturalNumbers(m + 1, n);

}