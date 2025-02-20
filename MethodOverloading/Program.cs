using System;
class MethodOverloading
{
    public int add(int a, int b)
    {
        return a + b;
    }
    public int add(int a, int b, int c) 
    {  
        return a + b + c; 
    }

    public static void Main(string[] args)
    {
        MethodOverloading mo = new MethodOverloading();
        Console.WriteLine(mo.add(1, 2));
        Console.WriteLine(mo.add(1, 2, 3));
    }
}