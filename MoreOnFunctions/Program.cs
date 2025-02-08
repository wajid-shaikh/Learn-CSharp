using System;

namespace MoreOnFunctions
{
    class MoreOnFunctions
    {
        public static void Main(string[] args)
        {
            int val = 20;

            // Call by value example
            Console.WriteLine($"Value before calling show function {val}");

            CallByValue cbv = new CallByValue();
            cbv.Show(val);

            Console.WriteLine($"Value after calling show function {val}");

            // Call by reference example
            Console.WriteLine($"Value before calling show function {val}");

            CallByReference cbr = new CallByReference();
            cbr.Show(ref val);

            Console.WriteLine($"Value after calling show function {val}");
        }
    }

    class CallByValue
    {
        public void Show(int val)
        {
            val = val + 10;
            Console.WriteLine($"Value inside show function {val}");
        }
    }

    class CallByReference
    {
        public void Show(ref int val)
        {
            val = val + 10;
            Console.WriteLine($"Value inside show function {val}");
        }
    }
}