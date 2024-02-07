using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер_5._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = GetArrayFromConsole();
           
            var Array = ShowArray(temp);
            Console.WriteLine("Отсортированный массив:");
            foreach (int i in temp)
            {
                
                Console.WriteLine(i);
                Console.ReadKey();
            }
            
          
            

            


        }
        static int[] ShowArray(int[] Arr, bool num = true ) 
        {
            var temp = Arr;
            if (num)
            {
                temp = SortArray(Arr);
            }
            
            return Arr;
        }


        static int[] GetArrayFromConsole(int num = 10 )
        {
            var array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        
        static int[] SortArray(int[] result)
        {

            int n = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        n = result[i];
                        result[i] = result[j];
                        result[j] = n;
                    }

                }
            }

            return result;
        }
        
    }
}
