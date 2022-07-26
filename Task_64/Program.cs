/* Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int M = Int32.Parse(Console.ReadLine());
int N = Int32.Parse(Console.ReadLine());
int sum = 0;
int SumNatural(int M, int N)
{
    if (M <= N)
    {
        sum = sum + M;
        M++;
        SumNatural(M, N);
    }
    return sum;
}
int result = SumNatural(M, N);
Console.WriteLine(result);