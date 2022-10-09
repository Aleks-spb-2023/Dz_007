int[,] Array = new int[7,7];

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)

    {
        Array[i,j] = new Random().Next(0,99);
        Console.Write(Array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите индекс строки ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца ");
int column = Convert.ToInt32(Console.ReadLine());
if(row <= Array.GetLength(0) && column <=  Array.GetLength(1))
{
    Console.WriteLine($"Под данными индексами находиться число {Array[row,column]}");
}
else
{
    Console.WriteLine("Числа под таким индексом нет");
}

