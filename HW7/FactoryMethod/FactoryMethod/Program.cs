using System;
namespace FactoryMethod
{
    /* З допомогою паттерну Factory Method реалізувати класи BachelorCS та MasterAP та вивести інформацію
     * про типи карток*/
    public abstract class StudentCardCreator
    {
        public abstract IStudentCard Create(int year);
    }

    public class ConcreteCreator : StudentCardCreator
    {
        public override IStudentCard Create(int type)
        {
            switch (type)
            {
                
                case 1: return new BachelorCS();
                case 2: return new MasterAP();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    public interface IStudentCard 
    {
         string GetCardType();
         string GetFieldOfStuduing();
         int GetNumberOfCredits();

    } 

   
    public class BachelorCS : IStudentCard 
    {
        public string GetCardType() 
        {
            return "Bachelor";
        }
        public string GetFieldOfStuduing()
        {
            return "Computer Science";
        }
        public int GetNumberOfCredits()
        {
            return 240;
        }

    }

    public class MasterAP : IStudentCard 
    {
        public string GetCardType()
        {
            return "Master";
        }
        public string GetFieldOfStuduing()
        {
            return "Applied Mathematics";
        }
        public int GetNumberOfCredits()
        {
            return 300;
        }
    }

    class MainApp
    {
        static void Main()
        {
            StudentCardCreator creator = new ConcreteCreator();
            for (int i = 1; i <= 2; i++)
            {
                var product = creator.Create(i);
                Console.WriteLine("Card type = {0}, Level {1}, Field {2}, Number Of Credits {3}", i, product.GetCardType(),product.GetFieldOfStuduing(), product.GetNumberOfCredits() );
            }
            Console.ReadKey();
        }
    }
}

