// The mainRoad class inherits from Stabilizethecarspeed class, representing the main road.
// It overrides the stabilizeCar method to provide instructions specific to main roads.
public class MainRoad : Stabilizethecarspeed
{
    public override void stabilizeCar()
    {
        // Outputs a message to inform the driver that there is no need to slow down on the main road.
        Console.WriteLine("You don't need to slow down, you can keep going at this speed.");
        
        // Calls the base class method for general speed stabilization instructions.
        base.stabilizeCar();
    }
}
