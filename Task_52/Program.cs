Console.WriteLine("Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива ");
int row = Convert.ToInt32(Console.ReadLine());

int[,] twoDArray = new int[row,column];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            twoDArray[i,j] = new Random().Next(1 , 99 );
            Console.Write(twoDArray[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();

double sum = 0;
int num = 1;

for (int i = 0; i < twoDArray.GetLength(1); i++)
{  
    sum = 0;
    for (int j = 0; j <twoDArray.GetLength(0); j++)
    {
        sum += twoDArray[j,i];
        
    }
    sum = sum / row;
    sum = Math.Round(sum,2);
    Console.WriteLine($" Среднее арифметическое столба {num} = {sum}  ");
    num ++;
}