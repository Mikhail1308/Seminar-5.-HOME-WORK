// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayToConsole()
{
    int[] array = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
void PrintArray(int[] array, string msg)
{
    Console.WriteLine(msg);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        //Console.Write($"{array[i]}\t");
        Console.Write(array[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int CheckToParity(int[] array)
{
    int count = 0;
    Console.Write("Количество четных чисел = ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] numbersArray = CreateArrayToConsole();
PrintArray(numbersArray, "В массиве: ");
Console.WriteLine(CheckToParity(numbersArray));
Console.WriteLine();