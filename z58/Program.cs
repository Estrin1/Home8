// Задача 58. Заполните спирально массив 4 на 4 числами от 1 до
//  16.

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Zadacha58()
{
    int[,] array = new int[4, 4];
    
    int ulitka = 1;
    
    for (int j = 0; j < 4 ; j++)
    {
     array[0,j]=ulitka;
     ulitka++;
    }
    for (int i=1;i<4;i++)
    {
        array[i,3]=ulitka;
        ulitka++;
    }
     for (int j = 2; j >= 0 ; j--)
    { 
     array[3,j]=ulitka;
     ulitka++;
    }
    for (int i = 2; i >0 ; i--)
    { 
     array[i,0]=ulitka;
     ulitka++;
    }
    for (int j = 1; j <3 ; j++)
    { 
     array[1,j]=ulitka;
     ulitka++;
    }
     for (int j = 2; j >0 ; j--)
    { 
     array[2,j]=ulitka;
     ulitka++;
    }
    
    PrintArray(array);
}




// // Описание методов

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



Zadacha58();