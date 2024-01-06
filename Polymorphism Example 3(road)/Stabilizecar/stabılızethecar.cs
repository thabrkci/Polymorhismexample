using System;

// The Stabilizethecarspeed class represents a base class for stabilizing car speed.
public class Stabilizethecarspeed
{
    // Virtual method providing a general instruction to stabilize the car speed.
    public virtual void stabilizeCar()
    {
        Console.WriteLine("Please stabilize the car speed.");
    }

    // Virtual method providing an instruction to slow down and stabilize the car speed.
    public virtual void stabilizeCarslow()
    {
        Console.WriteLine("Please slow down and stabilize the car speed.");
    }

    // Virtual method providing an instruction that the car speed is normal, and the driver should be careful.
    public virtual void stabilizeCarnormal()
    {
        Console.WriteLine("Your speed is normal, please be careful.");
    }
}
