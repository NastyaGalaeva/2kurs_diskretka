using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 10);

            Console.WriteLine("Исходная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nГлупая:");
            StupidSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nПузырьковая:");
            BubbleSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nШейкерная:");
            CocktailSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nЧет-нечет:");
            OddEvenSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nРасческой:");
            CombSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nВставками:");
            InsertionSort(array);
            Console.WriteLine("\nОтсортированная последовательность:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            
            Console.ReadLine();
        }

        static void StupidSort(int[] arr) //Глупая сортировка
        {
            int i = 0, tmp;
            while (i < arr.Length - 1)
            {
                if (arr[i + 1] < arr[i])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    i = 0;
                }
                else i++;
            }
        }

        static int[] BubbleSort(int[] mas) //Пузырьковая сортировка
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        static void CocktailSort(int[] A) //Шейкерная
        {
            int left = 0, right = A.Length - 1, temp;
            do
            {
                for (int i = right; i > left; i--)
                {
                    if (A[i] < A[i - 1])
                    {
                        temp = A[i]; A[i] = A[i - 1]; A[i - 1] = temp;                        
                    }
                }
                left++;
                for (int i = left; i < right; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        temp = A[i]; A[i] = A[i + 1]; A[i + 1] = temp;                        
                    }
                }
                right--;
            }
            while (left <= right);
        }

        static void OddEvenSort(int[] A) //Чет-нечет
        {
            int i, j, temp;
            for (i = 0; i < A.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    for (j = 2; j < A.Length; j += 2)
                        if (A[j - 1] > A[j])
                        {
                            temp = A[j]; A[j] = A[j - 1]; A[j - 1] = temp;                            
                        }
                }
                else
                {
                    for (j = 1; j < A.Length; j += 2)
                        if (A[j - 1] > A[j])
                        {
                            temp = A[j]; A[j] = A[j - 1]; A[j - 1] = temp;                            
                        }
                }
            }
        }

        static void CombSort(int[] A) ///Расческой
        {
            int step = A.Length, flag = 1, i, temp;
            while (step > 1 || flag == 1)
            {
                if (step > 1)
                    step = (int)(step / 1.247);
                flag = 0;
                for (i = 0; i + step < A.Length; ++i)
                    if (A[i] > A[i + step])
                    {
                        temp = A[i + step]; A[i + step] = A[i]; A[i] = temp;                        
                        flag = 1;
                    }
            }
        }

        public static void InsertionSort(int[] A) //Вставками
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int j = i + 1;
                int tmp = A[j];
                while (j < 0 && tmp < A[j - 1])
                {
                    A[j] = A[j - 1];
                    j--;
                }
                A[j] = tmp;
            }
        }


    }
}


