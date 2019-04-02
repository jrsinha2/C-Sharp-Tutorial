using System;

namespace arrays
{   //arrays declaration
    public class Program
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length ; i++)  //Length is not method
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            int[] arr = new int[10];
            //int arr[] = new int[10]; will give C.T. Error
            for (int i =0;i<10;i++)
            {
                arr[i] = i;         
            }
            printArray(arr);

            //MultiDimensional Array
            int[,] arr2 = new int[3,3];
            for(int i =0;i<3;i++)
            {
                for(int j =0;j<3;j++)
                {
                    arr2[i,j] = 3*i+j;
                }
            }
            for(int i =0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write(arr2[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
