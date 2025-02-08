using System;
using System.Diagnostics.Metrics;

class ParamsExample
{

    public void UserDetails(params object[] user)
    {
        for(int i=0; i<user.Length; i++)
        {
            Console.WriteLine(user[i]);
        }
    }
    public static void Main(string[] args)
    {
        ParamsExample pe = new ParamsExample();
        pe.UserDetails("Ramakrishnan Ayyer", "Ramesh", 101, 20.5, "Peter", "A");
    }
}