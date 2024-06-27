// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void ShowArray(int[] array, int i)
{
    if (i == 0)
    {
        System.Console.Write(array[i]);
        return;
    }
    System.Console.Write(array[i] + " ");
    ShowArray(array, i - 1);
    return;
}

int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
ShowArray(arr1, arr1.Length - 1);