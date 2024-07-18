using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class CountDuplicateElementcs
    {
        public void displayCountDuplicate()
        {
           
            int[] arr = [1, 2, 3, 4, 5, 6,1 ,1,1, 6, 7, 7, 6, 7];

            for (int i = 0; i < arr.Length; i++) 
            {
                int count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1;
                    }

                }
                if (arr[i] != -1)
                {
                    Console.WriteLine($"{arr[i]} is repeated {count} times");
                }

            }
        }
    }
}
