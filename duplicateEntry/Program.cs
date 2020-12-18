using System;
using System.Linq;

namespace duplicateEntry
{
   
         
class program
        {
            static void Main()
            {
                int[] arr = { 1,2,3, 1, 1, 2, 2, 2, 3, 3,7,9,9, 4, 8, 5 };


                arr = arr.Distinct().ToArray();

                Array.ForEach(arr, x => Console.WriteLine(x));



            }

        }
}
    

