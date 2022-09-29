// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;

using System.Globalization;
using System.Xml.Linq;

abstract class Worker 
{
    public Worker() { }
    public string Name;
    public string Position;
    public string WorkDay;
    public Worker(string name) 
    { 
        Name = name; 
    }
    public void Call() { }
    public void WriteCode() { }
    public void Relax() { }
    abstract public void FillWorkDay();
}

class Developer : Worker
{
    public Developer() { }
    public Developer(string name) 
    {
        Name = name;
        Position = "Розробник";
        FillWorkDay();
    }
    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}

class Manager : Worker
{
    public Manager() { }
    private Random random = new Random();
    public Manager(string name)
    {
        Name = name;
        Position = "Менеджер";
        FillWorkDay();
    }
    public override void FillWorkDay()
    {
        int p = random.Next(1, 11);
        int i=0;
        while (i < p)
        {
            Call();
            i++;
        }
        Relax();
        p = random.Next(1, 6);
        i = 0;
        while (i < p)
        {
            Call();
            i++;
        }
    }
}

class Team
{    
    public Team() { }
    private string TeamName;
    public Team(string teamName)
    {
        TeamName = teamName;
    }
    private List<Worker> workers = new List<Worker>();
    public void AddWorkerToTeam(Worker worker) 
    {
        workers.Add(worker);
    }
    public void DisplayTeamInfo() 
    {
        Console.WriteLine(TeamName);
        foreach (Worker worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }
    public void DetailedInformation()
    {
        Console.WriteLine(TeamName);
        foreach (Worker worker in workers)
        {
            Console.WriteLine(worker.Name +" - " + worker.Position);
        }
    }
}
public class Example
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Бажаєте створити команду? Натисність 1!");
        string ans = Console.ReadLine();
        if (ans=="1")
        {
            Console.WriteLine("Введіть назву команди");
            Team team = new Team(Console.ReadLine());

            Console.WriteLine("Введіть кількість менеджерів, яку ви бажаєте додати до команди");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть ім'я менеджера");
                team.AddWorkerToTeam(new Manager(Console.ReadLine()));
            }

            Console.WriteLine("Введіть кількість розробників, яку ви бажаєте додати до команди");
            int k = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Введіть ім'я розробника");
                team.AddWorkerToTeam(new Developer(Console.ReadLine()));
            }

            Console.WriteLine("Щоб переглянути інформацію про команду натисніть 1 ");
            string a=Console.ReadLine();
            if (a == "1")
            {
                team.DisplayTeamInfo();
            }

            Console.WriteLine("Щоб переглянути детальну інформацію про команду натисніть 1 ");
            string b = Console.ReadLine();
            if (b == "1")
            {
                team.DetailedInformation();
            }

            Console.WriteLine("Бажаєте створити команду? Натисність 1!");
            ans = "1";
            ans = Console.ReadLine();

        }
        while ( ans == "1") ;
    }
}