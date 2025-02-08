using System;
using System.Data;

// Here we have creating multiple classes in the same assembly
namespace Function
{
    class FuncWithoutParameter
    {
        public void Message()
        {
            Console.WriteLine("Function without parameter");
        }
        public static void Main(string[] args)
        {
            // Function calling with no parameter
            Console.WriteLine("+++++++++++++ Function without parameter and return type +++++++++++++\n");
            
            FuncWithoutParameter fwop = new FuncWithoutParameter();
            fwop.Message();

            // Function calling with two parameters
            Console.WriteLine("\n+++++++++++++ Function with parameter and return type +++++++++++++\n");
            
            Console.Write("Enter first number: ");
            int fNum = Convert.ToInt16(Console.ReadLine());

            Console.Write("\nEnter second number: ");
            int sNum = Convert.ToInt16(Console.ReadLine());
            
            FuncWithParameter fwp = new FuncWithParameter();
            int sum = fwp.Add(fNum, sNum);
            Console.WriteLine($"Sum of {fNum} + {sNum} = {sum}");
        }
    }

    class FuncWithParameter
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}