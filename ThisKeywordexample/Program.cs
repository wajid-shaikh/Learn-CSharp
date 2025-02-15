using System;

class ThisKeyword
{
    public int Id;
    public string Name;
    public float Score;
    public ThisKeyword (int id, string name, float score)
    {
        this.Id = id;
        this.Name = name;
        this.Score = score;
    }
    public string DisplayDetails()
    {
        return $"Name: {Name} \nExam id: {Id} \nScore: {Score}";
    }

    public static void Main(string[] args)
    {
        ThisKeyword tk = new ThisKeyword(786, "Jason", 98.34f);

        Console.WriteLine(tk.DisplayDetails());
    }
}