/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

Messager("Введите число М: ");
int M = InputNum();
Messager("Введите число N: ");
int N = InputNum();
int sum = 0;

Messager($"M = {M}; N = {N} -> ");

OutputOfEvenNaturalNumbers(M, N, sum);


void Messager(string message)
{
    Console.Write(message);
}

int InputNum()
{
    return Convert.ToInt32(Console.ReadLine()); ;
}

void OutputOfEvenNaturalNumbers(int m, int n, int s)
{
    if (m < 0)
    {
        m = 0;
    }

    if (m > n)
    {
        Console.Write(s);
        return;
    }

    if (m <= n)
    {
        s = s + m;
    }
    OutputOfEvenNaturalNumbers(m + 1, n, s);

}
