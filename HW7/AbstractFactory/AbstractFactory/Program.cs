using System;
/*Додатково потрібно додати новий вид продукту (абстрактний) - колеса. 
Це наочно демонструє, що для патерну AbstractFactory
додавання підтримки нового виду продукту є складними, на відміну від
додавання нового конкретного продукту.*/

namespace AbstractFactory
{
    // AbstractProductA
    public abstract class Car
    {
        public abstract void Info();
        public void Interact(Engine engine)
        {
            Info();
            Console.WriteLine("Set Engine: ");
            engine.GetPower();
        }
        public void InteractT(Tyres tyres)
        {
            Console.WriteLine("Check tyres: ");
            tyres.ShowTyresType();
        }
    }

    // ConcreteProductA1
    public class Ford : Car
    {
        public override void Info()
        {
            Console.WriteLine("Ford");
        }
    }

    //ConcreteProductA2
    public class Toyota : Car
    {
        public override void Info()
        {
            Console.WriteLine("Toyota");
        }
    }
    
    // ConcreteProductA3
    public class Mersedes : Car
    {
        public override void Info()
        {
            Console.WriteLine("Mersedes");
        }
    }


    // AbstractProductB
    public abstract class Engine
    {
        public virtual void GetPower()
        {
        }
    }

    // AbstractProductC
    public abstract class Tyres
    {
        public virtual void ShowTyresType()
        {
        }
    }

    // ConcreteProductB1
    public class FordEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Ford Engine");
        }
    }

    //ConcreteProductB2
    public class ToyotaEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Toyota Engine");
        }
    }

    //ConcreteProductB3
    public class MersedesEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Mersedes Engine");
        }
    }

    // ConcreteProductC1
    public class FordTyres : Tyres
    {
        public override void ShowTyresType()
        {
            Console.WriteLine("Ford Tyres");
        }
    }

    //ConcreteProductC2
    public class ToyotaTyres : Tyres
    {
        public override void ShowTyresType()
        {
            Console.WriteLine("Toyota Tyres");
        }
    }

    //ConcreteProductC3
    public class MersedesTyres : Tyres
    {
        public override void ShowTyresType()
        {
            Console.WriteLine("Mersedes Tyres");
        }
    }

    // AbstractFactory
    public interface ICarFactory
    {
        Car CreateCar();
        Engine CreateEngine();
        Tyres CreateTyres();
    }

    // ConcreteFactory1
    public class FordFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Ford();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new FordEngine();
        }

        Tyres ICarFactory.CreateTyres()
        {
            return new FordTyres();
        }
    }


    // ConcreteFactory2
    public class ToyotaFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Toyota();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new ToyotaEngine();
        }

        Tyres ICarFactory.CreateTyres()
        {
            return new ToyotaTyres();
        }
    }


    // ConcreteFactory3
    public class MersedesFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Mersedes();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new MersedesEngine();
        }

        Tyres ICarFactory.CreateTyres()
        {
            return new MersedesTyres();
        }
    }
    public class ClientFactory
    {
        private Car car;
        private Engine engine;
        private Tyres tyres;

        public ClientFactory(ICarFactory factory)
        {
            //Абстрагування процесів інстанціювання
            car = factory.CreateCar();
            engine = factory.CreateEngine();
            tyres = factory.CreateTyres();
        }

        public void Run()
        {
            car.GetType();
            //Абстрагування варіантів використання
            car.Interact(engine);
            car.InteractT(tyres);
        }
    }

    class AbstractFactoryApp
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();
            ClientFactory client1 = new ClientFactory(carFactory);
            
            client1.Run();

            carFactory = new FordFactory();
            ClientFactory client2 = new ClientFactory(carFactory);
            client2.Run();

            carFactory = new MersedesFactory();
            ClientFactory client3 = new ClientFactory(carFactory);
            client3.Run();

            Console.ReadKey();
        }
    }
}
