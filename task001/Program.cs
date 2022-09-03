// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) col[i] = new Random().Next(0,100);
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
    Console.WriteLine();
}


void CountArray(int[] col)
{
    int counter = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if ((col[i] >= 10)&(col[i]) <= 100)
        {
            counter =  counter + 1;
            i++;
        }
        i++;
    }
    Console.WriteLine($"Числа в диапозоне встречаются - {counter} раз");
}


FillArray(array);
PrintArray(array);
CountArray(array);