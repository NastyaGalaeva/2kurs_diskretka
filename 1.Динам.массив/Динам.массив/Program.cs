using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динам.массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 0;
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            lenght = numbers.Length; //5
            Array.Resize(ref numbers, numbers.Length + 2);
            lenght = numbers.Length; //7 т.к массив будет выглядеть теперь так {1,2,3,4,5,0,0}
            Console.WriteLine(numbers[6]); //0
        }

    }
}
