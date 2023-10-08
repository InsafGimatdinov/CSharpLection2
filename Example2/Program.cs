using System;
public class Example2
{
    public static void Main()
    {
        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if (arg2 > result) result = arg2;               // Подход с помощью метода
            if (arg3 > result) result = arg3;
            return result;
        }

        int[] array = { 2, 3, 57, 8, 5, 4, 3, 90, 15 };
        int max = Max(
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8])
        );
        Console.WriteLine(max);
    }
}