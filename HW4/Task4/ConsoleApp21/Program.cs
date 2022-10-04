using System.Xml.Linq;

interface IGeographicObject
{
    public void GetInformation();
}
class River : IGeographicObject
{
    public virtual void GetInformation()
    {
        Console.WriteLine($"Coordinates of the geographic object: XXXXX");
        Console.WriteLine($"Name: XXXXX");
        Console.WriteLine($"Description of the geographic object: XXXXX ");
        Console.WriteLine($"River's flow rate is equal to: XXXXX km per hour");
        Console.WriteLine($"River's length is equal to: XXXXX in km.");
    }
}
class Mountain : IGeographicObject
{
    public virtual void GetInformation()
    {
        Console.WriteLine($"Coordinates of the geographic object: XXXXX");
        Console.WriteLine($"Name: XXXXX");
        Console.WriteLine($"Description of the geographic object: XXXXX ");
        Console.WriteLine($"Mountain's highest point is equal to: XXXXX.");
    }
}
public class Program
{

    public static void Main(String[] args)
    {
        River r1 = new River();
        r1.GetInformation();
        Mountain m1 = new Mountain();
        m1.GetInformation();
    }
}
