using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; //Array Created w/values

            //int currentMinimum = Int32.MaxValue; //creates new variable
            //for(int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] < currentMinimum)
            //        currentMinimum = array[index];
            //}



            //for(int x = 1; x <=10; x++)
            //{
            //    Console.WriteLine(x);
            //}

            string[] anArray = { "This", "is", "an", "array", "of", "words" };
            int index = anArray.Length;
            index = index - 2;//says deisred index = length - 2
            Console.WriteLine(anArray[index]);// displays of because that is value of 4th index
        }
    }
}
