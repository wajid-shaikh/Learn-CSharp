using System;

class Exam1
{
    public void FirstExam()
    {
        Console.WriteLine("Passed in first test");
    }
}

class Exam2 : Exam1
{
    public void SecondExam()
    {
        Console.WriteLine("Passed in second test");
    }
}

class SSCCGL : Exam2
{
    public void Result()
    {
        Console.WriteLine("Congrats, You are selected!!!");
    }
}

class MultiLevel
{
    public static void Main(string[] args)
    {
        SSCCGL sc = new SSCCGL();
        sc.FirstExam();
        sc.SecondExam();
        sc.Result();
    }
}