using System;

class ForLoop
{
    public static void Main(string[] args)
    {
        // For Pattern printing
        for(int i=0; i<10; i++)
        {
            for(int j=0; j<i; j++)
            Console.Write("* ");
            Console.WriteLine("\n");
        }
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++ \n");

        // For numbers printing 1 to 10
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Number is " + (Convert.ToInt16(x) + 1));
        }
    }
}