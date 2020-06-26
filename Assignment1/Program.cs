using System;
using System.Diagnostics;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        public static int DemNguyenAm(string text)
        {
            
            int dem=0;
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < text.Length; i++)
            {
                dem += arr.Contains(text[i]) ? 1 : 0;
            }
            return dem;
        }

        public static int Dem(string str)
        {
            int nguyen_am=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    nguyen_am++;
                }
                
            }
            return nguyen_am;
        }
        public static void SapXep(ref int[]arr,int l,int r)
        {

            int pivot = arr[(l + r) / 2];
            int i = l, j = r;
            while (arr[i] < pivot)
                i++;
            while (arr[j] > pivot)
                j--;
            if (arr[i]>=arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            if (j > l)
                SapXep(ref arr, r, j);
            if (i < r)
                SapXep(ref arr, i, r);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 9, 8, 11, 15, 0 };
            var sw = Stopwatch.StartNew();
            SapXep(ref arr, 0, 7);
            //Console.WriteLine(DemNguyenAm("ádasdasgfafhiu"));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            sw.Stop();
            Console.WriteLine("Time elapsed: " + sw.ElapsedMilliseconds);


        }
    }
}
