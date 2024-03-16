using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "salam", "bb207", "codeacademy" };
            string[] array2 = { "bb207", "metodlar", "sabah"};


            OrtaqElement(array1, array2);


            Hasil(1, 2, 3, 12, 5);
            BashHerf("Anar", "Eli", "Yusif", "Arif");


            Console.WriteLine("Bir eded daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci sirasi: ");

            int[] arr = Fibonacci(n);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j] + " ");
            }
            
        }


        //Task1
        public static void OrtaqElement( string[] arr1, string[] arr2)
        {
            bool check = false;
            for(int i = 0;i < arr1.Length; i++)
            {
                for(int j = 0;j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("Ortaq element yoxdur");
            }
        }

        //Task2
        public static void Hasil(params int[] arr)
        {
            int hasil = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                hasil *= arr[i];
            }
            Console.WriteLine(hasil);
        }


        //Task3
        public static void BashHerf(params string[] arr)
        {
            string str = "";
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] == 'A')
                {
                    str += arr[i] + " ";
                }
            }
            Console.WriteLine(str);
        }

        //Task4
        public static int[] Fibonacci(int n)
        {
            int[] array = new int[n];

            int a = 0;
            int b = 1;
            int c = 0;
            array[0] = a;
            array[1] = b;   

            for(int i = 2; i < n; i++)
            {
                c = a + b;
                array[i] = c;
                a = b;
                b = c;
            }
            return array;
        }

    }
}
