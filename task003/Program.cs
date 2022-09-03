// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] array = new int[50];

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) col[i] = new Random().Next(0,100);
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
    Console.WriteLine();
}


void Limits(int[] col)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < col.Length; i++)
    {   
        if (col[i] < min)
        {
            min = col[i];
            i++;
        }
    }
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > max)
        {
            max = col[i];
            i++;
        }
    }
    int diff = max - min;
    Console.WriteLine($"Максимальное число {max}");
    Console.WriteLine($"Минимальное число {min}");
    Console.WriteLine($"Разница между максимальным значением и минимальным составляет {diff}");
}






FillArray(array);
PrintArray(array);
Limits(array);