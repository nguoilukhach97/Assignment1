using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        // Đếm nguyên âm
        public static int CountVowels1(string text)
        {

            int count = 0;
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < text.Length; i++)
            {
                count += arr.Contains(text[i]) ? 1 : 0;
            }
            return count;
        }

        public static int CountVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    count++;
                }

            }
            return count;
        }

        // Sắp xếp theo thứ tự tăng dần
        public static void QuickSort(int[] arr, int l, int r)
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
                QuickSort(arr, l, j);
            if (i < r)
                QuickSort(arr, i, r);
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
            for (int i = 0; i < n - 1; i++)
            {
                
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        
                    }
                }
               
            }
        }
        // Chu vi hình chữ nhật
        public static double PerimeterRectangle(double d, double r)
        {
            return (d + r) * 2;
        }
        // Chu vi hình tròn
        public static double PerimeterCircle(double r)
        {
            return 2*Math.PI*r;
        }
        // Tìm kiếm nhị phân
        public static int BinarySearch(int[] arr,int l, int r,int x)
        {
            if (arr.Length == 0)
                return -1;
            if (l<=r)
            {
                int pivot = (l + r) / 2;
                if (arr[pivot]==x)
                    return pivot;

                if (arr[pivot]>x)
                    return BinarySearch(arr,l,pivot,x);
                
                return BinarySearch(arr,pivot,r,x);
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 3, 9, 8, 11, 15, 0 };
            //var sw = Stopwatch.StartNew();
            //QuickSort(arr, 0, arr.Length-1);
            ////bubbleSort(arr, 8);
            ////Console.WriteLine(CountVowels("ádasdasgfafhiu"));
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            ////Console.WriteLine(Max(arr).ToString());
            ////Console.WriteLine(Min(arr).ToString());
            //Console.WriteLine(Math.Round(PerimeterRectangle(7.2,5.4),3));

            //Console.WriteLine(Math.Round(PerimeterCircle(5.4),3));

            //Console.WriteLine("Phan tu co gia tri "+11+" o vi tri : "+BinarySearch(arr,0,7,11)??"Không tìm thấy");

            //sw.Stop();
            //Console.WriteLine("Time elapsed: " + sw.Elapsed);



            // Binary search tree

            List<int> listAdd = new List<int> { 70,49,37,22,40,54,84,78,76,80,85};

            BinaryTree tree = new BinaryTree();
            
            Console.WriteLine("Them cac gia tri vao cay nhi phan:");
            Random random = new Random();
            //while(true)
            //{
                Console.WriteLine("Nhap gia tri node can them vao cay (Nhap 0 de thoat ) :");

                for (int i = 0; i < listAdd.Count; i++)
                {
                    tree.InsertNode(listAdd[i]);
                }

                //int key = int.Parse(Console.ReadLine());
                //if (key == 0)
                //    break;
                //tree.InsertNode(key);
            //}    
            
            Console.WriteLine("\n\nDuyet tien tu  Pre Order:");
            tree.PreOrder(tree.root);
            Console.WriteLine("\n\nDuyet trung tu In Order:");
            tree.InOrder(tree.root);
            Console.WriteLine("\n\nDuyet hau tu Post Order:");
            tree.PostOrder(tree.root);
            Console.Write("\n\nNhap khoa can tim kiem:");
            int keysearch = int.Parse(Console.ReadLine());
            bool result = tree.Search(tree.root, keysearch);
            if (result) Console.WriteLine("Tim thay {0} trong cay nhi phan tim kiem", keysearch);
            else Console.WriteLine("Khong tim thay {0} trong cay nhi phan tim kiem", keysearch);


        }
    }
}
