
using System.Diagnostics;
using System.Linq;
public class Program054
{
    public static void QuickSort(int[][] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[][] array, int low, int high)
    {
        int[] pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (CompareArrays(array[j], pivot) > 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static int CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length < arr2.Length)
        {
            return -1;
        }
        else if (arr1.Length > arr2.Length)
        {
            return 1;
        }
        else
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    return -1;
                }
                else if (arr1[i] > arr2[i])
                {
                    return 1;
                }
            }
            return 0;
        }
        
    }

    private static void Swap(int[][] array, int index1, int index2)
    {
        int[] temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    public static void BubbleSort(int[][] arr)
    {

        for (global::System.Int32 z = 0; z < arr.Length; z++)
        {


            for (global::System.Int32 i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = 0; j < arr[i].Length - 1; j++)
                {
                    if (arr[i][j] < arr[i][j + 1])
                    {
                        
                        int temp = arr[i][j + 1];
                        arr[i][j + 1] = arr[i][j];
                        arr[i][j] = temp;

                    }
                }


            }
        }

        for (int z = 0; z < arr.Length; z++)
        {
            for (global::System.Int32 i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i][0] < arr[i + 1][0])
                {
                    int[] temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;

                }






            }
        }
    }
    public static int[][] CreateAndFullArr(int row, int col, int startArr, int endArr)
    {
        int[][] arr = new int[row][];
        Random rd = new Random();
        for (int i = 0; i < row; i++)
        {
            arr[i] = new int[col];
            System.Console.Write("[");
            for (int j = 0; j < arr.Length; j++)
            {

                arr[i][j] = rd.Next(startArr, endArr);
                System.Console.Write(" " + arr[i][j]);

            }
            System.Console.WriteLine(" ]");


        }
        return arr;
    }
    public static void PrintMatrix(int[][] array)
    {
        foreach (var item in array)
        {
            global::System.Console.WriteLine(string.Join(" ", item));
        }
    }
    public static void Main()
    {
      int row = 2;
        int col = 2; int[][] matrix = CreateAndFullArr(row, col, 0, 10);
        var sw1 = new Stopwatch();
        sw1.Start();
      BubbleSort(matrix);
        sw1.Stop();
        global::System.Console.WriteLine("SimpleSort " + sw1.Elapsed);
        PrintMatrix(matrix);

        int[][] matrix2 = CreateAndFullArr(row, col, 0, 10);
        int low = 0;
        int high = matrix2[0].Length - 1;
        var sw = new Stopwatch();
        sw.Start();
     QuickSort(matrix2, low, high);
        sw.Stop();
        global::System.Console.WriteLine("QuickSort " + sw.Elapsed);
        PrintMatrix(matrix2);
        

    }
}