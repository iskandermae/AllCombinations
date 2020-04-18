using System;

namespace recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cur = new int[4];
            while (NextCombination(cur, 4))
            {
                Console.WriteLine(string.Join(' ', cur));
            }

            Console.WriteLine("");
            Console.WriteLine("http://zonakoda.ru/generaciya-sochetanij.html");
            int N = 4;
            for (int M = 1; M <= N; M++)
            {
                int[] arr = null;
                //int[] res;
                while (GenerateCombinations(arr, M, N, out arr))
                {
                    Console.WriteLine(string.Join(' ', arr));
                }
            }
        }

        static bool NextCombination(int[] a, int n)
        {
            int k = a.Length;
            for (int i = k - 1; i >= 0; --i)
                if (a[i] < n - k + i + 1)
                {
                    ++a[i];
                    for (int j = i + 1; j < k; ++j)
                        a[j] = a[j - 1] + 1;
                    return true;
                }
            return false;
        }


        private static bool GenerateCombinations(int[] arr, int M, int N,  out int[] res)
        {
            if (arr == null)
            {
                res = new int[M];
                for (int i = 0; i < M; i++)
                    res[i] = i + 1;
                return true;
            }
            res = arr;
            for (int i = M - 1; i >= 0; i--)
                if (arr[i] < N - M + i + 1)
                {
                    arr[i]++;
                    for (int j = i; j < M - 1; j++)
                        arr[j + 1] = arr[j] + 1;
                    return true;
                }
            return false;
        }
    }
}

