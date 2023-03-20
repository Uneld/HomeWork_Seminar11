
void InputArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int ReleaseArray(int[] array)
{
    int min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max - min;
}

Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
InputArray(array, 1, 100);
PrintArray(array);
System.Console.WriteLine($"Разность (макc - мин): {ReleaseArray(array)}");