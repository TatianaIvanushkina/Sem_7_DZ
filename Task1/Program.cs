// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowNumbers (int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Enter the number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N); 