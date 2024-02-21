// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintReverseArray (int[] array, int j)
{
    if (j == 0)
    {
    Console.WriteLine(array[j]);
    return;
    }
    Console.Write(array[j] + " ");
    PrintReverseArray (array, j - 1);
}
int[] arr = { 1, 2, 5, 0, 10, 34 };
int j = arr.Length - 1;
PrintReverseArray (arr, j);

