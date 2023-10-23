/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/
public class Program054
{
    public static void Main(string[] args)
    {

        int[][] arr = CreateAndFullArr(3, 3, 0, 10);
        SortArray(arr);

    }
    public static void SortArray(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            int index = 0;
        int minValue = arr[i][index];

        for (int j = 1; int j < arr[i].Length; int j++)
            {
            if (arr[i][j] > minValue)// если второй элемент массива больше первого, то на место первого мы запишем значение второго,
                                     //а на место второго запишем значение первого 
            {
                arr[i][idex] = arr[i][j];
                arr[i][j] = minValue;
                index = j;


            }
            if (arr[i][j] < minValue) // если значение следущего элемента меньше минимально,
                                      // то мы меняем значение и минимального и его индекс и сравниваем уже с новым значением
            {
                minValue = arr[i][j];
                index = j;
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
}



