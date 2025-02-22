using System;

class Shape
{
    public virtual void Draws()
    {
        Console.WriteLine("Drawing...");
    }
}

class Circle : Shape
{
    public override void Draws()
    {
        Console.WriteLine("Drawing circle...");
    }
}

class Triangle : Shape
{
    public override void Draws()
    {
        Console.WriteLine("Drawing triangle...");
    }
}

class Rectangle : Shape
{
    public override void Draws()
    {
        Console.WriteLine("Drawing rectangle...");
    }
}

class RuntimePolymorphism
{
    public static void Main(string[] args)
    {
        Shape a;
        a = new Shape();
        a.Draws();
        a = new Circle();
        a.Draws();
        a = new Triangle();
        a.Draws();
        a = new Rectangle();
        a.Draws();
    }
}