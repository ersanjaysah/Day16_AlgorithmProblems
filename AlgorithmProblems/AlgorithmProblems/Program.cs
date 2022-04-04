using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 32, 45, 67, 2, 56, 78, 1, 54, 7 };
            Algorithem obj = new Algorithem();
            obj.bubbleSort(arr);
            Console.WriteLine("Sorted array");
            obj.printArray(arr);
        }
    }
}
