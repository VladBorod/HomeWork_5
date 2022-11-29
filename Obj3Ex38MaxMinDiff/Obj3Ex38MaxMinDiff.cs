// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

int[] array = GetArray(5, 1, 20);
Console.WriteLine(String.Join(" ", array));
int maxNumber = MaxValueFound(array);
int minNumber = MinValueFound(array);
int minMaxDiff= MinMaxDiff(maxNumber, minNumber);
Console.WriteLine($"[{String.Join(" ", array)}] - > {minMaxDiff}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int MaxValueFound(int[] arr)
{
    int maxNum = 0;
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= maxNum)
            { 
                maxNum = arr[i];
            }
        }
        return maxNum;
    }
}

int MinValueFound(int[] arr)
{
    int minNum = arr[0];
    {
    for (int i = 0; i < arr.Length; i++)
        {
            if (minNum > arr[i])
            {
                minNum = arr[i];
            }
        }
        return minNum;
    }
}

int MinMaxDiff(int maxNum, int minNum)
{
    int diff = maxNumber - minNum;
    return diff;
}
