public interface Transport
{
    void Deliver();
}
public class Bus : Transport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by bus");
    }
}

public class Truck:Transport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by Truck");
    }
}

public class TransportFactory
{
   public static Transport CreateFactory(string type)
    {
       switch(type)
        {
            case "bus":
                    return new Bus();
            case "truck":
                return new Truck();
            default:
                throw new Exception("not a valid");
        }
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        var t =  TransportFactory.CreateFactory("bus");
        t.Deliver();
        var t1 = TransportFactory.CreateFactory("truck");
        t1.Deliver();
    }
}