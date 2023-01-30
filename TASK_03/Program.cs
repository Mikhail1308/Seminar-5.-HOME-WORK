// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76


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
        Console.Write(array[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] numbersArray = CreateArrayToConsole();
int maxValue = numbersArray.Max();
int minValue = numbersArray.Min();
PrintArray(numbersArray, "В массиве: ");
Console.WriteLine($"Разница между максимальным {maxValue} и минимальным {minValue} элементами = {(maxValue - minValue)}");
Console.WriteLine();
