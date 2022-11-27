// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetArray(5, -20, 21);
Console.WriteLine(String.Join(" ", array));

int oddPositionSum = OddPositionSum(array);
Console.Write("[");
Console.Write($"{String.Join(" ", array)}");
Console.Write("]");
Console.Write($" -> {oddPositionSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int OddPositionSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum = arr[i] + sum;
    }
        return sum;  
}
OddPositionSum(array);