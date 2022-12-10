// Задача 54. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного
// массива.
void Zadacha54()
{
    int[,] array = new int[4, 4];
    Console.WriteLine("Введите массив" + "\n");
    FillArray(array, -5, 10);
    PrintArray(array);
    ChangeElement(array);
    Console.WriteLine("\n"+"Массив отсортирован");
    PrintArray(array);

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
void ChangeElement(int[,] massive)
{
    int temp;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        
        for (int j = 0; j < massive.GetLength(1) -1 ; j++)
        {   
            for (int k = 0;  k < massive.GetLength(1)-1;k++)
            if ( massive[i, k]< massive[i,k+1])
            {
                
                temp = massive[i,k];
                massive[i,k] =  massive[i,k+1];
                massive[i,k+1]=temp;
            }
        }
    }
}

Zadacha54();