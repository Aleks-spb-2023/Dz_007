Double[,]  Array2D(int a,int b)
{
    Double[,] twoDArray = new double [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            twoDArray[i,j] = new Random().NextDouble() * 10;
            twoDArray[i,j] = Math.Round(twoDArray[i,j],2);
        }
    }
    return twoDArray;
}
void prDouble2DArray(Double[,] arrayToPrDouble)
{

    for (int i = 0; i < arrayToPrDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrDouble.GetLength(1); j++)
        {
            Console.Write(arrayToPrDouble[i,j]  + "\t");
        }
        Console.WriteLine();
    }
}

Double[,] generatedArray = Array2D(5,5);
prDouble2DArray(generatedArray);