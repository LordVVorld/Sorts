using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    static class BOGO
    {
        // To Swap two given numbers
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        // To check if array is sorted or not
        public static bool IsSorted(int[] a, int n)
        {
            int i = 0;
            while (i < n - 1)
            {
                if (a[i] > a[i + 1])
                    return false;
                i++;
            }
            return true;
        }

        // To generate permutation of the array
        public static void Shuffle(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Swap(ref a[i], ref a[rnd.Next(0, n)]);
        }

        // Sorts array a[0..n-1] using Bogo sort
        public static void Sort(int[] a, int n = 10)
        {
            // if array is not sorted then shuffle
            // the array again
            while (!IsSorted(a, n))
                Shuffle(a, n);
        }

        // prints the array
        public static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.Write("\n");
        }

    }
}
