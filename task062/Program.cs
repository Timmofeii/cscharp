// Задача 62: Заполните спирально массив 4 на 4.


Console.Clear();

void FillArraySpiral(int[,] arr, int len)
{
    int number = 1;
    int startX = 0;
    int startY = 0;
    int endX = len - 1;
    int endY = len - 1;

    while (startX <= endX && startY <= endY)
    {
        for (int i = startX; i <= endX; i++)
        {
            arr[startY, i] = number;
            number++;
        }
        startY++;

        for (int i = startY; i <= endY; i++)
        {
            arr[i, endX] = number;
            number++;
        }
        endX--;

        for (int i = endX; i >= startX; i--)
        {
            arr[endY, i] = number;
            number++;
        }
        endY--;

        for (int i = endY; i >= startY; i--)
        {
            arr[i, startX] = number;
            number++;
        }
        startX++;
    }
}

void PrintArray(int[,] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < len; j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                System.Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int len = 4;
int[,] array = new int[len, len];
FillArraySpiral(array, len);
PrintArray(array, len);