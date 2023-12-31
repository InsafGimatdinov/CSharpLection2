﻿using System;
public class Example4
{
    public static void Main()
    {
        void FillArray(int[] collection)
        {
            int length = collection.Length;
            int index = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(0, 10);
                index++;
            }
        }
        void PrintArray(int[] collect) 
        {
            int count = collect.Length;
            int position = 0;
            while (position < count) 
            {
                Console.Write(collect[position] + " ");
                position++;
            }
        }
        int indexOf(int[] collection, int find)
        {
            int count = collection.Length;
            int index = 0;
            int position = -1;
            while (index < count)
            {
                if (collection[index] == find) 
                {
                    position = index;
                    break;
                }
                index++;
            }
            return position;
        }
        int[] array = new int[10];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        int pos = indexOf(array, 4);
        Console.WriteLine(pos);
    }
}