/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

Messager("Введите число m: ");
int m = InputNum();

Messager("Введите число n: ");
int n = InputNum();

int function = AckermanFunction(m, n);
Console.WriteLine(function);

void Messager(string message)
{
    Console.Write(message);
}

int InputNum()
{
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m != 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }

    return AckermanFunction(m, n);
}