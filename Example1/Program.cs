// Нахождение максимума из 9 чисел
using System;
public class Example1
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

        int a = 10;
        int b = 900;
        int c = 30;
        int d = -5;
        int e = 8;
        int f = 15;
        int g = 3;
        int h = -2;
        int i = 9;
        /* int max1 = Max(a, b, c);
        int max2 = Max(d, e, f);
        int max3 = Max(g, h, i);
        int max = Max(max1, max2, max3); */
        int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, i));
        // if (b > max) max = b;
        // if (c > max) max = c;
        // if (d > max) max = d;
        // if (e > max) max = e;
        // if (f > max) max = f;           Стихийный подход
        // if (g > max) max = g;
        // if (h > max) max = h;
        // if (i > max) max = i;
        Console.WriteLine(max);
    }
}