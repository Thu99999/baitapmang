using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhap mang voi n gia tri
            //Console.WriteLine("nhap vao so luong phan tu n: ");
            //int bien_dem = 0;
            //int n=int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int j = 0, k = 0; 
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("nhap vao gia tri phan tu thu {0}: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());  
            //}
            // 1. doc va in gia tri cua mang
            //Console.Write("mang vua nhap la:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i]+ "\t");
            //}

            // 2. in mang du lieu theo chieu dao nguoc
            //Console.WriteLine();
            //Console.Write("mang du lieu theo chieu dao nguoc la: ");
            //for (int i = n-1; i >=0; i--)
            //{
            //    Console.Write(arr[i] + "\t");
            //}
            //Console.WriteLine();
            // 3. tim so phan tu giong nhau trong mang va in ra man hinh
            //for (int i = 0;i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            bien_dem++;
            //            break;
            //        }   

            //    }
            //}
            //Console.WriteLine("so phan tu giong nhau la: {0}", bien_dem);
            //Console.WriteLine();

            // 4. in cac phan tu duy nhat trong mang
            //Console.WriteLine("phan tu duy nhat duoc tim thay trong mang: ");
            //for (int i = 0; i < n; i++)
            //{
            //    bien_dem = 0;
            //    for (int j = 0; j < i - 1; j++)
            //    { 
            //        if (arr[i] == arr[j])
            //        {
            //            bien_dem++;
            //        }   
            //    }
            //    for (int k = i+1; k < n; k++)
            //    {
            //        if (arr[i] == arr[k])
            //        {
            //            bien_dem++;
            //        }
            //    }
            //    if (bien_dem==0)
            //        Console.Write("{0}", arr[i]+"\t");
            //}

            //Console.WriteLine();

            //5. Chia mang ban dau thanh mang chan va mang le
            //int[] arr1 = new int[10];
            //int[] arr2 = new int[10]; // mang chua cac phan tu chan
            //int[] arr3 = new int[10]; // mang chua cac phan tu le
            //int i, j = 0, k = 0, n;


            //Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
            //Console.Write("---------------------------------------------\n");

            //Console.Write("Nhap so phan tu can luu giu trong mang: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Phan tu - {0}: ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i < n; i++)
            //{
            //    if (arr1[i] % 2 == 0)
            //    {
            //        arr2[j] = arr1[i];
            //        j++;
            //    }
            //    else
            //    {
            //        arr3[k] = arr1[i];
            //        k++;
            //    }
            //}

            //Console.Write("\nCac phan tu chan la: \n");
            //for (i = 0; i < j; i++)
            //{
            //    Console.Write("{0} ", arr2[i]);
            //}

            //Console.Write("\nCac phan tu le la:\n");
            //for (i = 0; i < k; i++)
            //{
            //    Console.Write("{0} ", arr3[i]);
            //}
            //Console.Write("\n\n");

            // 6. sap xep mang theo thu tu giam dan
            //Console.WriteLine("nhap vao so luong phan tu n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("nhap vao gia tri phan tu thu {0}: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("mang vua nhap la: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i]+"\t");
            //}
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Console.WriteLine();
            //Console.WriteLine("mang vua nhap theo thu tu giam dan");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i]+"\t");
            //}



            // 7. tim phan tu lon thu hai
            int n, i, j = 0, lon_nhat, lon_thu_hai;
            int[] arr1 = new int[50];

            Console.Write("\nTim phan tu lon thu hai trong mang C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* truoc het, chung ta tim vi tri cua phan tu lon nhat trong mang */
            lon_nhat = 0;

            for (i = 0; i < n; i++)
            {
                if (lon_nhat < arr1[i])
                {
                    lon_nhat = arr1[i];
                    j = i;
                }
            }
            /* bo qua phan tu lon nhat nay va tim phan tu lon thu hai */
            lon_thu_hai = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* bo qua phan tu lon nhat */
                    i--;
                }
                else
                {
                    if (lon_thu_hai < arr1[i])
                    {
                        lon_thu_hai = arr1[i];
                    }
                }
            }

            Console.Write("Phan tu lon thu hai trong mang la:  {0} \n\n", lon_thu_hai);

            Console.ReadKey();

        }
    }
}
