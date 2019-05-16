using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaIV
{
    class Program
    {
        static void Main(string[] args)
        {
        }

            public static void selectionSort(T[] array)
            {
                
                T = array.Length;
                for (int i = 0; i < n-1; i++)
                {
                    int min = array[i];
                    int minId = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < min)
                        {
                            min = array[j];
                            minId = j;
                        }
                    }
                    // swapping
                    T temp = array[i];
                    array[i] = min;
                    array[minId] = temp;
                }
            }
          
        

    }
}

