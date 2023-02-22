// Найти сумму элементов от M до N, N и M заданы

void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
PrintNumber(1, 10);
Console.WriteLine();
Console.WriteLine(Sum(1, 10));