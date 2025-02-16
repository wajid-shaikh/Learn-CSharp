using System;

class ParentClass
{
    public string firstName = "Jason";
}

class ChildClass : ParentClass
{
    public string lastName = "Mamoa";
}

class SlingleLevelInheritance
{
    public static void Main(string[] args)
    {
        ChildClass c = new ChildClass();
        string fullName = c.firstName +" "+ c.lastName;
        Console.WriteLine(fullName);
    }
}