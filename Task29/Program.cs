// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());

GetArray(N);

static void GetArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < N; i++)
    {
        Console.Write(array[i] + " ");
    }
}