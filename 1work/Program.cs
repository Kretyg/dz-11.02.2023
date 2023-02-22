// Показать натуральные числа от N до 1, N задано

void PrintNumber(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
PrintNumber(10);