// Builder pattern 
public class House
{
    public int floor { get; set; }
    public int wall { get; set; }
    public string garden { get; set; }
    public string swimmingPool { get; set; }
    House(HouseBuilder b)
    {
        this.floor = b.floor;
        this.wall = b.wall;
        this.garden = b.garden;
        this.swimmingPool = b.swimmingPool;
    }
    public class HouseBuilder
    {
        public int floor;
        public int wall;
        public string garden;
        public string swimmingPool;
        public HouseBuilder(int floor, int wall)
        {
            this.floor = floor;
            this.wall = wall;
        }
        public HouseBuilder getGarden(string garden)
        {
            this.garden = garden;
            return this;
        }
        public HouseBuilder getSwimmingPool(string swimmingPool)
        {
            this.swimmingPool = swimmingPool;
            return this;
        }
        public House build()
        {
            return new House(this);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        House h = new House.HouseBuilder(2, 3).getGarden("grass").getSwimmingPool("blue water").build();
        Console.WriteLine($"Floor: {h.floor}, Wall: {h.wall}, Garden: {h.garden}, Swimming Pool: {h.swimmingPool}");
    }
}


// example

