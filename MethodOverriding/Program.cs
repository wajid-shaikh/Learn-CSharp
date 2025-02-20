class Animal
{
    public virtual void Eats()
    {
        Console.WriteLine("Eating grass");
    }
}

class Dog : Animal
{
    public override void Eats()
    {
        Console.WriteLine("Eating Pedigree...");
    }
}

class BullDog : Dog
{
    public override void Eats() 
    { 
        Console.WriteLine("Eating bones........");
    }
}

class MethodOverridden
{
    public static void Main(string[] args)
    {
        BullDog bd = new BullDog();
        bd.Eats();
    }
}