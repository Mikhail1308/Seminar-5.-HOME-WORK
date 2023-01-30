// Задача 2: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayToConsole()
{
    int[] array = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }
    return array;
}
void PrintArray(int[] array, string msg)
{
    Console.WriteLine(msg);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumArray(int[] array)
{
    int SumArray = 0;
    Console.Write("Сумма элементов на нечетных позициях массива = ");
    for (int i = 0; i < array.Length; i += 2)
    {
        SumArray = SumArray + array[i];
    }
    return SumArray;
}

int[] numbersArray = CreateArrayToConsole();
PrintArray(numbersArray, "В массиве: ");
Console.WriteLine(SumArray(numbersArray));
Console.WriteLine();
