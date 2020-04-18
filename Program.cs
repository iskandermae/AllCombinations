using System;

namespace recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cur = new int[4];
            while (NextCombination(cur, 4)){
                Console.WriteLine(string.Join(' ', cur));
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
    }
}
