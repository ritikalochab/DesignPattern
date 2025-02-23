using System.Security.Cryptography;

interface Prototype<T>
{
    T Clone();
}
public class House:Prototype<House>
{
    public int floor { get; set; }
    public int wall { get; set; }
    public string garden { get; set; }
   public  House(int floor, int wall, string garden)
    {
        this.floor = floor;
        this.wall = wall;
        this.garden = garden;
    }
    public House Clone()
    {
        return (House)MemberwiseClone();
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"floor is:{floor}, wall is:{wall}, garden is:{garden}");
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        House house1 = new House(2, 3, "green grass");
        house1.DisplayDetails();
        House house2 = house1.Clone();
        house2.DisplayDetails();
        house2.garden = "blue grass";
        house2.DisplayDetails();

    }
}