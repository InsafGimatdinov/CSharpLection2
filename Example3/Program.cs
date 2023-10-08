using System;
public class Example3
{
    public static void Main()
    {
        int[] array = { 1, 23, 4, 55, 64, 5, 6, 564, 5, 5, 6, 456 };
        int n = array.Length;
        int find = 5;
        int index = 0;
        while (index < n)
        {
            if (array[index] == find) 
            {
                Console.WriteLine(index);
                break;
            }
            index++;
        }
    }
}
