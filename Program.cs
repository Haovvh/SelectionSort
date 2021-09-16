using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n = 100;
            a = CreateArray(n);
            SelectionSort(a, a.Length);
            PrintArray(a);
        }
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i].ToString() + " ");
            Console.WriteLine("");
        }
        static int[] CreateArray(int n)
        {
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                a[i] = r.Next(10,10000);
            return a;
        }

        public static void SelectionSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                        min = j;
                }
                Swap(ref a[min], ref a[i]);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
