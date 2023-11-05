/* Задача 50. Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число.
Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу,
удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ табуляции
для более читаемого вывода.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива,
метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции,
а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
*/
class Program050
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (global::System.Int32 i = 0; i <matrix.Length; i++)
        {
            for (global::System.Int32 j = 0; j < matrix[i].Length; j++)
            {
                global::System.Console.Write(matrix[i][j]+"\t");
            }
            global::System.Console.WriteLine();

        }



    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[][]arr= new int[n][m];
        int value = 1;
        for (global::System.Int32 i = 0; i < arr.Length; i++)
        {
            for (global::System.Int32 j = 0; j < arr.Length; j++)
            {
                arr[i][j] = value;
                value += k;
            }


        }


    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int value = matrix[rowPosition, columnPosition];
        return value;


    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        if (X > 0 && X > results.GetLength(0) && Y > 0 && Y > results.GetLength(0)){
            global::System.Console.WriteLine("");
        } // Введите свое решение ниже
        


    }
}

// Не удаляйте и не меняйте метод Main! 
static public void Main(string[] args)
{
    int n, m, k, x, y;

    if (args.Length >= 5)
    {
        n = int.Parse(args[0]);
        m = int.Parse(args[1]);
        k = int.Parse(args[2]);
        x = int.Parse(args[3]);
        y = int.Parse(args[4]);
    }
    else
    {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
        n = 3;
        m = 4;
        k = 2;
        x = 2;
        y = 3;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
}
}