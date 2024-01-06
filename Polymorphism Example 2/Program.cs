using System;

namespace PolymorphismExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EXERCISES 2!");

            // Create an instance of bodyBuild
            bodyBuild body = new bodyBuild();
            body.lifttheWeight(); // Calls the method in bodyBuild class

            // Create an instance of Chest
            Chest chest = new Chest();
            chest.lifttheWeight(); // Calls the overridden method in Chest class

            // Create an instance of Shoulder
            Shoulder shoulder = new Shoulder();
            shoulder.lifttheWeight(); // Calls the overridden method in Shoulder class
        }
    }

    // Base class representing a general bodyBuild action
    public class bodyBuild
    {
        // Virtual method to lift the weight
        public virtual void lifttheWeight()
        {
            Console.WriteLine("Lift the weight");
        }
    }

    // Chest class inheriting from bodyBuild and overriding lifttheWeight method
    public class Chest : bodyBuild
    {
        public override void lifttheWeight()
        {
            // Calls the base class method before specific action
            base.lifttheWeight();
            Console.WriteLine("Lift the weight with chest for chest");
        }
    }

    // Shoulder class inheriting from bodyBuild and overriding lifttheWeight method
    public class Shoulder : bodyBuild
    {
        public override void lifttheWeight()
        {
            // Calls the base class method before specific action
            base.lifttheWeight();
            Console.WriteLine("Lift the weight with shoulder");
        }
    }
}
using System;

namespace Polymorphism_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EXERCISES 2!");

            // Create an instance of bodyBuild
            bodyBuild body = new bodyBuild();
            body.lifttheWeight(); // Calls the method in bodyBuild class

            // Create an instance of Chest
            Chest chest = new Chest();
            chest.lifttheWeight(); // Calls the overridden method in Chest class

            // Create an instance of Shoulder
            Shoulder shoulder = new Shoulder();
            shoulder.lifttheWeight(); // Calls the overridden method in Shoulder class
        }
    }

    // Base class representing a general bodyBuild action
    public class bodyBuild
    {
        // Virtual method to lift the weight
        public virtual void lifttheWeight()
        {
            Console.WriteLine("Lift the weight");
        }
    }

    // Chest class inheriting from bodyBuild and overriding lifttheWeight method
    public class Chest : bodyBuild
    {
        public override void lifttheWeight()
        {
            // Calls the base class method before specific action
            base.lifttheWeight();
            Console.WriteLine("Lift the weight with chest for chest");
        }
    }

    // Shoulder class inheriting from bodyBuild and overriding lifttheWeight method
    public class Shoulder : bodyBuild
    {
        public override void lifttheWeight()
        {
            // Calls the base class method before specific action
            base.lifttheWeight();
            Console.WriteLine("Lift the weight with shoulder");
        }
    }
}
