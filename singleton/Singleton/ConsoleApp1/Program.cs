// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");


//singleton


//public class Singleton
//{
//    private static Singleton instance;
//    private Singleton()
//    {

//    }
//    public static Singleton getInstance()
//    {
//        if (instance == null)
//        {
//            instance = new Singleton();
//        }
//        return instance;
//    }

//}
//public class Solution
//{
//    public static void Main(string[] args)
//    {
//        var t = Singleton.getInstance();
//    }
//}

///thread

class Singleton
{
    private static Singleton instance;
    private static readonly object _lock = new object();
    private Singleton() { }
    public static Singleton getInstance()
    {
        if (instance == null)
        {
            lock (_lock)
                if (instance == null)
                {
                    instance = new Singleton();
                }

        }
        return instance;
    }
}


public class Solution
{
    public static void Main(string[] args)
    {
        var t = Singleton.getInstance();
    }
}

