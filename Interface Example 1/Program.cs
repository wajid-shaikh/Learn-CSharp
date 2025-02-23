using System;

interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Barks...");
    }
}
class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meows...");
    }
}

class InterfaceExample
{
    public static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        dog.MakeSound();
        IAnimal cat = new Cat();
        cat.MakeSound();
    }
}