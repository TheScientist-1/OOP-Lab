using System;
using System.Runtime.CompilerServices;

abstract class GeographicObject
{
    public string? coordinateX;
    public string? coordinateY;
    public string? Name;
    public string? Description;
    public virtual void GetInformation()
    {
        Console.WriteLine($"Coordinates of the geographic object: {coordinateX} , {coordinateY}" );
        Console.WriteLine($"Name: {Name}" );
        Console.WriteLine($"Description of the geographic object:{Description}" );
    }
}
class River : GeographicObject
{
    public double FlowRate;
    public double Length;
    public River(string x, string y, string name, string descr, string rate, string length)
    {
        coordinateX = x;
        coordinateY = y;
        Name = name;
        Description = descr;
        FlowRate = Convert.ToDouble(rate);
        Length = Convert.ToDouble(length);
    }
    public override void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"River's flow rate is equal to: {FlowRate} km per hour");
        Console.WriteLine($"River's length is equal to: {Length} in km.");
    }
}

class Mountain : GeographicObject
{
    public double TheHighestPoint;

    public Mountain(string x, string y, string name, string descr, string height)
    {
        coordinateX = x;
        coordinateY = y;
        Name = name;
        Description = descr;
        TheHighestPoint = Convert.ToDouble(height);
    }
    public override void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"Mountain's highest point is equal to:{TheHighestPoint} meters.");
    }
}

public class Program
{

    public static void Main(String[] args)
    {
        River r1 = new River("55° 52′ 18.08″ N", "33° 43′ 27.08″ E", "Dnipro", "One of the major transboundary rivers of Europe", "5", "2200");
        r1.GetInformation();
        Mountain m1 = new Mountain("48° 9′ 36″ N", "24° 30′ 1″ E", "Hoverla", "The highest mountain in Ukraine and part of the Carpathian Mountains.", "2061");
        m1.GetInformation();
    }
}