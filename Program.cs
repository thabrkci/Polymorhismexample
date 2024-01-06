using System;

// Base class
class Shape
{
    // Virtual method to be overridden by derived classes
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived Class
class Rectangle : Shape
{
    // Overriding the Draw method for Rectangle
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

// Another derived class
class Circle : Shape
{
    // Overriding the Draw method for Circle
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism example
        Shape shape1 = new Rectangle();
        Shape shape2 = new Circle();

        // In both cases, the Draw method works differently
        shape1.Draw(); // "Drawing a rectangle"
        shape2.Draw(); // "Drawing a circle"
    }
}
