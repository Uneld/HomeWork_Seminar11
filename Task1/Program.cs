
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
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
InputArray(array, 100, 999);
PrintArray(array);
System.Console.WriteLine($"Количество четных: {ReleaseArray(array)}");