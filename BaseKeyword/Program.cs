using System;

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Drinks Milk");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Eats Fish...");
    }
}
class SnowBall : Cat
{
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Eats Mice");
    }
}

class BaseKeyword
{
    public static void Main(string[] args)
    {
        SnowBall sb = new SnowBall();
        sb.Eat();
    }
}