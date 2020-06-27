using System;
using System.Diagnostics;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        public static int DemNguyenAm(string text)
        {

            int dem = 0;
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < text.Length; i++)
            {
                dem += arr.Contains(text[i]) ? 1 : 0;
            }
            return dem;
        }

        public static int Dem(string str)
        {
            int nguyen_am = 0;
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
        public static void SapXep(int[] arr, int l, int r)
        {

            int pivot = arr[(l + r) / 2];
            int i = l, j = r;
            while (arr[i] < pivot)
                i++;
            while (arr[j] > pivot)
                j--;
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            if (j > l)
                SapXep(arr, l, j);
            if (i < r)
                SapXep(arr, i, r);
        }

        public static int Max(int[] arr)
        {
            return arr[0];
        }
        public static int Min(int[] arr)
        {
            return arr[arr.Length-1];
        }
        public static void bubbleSort(int[] arr, int n)
        {
            int i, j;
            bool haveSwap = false;
            for (i = 0; i < n - 1; i++)
            {
                // i phần tử cuối cùng đã được sắp xếp
                haveSwap = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        
                        haveSwap = true; // Kiểm tra lần lặp này có swap không
                    }
                }
                // Nếu không có swap nào được thực hiện => mảng đã sắp xếp. Không cần lặp thêm
                if (haveSwap == false)
                {
                    break;
                }
            }
        }

        public static double ChuViChuNhat(double d, double r)
        {
            return (d + r) * 2;
        }
        public static double ChuViHinhTron(double r)
        {
            return 2*Math.PI*r;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 9, 8, 11, 15, 0 };
            var sw = Stopwatch.StartNew();
            //SapXep(arr, 0, 7);
            bubbleSort(arr, 8);
            //Console.WriteLine(DemNguyenAm("ádasdasgfafhiu"));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(Max(arr).ToString());
            Console.WriteLine(Min(arr).ToString());
            Console.WriteLine(Math.Round(ChuViChuNhat(7.2,5.4),3));
            Console.WriteLine(Math.Round(ChuViHinhTron(5.4),3));
            sw.Stop();
            Console.WriteLine("Time elapsed: " + sw.Elapsed);


        }
    }
}
