using System;

namespace Arrays
{
    class TypesOfArrays
    {
        public static void Main(string[] args)
        {
            SingleDimensional sd = new SingleDimensional();
            for(int i=0; i<sd.numbers.Length; i++)
            {
                int val = sd.numbers[i];
                Console.WriteLine(val);
            }
        }
    }

    class SingleDimensional
    {
        public int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
    }
}