using System;
using System.IO;

namespace FindSmallestPositiveInterger
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[6] { 1, 3, 6, 4, 1, 2 };
            //var arr = new int[3] { 1, 2, 3 };
            //var arr = new int[2] { -1, -3 };

            Console.WriteLine(GetSmallestPositiveItemInArray(arr));
        }

        private static int GetSmallestPositiveItemInArray(int[] arr)
        {
            Array.Sort(arr);
            var n = arr.Length;

            for (var i = 0; i <= n - 1; i++)
            {
                if (arr[n - 1] <= 0)
                    return 1;

                if (i + 1 == n)
                    return arr[i] + 1;

                if (i + 1 < n && arr[i] > 0)
                {
                    if (arr[i] + 1 == arr[i + 1])
                        continue;

                    if (arr[i] == arr[i + 1])
                        continue;

                    if (arr[i + 1] - arr[i] > 1)
                        return arr[i] + 1;
                }
            }

            return arr[n - 1] + 1;
        }
    }
}
