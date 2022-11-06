using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create DecoratedChristamassTree and two Decorators
            DecoratedChristamassTree c = new DecoratedChristamassTree();
            StarsDecorator d1 = new StarsDecorator();
            LightsDecorator d2 = new LightsDecorator();
            OrnamentsDecorator d3 = new OrnamentsDecorator();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d3.SetComponent(d2);

            d3.Decorate();

            // Wait for user
            Console.Read();
        }
    }
    // "Component ChristmassTree"
    abstract class ChristmassTree
    {
        public abstract void Decorate();
    }

    // "DecoratedChristamassTree"
    class DecoratedChristamassTree : ChristmassTree
    {
        public override void Decorate()
        {
            Console.WriteLine("DecoratedChristamassTree.Decorate()");
        }
    }
    // "TreeDecorator"
    abstract class TreeDecorator : ChristmassTree
    {
        protected ChristmassTree component;

        public void SetComponent(ChristmassTree component)
        {
            this.component = component;
        }
        public override void Decorate()
        {
            if (component != null)
            {
                component.Decorate();
            }
        }
    }

    // "StarsDecorator"
    class StarsDecorator : TreeDecorator
    {
        private string addedState;

        public override void Decorate()
        {
            base.Decorate();
            addedState = "Christmass tree is decorated with stars";
            Console.WriteLine("StarsDecorator.Decorate()");
        }
    }

    // "OrnamentsDecorator"
    class OrnamentsDecorator : TreeDecorator
    {
        private string addedState;

        public override void Decorate()
        {
            base.Decorate();
            addedState = "Christmass tree is decorated with ornaments";
            Console.WriteLine("OrnamentsDecorator.Decorate()");
        }
    }

    // "LightsDecorator" 
    class LightsDecorator : TreeDecorator
    {
        public override void Decorate()
        {
            base.Decorate();
            AddedBehavior();
            Console.WriteLine("LightsDecorator.Decorate()");
        }
        void AddedBehavior()
        {
            Console.WriteLine("Christmass lights are shining");
        }
    }
}
