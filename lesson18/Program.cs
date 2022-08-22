// Двумерные массивы

// строки с 1, а столбцы с 0 пример: 
// table[1,0] table[1,1] table[1,2] table[1,3] ...
string[,] table = new string[2, 5];
table[1, 2] = "text";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"/{table[rows, columns]}/");
    }
    Console.WriteLine();
}


int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}