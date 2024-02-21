// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int CalculateАunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return CalculateАunctionAkkerman(m - 1, 1);
    else return CalculateАunctionAkkerman(m - 1, CalculateАunctionAkkerman(m, n - 1));
}
Console.Write("Enter the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalculateАunctionAkkerman(m, n));