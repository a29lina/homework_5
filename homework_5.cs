

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha34()
{
    int size = 4;
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}




void FillArray(int[] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Zadacha35()
{
    int size = 4;
    int[] array = new int[size];
    FillArray(array, -10, 20);
    PrintArray(array);
    Console.WriteLine();

    int sum = 0;
    for (int i = 0; i <size; i++)
    {
        if (i%2==1)
        {
            sum+=array[i];
        }
    }
    Console.Write($"Сумма элементов с нечетными индексами = {sum}");
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    int size = 4;
    double[] array = new double[size];
    FillArrayDoub(array); 
    PrintArrayDoub(array);
    Console.WriteLine();


    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array [i];
        }
    }

    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array [i];
        }
    }

    double diff = Math.Round(max - min, 2);

    Console.WriteLine(min);
    Console.WriteLine(max);

    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max} - {min} = {diff}");
}




void FillArrayDoub(double[] numbers)
{
    Random rand = new Random();
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(1, 20) + Math.Round(rand.NextDouble(), 2);
    }
}

void PrintArrayDoub(double[] numbers)
{
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}