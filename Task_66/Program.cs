/* Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 */

int M = Int32.Parse(Console.ReadLine());
int N = Int32.Parse(Console.ReadLine());
int result = 0;
int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return  (N + 1);
    }
    if (M > 0 && N == 0)
    {
        return Akkerman(M - 1, 1);
    }
    if (M > 0 && N > 0)
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }

    return result;
}
int result1 = Akkerman(M, N);
Console.WriteLine(result1);