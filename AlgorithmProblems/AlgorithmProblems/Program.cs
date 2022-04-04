using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Algorithm problems");
                string[] names = { "Banana", "Apple", "Kiwi", "PineApple", "Mango","Lichi","Coconut" };
                Algorithem algorithem = new Algorithem();
                algorithem.InsertionSort(names);
        }
    }
}
