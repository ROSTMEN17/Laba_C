using System;

namespace ConsoleApp2
{
    class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine("Введiть напругу:");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть силу струму:");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Опiр провiдника:{(double)(u / i)}");

        }
       */
        /*static void Main(string[] args)
        {
            double res = 1;
            Console.WriteLine("Введiть довжину суми ряду:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                res += (Math.Pow(n, 2) - Math.Pow(-1, n + 1) * (Math.Pow(n, 3)) / Math.Pow(n, 2) + n + 1);
            }
            Console.WriteLine(res);
        }*/

        /*static void Main()
        {
            int x, y;
            bool res = false;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 0){
                res = true;
            }
            Console.WriteLine(res);
        }*/
        /*static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            int[] A = new int[n];
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < A.Length; i++)
            {
                if(A[0] < A[i] && A[i] < A[n - 1])
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }
            if (flag == false) Console.WriteLine(0);
        }*/
        /*static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int min, max;
            int[,] A = new int [n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                min = A[i, 0]; // 7
                max = A[i, 0]; // 1 4 7
                for (int j = 0; j < m; j++)
                {
                    if (min > A[i, j]) min = A[i, j];
                    if (max < A[i, j]) max = A[i, j];
                }
                Console.WriteLine($"Row: {i} Min: {min} Max: {max}"); 
            }
        }*/
    }
}
