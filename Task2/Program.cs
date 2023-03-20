
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
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// OR
// int ReleaseArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }

Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
InputArray(array, -10, 10);
PrintArray(array);
System.Console.WriteLine($"Сумма на четных позициях: {ReleaseArray(array)}");