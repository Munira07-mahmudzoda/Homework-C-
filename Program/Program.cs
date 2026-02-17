using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- ВАЗИФАҲОИ BEGIN (1-10) ---");
        double a1 = 5;
        Console.WriteLine("Begin1: P = " + (4 * a1));

        double a2 = 6;
        Console.WriteLine("Begin2: S = " + (a2 * a2));

        double a3 = 4, b3 = 8;
        Console.WriteLine("Begin3: S = " + (a3 * b3) + ", P = " + (2 * (a3 + b3)));

        double d4 = 10;
        Console.WriteLine("Begin4: L = " + (3.14 * d4));

        double a5 = 3;
        Console.WriteLine("Begin5: V = " + (a5 * a5 * a5) + ", S = " + (6 * a5 * a5));

        double a6 = 2, b6 = 3, c6 = 4;
        Console.WriteLine("Begin6: V = " + (a6 * b6 * c6) + 
                          ", S = " + (2 * (a6 * b6 + b6 * c6 + a6 * c6)));

        double R7 = 5;
        Console.WriteLine("Begin7: L = " + (2 * 3.14 * R7) + 
                          ", S = " + (3.14 * R7 * R7));

        double a8 = 10, b8 = 20;
        Console.WriteLine("Begin8: Avg = " + ((a8 + b8) / 2));

        double a9 = 4, b9 = 9;
        Console.WriteLine("Begin9: Geom = " + Math.Sqrt(a9 * b9));

        double a10 = 5, b10 = 2;
        Console.WriteLine("Begin10: SumSq = " + (a10 * a10 + b10 * b10));
        Console.WriteLine("--- ВАЗИФАҲОИ INTEGER (1-10) ---");

        int L1 = 580;
        Console.WriteLine("Integer1: Meters = " + (L1 / 100));

        int M2 = 2500;
        Console.WriteLine("Integer2: Tons = " + (M2 / 1000));

        int byte3 = 4096;
        Console.WriteLine("Integer3: KB = " + (byte3 / 1024));

        int A4 = 20, B4 = 3;
        Console.WriteLine("Integer4: Count = " + (A4 / B4));

        int A5 = 20, B5 = 3;
        Console.WriteLine("Integer5: Remainder = " + (A5 % B5));

        int n6 = 47;
        Console.WriteLine("Integer6: Tens = " + (n6 / 10) + 
                          ", Units = " + (n6 % 10));

        int n7 = 47;
        Console.WriteLine("Integer7: Sum = " + (n7 / 10 + n7 % 10));

        int n8 = 47;
        Console.WriteLine("Integer8: Swap = " + (n8 % 10 * 10 + n8 / 10));

        int n9 = 385;
        Console.WriteLine("Integer9: Hundreds = " + (n9 / 100));

        int n10 = 385;
        Console.WriteLine("Integer10: Units = " + (n10 % 10) + 
                          ", Tens = " + (n10 / 10 % 10));
         Console.WriteLine("\n--- ВАЗИФАҲОИ BOOLEAN (1-10) ---");

        int ba1 = 5;
        Console.WriteLine("Boolean1: " + (ba1 > 0));

        int ba2 = 7;
        Console.WriteLine("Boolean2: " + (ba2 % 2 != 0));

        int ba3 = 8;
        Console.WriteLine("Boolean3: " + (ba3 % 2 == 0));

        int ba4 = 3, bb4 = 2;
        Console.WriteLine("Boolean4: " + (ba4 > 2 && bb4 <= 3));

        int ba5 = 1, bb5 = -3;
        Console.WriteLine("Boolean5: " + (ba5 >= 0 || bb5 <= -2));

        int ba6 = 2, bb6 = 5, bc6 = 10;
        Console.WriteLine("Boolean6: " + (ba6 < bb6 && bb6 < bc6));

        int ba7 = 1, bb7 = 4, bc7 = 8;
        Console.WriteLine("Boolean7: " + (bb7 > ba7 && bb7 < bc7));

        int ba8 = 3, bb8 = 5;
        Console.WriteLine("Boolean8: " + (ba8 % 2 != 0 && bb8 % 2 != 0));

        int ba9 = 2, bb9 = 3;
        Console.WriteLine("Boolean9: " + (ba9 % 2 != 0 || bb9 % 2 != 0));

        int ba10 = 2, bb10 = 3;
        Console.WriteLine("Boolean10: " + (ba10 % 2 != 0 && bb10 % 2 != 0));
    }
}
