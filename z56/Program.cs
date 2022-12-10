// Задача 56. Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей 
//  суммой элементов.

void Zadacha56()
{
    int[,] array = new int[4, 4];
    Console.WriteLine("Введите массив" + "\n");
    FillArray(array, -5, 10);
    PrintArray(array);
    MinSumm(array);
    Console.WriteLine();
    

}


// Описание методов

void FillArray(int[,] massive, int min, int max)
{
    Random rand = new Random();
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) massive[i, j] = rand.Next(min, max);
    }

}
void PrintArray(int[,] massive)
{
    Random rand = new Random();
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) Console.Write(massive[i, j] + "\t");
        Console.WriteLine();
    }
}
void MinSumm(int[,] massive)
{
    int result = 0;
    int index = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        int summinrows = 0;

        for (int j = 0; j < massive.GetLength(1); j++)
        {
         summinrows += massive[i, j];
        
           if (summinrows > result)
           {
            result = summinrows;
            index = i;
           }
        }
    }
    Console.WriteLine($"индекс строки с наибольшей суммой > {index}");
}


Zadacha56();