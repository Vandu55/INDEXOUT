using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXOUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] arr = new int[3];
                arr[0] = 1;
                arr[1] = 2;
                arr[3] = 4;
                arr[4] = 5;
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }


            catch (IndexOutOfRangeException ex) {
                Console.WriteLine("Array range is exceeded......");
                Console.ReadLine();
            }

           

        }
    }
}
