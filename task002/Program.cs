// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int[] array = new int[10];

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) col[i] = new Random().Next(0,100);
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
    Console.WriteLine();
}


void Multiply(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        int multiplied = col[i] * col[col.Length - 1];
        Console.WriteLine($"{col[i]} * {col[col.Length - 1 - i]} = {multiplied}");
    }
}

FillArray(array);
PrintArray(array);
Multiply(array);