using System;

static class StaticClass
{
    public static int id = 45;
    public static string name = "Jony";
    public static float marks = 45.4f;

    public static void Display()
    {
        Console.WriteLine($"id: {id}\nname: {name}\nmarks: {marks}");
    }
}

class StaticClassExample
{
    public static void Main( string[] args)
    {
        StaticClass.name = "Jessica";
        StaticClass.Display();
    }
}