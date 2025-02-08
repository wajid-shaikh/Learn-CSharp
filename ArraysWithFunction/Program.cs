using System;

namespace PassingArraytoFunction
{
    class PassArrToFunc
    {
        public static void Main(string[] args)
        {
            PassAtoF paf = new PassAtoF();
            PassAtoF.PrintArray(paf.carsBrand);

            FindMaxFromArray fmfa = new FindMaxFromArray();
            FindMaxFromArray.FindMax(fmfa.values);

            FindMinFromArray fminfa = new FindMinFromArray();
            FindMinFromArray.FindMin(fminfa.values);
        }
    }

    class PassAtoF
    {
        public string[] carsBrand = { "Tata", "Mahindra", "Maruti Suzuki", "Jaguar", "Range Rover" };

        public static void PrintArray(string[] brands)
        {
            foreach(string i in brands)
            {
                Console.WriteLine(i);
            }
        }
    }

    class FindMaxFromArray
    {
        public int[] values = { 43, 34, 5, 177, 3, 67 };

        public static void FindMax(int[] num)
        {
            int temp = num[0];
            for(int i=0; i<num.Length; i++)
            {
                if (num[i] > temp) 
                { 
                    temp = num[i];
                }
            }
            Console.WriteLine($"Max value : {temp}");
        }
    }

    class FindMinFromArray
    {
        public int[] values = { 43, 34, 5, 177, 3, 67 };

        public static void FindMin(int[] num)
        {
            int temp = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < temp)
                {
                    temp = num[i];
                }
            }
            Console.WriteLine($"Min value : {temp}");
        }
    }
}