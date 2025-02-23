using System;

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barking...");
    }
}

class Cats : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meowing...");
    }
}

class AbstractClassExample
{
    public static void Main(string[] args)
    {
        Animal a;
        a = new Dog();
        a.MakeSound();
        a = new Cats();
        a.MakeSound();
    }
}