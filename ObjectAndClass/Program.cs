using System;

class Restaurant
{
    string name;
    string location;
    string specialDish;
    int price;
    float fixedTaxPerDish;
    
    public void insertDetails(string nme, string lct, string sd, int p, float ftpd)
    {
        string name = nme;
        string location = lct;
        string specialDish = sd;
        int price = p;
        float fixedTaxPerDish = ftpd;
    }

    public void Display()
    {
        Console.WriteLine($"There is a {name} restaurant which is famous for {specialDish} dish at price of {price} with minimum tax at {fixedTaxPerDish}rs. this restaurant is situated in {location}");
    }
}

class MyRestaurant
{
    public static void Main(string[] args)
    {
        Restaurant r = new Restaurant();
        r.insertDetails("Kokani Darbar", "Nashik", "Biryani & Kebabs", 250, 11.5F);
        r.Display();
    }
}