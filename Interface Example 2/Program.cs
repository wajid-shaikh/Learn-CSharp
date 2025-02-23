using System;

interface ISamsung
{
    void CameraPixel();
}

interface IApple
{
    void CameraPixel();
}

class Phone : ISamsung, IApple
{
    void ISamsung.CameraPixel()
    {
        Console.WriteLine("Samsung has max of 120 mega pixels ...");
    }

    void IApple.CameraPixel()
    {
        Console.WriteLine("Apple has max of 30 mega pixels ...");
    }
}

class InterfaceExample
{
    public static void Main(string[] args)
    {
        // 1st way
        //Phone phone = new Phone();
        //((ISamsung)phone).CameraPixel();
        //((IApple)phone).CameraPixel();

        // 2nd way
        IApple a = new Phone();
        a.CameraPixel();

        ISamsung s = new Phone();
        s.CameraPixel();
    }
}